# Distro.Ordering.Microservice
This is the Ordering Microservice on the Distributed spike representing a DDD Clean Architecture template.

[![Build Status](https://dev.azure.com/inoxidev/Container%20Microservice%20(Order)/_apis/build/status/InoxicoDev.Distro.Ordering.Microservice?branchName=cicd)](https://dev.azure.com/inoxidev/Container%20Microservice%20(Order)/_build/latest?definitionId=20&branchName=cicd)

**Guiding principals**
- High Cohesion Lose Coupling
- Simple things should be easy, complex things possible
- Don't call us, we'll call you (Hollywood principle)

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

<img src="https://github.com/InoxicoDev/Distro.Portal.WebApplication/blob/main/Resources/Conceptual%20Architecture.png?raw=true" width="600" />

**Clean Architecture Design**
- [X] *Use clean Use Case defnitions to show capability of microservice (Application Service Interfaces)
- [X] *Ensure directional implimentation of interfaces with inner boundries unaware of outer implimentations (Onion Architecture)

**DDD Design**
- [X] *Domain Entities, Behaviors and Aggrigate Root Repositories
- [X] *Domain Services (Entity orchestration and complex domain logic)
- [ ] *Domain Event Handeling (Sync/A-Sync with unit of work rollback) [[MediatR](https://medium.com/dotnet-hub/use-mediatr-in-asp-net-or-asp-net-core-cqrs-and-mediator-in-dotnet-how-to-use-mediatr-cqrs-aspnetcore-5076e2f2880c) or RabbitMQ?] Look at the following examples when deciding on a strategy:
  - [Ardalis Example](https://github.com/ardalis/CleanArchitecture/blob/main/src/Clean.Architecture.Core/ProjectAggregate/ToDoItem.cs): Add ToDoItemCompletedEvent from Domain Entity Behaviour
  - [Udemy Example](https://github.com/mehmetozkaya/AspnetMicroservices/tree/main/src/Services/Ordering/Ordering.Application): Add BasketCheckoutEvent during basket checkout (Looks like external ESB implimentation)
  - [ABP Framework](https://github.com/abpframework/abp/blob/dev/framework/test/Volo.Abp.TestApp/Volo/Abp/TestApp/Domain/Person.cs): Add PersonNameChangedEvent to Domain Entity Behaviours
- [X] *Ensure valid state - Side affects through domain events (Unit of Work Pattern, shared database context)
- [ ] *Include basic data population (seed from repo) for local dev and unit testing (Environment configurable)
- [ ] Ensure valid state - Use [value objects](src/Clean.Architecture.SharedKernel/ValueObject.cs) to ensure entities cannot be set in an invalid state, imutable history of values can be a subset of an entity object can have behaviors e.g. Product Code or Invoice Number that requires special formats and sequencing
- [ ] CQRS (Command & Query) Data Access Implimentation (Must be able to support standard repo's OR CQRS)
- [X] *Isolate sensitive (domain rule) updates on domain entity from access in application layer i.e. domain entity exposure / value objects

**General Microservice Design**
- [ ] *[Specification pattern](https://www.nuget.org/packages/Ardalis.Specification) implimentation (Decouple query construction from Data Access layer)
- [ ] Data Services ([Crud Rest vs Data Streams](https://www.confluent.io/blog/data-dichotomy-rethinking-the-way-we-treat-data-and-services/))
- [ ] Split testing into Functional, Integration and Unit Testing (Decent mocking / Stubbing capability)
- [ ] Leverage an async design for non-blocking activities
- [ ] Rate throttling

**CI/CD & Hosting**
- [ ] *Self hosted container on Linux image
- [ ] *API Gateway orchestration of Application Services REST implimentations (Example [Envoy](https://www.envoyproxy.io/) or Ocelot)
- [ ] *DevOps Pipeline automated deploy (Unit testing, versioning, certificate)
- [ ] Dependancy health check during deployment

**Miscellaneous**
- [X] Relook at the Unit of Work Pattern service and repository instanciation, check if we can use the DI to inject the same DB context and manage it through configuration

## Important Resources
- [Clean Architecture Uncle Bob](https://blog.cleancoder.com/uncle-bob/2012/08/13/the-clean-architecture.html)
- [Sample Clean Architecture Microservice](https://github.com/ardalis/CleanArchitecture) by Ardalis
- [Sample Microservice Git Repository](https://github.com/mehmetozkaya/AspnetMicroservices/tree/main/src/Services/Ordering/Ordering.Application) from Microservice .Net [Udemy Course](https://www.udemy.com/share/103fFg3@Sdnt_AcFYl01YJfSn6FcZweRsyhC2MjF0MirCRz9xbUlrvERX45dMfAEl8lJPS3D/)
- Example clean architecture from [ABP](https://abp.io/) with their [Source Code](https://github.com/abpframework/abp/)


