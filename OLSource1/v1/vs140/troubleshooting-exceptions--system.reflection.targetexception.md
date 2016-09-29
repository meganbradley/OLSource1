---
title: "Troubleshooting Exceptions: System.Reflection.TargetException"
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
  - "System.Reflection.TargetException exception"
  - "TargetException exception"
ms.assetid: 88b8e4b4-f1a3-4c4a-b1ef-cac176160803
caps.latest.revision: 10
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Troubleshooting Exceptions: System.Reflection.TargetException
The exception that is thrown when an attempt is made to invoke an invalid target.  
  
## Remarks  
 A <xref:System.Reflection.TargetException*> is thrown when an attempt is made to invoke a non-static method on a null object. This may occur because the caller does not have access to the member, or because the target does not define the member, or similar circumstances.  
  
## See Also  
 <xref:System.Reflection.TargetException*>   
 [How to: Find Out More About an Exception with the Exception Assistant](../vs140/how-to--use-the-exception-assistant.md)