---
title: "How to: Query for the Total Number of Bytes in a Set of Folders (LINQ) (Visual Basic)"
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
ms.assetid: bfe85ed2-44dc-4ef1-aac7-241622b80a69
caps.latest.revision: 7
---
# How to: Query for the Total Number of Bytes in a Set of Folders (LINQ) (Visual Basic)
This example shows how to retrieve the total number of bytes used by all the files in a specified folder and all its subfolders.  
  
## Example  
 The \<xref:System.Linq.Enumerable.Sum*> method adds the values of all the items selected in the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> clause. You can easily modify this query to retrieve the biggest or smallest file in the specified directory tree by calling the \<xref:System.Linq.Enumerable.Min*> or \<xref:System.Linq.Enumerable.Max*> method instead of \<xref:System.Linq.Enumerable.Sum*>.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 If you only have to count the number of bytes in a specified directory tree, you can do this more efficiently without creating a LINQ query, which incurs the overhead of creating the list collection as a data source. The usefulness of the LINQ approach increases as the query becomes more complex, or when you have to run multiple queries against the same data source.  
  
 The query calls out to a separate method to obtain the file length. It does this in order to consume the possible exception that will be raised if the file was deleted on another thread after the \<xref:System.IO.FileInfo*> object was created in the call to <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>. Even though the \<xref:System.IO.FileInfo*> object has already been created, the exception can occur because a \<xref:System.IO.FileInfo*> object will try to refresh its \<xref:System.IO.FileInfo.Length*> property with the most current length the first time the property is accessed. By putting this operation in a try-catch block outside the query, the code follows the rule of avoiding operations in queries that can cause side-effects. In general, great care must be taken when you consume exceptions to make sure that an application is not left in an unknown state.  
  
## Compiling the Code  
 Create a project that targets the .NET Framework version 3.5 or higher with a reference to System.Core.dll and a   <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> statement for the System.Linq namespace.  
  
## See Also  
 [LINQ to Objects (Visual Basic)](../vs140/linq-to-objects--visual-basic-.md)   
 [LINQ and File Directories (Visual Basic)](../vs140/linq-and-file-directories--visual-basic-.md)