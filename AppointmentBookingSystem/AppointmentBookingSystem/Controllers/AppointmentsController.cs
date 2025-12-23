
using AppointmentBookingSystem.Models;
using AppointmentBookingSystem.Services;
using Microsoft.AspNetCore.Mvc;

namespace AppointmentBookingSystem.Controllers;

public class AppointmentsController : Controller
{
    private readonly IAppointmentStore _store;

    public AppointmentsController(IAppointmentStore store)
    {
        _store = store;
    }

    public IActionResult Index() => View(_store.GetAll());

    [HttpGet]
    public IActionResult Create()
    {
        return View(new Appointment
        {
            AppointmentDate = DateTime.Now.AddHours(1)
        });
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(Appointment model)
    {
        if (!ModelState.IsValid)
            return View(model);

        var (ok, error, created) = _store.Create(model);
        if (!ok)
        {
            ModelState.AddModelError(string.Empty, error ?? "Unable to create appointment.");
            return View(model);
        }

        TempData["Success"] = "Appointment booked successfully!";
        return RedirectToAction(nameof(Confirmation), new { id = created!.Id });
    }

    public IActionResult Confirmation(int id)
    {
        var appt = _store.GetById(id);
        if (appt == null) return RedirectToAction(nameof(Index));
        return View(appt);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Delete(int id)
    {
        _store.Delete(id);
        return RedirectToAction(nameof(Index));
    }
}
