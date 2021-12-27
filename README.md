# Distro.Ordering.Microservice
This is the Ordering Microservice on the Distributed spike representing a DDD Clean Architecture template.

**Setup Instructions**
1. Clone the repository
2. Create an empty "DistroOrdering" database on your local SQL Server instance
3. Initialize and update submodules, the below for [Distro.Seedworks.Infrastructure] folder in CMD

```git
git submodule init
git submodule update
git checkout main
git pull
```

4. Open "Package Manager Console" and select "Distro.Ordering.DataAccess" and run `Update-Database`
5. Remove the skip anotation from the 'DatabaseInitializationTests.cs' > InitializeDatabaseWithSampleData and run for population

**Not in scope**
- Security (Assume OAuth JWT with Identity Server)
- Inter Bounded Context communication (ESB)
- Cloud logging and visualization (Assume ELK)

**Clean Architecture Design**
- [X] Use clean Use Case defnitions to show capability of microservice (Application Service Interfaces)
- [X] Ensure directional implimentation of interfaces with inner boundries unaware of outer implimentations (Onion Architecture)

**DDD Design**
- [X] Domain Entities, Behaviors and Aggrigate Root Repositories
- [X] Domain Services (Entity orchestration and complex domain logic)
- [ ] Domain Event Handeling (Sync/A-Sync with unit of work rollback) [[MediatR](https://medium.com/dotnet-hub/use-mediatr-in-asp-net-or-asp-net-core-cqrs-and-mediator-in-dotnet-how-to-use-mediatr-cqrs-aspnetcore-5076e2f2880c) or RabbitMQ?]
- [X] Ensure valid state - Side affects through domain events (Unit of Work Pattern, shared database context)
- [ ] Ensure valid state - Use [value objects](src/Clean.Architecture.SharedKernel/ValueObject.cs) to ensure entities cannot be set in an invalid state
- [ ] CQRS (Command & Query) Data Access Implimentation

**General Microservice Design**
- [ ] Data Services ([Crud Rest vs Data Streams](https://www.confluent.io/blog/data-dichotomy-rethinking-the-way-we-treat-data-and-services/))
- [ ] API Gateway orchestration of Application Services REST implimentations (Example [Envoy](https://www.envoyproxy.io/) or Ocelot)
- [ ] [Specification pattern](https://www.nuget.org/packages/Ardalis.Specification) implimentation (Decouple query construction from Data Access layer)
- [ ] Split testing into Functional, Integration and Unit Testing (Decent mocking / Stubbing capability) 

**CI/CD**
- [ ] Self hosted container on Linux image
- [ ] DevOps Pipeline automated deploy (Unit testing, versioning, certificate)
- [ ] Dependancy health check during deployment

![alt text](https://github.com/InoxicoDev/Distro.Portal.WebApplication/blob/main/Resources/Conceptual%20Architecture.png?raw=true)

## Important Resources
- [Clean Architecture Uncle Bob](https://blog.cleancoder.com/uncle-bob/2012/08/13/the-clean-architecture.html)
- [Sample Clean Architecture Microservice](https://github.com/ardalis/CleanArchitecture) by Ardalis


