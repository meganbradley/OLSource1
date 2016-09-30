---
title: "Troubleshooting Exceptions: System.IdentityModel.Selectors.ServiceBusyException"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "ServiceBusyException exception"
  - "System.IdentityModel.Selectors.ServiceBusyException exception"
ms.assetid: 88acdc6b-45ad-40c6-aa5c-3b56244edcee
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Troubleshooting Exceptions: System.IdentityModel.Selectors.ServiceBusyException
A \<xref:System.IdentityModel.Selectors.ServiceBusyException*> exception is thrown to indicate that the CardSpace service is busy processing other requests. CardSpace does not queue requests, and can service only one request at a time.  
  
 Determine whether another instance of CardSpace is running. If there is another instance running, end it by stopping the icardagt.exe process from Task Manager.  
  
## See Also  
 \<xref:System.IdentityModel.Selectors.ServiceBusyException*>   
 [How to: Find Out More About an Exception with the Exception Assistant](../vs140/how-to--use-the-exception-assistant.md)