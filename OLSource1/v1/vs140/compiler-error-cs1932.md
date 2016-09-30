---
title: "Compiler Error CS1932"
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
  - "CS1932"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS1932"
ms.assetid: fc927899-2d35-4d47-9ae9-8fc99295bb66
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS1932
Cannot assign 'expression' to a range variable.  
  
 The compiler must be able to infer the type of a range variable, whether it is introduced in a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> clause or a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> clause. It cannot be null because null is not a type, and it cannot be assigned with an expression of an unsafe type.  
  
### To correct this error  
  
-   Remove the assignment that is not valid.  
  
-   Explicitly cast the expression to an allowed type  
  
## Example  
 The following code generates CS1932 because the type of the range variable cannot be inferred. Cast the value to the intended type to fix the error, as shown in the following example.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [LINQ Query Expressions (C# Programming Guide)](../vs140/linq-query-expressions--csharp-programming-guide-.md)