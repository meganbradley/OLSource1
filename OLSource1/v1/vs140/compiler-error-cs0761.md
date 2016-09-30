---
title: "Compiler Error CS0761"
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
  - "CS0761"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0761"
ms.assetid: b16ac1df-0ddc-44d2-89f1-8d9c32af87ad
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0761
Partial method declarations of 'method\<T>' have inconsistent type parameter constraints.  
  
 If a partial method has an implementation, the generic type constraint must be identical to the constraint defined on the method signature.  
  
### To correct this error  
  
1.  Make the generic type constraints identical on each part of the partial method.  
  
## Example  
 The following code generates CS0761:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [Partial Classes and Methods (C# Programming Guide)](../vs140/partial-classes-and-methods--csharp-programming-guide-.md)   
 [Constraints on Type Parameters (C# Programming Guide)](../vs140/constraints-on-type-parameters--csharp-programming-guide-.md)