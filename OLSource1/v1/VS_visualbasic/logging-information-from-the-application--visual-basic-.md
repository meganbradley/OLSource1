---
title: "Logging Information from the Application (Visual Basic)"
ms.custom: na
ms.date: "10/03/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "Log object"
  - "My.Log object"
  - "applications [Visual Basic], logging information from"
  - "logging"
  - "My.Application.Log object"
  - "examples [Visual Basic], logging application information"
ms.assetid: 8bf4f047-22d6-48d6-aec5-93b98ad5b8e8
caps.latest.revision: 12
ms.author: "shoag"
manager: "wpickett"
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
# Logging Information from the Application (Visual Basic)
This section contains topics that cover how to log information from your application using the `My.Application.Log` or `My.Log` object, and how to extend the application's logging capabilities.  
  
 The `Log` object provides methods for writing information to the application's log listeners, and the `Log` object's advanced `TraceSource` property provides detailed configuration information. The `Log` object is configured by the application's configuration file.  
  
 The `My.Log` object is available only for ASP.NET applications. For client applications, use `My.Application.Log`. For more information, see \<xref:Microsoft.VisualBasic.Logging.Log>.  
  
## Tasks  
  
|To|See|  
|--------|---------|  
|Write event information to the application's logs.|[How to: Write Log Messages](../VS_visualbasic/how-to--write-log-messages--visual-basic-.md)|  
|Write exception information to the application's logs.|[How to: Log Exceptions](../VS_visualbasic/how-to--log-exceptions-in-visual-basic.md)|  
|Write trace information to the application's logs when the application starts and shuts down.|[How to: Log Messages When the Application Starts or Shuts Down](../VS_visualbasic/how-to--log-messages-when-the-application-starts-or-shuts-down--visual-basic-.md)|  
|Configure `My.Application.Log` to write information to a text file.|[How to: Write Event Information to a Text File](../VS_visualbasic/how-to--write-event-information-to-a-text-file--visual-basic-.md)|  
|Configure `My.Application.Log` to write information to an event log.|[How to: Write to an Application Event Log](../VS_visualbasic/how-to--write-to-an-application-event-log--visual-basic-.md)|  
|Change where `My.Application.Log` writes information.|[Walkthrough: Changing Where My.Application.Log Writes Information](../VS_visualbasic/walkthrough--changing-where-my.application.log-writes-information--visual-basic-.md)|  
|Determine where `My.Application.Log` writes information.|[Walkthrough: Determining Where My.Application.Log Writes Information](../VS_visualbasic/walkthrough--determining-where-my.application.log-writes-information--visual-basic-.md)|  
|Create a custom log listener for `My.Application.Log`.|[Walkthrough: Creating Custom Log Listeners](../VS_visualbasic/walkthrough--creating-custom-log-listeners--visual-basic-.md)|  
|Filter the output of the `My.Application.Log` logs.|[Walkthrough: Filtering My.Application.Log Output](../VS_visualbasic/walkthrough--filtering-my.application.log-output--visual-basic-.md)|  
  
## See Also  
 \<xref:Microsoft.VisualBasic.Logging.Log?displayProperty=fullName>   
 [Working with Application Logs](../VS_visualbasic/working-with-application-logs-in-visual-basic.md)   
 [Troubleshooting: Log Listeners](../VS_visualbasic/troubleshooting--log-listeners--visual-basic-.md)