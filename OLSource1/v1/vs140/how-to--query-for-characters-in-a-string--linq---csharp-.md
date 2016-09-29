---
title: "How to: Query for Characters in a String (LINQ) (C#)"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "CSharp"
ms.assetid: 727a1be7-dbec-4ab8-b414-bc2d56feb6ff
caps.latest.revision: 8
---
# How to: Query for Characters in a String (LINQ) (C#)
Because the <xref:System.String*> class implements the generic <xref:System.Collections.Generic.IEnumerable`1*> interface, any string can be queried as a sequence of characters. However, this is not a common use of LINQ. For complex pattern matching operations, use the <xref:System.Text.RegularExpressions.Regex*> class.  
  
## Example  
 The following example queries a string to determine the number of numeric digits it contains. Note that the query is "reused" after it is executed the first time. This is possible because the query itself does not store any actual results.  
  
<CodeContentPlaceHolder>0</CodeContentPlaceHolder>  
## Compiling the Code  
 Create a project that targets the .NET Framework  version 3.5 or higher, with a reference to System.Core.dll and `using` directives for the System.Linq and System.IO namespaces.  
  
## See Also  
 [LINQ and Strings (C#)](../vs140/linq-and-strings--csharp-.md)   
 [How to: Combine LINQ Queries with Regular Expressions (C#)](../vs140/how-to--combine-linq-queries-with-regular-expressions--csharp-.md)