---
title: "Troubleshooting Exceptions: System.Net.NetworkInformation.NetworkInformationException"
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
  - "NetworkInformationException exception"
  - "System.Net.NetworkInformation.NetworkInformationException exception"
ms.assetid: 81da4ec9-9489-4ff9-a0b5-ec5e9049d07c
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Troubleshooting Exceptions: System.Net.NetworkInformation.NetworkInformationException
The exception that is thrown when an error occurs while retrieving network information.  
  
## Remarks  
 Types in the <xref:System.Net.NetworkInformation*> namespace throw this exception when a call to a Win32 function fails. The <xref:System.Net.NetworkInformation.NetworkInformationException.ErrorCode*> property contains the result returned by the function.  
  
## See Also  
 <xref:System.Net.NetworkInformation.NetworkInformationException*>   
 [How to: Find Out More About an Exception with the Exception Assistant](../vs140/how-to--use-the-exception-assistant.md)