
using AppointmentBookingSystem.Models;

namespace AppointmentBookingSystem.Services;

public interface IAppointmentStore
{
    IReadOnlyList<Appointment> GetAll();
    Appointment? GetById(int id);
    (bool ok, string? error, Appointment? created) Create(Appointment appt);
    bool Delete(int id);
}
