---
title: "Compiler Error CS1941"
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
  - "CS1941"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS1941"
ms.assetid: 503054d6-9553-4a2a-9b68-4ccfdeccca22
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS1941
The type of one of the expressions in the 'clause' clause is incorrect. Type inference failed in the call to 'method'.  
  
 Type inference in query expressions flows from the type of the elements in the data source(s).  
  
### To correct this error  
  
1.  If it is not immediately obvious why the error is occurring, examine the query carefully and trace the type of the result of each clause from the data source to the point where the error is occurring.  
  
## Example  
 The following code generates CS1941 because the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> operator is being asked to compare an <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> to a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The method in which type inference fails is the method that the query clause is translated to at compile time.  
  
## See Also  
 [LINQ Query Expressions (C# Programming Guide)](../vs140/linq-query-expressions--csharp-programming-guide-.md)   
 [Type Relationships in Query Operations (LINQ)](../vs140/type-relationships-in-linq-query-operations--csharp-.md)