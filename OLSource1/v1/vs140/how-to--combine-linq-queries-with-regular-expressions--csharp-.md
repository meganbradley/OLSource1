---
title: "How to: Combine LINQ Queries with Regular Expressions (C#)"
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
ms.assetid: 6b003b65-20a4-4ca2-929e-2ee3f215aecc
caps.latest.revision: 7
---
# How to: Combine LINQ Queries with Regular Expressions (C#)
This example shows how to use the \<xref:System.Text.RegularExpressions.Regex*> class to create a regular expression for more complex matching in text strings. The LINQ query makes it easy to filter on exactly the files that you want to search with the regular expression, and to shape the results.  
  
## Example  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 Note that you can also query the \<xref:System.Text.RegularExpressions.MatchCollection*> object that is returned by a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> search. In this example only the value of each match is produced in the results. However, it is also possible to use LINQ to perform all kinds of filtering, sorting, and grouping on that collection. Because \<xref:System.Text.RegularExpressions.MatchCollection*> is a non-generic \<xref:System.Collections.IEnumerable*> collection, you have to explicitly state the type of the range variable in the query.  
  
## Compiling the Code  
 Create a project that targets the .NET Framework  version 3.5 or higher, with a reference to System.Core.dll and <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> directives for the System.Linq and System.IO namespaces.  
  
## See Also  
 [LINQ and Strings (C#)](../vs140/linq-and-strings--csharp-.md)   
 [LINQ and File Directories (C#)](../vs140/linq-and-file-directories--csharp-.md)