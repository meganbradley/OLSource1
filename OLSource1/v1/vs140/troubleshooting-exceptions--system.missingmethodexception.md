---
title: "Troubleshooting Exceptions: System.MissingMethodException"
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
  - "MissingMethodException class"
ms.assetid: 1ca4c351-ca26-4a6d-a5a1-c484ac193e2e
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Troubleshooting Exceptions: System.MissingMethodException
A \<xref:System.MissingMethodException*> exception is thrown when there is an attempt to dynamically access a method that does not exist.  
  
## Associated Tips  
 **If a method in a class library has been removed or renamed, recompile any assemblies that reference that method.**  
 This exception is typically thrown when an attempt is made to dynamically access a deleted or renamed method of an assembly that is not referenced by its strong name.  
  
## Remarks  
 If you are calling an unmanaged function, this exception is thrown if the CLR cannot find the module or function.  
  
## See Also  
 \<xref:System.MissingMethodException*>   
 [How to: Find Out More About an Exception with the Exception Assistant](../vs140/how-to--use-the-exception-assistant.md)   
 [Troubleshooting Interoperability](../vs140/troubleshooting-interoperability--visual-basic-.md)