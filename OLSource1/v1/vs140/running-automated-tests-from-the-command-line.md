---
title: "Running automated tests from the command line"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-tfs-dev14
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: article
helpviewer_keywords: 
  - tests, running from command line
  - testing, command-line
  - command line, running tests from
  - command-line tests
ms.assetid: f18179c6-b688-4e41-9898-8aca130c4fc3
caps.latest.revision: 29
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Running automated tests from the command line
[!INCLUDE[vs_dev11_long](../vs140/includes/vs_dev11_long_md.md)] includes the following command-line tools for testing purposes:  
  
-   **VSTest.Console.exe** You can use the VSTest.Console.exe program to run automated unit and coded UI tests from a command line. VSTest.Console.exe is optimized for performance and is used in place of MSTest.exe in [!INCLUDE[vs_dev11_long](../vs140/includes/vs_dev11_long_md.md)].  
  
-   **MSTest.exe** You can use the MSTest.exe program to run automated tests in a test assembly from a command line. MSTest is used for load tests and for compatibility with [!INCLUDE[vs2010](../vs140/includes/vs2010_md.md)] test projects. MSTest can also be used to view the test results from these test runs, save the results to disk, and save your results to [!INCLUDE[esprtfs](../vs140/includes/esprtfs_md.md)].  
  
-   **TCM.exe** Tcm.exe is a command-line utility that lets you perform the following tasks:  
  
    1.  Import automated tests into a test plan  
  
    2.  Run tests that are part of a test plan from the command line  
  
    3.  View a list of test items and their corresponding IDs to use when you import tests or run tests  
  
     You can also use tcm.exe to run test cases with associated automation from the command line using a test environment.  
  
## Tasks  
 Use the following topics to help you run automated tests from the command line:  
  
|Tasks|Associated Topics|  
|-----------|-----------------------|  
|**Running Automated tests from the command line using VSTest.Console.exe:** You can run automated unit and coded UI tests from the command line.|-   [Using VSTest.Console from the Command Line](assetId:///852812d8-b3bb-407e-bc43-04d511fcb27a)|  
|**Running automated tests from the command line using mstest.exe:** You can run automated Web performance and load tests from the command line either locally or by using a test controller or test agents.<br /><br /> Using MSTest.exe, you can save and view the automated test results from your test runs from the command line to your [!INCLUDE[esprtfs](../vs140/includes/esprtfs_md.md)].<br /><br /> MStest can also be used to run tests created in a Visual Studio 2010 test project, or if you have manually added a .testsettings file to your [!INCLUDE[vs_dev11_long](../vs140/includes/vs_dev11_long_md.md)] test project type.|-   [Using MSTest from the Command Line](assetId:///da19a039-f142-4c4a-959e-70146d11a943)|  
  
## See Also  
 [Running System Tests Using Microsoft Visual Studio](../vs140/running-automated-tests-using-microsoft-visual-studio.md)   
 [Creating System Tests Using Visual Studio](../vs140/creating-automated-tests-using-visual-studio.md)   
 [Plan Manual Tests using Team Web Access](../vs140/planning-manual-tests-using-the-web-portal.md)