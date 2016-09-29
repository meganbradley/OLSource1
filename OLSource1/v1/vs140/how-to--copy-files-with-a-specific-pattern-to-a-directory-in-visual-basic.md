---
title: "How to: Copy Files with a Specific Pattern to a Directory in Visual Basic"
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
  - "My.Computer.FileSystem.CopyFile method, copying files [Visual Basic]"
  - "files, copying"
  - "CopyFile method, copying files in Visual Basic"
  - "I/O [Visual Basic], copying files"
ms.assetid: f205d2ad-bbe5-4d55-8a40-acda21aa82dd
caps.latest.revision: 19
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Copy Files with a Specific Pattern to a Directory in Visual Basic
The [GetFiles](assetId:///M:Microsoft.VisualBasic.MyServices.FileSystemProxy.GetFiles(System.String)?qualifyHint=False&autoUpgrade=True) method returns a read-only collection of strings representing the path names for the files. You can use the `wildCards` parameter to specify a specific pattern.  
  
 An empty collection is returned if no matching files are found.  
  
 You can use the [CopyFile](assetId:///M:Microsoft.VisualBasic.FileIO.FileSystem.CopyFile(System.String,System.String)?qualifyHint=False&autoUpgrade=True) method to copy the files to a directory.  
  
### To copy files with a specific pattern to a directory  
  
1.  Use the `GetFiles` method to return the list of files. This example returns all .rtf files in the specified directory.  
  
     [!code[VbFileIOMisc#36](../vs140/codesnippet/VisualBasic/how-to--copy-files-with-a-specific-pattern-to-a-directory-in-visual-basic_1.vb)]  
  
2.  Use the `CopyFile` method to copy the files. This example copies the files to the directory named `testdirectory`.  
  
     [!code[VbVbcnMyFileSystem#88](../vs140/codesnippet/VisualBasic/how-to--copy-files-with-a-specific-pattern-to-a-directory-in-visual-basic_2.vb)]  
  
3.  Close the `For` statement with a `Next` statement.  
  
     [!code[VbVbcnMyFileSystem#89](../vs140/codesnippet/VisualBasic/how-to--copy-files-with-a-specific-pattern-to-a-directory-in-visual-basic_3.vb)]  
  
## Example  
 The following example, which presents the above snippets in complete form, copies all .rtf files in the specified directory to the directory named `testdirectory`.  
  
 [!code[VbFileIOMisc#37](../vs140/codesnippet/VisualBasic/how-to--copy-files-with-a-specific-pattern-to-a-directory-in-visual-basic_4.vb)]  
  
## .NET Framework Security  
 The following conditions may cause an exception:  
  
-   The path is not valid for one of the following reasons: it is a zero-length string, it contains only white space, it contains invalid characters, or it is a device path (starts with \\\\.\\) (<xref:System.ArgumentException*>).  
  
-   The path is not valid because it is `Nothing` (<xref:System.ArgumentNullException*>).  
  
-   The directory does not exist (<xref:System.IO.DirectoryNotFoundException*>).  
  
-   The directory points to an existing file (<xref:System.IO.IOException*>).  
  
-   The path exceeds the system-defined maximum length (<xref:System.IO.PathTooLongException*>).  
  
-   A file or directory name in the path contains a colon (:) or is in an invalid format (<xref:System.NotSupportedException*>).  
  
-   The user lacks necessary permissions to view the path (<xref:System.Security.SecurityException*>). The user lacks necessary permissions (<xref:System.UnauthorizedAccessException*>).  
  
## See Also  
 assetId:///M:Microsoft.VisualBasic.FileIO.FileSystem.CopyFile(System.String,System.String)?qualifyHint=False&autoUpgrade=True   
 assetId:///M:Microsoft.VisualBasic.MyServices.FileSystemProxy.GetFiles(System.String)?qualifyHint=False&autoUpgrade=True   
 [How to: Find Subdirectories with a Specific Pattern](../vs140/how-to--find-subdirectories-with-a-specific-pattern-in-visual-basic.md)   
 [Troubleshooting: Reading from and Writing to Text Files](../vs140/troubleshooting--reading-from-and-writing-to-text-files--visual-basic-.md)   
 [How to: Get the Collection of Files in a Directory in Visual Basic](../vs140/how-to--get-the-collection-of-files-in-a-directory-in-visual-basic.md)