---
title: "How to: Group Files by Extension (LINQ) (C#)"
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
ms.assetid: 21a98320-a5a1-4981-82d8-6a637e7d9018
caps.latest.revision: 7
---
# How to: Group Files by Extension (LINQ) (C#)
This example shows how LINQ can be used to perform advanced grouping and sorting operations on lists of files or folders. It also shows how to page output in the console window by using the \<xref:System.Linq.Enumerable.Skip*> and \<xref:System.Linq.Enumerable.Take*> methods.  
  
## Example  
 The following query shows how to group the contents of a specified directory tree by the file name extension.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The output from this program can be long, depending on the details of the local file system and what the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> is set to. To enable viewing of all results, this example shows how to page through results. The same techniques can be applied to Windows and Web applications. Notice that because the code pages the items in a group, a nested <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> loop is required. There is also some additional logic to compute the current position in the list, and to enable the user to stop paging and exit the program. In this particular case, the paging query is run against the cached results from the original query. In other contexts, such as LINQ to SQL, such caching is not required.  
  
## Compiling the Code  
 Create a project that targets the .NET Framework  version 3.5 or higher, with a reference to   System.Core.dll and <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> directives for the System.Linq and System.IO namespaces.  
  
## See Also  
 [LINQ to Objects (C#)](../vs140/linq-to-objects--csharp-.md)   
 [LINQ and File Directories (C#)](../vs140/linq-and-file-directories--csharp-.md)