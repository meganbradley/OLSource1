---
title: "Sample Project for Creating Unit Tests"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-devops-test"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "unit test sample [Visual Studio]"
  - "unit tests, samples"
ms.assetid: db80aaf2-0652-4d3f-a8c5-2a98fd8502a2
caps.latest.revision: 34
ms.author: "mlearned"
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Sample Project for Creating Unit Tests
This sample code is provided for use in the following walkthroughs:  
  
-   [Walkthrough: Creating and Running Unit Tests](../vs140/walkthrough--creating-and-running-unit-tests-for-managed-code.md). This walkthrough leads you through the steps to create and customize unit tests, run them, and examine the test results.  
  
-   [Walkthrough: Run tests and view code coverage](assetId:///d4aab8e2-2140-4975-b4e3-41ef3fa944c8). This walkthrough illustrates  how to view code coverage data, which shows the proportion of your project's code that is being tested.  
  
-   [Walkthrough: using the command-line test utility](assetId:///52c11992-9e94-4067-a4b7-59f19d69d867). In this walkthrough, you use the MSTest.exe command-line utility to run tests and view results.  
  
## Sample Code  
 The only intentional error in this sample is that the in Debit method "m_balance += amount" should have a minus not a plus sign before the equals sign.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 /* The example companies, organizations, products, domain names, e-mail addresses, logos, people, places, and events depicted herein are fictitious.  No association with any real company, organization, product, domain name, email address, logo, person, places, or events is intended or should be inferred. \*/  
  
## Working with the Code  
 To work with this code, you first have to create a project for it in [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)]. Follow the steps in the "Prepare the Walkthrough" section in [Walkthrough: Creating and Running Unit Tests](../vs140/walkthrough--creating-and-running-unit-tests-for-managed-code.md).  
  
## See Also  
 [Walkthrough: Creating and Running Unit Tests](../vs140/walkthrough--creating-and-running-unit-tests-for-managed-code.md)   
 [Walkthrough: Run tests and view code coverage](assetId:///d4aab8e2-2140-4975-b4e3-41ef3fa944c8)   
 [Walkthrough: using the command-line test utility](assetId:///52c11992-9e94-4067-a4b7-59f19d69d867)