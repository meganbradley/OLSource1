---
title: "Troubleshooting Exceptions: System.Net.Sockets.SocketException"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "JScript"
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "SocketException class"
ms.assetid: 89e8194d-83b0-450f-91f5-548e5c13944d
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Troubleshooting Exceptions: System.Net.Sockets.SocketException
A \<xref:System.Net.Sockets.SocketException*> exception is thrown by the \<xref:System.Net.Sockets.Socket*> and \<xref:System.Net.Dns*> classes when an error occurs with the network.  
  
## Associated Tips  
 **Check the Errorcode property to determine why the socket error occurred.**  
 The default constructor for the \<xref:System.Net.Sockets.SocketException*> class sets the \<xref:System.Net.Sockets.SocketException.ErrorCode*> property to the last operating-system socket error that occurred.  
  
## See Also  
 \<xref:System.Net.Sockets.SocketException*>   
 [How to: Find Out More About an Exception with the Exception Assistant](../vs140/how-to--use-the-exception-assistant.md)   
 [Using Secure Sockets Layer](assetId:///6e4289e6-d1b7-4e82-ab0d-e83e3b6063ed)