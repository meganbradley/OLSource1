---
title: "Compiler Error CS0819"
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
  - "CS0819"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0819"
ms.assetid: a5369e03-eb7d-4c88-b390-51304bd8d1ae
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0819
Implicitly typed locals cannot have multiple declarators.  
  
 Multiple declarators are allowed in explicit type declarations, but not with implicitly typed variables.  
  
### To correct this error  
  
1.  Declare and assign a value to each implicitly typed local variable on a separate line.  
  
## Example  
 The following code generates CS0819:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [Implicitly Typed Local Variables (C# Programming Guide)](../vs140/implicitly-typed-local-variables--csharp-programming-guide-.md)