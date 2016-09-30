---
title: "How to: Compare the Contents of Two Folders (LINQ) (C#)"
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
ms.assetid: c7c4870e-c500-4de3-afa4-2c8e07f510e6
caps.latest.revision: 7
---
# How to: Compare the Contents of Two Folders (LINQ) (C#)
This example demonstrates three ways to compare two file listings:  
  
-   By querying for a Boolean value that specifies whether the two file lists are identical.  
  
-   By querying for the intersection to retrieve the files that are in both folders.  
  
-   By querying for the set difference to retrieve the files that are in one folder but not the other.  
  
    > [!NOTE]
    >  The techniques shown here can be adapted to compare sequences of objects of any type.  
  
 The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> class shown here demonstrates how to use a custom comparer class together with the Standard Query Operators. The class is not intended for use in real-world scenarios. It just uses the name and length in bytes of each file to determine whether the contents of each folder are identical or not. In a real-world scenario, you should modify this comparer to perform a more rigorous equality check.  
  
## Example  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Compiling the Code  
 Create a project that targets the .NET Framework  version 3.5 or higher, with a reference to System.Core.dll and <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> directives for the System.Linq and System.IO namespaces.  
  
## See Also  
 [LINQ to Objects (C#)](../vs140/linq-to-objects--csharp-.md)   
 [LINQ and File Directories (C#)](../vs140/linq-and-file-directories--csharp-.md)