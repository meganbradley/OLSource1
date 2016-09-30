---
title: "How to: Split a File Into Many Files by Using Groups (LINQ) (C#)"
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
ms.assetid: 8179b91c-d778-4e57-884f-77fe5a8e4e40
caps.latest.revision: 7
---
# How to: Split a File Into Many Files by Using Groups (LINQ) (C#)
This example shows one way to merge the contents of two files and then create a set of new files that organize the data in a new way.  
  
### To create the data files  
  
1.  Copy these names into a text file that is named names1.txt and save it in your project folder:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
2.  Copy these names into a text file that is named names2.txt and save it in your project folder: Note that the two files have some names in common.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Example  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The program writes a separate file for each group in the same folder as the data files.  
  
## Compiling the Code  
 Create a project that targets the .NET Framework  version 3.5 or higher, with a reference to System.Core.dll and <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> directives for the System.Linq and System.IO namespaces.  
  
## See Also  
 [LINQ and Strings (C#)](../vs140/linq-and-strings--csharp-.md)   
 [LINQ and File Directories (C#)](../vs140/linq-and-file-directories--csharp-.md)