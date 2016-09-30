---
title: "Troubleshooting Exceptions: System.ArgumentException"
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
  - "ArgumentException exception"
  - "System.ArgumentException exception"
ms.assetid: d8052e62-bc73-4828-87e9-a84ef2a39a5b
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Troubleshooting Exceptions: System.ArgumentException
An \<xref:System.ArgumentException*> exception is thrown when at least one of the arguments provided to a method does not meet the specifications of the parameters of the method.  
  
 In the following example, the exception is thrown when the argument sent to method <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> is not an even number.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 All instances of the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> class should include information that specifies which argument is not valid, and what the range of acceptable values is. If a more precise exception, such as \<xref:System.ArgumentNullException*> or \<xref:System.ArgumentOutOfRangeException*>, accurately describes the situation, it should be used instead of <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 For more information about this exception, including examples in other languages, see \<xref:System.ArgumentException*>. For a list of additional constructors, see \<xref:System.ArgumentException.#ctor*>.  
  
## See Also  
 \<xref:System.ArgumentException*>   
 [How to: Find Out More About an Exception with the Exception Assistant](../vs140/how-to--use-the-exception-assistant.md)