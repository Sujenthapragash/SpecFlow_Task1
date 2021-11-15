using MarsQA_1.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace MarsQA_1.SpecflowPages.Pages
{
    public class ProfilePage
    {
        private IWebElement profileTab => Driver.driver.FindElement(By.XPath("//a[@class = 'item'][text()='Profile']"));
        private IWebElement availabilityWriteIcon => Driver.driver.FindElement(By.XPath("//div[@class ='extra content']//*[@class ='right floated outline small write icon'][1]"));

        private IWebElement availabilityDropdown => Driver.driver.FindElement(By.XPath("//div[@class = 'extra content']//select[@name = 'availabiltyType']"));

        private  IWebElement avilability => Driver.driver.FindElement(By.XPath("//div[@class = 'extra content']//div[@class = 'right floated content']/span[1]"));

        private  IWebElement alertMessage => Driver.driver.FindElement(By.XPath("//div[@class = 'ns-box-inner']"));

        private IWebElement languagesTap => Driver.driver.FindElement(By.XPath("//div[@class = 'ui top attached tabular menu']/a[text() = 'Languages']"));
        private IWebElement skillsTap => Driver.driver.FindElement(By.XPath("//div[@class = 'ui top attached tabular menu']/a[text() = 'Skills']"));


        private IWebElement languageAddNewButton => Driver.driver.FindElement(By.XPath("//div[@class = 'ui teal button '][text() = 'Add New'][1]"));
        private IWebElement skillsAddNewButton => Driver.driver.FindElement(By.XPath("//div[@class = 'ui teal button'][text() = 'Add New']"));

        private IWebElement addLanguageTextBox => Driver.driver.FindElement(By.XPath("//input[@name = 'name'][@type = 'text']"));
       
        private IWebElement chooseLanguageLevelDropDown => Driver.driver.FindElement(By.XPath("//select[@name = 'level'][@class = 'ui dropdown']"));

        private IWebElement languageAddButton => Driver.driver.FindElement(By.XPath("//input[@type = 'button'][@value ='Add']"));

        private IWebElement lastLanguageName => Driver.driver.FindElement(By.XPath("//div[@data-tab = 'first']//table[@class ='ui fixed table']/tbody[last()]/tr[last()]/td[1]"));
        private IWebElement lastLanguageLevel => Driver.driver.FindElement(By.XPath("//div[@data-tab = 'first']//table[@class ='ui fixed table']/tbody[last()]/tr[last()]/td[2]"));

        private IWebElement addSkilTextBox => Driver.driver.FindElement(By.XPath("//input[@type = 'text'][@name = 'name']"));

        private IWebElement chooseSkillLevelDropDown => Driver.driver.FindElement(By.XPath("//select[@class = 'ui fluid dropdown'][@name ='level']"));

        private IWebElement skillAddButton => Driver.driver.FindElement(By.XPath("//input[@type = 'button'][@value ='Add']"));

        private IWebElement lastSkillName => Driver.driver.FindElement(By.XPath("//div[@data-tab = 'second']//table[@class ='ui fixed table']/tbody[last()]/tr[last()]/td[1]"));
        private IWebElement lastSkillLevel => Driver.driver.FindElement(By.XPath("//div[@data-tab = 'second']//table[@class ='ui fixed table']/tbody[last()]/tr[last()]/td[2]"));


        public void GoToProfile() {

            profileTab.Click();
        }

        public void ChnageAvailability()
        {
            availabilityWriteIcon.Click();
        }

        public void SelectAvailability(string availability)
        {
            availabilityDropdown.Click();
            SelectElement availabilityDropdownOptions = new SelectElement(availabilityDropdown);
            if(availability == "Part Time")
            {
                availabilityDropdownOptions.SelectByValue("0");
            }
            else if (availability == "Full Time")
            {
                availabilityDropdownOptions.SelectByValue("1");
            }
          
            
        }

        public string GetAlertMessage()
        {
            var wait = new WebDriverWait(Driver.driver, new TimeSpan(0, 0, 10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//div[@class = 'ns-box-inner']")));
            return alertMessage.Text;
        }

        public string GetAvailability()
        {
            return avilability.Text;
        }

        public void GoToLanguages()
        {
            languagesTap.Click();
        }

        public void GoToSkills()
        {
            skillsTap.Click();
        }

        public void ClickOnLanguageAddNew()
        {
            languageAddNewButton.Click();
        }

        public void ClickOnSkillsAddNew()
        {
            skillsAddNewButton.Click();
        }
        public void EnterLanguageName(string languageName)
        {
            addLanguageTextBox.SendKeys(languageName);
        }

        public void SelctLanguageLevel(string languageLevel)
        {

            chooseLanguageLevelDropDown.Click();
            SelectElement languageLevelOptons = new SelectElement(chooseLanguageLevelDropDown);
            languageLevelOptons.SelectByText(languageLevel);
        }

        public void ClickAddLanguage()
        {
            languageAddButton.Click();
        }

        public string GetLastLanguageName()
        {
            
            return lastLanguageName.Text;
        }

        public string GetLastLanguageLevel()
        {
            
            return lastLanguageLevel.Text;
        }

        public void EnterSkillName(string skillName)
        {
            addSkilTextBox.SendKeys(skillName);
        }

        public void SelectSkillLevel(string skillLevel)
        {
            chooseSkillLevelDropDown.Click();
            SelectElement skillLevelOptions = new SelectElement(chooseSkillLevelDropDown);
            skillLevelOptions.SelectByText(skillLevel);
        }

        public void ClickAddSkill()
        {
            skillAddButton.Click();
        }

        public string GetLastSkillName()
        {

            return lastSkillName.Text;
        }

        public string GetLastSkillLevel()
        {

            return lastSkillLevel.Text;
        }


    }
}
