---
title: "How to: Query for the Largest File or Files in a Directory Tree (LINQ) (C#)"
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
ms.assetid: 20c8a917-0552-4514-b489-0b8b6a4c3b4c
caps.latest.revision: 7
---
# How to: Query for the Largest File or Files in a Directory Tree (LINQ) (C#)
This example shows five queries related to file size in bytes:  
  
-   How to retrieve the size in bytes of the largest file.  
  
-   How to retrieve the size in bytes of the smallest file.  
  
-   How to retrieve the \<xref:System.IO.FileInfo*> object largest or smallest file from one or more folders under a specified root folder.  
  
-   How to retrieve a sequence such as the 10 largest files.  
  
-   How to order files into groups based on their file size in bytes, ignoring files that are less than a specified size.  
  
## Example  
 The following example contains five separate queries that show how to query and group files, depending on their file size in bytes. You can easily modify these examples to base the query on some other property of the \<xref:System.IO.FileInfo*> object.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 To return one or more complete \<xref:System.IO.FileInfo*> objects, the query first must examine each one in the data source, and then sort them by the value of their Length property. Then it can return the single one or the sequence with the greatest lengths. Use \<xref:System.Linq.Enumerable.First*> to return the first element in a list. Use \<xref:System.Linq.Enumerable.Take*> to return the first n number of elements. Specify a descending sort order to put the smallest elements at the start of the list.  
  
 The query calls out to a separate method to obtain the file size in bytes in order to consume the possible exception that will be raised in the case where a file was deleted on another thread in the time period since the \<xref:System.IO.FileInfo*> object was created in the call to <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>. Even through the \<xref:System.IO.FileInfo*> object has already been created, the exception can occur because a \<xref:System.IO.FileInfo*> object will try to refresh its \<xref:System.IO.FileInfo.Length*> property by using the most current size in bytes the first time the property is accessed. By putting this operation in a try-catch block outside the query, we follow the rule of avoiding operations in queries that can cause side-effects. In general, great care must be taken when consuming exceptions, to make sure that an application is not left in an unknown state.  
  
## Compiling the Code  
 Create a project that targets the .NET Framework  version 3.5 or higher, with a reference to System.Core.dll and <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> directives for the System.Linq and System.IO namespaces.  
  
## See Also  
 [LINQ to Objects (C#)](../vs140/linq-to-objects--csharp-.md)   
 [LINQ and File Directories (C#)](../vs140/linq-and-file-directories--csharp-.md)