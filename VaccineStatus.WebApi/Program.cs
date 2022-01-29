
using VaccineStatusWeb.Services.MedicalInstitutes;
using VaccineStatusWeb.Services.VaccineDatas;
using VaccineStatusWeb.Services.Organizations;
using VaccineStatusWeb.Services.Vaccines;
using VaccineStatusWeb.Services.VaccineBatches;
using VaccineStatusWeb.Services.VaccineDoses;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers(options=>
{
    options.ReturnHttpNotAcceptable=true;
}).AddXmlDataContractSerializerFormatters();


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IMedicalInstituteRepository, MedicalInstituteSqlSeverService>();
builder.Services.AddScoped<IVaccineDataRepository, VaccineDataSqlServerService>();
builder.Services.AddScoped<IOrganizationRespository, OrganizationSqlServerService>();
builder.Services.AddScoped<IVaccineRepository, VaccineSqlSeverService>();
builder.Services.AddScoped<IVaccineBatchRepository, VaccineBatchSqlSeverService>();
builder.Services.AddScoped<IVaccineDoseRepository, VaccineDoseSqlSeverService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
