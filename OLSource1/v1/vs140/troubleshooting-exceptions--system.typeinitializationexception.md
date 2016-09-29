---
title: "Troubleshooting Exceptions: System.TypeInitializationException"
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
  - "TypeInitializationException exception"
  - "System.TypeInitializationException exception"
ms.assetid: c77e81fd-1518-49a1-8213-3f169658f5f5
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Troubleshooting Exceptions: System.TypeInitializationException
The exception that is thrown as a wrapper around the exception thrown by the class initializer.  
  
## Remarks  
 When a class initializer fails to initialize a type, a <xref:System.TypeInitializationException*> is created and passed a reference to the exception thrown by the type's class initializer. The <xref:System.Exception.InnerException*> property of the <xref:System.TypeInitializationException*> holds the underlying exception.  
  
## See Also  
 <xref:System.TypeInitializationException*>   
 [How to: Find Out More About an Exception with the Exception Assistant](../vs140/how-to--use-the-exception-assistant.md)