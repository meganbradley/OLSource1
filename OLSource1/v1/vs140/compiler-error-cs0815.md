---
title: "Compiler Error CS0815"
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
  - "CS0815"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0815"
ms.assetid: 8f055d34-9ee4-482e-9e79-8b3698c55cb4
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0815
Cannot assign 'expression' to an implicitly typed local  
  
 An expression that is used as the initializer for an implicitly typed variable must have a type. Because anonymous function expressions, method group expressions, and the null literal expression do not have a type, they are not appropriate initializers. An implicitly typed variable cannot be initialized with a null value in its declaration, although it can later be assigned a value of null.  
  
### To correct this error  
  
1.  Provide an explicit type for the variable.  
  
## Example  
 The following code generates CS0815:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [Implicitly Typed Local Variables (C# Programming Guide)](../vs140/implicitly-typed-local-variables--csharp-programming-guide-.md)