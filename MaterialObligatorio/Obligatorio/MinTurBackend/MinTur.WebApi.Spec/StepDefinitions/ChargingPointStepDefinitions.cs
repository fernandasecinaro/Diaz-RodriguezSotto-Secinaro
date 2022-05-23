using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;
using MinTur.WebApi.Controllers;
using MinTur.BusinessLogic.ResourceManagers;
using MinTur.DataAccess.Repositories;
using MinTur.DataAccess.Contexts;
using MinTur.DataAccessInterface.Facades;
using MinTur.Domain.BusinessEntities;
using MinTur.Models.In;
using MinTur.Models.Out;
using Moq;
using Microsoft.AspNetCore.Mvc;
using System;

namespace MinTur.WebApi.Spec.StepDefinitions
{
    [Binding]
    public sealed class ChargingPointStepDefinitions
    {
        private int _id;
        private string _name;
        private string _description;
        private string _address;
        private int _touristSpot;
        private bool _exists;
        private ChargingPointConfirmationModel _result;

        private TouristPointRepository _repository;
        private NaturalUruguayContext _context;

        private readonly ScenarioContext _scenarioContext;

        public ChargingPointStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }


        [Given("the id (.*)")]
        public void GivenTheIdIs(int id)
        {
            _id = id;
        }

        [Given("the name (.*)")]
        public void GivenTheNameIs(string name)
        {
            _name = name;
        }

        [Given("the address (.*)")]
        public void GivenTheAddressIs(string address)
        {
            _address = address;
        }

        [Given("the tourist spot (.*)")]
        public void GivenTheTouristSpotIs(int touristSpot)
        {
            _touristSpot = touristSpot;
        }

        [Given("the description (.*)")]
        public void GivenTheDescriptionIs(string description)
        {
            _description = description;
        }

        [Given("that a charging point with that id (.*)")]
        public void GivenTheChargingPointExists(string exists)
        {
            if (exists.Equals("exists"))
                _exists = true;
            else
                _exists = false;
        }

        [When("I click \"Add charging point\"")]
        public void WhenIClickAddChargingPoint()
        {
            var chargingPoint = new ChargingPoint()
            {
                Id = _id,
                Name = _name,
                Description = _description,
                Address = _address,
                TouristPoint = new TouristPoint() { Id = _touristSpot },
            };
            var repositoryMock = new Mock<IRepositoryFacade>(MockBehavior.Strict);
            repositoryMock.Setup(r => r.GetTouristPointById(It.IsAny<int>())).Returns(new TouristPoint() { Id= _touristSpot});
            repositoryMock.Setup(r => r.StoreChargingPoint(chargingPoint)).Returns(_id);

            var logic = new ChargingPointManager(repositoryMock.Object);
            var controller = new ChargingPointController(logic);

            try
            {
                var request = new ChargingPointIntentModel()
                {
                    Id = _id,
                    Name = _name,
                    Description = _description,
                    Address = _address,
                    TouristPointId = _touristSpot,
                };
                var requestResult = controller.MakeChargingPoint(request);
                var okResult = requestResult as OkObjectResult;
                _result = okResult.Value as ChargingPointConfirmationModel;
            } catch (Exception e)
            {
                _result = new ChargingPointConfirmationModel(0)
                {
                    UniqueCode = e.Message,
                };
            }
        }

        [When("I click \"Delete charging point\"")]
        public void WhenIClickDeleteChargingPoint()
        {
            var repositoryMock = new Mock<IRepositoryFacade>(MockBehavior.Strict);
            repositoryMock.Setup(r => r.DeleteChargingPoint(_id));
            
            var logic = new ChargingPointManager(repositoryMock.Object);
            var controller = new ChargingPointController(logic);

            try
            {
                int requestedId = _id;
                var requestResult = controller.DeleteChargingPoint(requestedId);
                var okResult = requestResult as OkObjectResult;
                _result = new ChargingPointConfirmationModel(0)
                {
                    UniqueCode = okResult.ToString()
                };
            } catch (Exception e)
            {
                _result = new ChargingPointConfirmationModel(0)
                {
                    UniqueCode = e.Message,
                };
            }
        }

        [Then("I recieve a message showing (.*)")]
        public void ThenTheResultShouldBe(string result)
        {
            _result.UniqueCode.Should().Equals(result);
        }
    }
}