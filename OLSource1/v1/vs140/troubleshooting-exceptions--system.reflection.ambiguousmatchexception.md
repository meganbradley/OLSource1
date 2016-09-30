---
title: "Troubleshooting Exceptions: System.Reflection.AmbiguousMatchException"
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
  - "System.Reflection.AmbiguousMatchException exception"
  - "AmbiguousMatchException exception"
ms.assetid: f92b5c51-42b6-4c2e-83df-0d598b3b41c4
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Troubleshooting Exceptions: System.Reflection.AmbiguousMatchException
The exception that is thrown when binding to a method results in more than one method matching the binding criteria.  
  
## Remarks  
 An \<xref:System.Reflection.AmbiguousMatchException*> is thrown if the application calls upon a class, and it cannot determine which class or overloaded class to use. The binding attempts to locate the proper class to use, determined by the number of parameters and the type of parameters. If multiple acceptable classes are located, this exception is thrown.  
  
## See Also  
 \<xref:System.Reflection.AmbiguousMatchException*>   
 [How to: Find Out More About an Exception with the Exception Assistant](../vs140/how-to--use-the-exception-assistant.md)