using HospitalMicroservice.Appointment.Api;
using HospitalMicroservice.Appointment.Api.Features;
using HospitalMicroservice.Doctor.Api.Repositories;
using HospitalMicroservice.Patient.Api.Options;
using HospitalMicroservice.Shared.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDatabaseServiceExtension();
builder.Services.AddCommonServiceExtension(typeof(AppointmentAssembly));
builder.Services.AddOptionExtension();
builder.Services.AddVersioningExtension();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.AddAppointmentGroupEndpointExtensions(app.AddVersionSetExtension());

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();


app.Run();
