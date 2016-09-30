---
title: "Debugging ASP.NET and AJAX Applications"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "debugging, WCF"
  - "debugging ASP.NET Web applications"
  - "debugging [ASP.NET], about ASP.NET debugging"
  - "WCF, debugging"
ms.assetid: 9d531913-541b-47b8-864d-138021fca0c6
caps.latest.revision: 35
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Debugging ASP.NET and AJAX Applications
Debugging [!INCLUDE[vstecasp](../vs140/includes/vstecasp_md.md)] Web applications is similar to debugging a Windows Form or any other Windows application because both kinds of applications involve controls and events. However, there are also basic differences between the two kinds of applications:  
  
-   Keeping track of state is more complex in a Web application.  
  
-   In a Windows application, the code to be debugged is mostly in one location; in a Web application, the code can be on the client and on the server. While [!INCLUDE[vstecasp](../vs140/includes/vstecasp_md.md)] code is all on the server, there might also be JavaScript or [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] code on the client.  
  
## In This Section  
 [Preparing to Debug ASP.NET applications](../vs140/preparing-to-debug-asp.net.md)  
 Describes the steps that are required to enable debugging of [!INCLUDE[vstecasp](../vs140/includes/vstecasp_md.md)] applications.  
  
 [Debugging Web Applications](../vs140/debugging-web-applications.md)  
 Discusses how to debug a [!INCLUDE[vstecasp](../vs140/includes/vstecasp_md.md)] application, including AJAX-enabled script applications.  
  
## Related Sections  
 [Exception Handling (Debugging)](../vs140/managing-exceptions-with-the-debugger.md)  
 Explains why Just My Code must be enabled for debugging [!INCLUDE[vstecasp](../vs140/includes/vstecasp_md.md)] exceptions.  
  
 [Debugging and Tracing Ajax Applications Overview](assetId:///92684ea0-7bb4-4a34-9203-3aa6394ce375)  
 Discusses some techniques and tools that can help you debug your AJAX code.  
  
 [Debugging Code Faster by Recording its History with IntelliTrace](../vs140/intellitrace.md)  
 Debug your code faster by using IntelliTrace to record and review a history of your application's state without restarting the application as frequently. You can see information about events and calls that occur during the running of your application and start debugging from these points in time. Requires Visual Studio Ultimate.  
  
## See Also  
 [Debugger Security](../vs140/debugger-security.md)   
 [Debugging Web Applications](../vs140/debugging-web-applications-and-script.md)   
 [Debug Settings and Preparation](../vs140/debugger-settings-and-preparation.md)   
 [Debugger Roadmap](../vs140/debugger-basics.md)