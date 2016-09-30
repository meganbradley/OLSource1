---
title: "Troubleshooting Exceptions: System.MissingMemberException"
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
  - "MissingMemberException class"
ms.assetid: c4cf497b-0554-47fe-b2e9-81ee3eb9ec04
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Troubleshooting Exceptions: System.MissingMemberException
A \<xref:System.MissingMemberException*> exception is thrown when there is an attempt to dynamically access a class member that does not exist.  
  
## Associated Tips  
 **If a member in a class library has been removed or renamed, recompile any assemblies that reference that library.**  
 This exception is typically thrown when a field or method is deleted or renamed in one assembly, and the change is not reflected in a second assembly that is trying to access the missing member.  
  
 **If you are attempting to access members on a late-bound object variable, make sure it is declared Public.**  
 `Protected`, `Friend`, and `Private` variables cannot be late-bound in Visual Basic.  
  
## See Also  
 \<xref:System.MissingMemberException*>   
 [How to: Find Out More About an Exception with the Exception Assistant](../vs140/how-to--use-the-exception-assistant.md)