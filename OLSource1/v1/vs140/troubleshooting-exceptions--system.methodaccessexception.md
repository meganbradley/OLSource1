---
title: "Troubleshooting Exceptions: System.MethodAccessException"
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
  - "MethodAccessException class"
ms.assetid: 1c276666-e451-489e-8b95-25d737787030
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Troubleshooting Exceptions: System.MethodAccessException
A \<xref:System.MethodAccessException*> exception is thrown when there is an invalid attempt to access a private or protected method inside a class.  
  
## Associated Tips  
 **If the access level of a method in a class library has changed, recompile any assemblies that reference the library.**  
 This exception typically occurs when the caller does not have access permission to the member.  
  
## See Also  
 \<xref:System.MethodAccessException*>   
 [How to: Find Out More About an Exception with the Exception Assistant](../vs140/how-to--use-the-exception-assistant.md)