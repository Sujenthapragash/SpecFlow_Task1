Feature: Seller add profile details
	As a Seller
	I want to add my profile details
	So that
	The people seeking for some skills can look into my details.

@Automated
Scenario Outline: Change my availability with selection of an availability option on my profile
	Given I logged in to my Mars profile successfully 
	When I change Availability on my profile page
	And I select '<Availability>' option
	Then There should be an alert message of 'Availability updated'
	And My availability option should be '<Availability>' on my profile page

Examples:
| Availability |
| Part Time    |
| Full Time    |

Scenario: Change my availability without selection of an availability option on my profile
	Given I logged in to my Mars profile successfully 
	When I change Availability on my profile page
	And I click on remove icon without selecting any availability options
	Then My availability option should not be changed on my profile page

Scenario Outline: Change my hours with selection of a hours option on my profile
	Given I logged in to my Mars profile successfully 
	When I change hours on my profile page
	And I select '<Hours>' option
	Then There should be an alert message of 'Availability updated'
	And My hours should be '<Hours>' on my profile page

Examples: 
| Hours                    |
| Less than 30hours a week |
| More than 30hours a week |
| As needed                |

Scenario: Change my hours without selection of a hour option on my profile
	Given I logged in to my Mars profile successfully 
	When I change hours on my profile page
	And I click on remove icon without selecting any hours options
	Then My hours option should not be changed on my profile page

Scenario Outline: Change my earn target with selection of an earn target option on my profile
	Given I logged in to my Mars profile successfully 
	When I change earn target on my profile page
	And I select '<EarnTarget>' earn target option
	Then There should be an alert message of 'Availability updated'
	Then My earn target should be '<EarnTarget>' on my profile page

Examples: 
| EarnTarget                       |
| Less than $500 per month         |
| Between $500 and $1000 per month |
| More than $1000 per month        |

Scenario: Change my earn target without selection of an earn target option on my profile
	Given I logged in to my Mars profile successfully 
	When I change earn target on my profile page
	And I click on remove icon without selecting any earn target options
	Then My hours option should not be changed on my profile page


Scenario Outline:  Change description with valid description on my profile
	Given I logged in to my Mars profile successfully 
	When I change description on my profile page
	And I type a '<Description>' on description text box 
	And I click on save button
	Then There should be an alert message of 'Description has been saved successfully'
	And My description should be '<Description>' on my profile page

Examples: 
| Description                                                     |
| Description start with letter                                   |
| 1 Description start with digit                                  |
| Description with !@#$%^&*()_+=-}{ \'";:/?.,>< special character |
| a                                                               |
| The Maximum number of characters remaining in the description is six hundred (600) characters. The Maximum number of characters remaining in the description is six hundred (600) characters. The Maximum number of characters remaining in the description is six hundred (600) characters. The Maximum number of characters remaining in the description is six hundred (600) characters. The Maximum number of characters remaining in the description is six hundred (600) characters. The Maximum number of characters remaining in the description is six hundred (600) characters. The Maximum number of characte |


Scenario Outline: Change description with in valid description on my profile
	Given I logged in to my Mars profile successfully 
	When I change description on my profile page
	And I clear the description on the description text box 
	And I type '<Description>' on the description text box
	And I click on save button
	Then There should be an alert error message of '<Message>'
	And My description should not be changed on my profile page

Examples: 
| Description                                | Message                                      |
| @ description start with special character | First character can only be digit or letters |
| Start with space                           | First character can only be digit or letters |
|                                            | Please, a description is required            |

Scenario: Change description with more than 600 character on my profile
	Given I logged in to my Mars profile successfully 
	When I change description on my profile page
	And I clear the description on the description text box 
	And I type more than 600 characters on the description text box
	And I click on save button
	Then There should be an alert message of 'Description has been saved successfully'
	And My description should be changed only with first 600 characters on my profile page

@ClearLanguage @Automated
Scenario Outline: Add a language with a language name and a language level option on my profile page
	Given I logged in to my Mars profile successfully
	And I select Languages
	When I click Add New button in Language tap
	And I type '<LanguageName>' to addLanguage text box
	And I select '<LanguageLevel>' from Choose Language Level drop down
	And I click on Add button in Languages tap
	Then There should be an alert message of '<AlertMessage>'
	And Language should be added to languages with '<LanguageName>' '<LanguageLevel>'

Examples: 
| LanguageName | LanguageLevel    | AlertMessage                             |
| English      | Basic            | English has been added to your languages |
| French       | Conversational   | French has been added to your languages  |
| Spanish      | Fluent           | Spanish has been added to your languages |
| Tamil        | Native/Bilingual | Tamil has been added to your languages   |

@ClearLanguage
Scenario Outline: Add a language without a language name and with a language level option
	Given I logged in to my Mars profile successfully
	And I select Languages
	When I click Add New button in Language tap
	And I select '<LanguageLevel>' from Choose Language Level drop down
	And I click on Add button in Languages tap
	Then There should be an alert message of '<AlertMessage>'
	And Language should not be added to language

