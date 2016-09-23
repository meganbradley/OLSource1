---
title: "Creating Automated Tests Using Visual Studio"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-tfs-dev14
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: a574d7fa-10bd-453a-8ce0-b899178aee5b
caps.latest.revision: 7
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Creating Automated Tests Using Visual Studio
Using Visual Studio, you can create, manage, and run unit tests, coded UI tests, web performance tests, and load tests.  
  
 [!INCLUDE[crabout](../vs140/includes/crabout_md.md)] web performance and load tests see [Testing Performance and Stress Using Visual Studio Web Performance and Load Tests](../vs140/web-performance-and-load-tests-in-visual-studio.md).  
  
 Unit tests and coded UI tests are generally used by developers, or by team members who use Visual Studio, to validate the quality of their code in an app. For example, you might run these tests prior to checking your code into [version control](assetId:///33267cee-fe5f-4aa3-b2cd-6d22ceace314). For more information, see [Unit Test Your Code](../vs140/unit-test-your-code.md) and [Use UI Automation To Test Your Code](../vs140/use-ui-automation-to-test-your-code.md). However, team members involved in testing the application can also use these tests types for converting manual tests to automated tests and for isolating bugs that come out of integration testing from [Team Foundation builds](assetId:///a971b0f9-7c28-479d-a37b-8fd7e27ef692).  
  
## Tasks  
  
|Tasks|Associated Topics|  
|-----------|-----------------------|  
|**Creating system tests in Visual Studio:** Using Visual Studio, you can create coded UI tests from an existing action recording, for example an action recording created from a manual test. This allows you to automate your team’s [!INCLUDE[TCMext](../vs140/includes/tcmext_md.md)] manual testing efforts.|-   [System Testing with Coded UI Tests](../vs140/automated-testing-with-coded-ui-tests.md)|  
|**Categorizing tests:** If you have created automated tests using Visual Studio you can manage these tests by categorizing them with test categories. When you run these automated tests using Visual Studio, Team Foundation Build, or mstest.exe, you can use these test categories to easily select which tests you run. You add test categories as attributes to your test methods.|-   [Defining Test Categories to Group Your Tests](../vs140/defining-test-categories-to-group-your-tests.md)|  
|**Specify a group of test to run in a specific order:** An ordered test contains other tests that are meant to be run in a specified order. An ordered test is displayed as a single test in Test Explorer.|-   [Setting Up Your Test Run Sequence Using Ordered Tests](../vs140/setting-up-your-test-run-sequence-using-ordered-tests.md)|  
|**Using generic test to wrap an existing test, program, or third-party tool:** You use generic tests to call external programs and tests. After you have done this, the generic test is treated by the test engine as any other test type. For example, you can run generic tests from Test Explorer and you can obtain and publish results from generic tests just as you do from other tests.|-   [Creating an Automated Test That Runs an Executable Using Generic Tests](../vs140/creating-an-automated-test-that-runs-an-executable-using-generic-tests.md)|  
  
## Related Tasks  
 Coded UI tests can be used while developing an application to validate continuous functionality with code changes. [!INCLUDE[Crdefault](../vs140/includes/crdefault_md.md)][Use UI Automation To Test Your Code](../vs140/use-ui-automation-to-test-your-code.md).  
  
 In addition to coded UI tests, Visual Studio also includes unit tests. Unit tests are used primarily to verify an isolated unit of code for quality and functionality while you are developing an app. [!INCLUDE[Crdefault](../vs140/includes/crdefault_md.md)][Unit Test Your Code](../vs140/unit-test-your-code.md).  
  
## See Also  
 [System Testing Your Application Using Visual Studio](../vs140/create--manage--and-run-unit-tests--coded-ui-tests--web-performance-tests--and-load-tests.md)   
 [Running Automated System Tests Using Microsoft Visual Studio](../vs140/running-automated-tests-using-microsoft-visual-studio.md)