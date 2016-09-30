---
title: "How to: Combine LINQ Queries with Regular Expressions (Visual Basic)"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
ms.assetid: 3da1bd10-b0d8-4d5b-a637-966891c13592
caps.latest.revision: 5
---
# How to: Combine LINQ Queries with Regular Expressions (Visual Basic)
This example shows how to use the \<xref:System.Text.RegularExpressions.Regex*> class to create a regular expression for more complex matching in text strings. The LINQ query makes it easy to filter on exactly the files that you want to search with the regular expression, and to shape the results.  
  
## Example  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 Note that you can also query the \<xref:System.Text.RegularExpressions.MatchCollection*> object that is returned by a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> search. In this example only the value of each match is produced in the results. However, it is also possible to use LINQ to perform all kinds of filtering, sorting, and grouping on that collection. Because \<xref:System.Text.RegularExpressions.MatchCollection*> is a non-generic \<xref:System.Collections.IEnumerable*> collection, you have to explicitly state the type of the range variable in the query.  
  
## Compiling the Code  
 Create a project that targets the .NET Framework version 3.5 or higher with a reference to System.Core.dll and a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> statement for the System.Linq namespace.  
  
## See Also  
 [LINQ and Strings (Visual Basic)](../vs140/linq-and-strings--visual-basic-.md)   
 [LINQ and File Directories (Visual Basic)](../vs140/linq-and-file-directories--visual-basic-.md)