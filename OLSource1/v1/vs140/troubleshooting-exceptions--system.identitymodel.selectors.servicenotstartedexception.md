---
title: "Troubleshooting Exceptions: System.IdentityModel.Selectors.ServiceNotStartedException"
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
  - "System.IdentityModel.Selectors.ServiceNotStartedException exception"
  - "ServiceNotStartedException exception"
ms.assetid: 6d34bab2-994a-4b0c-893d-19b5d7acf92d
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Troubleshooting Exceptions: System.IdentityModel.Selectors.ServiceNotStartedException
A \<xref:System.IdentityModel.Selectors.ServiceNotStartedException*> exception is thrown when CardSpace has not been started on the user's computer. If CardSpace has attempted to start but has been unable to for any reason, this exception is thrown.  
  
 Check that the CardSpace service is installed and enabled on the computer. Try to start the CardSpace service manually by using Microsoft Management Console (MMC).  
  
 CardSpace version 1 does not support FAT file systems. On FAT systems, CardSpace will not start and this exception will occur.  
  
## See Also  
 \<xref:System.IdentityModel.Selectors.ServiceNotStartedException*>   
 [How to: Find Out More About an Exception with the Exception Assistant](../vs140/how-to--use-the-exception-assistant.md)