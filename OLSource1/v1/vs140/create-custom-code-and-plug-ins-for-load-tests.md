---
title: "Create custom code and plug-ins for load tests"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-tfs-dev14
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - vs.test.dialog.recorderplugin
helpviewer_keywords: 
  - Web performance tests, plug-ins
  - load tests, plug-ins
ms.assetid: 0c0fcc99-673b-4ea0-a268-0475f66e5cb6
caps.latest.revision: 26
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Create custom code and plug-ins for load tests
A custom plug-in uses code that you write and attach to a load test or a Web performance test. You can use the load test API and the Web Performance test API to create custom plug-ins for tests to expand to the built-in functionality.  
  
> [!NOTE]
>  In this version, you can add multiple plug-ins to your load test. Prior to Visual Studio Ultimate 2010, you were limited to using only one plug-in per load test. You no longer have to place all of your add-in code into the same plug-in.  
  
 **Requirements**  
  
-   Visual Studio Enterprise  
  
## Tasks  
  
|Tasks|Associated topics|  
|-----------|-----------------------|  
|**Create a custom plug-in for your load test**: You can use load test API to create a custom plug-in to add more testing functionality to your load test.|-   [How to: Use the Load Test API](assetId:///e15567bc-1f21-4feb-b81d-f17ba35cfde5)<br />-   [How to: Create a Load Test Plug-In](assetId:///27806972-1b15-4388-833d-6d0632816f1f)|  
|**Create a custom plug-in for your Web Performance test:** You can use Web performance test API to create a custom plug-in to add more testing functionality to your Web performance test, including at the request level. You can also create a Web Service test.<br /><br /> Additionally, you can create a Web recorder plug-in that can modify a Web performance test after it is recorded, but before it appears in the Web Performance Test Result Viewer.|-   [How to: Use the Web Performance Test API](assetId:///93a6a1dd-663b-4ab5-8760-7d6b081561d3)<br />-   [How to: Create a Web Performance Test Plug-In](assetId:///a612f2d2-9806-477d-a126-12842f07da6e)<br />-   [How to: Create a Request-Level Plug-In](assetId:///d0b5b23c-7e94-4637-be6c-2620a5442d46)<br />-   [How to: Create a Web Service Test](assetId:///fbcd57ee-06ad-4260-8694-09f8e0f93e39)<br />-   [How to: Create a Recorder Plug-in](assetId:///6fe13be1-aeb5-4927-9bff-35950e194da9)|  
|**Add UI features to Web Performance Test Results Viewer:** You can add more UI features to the Web Performance Test Results Viewer using a Visual Studio add-in.|-   [How to: Create a Web Performance Test Results Viewer Plug-in](assetId:///1118c604-4b1b-4b21-a04e-45995b676fa8)|  
|**Create a custom HTTP body editor:** You can create a custom editor to edit binary or string http XML responses from a web service.|-   [How to: Create a Web Performance Test Editor Plug-in](assetId:///a0b2d8ff-3e2a-487e-9172-90047174f336)|  
  
## Reference  
 <xref:Microsoft.VisualStudio.TestTools.WebTesting.WebTestPlugin?qualifyHint=False>  
  
 <xref:Microsoft.VisualStudio.TestTools.WebTesting.WebTestRequestPlugin?qualifyHint=False>  
  
 <xref:Microsoft.VisualStudio.TestTools.LoadTesting.ILoadTestPlugin?qualifyHint=False>  
  
 <xref:Microsoft.VisualStudio.TestTools.WebTesting.WebTestRecorderPlugin?qualifyHint=False>  
  
 <xref:Microsoft.VisualStudio.TestTools.LoadTesting?qualifyHint=False>  
  
## See Also  
 [Analyzing and Reporting on Load and Web Performance Tests](../vs140/analyzing-load-test-results-using-the-load-test-analyzer.md)   
 [Walkthrough: Creating a Coded Web Performance Test](assetId:///169e48f9-52fd-4d0b-83d9-54913bde506b)   
 [How to: Create a Coded Web Performance Test](../vs140/how-to--create-a-coded-web-performance-test.md)   
 [Testing Application Performance and Stress](../vs140/web-performance-and-load-tests-in-visual-studio.md)   
 [API Reference for Testing Tools for Visual Studio ALM](../vs140/api-reference-for-testing-tools-for-visual-studio-alm.md)