Examples: 
| LangaugeLevel    | AlertMessage                    |
| Basic            | Please enter language and level |
| Conversational   | Please enter language and level |
| Fluent           | Please enter language and level |
| Native/Bilingual | Please enter language and level |

@ClearLanguage
Scenario Outline: Add a language without a language name and a language level option
	Given I logged in to my Mars profile successfully
	And I select Languages
	When I click Add New button in Language tap
	And I click on Add button in Languages tap
	Then There should be an alert message of 'Please enter language and level'
	And Language should not be added to language
@ClearLanguage
Scenario Outline: Add a language with a language name and without a language level option
	Given I logged in to my Mars profile successfully
	And I select Languages
	When I click Add New button in Language tap
	And I type '<LanguageName>' to addLanguage text box
	And I click on Add button in Languages tap
	Then There should be an alert message of '<AlertMessage>'
	And Language should not be added to language

Examples: 
| LanguageName | AlertNessage                    |
| English      | Please enter language and level |

@ClearLanguage
Scenario Outline: Cancel the Add language with a language name and a language level option on my profile page
	Given I logged in to my Mars profile successfully
	And I select Languages
	When I click Add New button in Language tap
	And I type '<LanguageName>' to addLanguage text box
	And I select '<LanguageLevel>' from Choose Language Level drop down
	And I click on Cancel button
	Then Language should not be added to language

Examples: 
| LanguageName | LangaugeLevel    |
| English      | Basic            |

@ClearLanguage
Scenario Outline: Cancel the Add language without a language name and with a language level option on my profile page
	Given I logged in to my Mars profile successfully
	And I select Languages
	When I click Add New button in Language tap
	And I select '<LanguageLevel>' from Choose Language Level drop down
	And I click on Cancel button
	Then Language should not be added to language

Examples: 
| LangaugeLevel    |
| Basic            |
@ClearLanguage
Scenario Outline: Cancel the Add language with a language name and without a language level option on my profile page
	Given I logged in to my Mars profile successfully
	And I select Languages
	When I click Add New button in Language tap
	And I type '<LanguageName>' to addLanguage text box
	And I click on Cancel button
	Then Language should not be added to language

Examples: 
| LanguageName |
| English      |

@ClearLanguage
Scenario: Cancel the Add language with out a language name and a language level option on my profile page
	Given I logged in to my Mars profile successfully
	And I select Languages
	When I click Add New button in Language tap
	And I select '<LanguageLevel>' from Choose Language Level drop down
	And I click on Cancel button
	Then Language should not be added to language

Examples: 
| LanguageLevel |
| Basic         |

@ClearLanguage
Scenario Outline: Add maximum number of 4 language on my profile page
	Given I logged in to my Mars profile successfully
	And I select Languages
	And I already have 3 languages on my profile
	| LanguageName | LanguageLevel    |
	| English      | Basic            |
	| French       | Conversational   |
	| Spanish      | Fluent           |
	
	When I type '<LanguageName>' to addLanguage text box
	And I select '<LanguageLvel>' from Choose Language Level drop down
	And I click on Add button in Languages tap
	Then Language should be added to languages with '<LanguageName>' '<LanguageLevel>'
	And There should not be an Add New button in Language tap

Examples: 
| LanguageName | LanguageLevel    |
| Tamil        | Native/Bilingual |

@ClearLanguage
Scenario Outline:Add a language with existing language name with same case letters
	Given I logged in to my Mars profile successfully
	And I select Languages
	And I already have 2 languages on my profile
	| LanguageName | LanguageLevel    |
	| English      | Basic            |
	| French       | Conversational   |

	When I click Add New button in Language tap
	And I type '<LanguageName>' to addLanguage text box
	And I select '<LanguageLevel>' from Choose Language Level drop down
	And I click on Add button in Languages tap
	Then There should be an alert message of '<AlertMessage>'
	And Language should not be added to language

Examples: 
| LanguageName | LanguageLevel  | AlertMessage                                          |
| English      | Fluent         | Duplicated data                                       |
| English      | Conversational | Duplicated data                                       |
| English      | Basic          | This language is already exist in your language list. |

@ClearLanguage
Scenario Outline:Add a language with existing language name with different case letters
	Given I logged in to my Mars profile successfully
	And I select Languages
	And I already have 2 languages on my profile
	| LanguageName | LanguageLevel    |
	| English      | Basic            |
	| French       | Conversational   |

	When I click Add New button in Language tap
	And I type '<LanguageName>' to addLanguage text box
	And I select '<LanguageLevel>' from Choose Language Level drop down
	And I click on Add button in Languages tap
	Then There should be an alert message of '<AlertMessage>'
	And Language should be added to languages with '<LanguageName>' '<LanguageLevel>'

Examples: 
| LanguageName | LanguageLevel  | AlertMessage                             |
| english      | Basic          | english has been added to your languages |
| enGlish      | Conversational | enGlish has been added to your languages |


