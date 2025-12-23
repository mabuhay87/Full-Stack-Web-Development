
using AppointmentBookingSystem.Models;

namespace AppointmentBookingSystem.Services;

public class InMemoryAppointmentStore : IAppointmentStore
{
    private static readonly List<Appointment> _items = new();
    private static int _nextId = 1;
    private static readonly TimeSpan SlotWindow = TimeSpan.FromMinutes(30);

    public IReadOnlyList<Appointment> GetAll() =>
        _items.OrderBy(a => a.AppointmentDate).ToList();

    public Appointment? GetById(int id) =>
        _items.FirstOrDefault(a => a.Id == id);

    public (bool ok, string? error, Appointment? created) Create(Appointment appt)
    {
        if (appt.AppointmentDate < DateTime.Now.AddMinutes(5))
            return (false, "Please choose a time in the future.", null);

        var start = appt.AppointmentDate;
        var end = appt.AppointmentDate.Add(SlotWindow);

        bool overlaps = _items.Any(a =>
            string.Equals(a.Service, appt.Service, StringComparison.OrdinalIgnoreCase) &&
            a.AppointmentDate < end &&
            a.AppointmentDate.Add(SlotWindow) > start);

        if (overlaps)
            return (false, "That time slot is already taken for this service. Please choose another time.", null);

        appt.Id = _nextId++;
        _items.Add(appt);
        return (true, null, appt);
    }

    public bool Delete(int id)
    {
        var item = GetById(id);
        if (item == null) return false;
        _items.Remove(item);
        return true;
    }
}
