---
title: "How to: Find Files with a Specific Pattern in Visual Basic"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "files, finding"
  - "pattern matching"
  - "patterns, matching"
ms.assetid: 25e3b71d-b844-4293-9e4e-f06c5836b5cc
caps.latest.revision: 27
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Find Files with a Specific Pattern in Visual Basic
The \<xref:Microsoft.VisualBasic.MyServices.FileSystemProxy.GetFiles*> method returns a read-only collection of strings representing the path names for the files. You can use the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> parameter to specify a specific pattern. If you would like to include subdirectories in the search, set the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> parameter to <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
 An empty collection is returned if no files matching the specified pattern are found.  
  
> [!NOTE]
>  For information about returning a file list by using the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> class of the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> namespace, see \<xref:System.IO.DirectoryInfo.GetFiles*>.  
  
### To find files with a specified pattern  
  
-   Use the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> method, supplying the name and path of the directory you want to search and specifying the pattern. The following example returns all files with the extension <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> in the directory and adds them to <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
     [!code[VbFileIOMisc#4](../vs140/codesnippet/VisualBasic/how-to--find-files-with-a-specific-pattern-in-visual-basic_1.vb)]  
  
## .NET Framework Security  
 The following conditions may cause an exception:  
  
-   The path is not valid for one of the following reasons: it is a zero-length string, it contains only white space, it contains invalid characters, or it is a device path (starts with \\\\.\\) (\<xref:System.ArgumentException*>).  
  
-   The path is not valid because it is <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> (\<xref:System.ArgumentNullException*>).  
  
-   <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> does not exist (\<xref:System.IO.DirectoryNotFoundException*>).  
  
-   <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> points to an existing file (\<xref:System.IO.IOException*>).  
  
-   The path exceeds the system-defined maximum length (\<xref:System.IO.PathTooLongException*>).  
  
-   A file or folder name in the path contains a colon (:) or is in an invalid format (\<xref:System.NotSupportedException*>).  
  
-   The user lacks necessary permissions to view the path (\<xref:System.Security.SecurityException*>).  
  
-   The user lacks necessary permissions (\<xref:System.UnauthorizedAccessException*>).  
  
## See Also  
 \<xref:Microsoft.VisualBasic.MyServices.FileSystemProxy.GetFiles*>   
 [How to: Find Subdirectories with a Specific Pattern](../vs140/how-to--find-subdirectories-with-a-specific-pattern-in-visual-basic.md)   
 [Troubleshooting: Reading from and Writing to Text Files](../vs140/troubleshooting--reading-from-and-writing-to-text-files--visual-basic-.md)   
 [How to: Get the Collection of Files in a Directory in Visual Basic](../vs140/how-to--get-the-collection-of-files-in-a-directory-in-visual-basic.md)