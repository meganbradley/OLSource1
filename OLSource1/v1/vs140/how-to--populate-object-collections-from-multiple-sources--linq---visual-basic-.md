---
title: "How to: Populate Object Collections from Multiple Sources (LINQ) (Visual Basic)"
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
ms.assetid: 63062a22-e6a9-42c0-b357-c7c965f58f33
caps.latest.revision: 7
---
# How to: Populate Object Collections from Multiple Sources (LINQ) (Visual Basic)
This example shows how to merge data from different sources into a sequence of new types.  
  
> [!NOTE]
>  Do not try to join in-memory data or data in the file system with data that is still in a database. Such cross-domain joins can yield undefined results because of different ways in which join operations might be defined for database queries and other types of sources. Additionally, there is a risk that such an operation could cause an out-of-memory exception if the amount of data in the database is large enough. To join data from a database to in-memory data, first call <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> on the database query, and then perform the join on the returned collection.  
  
### To create the data file  
  
-   Copy the names.csv and scores.csv files into your project folder, as described in [How to: Join Content from Dissimilar Files (LINQ) (Visual Basic)](../vs140/how-to--join-content-from-dissimilar-files--linq---visual-basic-.md).  
  
## Example  
 The following example shows how to use a named type <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> to store merged data from two in-memory collections of strings that simulate spreadsheet data in .csv format. The first collection of strings represents the student names and IDs, and the second collection represents the student ID (in the first column) and four exam scores. The ID is used as the foreign key.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 In the [Select Clause (Visual Basic)](../vs140/select-clause--visual-basic-.md) clause, an object initializer is used to instantiate each new <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object by using the data from the two sources.  
  
 If you do not have to store the results of a query, anonymous types can be more convenient than named types. Named types are required if you pass the query results outside the method in which the query is executed. The following example performs the same task as the previous example, but uses anonymous types instead of named types:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Compiling the Code  
 Create a project that targets the .NET Framework version 3.5 or higher with a reference to System.Core.dll and a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> statement for the System.Linq namespace.  
  
## See Also  
 [LINQ and Strings (Visual Basic)](../vs140/linq-and-strings--visual-basic-.md)