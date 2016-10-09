---
title: "Profiling the Performance of SharePoint Applications"
ms.custom: na
ms.date: "10/01/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "VS.SharePointTools.Profiling.SilverlightWebPartOnly"
  - "VS.SharePointTools.Profiling.DotNetTrustLevel"
dev_langs: 
  - "VB"
  - "CSharp"
helpviewer_keywords: 
  - "SharePoint development in Visual Studio, profiling"
  - "performance testing [SharePoint development in Visual Studio]"
  - "SharePoint development in Visual Studio, performance testing"
  - "profiling [SharePoint development in Visual Studio]"
ms.assetid: 61ae02e7-3f37-4230-bae1-54a498c2fae8
caps.latest.revision: 18
ms.author: "kempb"
manager: "douge"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# Profiling the Performance of SharePoint Applications
  If your SharePoint applications are performing slowly or inefficiently, you can use the profiling features in Visual Studio to identify problematic code and other elements. By using the load testing feature, you can determine how a SharePoint application performs under stress, such as when many users access the application simultaneously. By running web performance tests, you can measure how the application performs on the web. By using coded UI tests, you can verify whether the whole SharePoint application, including its user interface, functions correctly. When you use these tests together, they can help you identify performance issues before you deploy your application.  
  
## Profiling Tools Overview  
 Profiling refers to the process of observing and recording the performance behavior of your application as it runs. By profiling your application, you can uncover problems such as bottlenecks, inefficient code, and memory allocation issues, which cause applications to run slowly or use too much memory. For example, you can use profiling to identify hotspots in your code, which are segments of code that are frequently called and can slow down the overall performance of your application. After you identify hotspots, you can often optimize or eliminate them.  
  
 You can use several profiling tools in the integrated development environment (IDE) to identify and locate these kinds of performance issues. These tools work the same way for SharePoint projects as they do for other kinds of Visual Studio projects. The Profiling Tools Performance Wizard leads you through the creation of a performance session that uses the tests that you specify. A performance session is a set of configuration data that’s used for collecting performance information from an application, along with the results of one or more profiling runs. Performance sessions are stored in your project folder, and you can view them in **Performance Explorer**. For more information, see [Understanding Performance Collection Methods](../Topic/Understanding%20Performance%20Collection%20Methods.md).  
  
 After you create and run a profile analysis on your application, a report provides details about its performance. This report can include items such as a graph of CPU usage over time, a hierarchical function call stack, or a call tree. The exact contents of the report can vary, depending on the type of test that you run, such as sampling or instrumentation. For more information, see [Profiling Tools Report Overview](http://go.microsoft.com/fwlink/?LinkId=224689).  
  
## Performance Session Process  
 To profile an application, you start by using the Profiling Tools Performance Wizard to create a performance session. On the menu bar, choose **Analyze**, **Launch Performance Wizard**. As you complete the wizard, you enter the required information for your performance session, such as the profile method that you want and the application that you want to profile. For more information, see [How to: Profile a Web Site or Web Application Using the Performance Wizard](http://go.microsoft.com/fwlink/?LinkId=224692). As an alternative, you can use command-line options to set up and run a performance session. For more information, see [Using the Profiling Tools From the Command-Line](http://go.microsoft.com/fwlink/?LinkId=224703). If you want to configure every aspect of a performance session manually, see [How to: Manually Create Performance Sessions with the Profiling Tools](http://go.microsoft.com/fwlink/?LinkId=224691). You can also create a performance session from a unit test by, in the **Test Results** window, opening the shortcut menu for the unit test and then choosing **Create Performance Session**.  
  
 After you set up a performance session, the session configuration is saved, the server is configured to provide profiling data, and the application runs. As you use the application, performance data is written to a log file. Performance sessions are listed in **Performance Explorer** under the **Targets** folder. After a performance session finishes, its report appears in the **Reports** folder in **Performance Explorer**. To display the report, open it in **Performance Explorer**. To view or configure the properties of a performance session, open its shortcut menu in **Performance Explorer**, and then choose **Properties**. For more information about specific properties of a performance session, see [Configuring Performance Sessions for Profiling Tools](http://go.microsoft.com/fwlink/?LinkId=224694). For information about how to interpret the results of a performance session, see [Analyzing Profiling Tools Data](http://go.microsoft.com/fwlink/?LinkId=224704).  
  
## Stress Testing  
 You can analyze the stress performance of your applications by creating load tests and web performance tests in Visual Studio Ultimate. When you create a load test in Visual Studio, you specify a combination of factors, called a scenario, to test your application against. These factors include load pattern, test mix model, test mix, network mix, and web browser mix. Load test scenarios can include both unit tests and web performance tests.  
  
 Figure 1: Load testing results example  
  
 ![Running load test graphs view](../VS_officedev/media/load_webgraphs.png "Load_WebGraphs")  
  
 Web performance tests simulate how an end user might interact with a SharePoint application. You can create web performance tests by recording HTTP requests in a browser session or by using the **Web Performance Test Recorder**. The web requests appear in the **Web Performance Test Editor** after the browser session is finished. You can then debug the results in the **Web Performance Test Results Viewer**. You can also manually build web performance tests by using the **Web Performance Test Editor**.  
  
## Testing User Interfaces  
 Coded UI tests automatically drive your SharePoint application through its user interface (UI). These tests cover the UI controls, such as buttons and menus, to verify that they function correctly. This kind of testing is particularly useful if validation or other logic is performed in the UI, such as in a web page. You can also use coded UI tests to automate manual tests. You creating coded UI tests for your SharePoint applications in the same way as you create tests for other types of applications. For more information, see [Testing SharePoint 2010 Applications with Coded UI Tests](../Topic/Testing%20SharePoint%202010%20Applications%20with%20Coded%20UI%20Tests.md).  
  
## Related Topics  
  
|Title|Description|  
|-----------|-----------------|  
|[Walkthrough: Profiling a SharePoint Application](../VS_officedev/walkthrough--profiling-a-sharepoint-application.md)|Demonstrates how to perform a sampling profile analysis on a SharePoint application.|  
|[Create and run a load test](assetId:///7041cbcf-9ab1-4579-98ff-8f296aeaded4)|Describes how to create load tests, which help you stress test SharePoint applications.|  
|[Creating and Editing Web Performance Tests](assetId:///8bf5f2a7-c693-47d6-9282-5946480151dc)|Describes how to create web performance tests, which help you simulate how a user interacts with your SharePoint site on the web.|  
|[Unit Test Your Code](../Topic/Unit%20Test%20Your%20Code.md)|Describes how to find logic errors in your code by using unit tests.|  
|[Testing SharePoint 2010 Applications with Coded UI Tests](../Topic/Testing%20SharePoint%202010%20Applications%20with%20Coded%20UI%20Tests.md)|Describes how to test the user interface of your SharePoint applications.|  
  
## See Also  
 [Building and Debugging SharePoint Solutions](../VS_officedev/building-and-debugging-sharepoint-solutions.md)   
 [Testing the application](../Topic/Test%20apps%20early%20and%20often.md)   
 [Improve Code Quality](../Topic/Improve%20Code%20Quality.md)  
  
  