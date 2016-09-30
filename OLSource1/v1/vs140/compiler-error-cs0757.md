---
title: "Compiler Error CS0757"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "CS0757"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0757"
ms.assetid: ba093570-306d-4b7b-aad5-1a3855ad6776
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0757
A partial method may not have multiple implementing declarations.  
  
 A partial method consists of exactly one defining declaration (signature) and one or zero implementing declarations (body). Multiple implementing declarations for the same identical defining declarations are not allowed. Partial methods may be overloaded, and each overloaded version may have one or zero implementing declarations.  
  
### To correct this error  
  
1.  Remove all except one of the implementing declarations for the partial method.  
  
## Example  
 The following example generates CS0757:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [Partial Classes and Methods (C# Programming Guide)](../vs140/partial-classes-and-methods--csharp-programming-guide-.md)