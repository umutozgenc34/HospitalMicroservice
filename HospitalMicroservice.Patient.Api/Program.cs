using HospitalMicroservice.Patient.Api;
using HospitalMicroservice.Patient.Api.Features.Patients;
using HospitalMicroservice.Patient.Api.Options;
using HospitalMicroservice.Patient.Api.Repositories;
using HospitalMicroservice.Shared.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDatabaseServiceExtension();
builder.Services.AddCommonServiceExtension(typeof(PatientAssembly));
builder.Services.AddOptionExtension();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.AddPatientGroupEndpointExtension();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.Run();
