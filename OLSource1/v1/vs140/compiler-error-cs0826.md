---
title: "Compiler Error CS0826"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "error-reference"
f1_keywords: 
  - "CS0826"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0826"
ms.assetid: baa68741-2813-4bdd-9312-dd45fdf10701
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0826
No best type found for implicitly typed array.  
  
 Array elements must all be the same type or implicitly convertible to the same type according to the type inference rules used by the compiler. The best type must be one of the types present in the array expression. Elements will not be converted to a new type such as <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>. For an implicitly typed array, the compiler must infer the array type based on the type of elements assigned to it.  
  
### To correct this error  
  
-   Give the array an explicit type.  
  
-   Give all array elements the same type.  
  
-   Provide explicit casts on those elements that might be causing the problem.  
  
## Example  
 The following code generates CS0826 because the array elements are not all the same type, and the compiler's type inference logic does not find a single best type:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [Implicitly Typed Local Variables (C# Programming Guide)](../vs140/implicitly-typed-local-variables--csharp-programming-guide-.md)