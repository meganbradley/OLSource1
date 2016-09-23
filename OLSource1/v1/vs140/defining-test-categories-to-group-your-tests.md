---
title: "Defining Test Categories to Group Your Tests"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-tfs-dev14
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: article
helpviewer_keywords: 
  - test categories
ms.assetid: 2c26a648-f068-4d60-99b6-b9747b7bdbc9
caps.latest.revision: 37
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Defining Test Categories to Group Your Tests
If you have created automated tests using Visual Studio you can manage these tests by categorizing them with *test categories*. When you run these automated tests using Visual Studio, [!INCLUDE[esprbuild](../vs140/includes/esprbuild_md.md)], or mstest.exe, you can use these test categories to easily select which tests you run. You add test categories as attributes to your test methods.  
  
 **Requirements**  
  
-   Visual Studio Enterprise, [!INCLUDE[vstsTestEssLong](../vs140/includes/vststestesslong_md.md)]  
  
 Test categories provide more flexibility than the test lists functionality from earlier versions of Microsoft Visual Studio. You can use logical operators with test categories to run tests from multiple categories together or to limit the tests that you run to tests that belong to multiple categories. Also test categories are easy to add as you create your test methods and you do not have to maintain test lists after you have created your test methods. By using test categories, you do not have to check in and check out the **<solution name\>.vsmdi** file that maintains the test lists.  
  
## Tasks  
  
|Tasks|Associated Topics|  
|-----------|-----------------------|  
|**Grouping Tests into Test Categories:** You can add an automated test to one or multiple test categories using a test attribute. Each test can belong to multiple test categories.|-   [How to: Group and Run Automated Tests Using Test Categories](assetId:///7d7b3263-43fb-4aa9-8f05-2ac2e4c8af94)|  
|**Running Tests Using Test Categories:** After you choose which tests you want to run, you can choose which test categories they must belong to. You do this by using logical operators. For example, you could run all tests that belong to Priority 1 test category and Priority 2 test category.|-   [VSTest.Console.exe Command-Line Options](assetId:///52e1689d-b1a8-4589-bd98-99a55acd0a11)<br />-   [MSTest.exe Command-Line Options](assetId:///8813ba7f-e790-4e92-9f91-7080508a1c36)|  
|**Using Test Categories To Select Tests to Run Before Check-In:** You can use a build to check your code changes before you check in. You can use test categories to define the tests to run for this gated check-in build.|-   [Define a Build to Validate Changes Before Check-in](assetId:///9cfc8b9c-1023-40fd-8ab5-1b1bd9c172ec)|  
|**Using Test Categories To Select Tests to Run After Building Your Application or Before Check-In:** You can use a build definition to define which test categories to run to test a new build.|-   [How to: Configure and Run Scheduled Tests After Building Your Application](assetId:///32acfeb1-b1aa-4afb-8cfe-cc209e6183fd)|  
  
## See Also  
 [Creating Automated Tests Using Microsoft Test Manager](assetId:///7b5075ee-ddfe-411d-b1d4-94283550a5d0)