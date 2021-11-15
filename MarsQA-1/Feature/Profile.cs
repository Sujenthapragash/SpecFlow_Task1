using System;
using TechTalk.SpecFlow;
using MarsQA_1.SpecflowPages.Pages;
using NUnit.Framework;

namespace MarsQA_1.Feature
{
    [Binding]
    public class Profile
    {
        ProfilePage profilePage = new ProfilePage();


        [Given(@"I logged in to my Mars profile successfully")]
        public void GivenILoggedInToMyMarsProfileSuccessfully()
        {
            profilePage.GoToProfile();
        }
        

        [Then(@"My availability option should be '(.*)' on my profile page")]
        public void ThenMyAvailabilityOptionShouldBeOnMyProfilePage(string p0)
        {
            string avialability = profilePage.GetAvailability();
            Assert.That(avialability == p0, "Availability is not changed");
        }

        [When(@"I change Availability on my profile page")]
        public void WhenIChangeAvailabilityOnMyProfilePage()
        {
            profilePage.ChnageAvailability();
        }

        [When(@"I click on remove icon without selecting any availability options")]
        public void WhenIClickOnRemoveIconWithoutSelectingAnyAvailabilityOptions()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"My availability option should not be changed on my profile page")]
        public void ThenMyAvailabilityOptionShouldNotBeChangedOnMyProfilePage()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I change hours on my profile page")]
        public void WhenIChangeHoursOnMyProfilePage()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I select '(.*)' option")]
        public void WhenISelectOption(string p0)
        {
            profilePage.SelectAvailability(p0);
        }

        [Then(@"My hours should be '(.*)' on my profile page")]
        public void ThenMyHoursShouldBeOnMyProfilePage(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I click on remove icon without selecting any hours options")]
        public void WhenIClickOnRemoveIconWithoutSelectingAnyHoursOptions()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"My hours option should not be changed on my profile page")]
        public void ThenMyHoursOptionShouldNotBeChangedOnMyProfilePage()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I change earn target on my profile page")]
        public void WhenIChangeEarnTargetOnMyProfilePage()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I select '(.*)' earn target option")]
        public void WhenISelectEarnTargetOption(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"My earn target should be '(.*)' on my profile page")]
        public void ThenMyEarnTargetShouldBeOnMyProfilePage(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I click on remove icon without selecting any earn target options")]
        public void WhenIClickOnRemoveIconWithoutSelectingAnyEarnTargetOptions()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I change description on my profile page")]
        public void WhenIChangeDescriptionOnMyProfilePage()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I type a '(.*)' on description text box")]
        public void WhenITypeAOnDescriptionTextBox(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I click on save button")]
        public void WhenIClickOnSaveButton()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"My description should be '(.*)' on my profile page")]
        public void ThenMyDescriptionShouldBeOnMyProfilePage(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I clear the description on the description text box")]
        public void WhenIClearTheDescriptionOnTheDescriptionTextBox()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I type '(.*)' on the description text box")]
        public void WhenITypeOnTheDescriptionTextBox(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"There should be an alert error message of '(.*)'")]
        public void ThenThereShouldBeAnAlertErrorMessageOf(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"My description should not be changed on my profile page")]
        public void ThenMyDescriptionShouldNotBeChangedOnMyProfilePage()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I type more than (.*) characters on the description text box")]
        public void WhenITypeMoreThanCharactersOnTheDescriptionTextBox(int p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"My description should be changed only with first (.*) characters on my profile page")]
        public void ThenMyDescriptionShouldBeChangedOnlyWithFirstCharactersOnMyProfilePage(int p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I select Languages")]
        public void GivenISelectLanguages()
        {
            profilePage.GoToLanguages();
        }

        [When(@"I click Add New button in Language tap")]
        public void WhenIClickAddNewButtonInLanguageTap()
        {
            profilePage.ClickOnLanguageAddNew();
        }

        [When(@"I click on Add button in Languages tap")]
        public void WhenIClickOnAddButtonInLanguageTap()
        {
            profilePage.ClickAddLanguage();
        }

        [Then(@"There should be an alert message of '(.*)'")]
        public void ThenThereShouldBeAnAlertMessageOf(string p0)
        {
          
            string aletmessage = profilePage.GetAlertMessage();
            Assert.That(aletmessage == p0, ("Wrong alert message "+aletmessage));
        }

        [Then(@"Language should be added to languages with '(.*)' '(.*)'")]
        public void ThenLanguageShouldBeAddedToLanguagesWith(string p0, string p1)
        {
            string languageName = profilePage.GetLastLanguageName();
            string languageLevel = profilePage.GetLastLanguageLevel();
            Assert.That(languageName == p0, "Language is not added");
            Assert.That(languageLevel == p1, "Language is not added");
        }

        [Then(@"Language should not be added to language")]
        public void ThenLanguageShouldNotBeAddedToLanguage()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I add a '(.*)' to AddLanguage text box")]
        public void WhenIAddAToAddLanguageTextBox(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I click on Cancel button")]
        public void WhenIClickOnCancelButton()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I select '(.*)' from Choose Language Level drop down")]
        public void WhenISelectFromChooseLanguageLevelDropDown(string p0)
        {
           profilePage.SelctLanguageLevel(p0);
        }

        [When(@"I type '(.*)' to addLanguage text box")]
        public void WhenITypeToAddLanguageTextBox(string p0)
        {
            profilePage.EnterLanguageName(p0);
        }

        [Given(@"I already have (.*) languages on my profile")]
        public void GivenIAlreadyHaveLanguagesOnMyProfile(int p0, Table table)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"There should not be an Add New button in Language tap")]
        public void ThenThereShouldNotBeAnAddNewButtonInLanguageTap()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I select skills")]
        public void GivenISelectSkills()
        {
            profilePage.GoToSkills();
        }

        [When(@"I click Add New button in Skill tap")]
        public void WhenIClickAddNewButtonInSkillTap()
        {
            profilePage.ClickOnSkillsAddNew();
        }

        [When(@"I type '(.*)' in Add Skill text box")]
        public void WhenITypeInAddSkillTextBox(string p0)
        {
            profilePage.EnterSkillName(p0);
        }

        [When(@"I select '(.*)' from Choose Skill Level drop down")]
        public void WhenISelectFromChooseSkillLevelDropDown(string p0)
        {
            profilePage.SelectSkillLevel(p0);
        }

        [When(@"I click on Add button in skills tap")]
        public void WhenIClickOnAddButtonInSkillsTap()
        {
            profilePage.ClickAddSkill();
        }

        [Then(@"skill should be added to skills with '(.*)' '(.*)'")]
        public void ThenSkillShouldBeAddedToSkillsWith(string p0, string p1)
        {
            string skillName = profilePage.GetLastSkillName();
            string skillLevel = profilePage.GetLastSkillLevel();
            Assert.That(skillName == p0, "Skill name is not added");
            Assert.That(skillLevel == p1, "Skill level is not added");
        }

        [Then(@"Skill should not be added to skill")]
        public void ThenSkillShouldNotBeAddedToSkill()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I click on Cancel button in Skill tap")]
        public void WhenIClickOnCancelButtonInSkillTap()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I already have (.*) skills on my profile")]
        public void GivenIAlreadyHaveSkillsOnMyProfile(int p0, Table table)
        {
            ScenarioContext.Current.Pending();
        }


    }
}
