var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.NEXTERA_Server>("nextera-server");

builder.Build().Run();
