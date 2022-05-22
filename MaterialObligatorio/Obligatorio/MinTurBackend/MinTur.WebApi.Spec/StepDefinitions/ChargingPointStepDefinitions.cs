using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

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
        private int _result;

        [Given("the the id (.*)")]
        public void GivenTheFirstNumberIs(int id)
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

        [When("I click \"Add charging point\"")]
        public void WhenIClickAddChargingPoint()
        {
            //TODO: implement act (action) logic

            throw new PendingStepException();
        }

        [Then("I recieve a message showing (.*)")]
        public void ThenTheResultShouldBe(string result)
        {
            _result.Should().Equals(result);
        }
    }
}