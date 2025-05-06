using HospitalMicroservice.Doctor.Api.Repositories;
using HospitalMicroservice.Shared;
using MediatR;

namespace HospitalMicroservice.Appointment.Api.Features.Appointments.Delete;

public class DeleteAppointmentCommandHandler(AppDbContext context) : IRequestHandler<DeleteAppointmentCommand, ServiceResult>
{
    public async Task<ServiceResult> Handle(DeleteAppointmentCommand request, CancellationToken cancellationToken)
    {
        var appointment = await context.Appointments.FindAsync(request.Id, cancellationToken);
        if (appointment is null)
        {
            return ServiceResult.Error("Appointment not found", System.Net.HttpStatusCode.NotFound);
        }
        context.Appointments.Remove(appointment);
        await context.SaveChangesAsync(cancellationToken);

        return ServiceResult.SuccessAsNoContent();
    }
}
