---
title: "Compiler Error CS1947"
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
  - "CS1947"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS1947"
ms.assetid: e2822fba-a176-4466-9cdc-63c44e22ebcb
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS1947
Range variable 'variable name' cannot be assigned to -- it is read only.  
  
 A range variable is like an iteration variable in a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> statement. It cannot be assigned to in a query expression.  
  
### To correct this error  
  
1.  Remove the assignment to the range variable.  
  
2.  If necessary, introduce a new range variable by using the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> clause and use it to store the value.  
  
## Example  
 The following code generates CS1947:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [LINQ Query Expressions (C# Programming Guide)](../vs140/linq-query-expressions--csharp-programming-guide-.md)