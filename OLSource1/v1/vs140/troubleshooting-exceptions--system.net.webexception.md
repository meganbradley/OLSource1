---
title: "Troubleshooting Exceptions: System.Net.WebException"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
dev_langs: 
  - JScript
  - VB
  - CSharp
  - C++
helpviewer_keywords: 
  - WebException class
ms.assetid: 6cd69a2c-c52b-420d-be47-a4e34eaec6f3
caps.latest.revision: 17
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Troubleshooting Exceptions: System.Net.WebException
A <xref:System.Net.WebException?qualifyHint=False> exception is thrown when an error occurs while accessing the network through a pluggable protocol.  
  
## Associated Tips  
 **Check the Response property of the exception to determine why the request failed.**  
 When a <xref:System.Net.WebException?qualifyHint=False> exception is thrown by a descendent of the <xref:System.Net.WebRequest?qualifyHint=False> class, the <xref:System.Net.WebException.Response?qualifyHint=False> property provides the Internet response to the application.  
  
 **Check the Status property of the exception to determine why the request failed.**  
 The <xref:System.Net.WebException.Status?qualifyHint=False> property of the exception provides status information for the error. For more information, see <xref:System.Net.WebExceptionStatus?qualifyHint=False>.  
  
 **If you are timing out when stepping into an XML Web Service, set the timeout value for the XML Web Service call to infinite.**  
 For more information, see [Error: Timeout While Debugging Web Services](../vs140/error--timeout-while-debugging-web-services.md).  
  
## See Also  
 <xref:System.Net.WebException?qualifyHint=False>   
 [How to: Find Out More About an Exception with the Exception Helper](../vs140/how-to--use-the-exception-assistant.md)   
 [How to: Send Data Using the WebRequest Class](assetId:///66686878-38ac-4aa6-bf42-ffb568ffc459)   
 [How to: Request Data Using the WebRequest Class](assetId:///368b8d0f-dc5e-4469-a8b8-b2adbf5dd800)   
 [How to Retrieve a Protocol-Specific WebResponse that Matches a WebRequest](assetId:///d8c90785-f16b-42a5-8439-ed2f731b2ba8)