Scenario Outline: Add a skill with a skill name and a skill level option on my profile page
	Given I logged in to my Mars profile successfully
	And I select skills
	When I click Add New button in Skill tap
	And I type '<SkillName>' in Add Skill text box
	And I select '<SkillLevel>' from Choose Skill Level drop down
	And I click on Add button in skills tap
	Then There should be an alert message of '<AlertMessage>'
	And skill should be added to skills with '<SkillName>' '<SkillLevel>'

Examples: 
| SkillName | SkillLevel   | AlertMessage                            |
| Java      | Beginner     | Java has been added to your skills      |
| c#        | Intermediate | c# has been added to your skills        |
| @python   | Expert       | @python has been added to your skills   |
| 4Selenium | Expert       | 4Selenium has been added to your skills |
| java8     | Beginner     | java8 has been added to your skills     |


Scenario Outline: Add a skill without a skill name and with a skill level option
	Given I logged in to my Mars profile successfully
	And I select skills
	When I click Add New button in Skill tap
	And I select '<SkillLevel>' from Choose Skill Level drop down
	And I click on Add button in skills tap
	Then There should be an alert message of '<AlertMessage>'
	And Skill should not be added to skill

Examples: 
| SkillLevel   | AlertMessage                            |
| Beginner     | Please enter skill and experience level |
| Intermediate | Please enter skill and experience level |
| Expert       | Please enter skill and experience level |


Scenario Outline: Add a skill without a skill name and a skill level option
	Given I logged in to my Mars profile successfully
	And I select skills
	When I click Add New button in Skill tap
	And I click on Add button in skills tap
	Then There should be an alert message of 'Please enter skill and experience level'
	And Skill should not be added to skill

Scenario Outline: Add a skill with a skill name and without a skill level option
	Given I logged in to my Mars profile successfully
	And I select skills
	When I click Add New button in Skill tap
	And I type '<SkillName>' in Add Skill text box
	And I click on Add button in skills tap
	Then There should be an alert message of '<AlertMessage>'
	And Skill should not be added to skill

Examples: 
| SkillName | AlertNessage                    |
| Reading      | Please enter skill and level |


Scenario Outline: Cancel the Add skill with a skill name and a skill level option on my profile page
	Given I logged in to my Mars profile successfully
	And I select skills
	When I click Add New button in Skill tap
	And I type '<SkillName>' in Add Skill text box
	And I select '<SkillLevel>' from Choose Skill Level drop down
	And I click on Cancel button in Skill tap
	Then Skill should not be added to skill

Examples: 
| SkillName | SkillLevel |
| Writing   | Beginner   |


Scenario Outline: Cancel the Add skill without a skill name and with a skill level option on my profile page
	Given I logged in to my Mars profile successfully
	And I select skills
	When I click Add New button in Skill tap
	And I select '<SkillLevel>' from Choose Skill Level drop down
	And I click on Cancel button in Skill tap
	Then Skill should not be added to skill

Examples: 
| SkillLevel    |
| Beginner            |

Scenario Outline: Cancel the Add skill with a skill name and without a skill level option on my profile page
	Given I logged in to my Mars profile successfully
	And I select skills
	When I click Add New button in Skill tap
	And I type '<SkillName>' in Add Skill text box
	And I click on Cancel button in Skill tap
	Then Skill should not be added to skill

Examples: 
| SkillName  |
| Programing |


Scenario: Cancel the Add skill with out a skill name and a skill level option on my profile page
	Given I logged in to my Mars profile successfully
	And I select skills
	When I click Add New button in Skill tap
	And I click on Cancel button in Skill tap
	Then Skill should not be added to skill

Scenario Outline:Add a skill with existing skill name with same case letters
	Given I logged in to my Mars profile successfully
	And I select skills
	And I already have 2 skills on my profile
	| SkillName | SkillLevel   |
	| Learning  | Beginner     |
	| Typing    | Intermediate |

	When I click Add New button in Skill tap
	And I type '<SkillName>' in Add Skill text box
	And I select '<SkillLevel>' from Choose Skill Level drop down
	And I click on Add button in skills tap
	Then There should be an alert message of '<AlertMessage>'
	And Skill should not be added to skill

Examples: 
| SkillName | SkillLevel   | AlertMessage                                    |
| Learning  | Intermediate | Duplicated data                                 |
| Learning  | Expert       | Duplicated data                                 |
| Learning  | Beginner     | This skill is already exist in your skill list. |



Scenario Outline:Add a skill with existing skill name with different case letters
	Given I logged in to my Mars profile successfully
	And I select skills
	And I already have 2 skills on my profile
	| SkillName  | SkillLevel |
	| Testing    | Expert     |
	| Automation | Beginner   |

	When I click Add New button in Skill tap
	And I type '<SkillName>' in Add Skill text box
	And I select '<SkillLevel>' from Choose Skill Level drop down
	And I click on Add button in skills tap
	Then There should be an alert message of '<AlertMessage>'
	And skill should be added to skills with '<skillName>' '<skillLevel>'

Examples: 
| SkillName | SkillLevel | AlertMessage                          |
| testing   | Expert     | Testing has been added to your skills |
| tesTing   | Beginner   | tesTing has been added to your skills |