---
title: "Logging Information from the Application (Visual Basic)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-visual-basic
ms.tgt_pltfrm: na
ms.topic: article
dev_langs: 
  - VB
helpviewer_keywords: 
  - Log object
  - My.Log object
  - applications [Visual Basic], logging information from
  - logging
  - My.Application.Log object
  - examples [Visual Basic], logging application information
ms.assetid: 8bf4f047-22d6-48d6-aec5-93b98ad5b8e8
caps.latest.revision: 16
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Logging Information from the Application (Visual Basic)
This section contains topics that cover how to log information from your application using the `My.Application.Log` or `My.Log` object, and how to extend the application's logging capabilities.  
  
 The `Log` object provides methods for writing information to the application's log listeners, and the `Log` object's advanced `TraceSource` property provides detailed configuration information. The `Log` object is configured by the application's configuration file.  
  
 The `My.Log` object is available only for ASP.NET applications. For client applications, use `My.Application.Log`. For more information, see <xref:Microsoft.VisualBasic.Logging.Log?qualifyHint=False>.  
  
## Tasks  
  
|To|See|  
|--------|---------|  
|Write event information to the application's logs.|[How to: Write Log Messages](../vs140/how-to--write-log-messages--visual-basic-.md)|  
|Write exception information to the application's logs.|[How to: Log Exceptions in Visual Basic](../vs140/how-to--log-exceptions-in-visual-basic.md)|  
|Write trace information to the application's logs when the application starts and shuts down.|[How to: Log Messages When the Application Starts or Shuts Down](../vs140/how-to--log-messages-when-the-application-starts-or-shuts-down--visual-basic-.md)|  
|Configure `My.Application.Log` to write information to a text file.|[How to: Write Event Information to a Text File](../vs140/how-to--write-event-information-to-a-text-file--visual-basic-.md)|  
|Configure `My.Application.Log` to write information to an event log.|[How to: Write Event Information to an Application Event Log](../vs140/how-to--write-to-an-application-event-log--visual-basic-.md)|  
|Change where `My.Application.Log` writes information.|[Walkthrough: Changing Where My.Application.Log Writes Information](../vs140/walkthrough--changing-where-my.application.log-writes-information--visual-basic-.md)|  
|Determine where `My.Application.Log` writes information.|[Walkthrough: Determining Where My.Application.Log Writes Information](../vs140/walkthrough--determining-where-my.application.log-writes-information--visual-basic-.md)|  
|Create a custom log listener for `My.Application.Log`.|[Walkthrough: Creating Custom Log Listeners](../vs140/walkthrough--creating-custom-log-listeners--visual-basic-.md)|  
|Filter the output of the `My.Application.Log` logs.|[Walkthrough: Filtering My.Application.Log Output](../vs140/walkthrough--filtering-my.application.log-output--visual-basic-.md)|  
  
## See Also  
 <xref:Microsoft.VisualBasic.Logging.Log?qualifyHint=True>   
 [Working with Application Logs in Visual Basic](../vs140/working-with-application-logs-in-visual-basic.md)   
 [Troubleshooting: Log Listeners](../vs140/troubleshooting--log-listeners--visual-basic-.md)