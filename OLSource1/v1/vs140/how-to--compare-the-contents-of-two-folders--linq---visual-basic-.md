---
title: "How to: Compare the Contents of Two Folders (LINQ) (Visual Basic)"
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
ms.assetid: 903c7e9a-f48d-4a07-a8a8-5450d2646efa
caps.latest.revision: 7
---
# How to: Compare the Contents of Two Folders (LINQ) (Visual Basic)
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
 Create a project that targets the .NET Framework version 3.5 or higher with a reference to System.Core.dll and a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> statement for the System.Linq namespace.  
  
## See Also  
 [LINQ to Objects (Visual Basic)](../vs140/linq-to-objects--visual-basic-.md)   
 [LINQ and File Directories (Visual Basic)](../vs140/linq-and-file-directories--visual-basic-.md)