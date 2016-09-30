---
title: "Compiler Error CS1933"
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
  - "CS1933"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS1933"
ms.assetid: 80d719d3-1b39-44ec-90fd-039ae5570f01
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS1933
Expression cannot contain query expressions  
  
 Some variables cannot be initialized with a query expression. Constants cannot be initialized with query expressions because constants may only be initialized with some combination of literals, named constants, and mathematical operators.  
  
### To correct this error  
  
1.  Remove the modifier from the query variable.  
  
## Example  
 The following example generates CS1933:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [LINQ Query Expressions (C# Programming Guide)](../vs140/linq-query-expressions--csharp-programming-guide-.md)