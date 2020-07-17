using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using ASPNetProject.Areas.Admin.ViewModels;
using ASPNetProject.DAL;
using ASPNetProject.Helpers;
using ASPNetProject.Models;
using ASPNetProject.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ASPNetProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class EventController : Controller
    {
        private readonly IHostingEnvironment _env;
        private readonly AppDbContext _db;
        public EventController(AppDbContext db, IHostingEnvironment env)
        {
            _env = env;
            _db = db;
        }

        public IActionResult Index()
        {
            return View(_db.Events);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Event evt = await _db.Events.FindAsync(id);
            if (evt == null)
            {
                return NotFound();
            }
            EventVM model = new EventVM()
            {
                Event = _db.Events.Include(e => e.EventSpeakers).FirstOrDefault(e => e.Id == id),
                EventSpeakers = _db.EventSpeakers.Include(es => es.Speaker)
            };
            return View(model);
        }

        public IActionResult Create()
        {
            EventVM model = new EventVM()
            {
                Speakers = _db.Speakers
            };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(EventVM eventVM,DateTime dateTime,DateTime time)
        {
            if (!eventVM.Event.Photo.isImage())
            {
                ModelState.AddModelError(string.Empty, "Please pick a file matching the format!");
                return View(new EventVM { Speakers = _db.Speakers });
            }
            string test = Request.Form["states[]"];
            if (test==null)
            {
                ModelState.AddModelError(string.Empty, "Please pick at least one event speaker!!!");
                return View(new EventVM { Speakers=_db.Speakers });
            }
            string[] strId = test.Split(",");
            List<int> intId = new List<int>();
            foreach (string id in strId)
            {
                intId.Add(Int32.Parse(id));
            }
            CultureInfo culture = CultureInfo.CreateSpecificCulture("en-US");
            Event evt = eventVM.Event;
            evt.Date = dateTime.ToString("dd MMMM yyyy");
            evt.Time = dateTime.ToString("t", culture) + " - " + time.ToString("t", culture);
            evt.Image = await eventVM.Event.Photo.SaveImg(_env.WebRootPath, "img/event");
            List<EventSpeaker> eventSpeakers = new List<EventSpeaker>();
            foreach (int id in intId)
            {
                eventSpeakers.Add(new EventSpeaker
                {
                    EventId = evt.Id,
                    SpeakerId = id
                });
            }
            evt.EventSpeakers = eventSpeakers;
            _db.Events.Add(evt);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Event evt = await _db.Events.FindAsync(id);
            if (evt == null)
            {
                return NotFound();
            }
            ApEventVM model = new ApEventVM()
            {
                Event = _db.Events.Include(e => e.EventSpeakers).FirstOrDefault(e => e.Id == id),
                EventSpeakers = _db.EventSpeakers.Include(es => es.Speaker),
                Speakers=_db.Speakers
            };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, ApEventVM apEventVM, IFormFile File, DateTime dateTime, DateTime time)
        {
            if (id == null)
            {
                return NotFound();
            }
            Event evt = await _db.Events.FindAsync(id);
            if (evt == null)
            {
                return NotFound();
            }
            if (File != null)
            {
                if (!File.isImage())
                {
                    ModelState.AddModelError(string.Empty, "Please pick a file matching the format!");
                    return View(new ApEventVM()
                    {
                        Event = _db.Events.Include(e => e.EventSpeakers).FirstOrDefault(e => e.Id == id),
                        EventSpeakers = _db.EventSpeakers.Include(es => es.Speaker),
                        Speakers = _db.Speakers
                    });
                }
                Extensions.DeleteImg(_env.WebRootPath, "img/event", evt.Image);
                evt.Image = await File.SaveImg(_env.WebRootPath, "img/event");
            }

            List<EventSpeaker> eventSpeakers = _db.EventSpeakers.Where(es => es.EventId == evt.Id).ToList();
            List<EventSpeaker> currentEventSpeakers = _db.EventSpeakers.Where(es => es.EventId == evt.Id).ToList();
            List<Speaker> currentSpeakers = new List<Speaker>();
            List<EventSpeaker> newEventSpeakers = new List<EventSpeaker>();
            foreach (EventSpeaker es in currentEventSpeakers)
            {
                currentSpeakers.Add(_db.Speakers.FirstOrDefault(s => s.Id == es.SpeakerId));
            }

            string test = Request.Form["states[]"];
            if (test != null)
            {
                string[] strId = test.Split(",");
                List<int> intId = new List<int>();
                foreach (string Id in strId)
                {
                    intId.Add(Int32.Parse(Id));
                }
                foreach (int Id in intId)
                {
                    newEventSpeakers.Add(new EventSpeaker
                    {
                        EventId = evt.Id,
                        SpeakerId = Id
                    });
                }
                currentEventSpeakers = newEventSpeakers;
                foreach (EventSpeaker es in eventSpeakers)
                {
                    _db.EventSpeakers.Remove(es);
                }
                foreach (EventSpeaker es in currentEventSpeakers)
                {
                    _db.EventSpeakers.Add(es);
                }
            }
            evt.Name = apEventVM.Event.Name;
            evt.Description = apEventVM.Event.Description;
            evt.Date = apEventVM.Event.Date;
            evt.Time = apEventVM.Event.Time;
            evt.Venue = apEventVM.Event.Venue;
            CultureInfo culture = CultureInfo.CreateSpecificCulture("en-US");
            string[] spt = apEventVM.Event.Time.Split("-");
            if (dateTime.ToString() != "1/1/0001 12:00:00 AM")
            {
                evt.Date = dateTime.ToString("dd MMMM yyyy");
                if (time.ToString() == "1/1/0001 12:00:00 AM")
                {                   
                    evt.Time = dateTime.ToString("t", culture) + " -" + spt[1];
                }
            }
            if (time.ToString() != "1/1/0001 12:00:00 AM")
            {
                if (dateTime.ToString() == "1/1/0001 12:00:00 AM")
                {
                    evt.Time = spt[0] + "- " + time.ToString("t", culture);
                }
                if (dateTime.ToString() != "1/1/0001 12:00:00 AM")
                {
                    evt.Time = dateTime.ToString("t", culture) + " - " + time.ToString("t", culture);
                }               
            }
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Event evt = await _db.Events.FindAsync(id);
            if (evt == null)
            {
                return NotFound();
            }
            EventVM model = new EventVM()
            {
                Event = _db.Events.Include(e => e.EventSpeakers).FirstOrDefault(e => e.Id == id),
                EventSpeakers = _db.EventSpeakers.Include(es => es.Speaker)
            };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteEvent(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Event evt = await _db.Events.FindAsync(id);
            if (evt == null)
            {
                return NotFound();
            }
            Extensions.DeleteImg(_env.WebRootPath, "img/event", evt.Image);
            _db.Events.Remove(evt);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public IActionResult Search(string term)
        {
            var model = _db.Events.Where(c => c.Name.Contains(term)).Take(4);
            return PartialView("_ApEventSearch", model);
        }
    }
}