---
title: "Lambda parameter &#39;&lt;parameter&gt;&#39; hides a variable in an enclosing block, a previously defined range variable, or an implicitly declared variable in a query expression."
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - bc36641
  - vbc36641
helpviewer_keywords: 
  - BC36641
ms.assetid: ee08c366-29d1-4abb-b14c-23ae2b9680e7
caps.latest.revision: 7
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Lambda parameter &#39;&lt;parameter&gt;&#39; hides a variable in an enclosing block, a previously defined range variable, or an implicitly declared variable in a query expression.
A variable in a lambda expression has the same name as a variable previously defined within the same scope. This can be a variable in an enclosing block of code for a nested lambda expression, a range variable previously defined within a LINQ query, or a variable that is implicitly declared for a LINQ query.  
  
 **Error ID:** BC36641  
  
### To correct this error  
  
-   Ensure that all variables in your lambda expression have unique names that do not duplicate existing variable names in the same scope.  
  
## See Also  
 [Lambda Expressions](../vs140/lambda-expressions--visual-basic-.md)   
 [Introduction to LINQ in Visual Basic](../vs140/introduction-to-linq-in-visual-basic.md)   
 [LINQ in Visual Basic](../vs140/linq-in-visual-basic.md)