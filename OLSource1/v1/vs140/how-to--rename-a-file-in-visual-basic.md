---
title: "How to: Rename a File in Visual Basic"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-visual-basic
ms.tgt_pltfrm: na
ms.topic: article
dev_langs: 
  - VB
helpviewer_keywords: 
  - I/O [Visual Basic], renaming files
  - files, renaming
ms.assetid: 0ea7e0c8-2cb2-4bf5-a00d-7b6e3c08a3bc
caps.latest.revision: 25
translation.priority.ht: 
  - de-de
  - ja-jp
---
# How to: Rename a File in Visual Basic
Use the `RenameFile` method of the `My.Computer.FileSystem` object to rename a file by supplying the current location, file name, and the new file name. This method cannot be used to move a file; use the `MoveFile` method to move and rename the file.  
  
### To rename a file  
  
-   Use the `My.Computer.FileSystem.RenameFile` method to rename a file. This example renames the file named `Test.txt` to `SecondTest.txt`.  
  
     [!code[VbVbcnMyFileSystem#9](../vs140/codesnippet/VisualBasic/how-to--rename-a-file-in-visual-basic_1.vb)]
  
  
 This code example is also available as an IntelliSense code snippet. In the code snippet picker, the snippet is located in **File system - Processing Drives, Folders, and Files**. For more information, see [Code Snippets](../vs140/code-snippets.md).  
  
## Robust Programming  
 The following conditions may cause an exception:  
  
-   The path is not valid for one of the following reasons: it is a zero-length string, it contains only white space, it contains invalid characters, or it is a device path (starts with \\\\.\\) (<xref:System.ArgumentException?qualifyHint=False>).  
  
-   `newName` contains path information (<xref:System.ArgumentException?qualifyHint=False>).  
  
-   The path is not valid because it is `Nothing` (<xref:System.ArgumentNullException?qualifyHint=False>).  
  
-   `newName` is `Nothing` or an empty string (<xref:System.ArgumentNullException?qualifyHint=False>).  
  
-   The source file is not valid or does not exist (<xref:System.IO.FileNotFoundException?qualifyHint=False>).  
  
-   There is an existing file or directory with the name specified in `newName` (<xref:System.IO.IOException?qualifyHint=False>).  
  
-   The path exceeds the system-defined maximum length (<xref:System.IO.PathTooLongException?qualifyHint=False>).  
  
-   A file or directory name in the path contains a colon (:) or is in an invalid format (<xref:System.NotSupportedException?qualifyHint=False>).  
  
-   The user lacks necessary permissions to view the path (<xref:System.Security.SecurityException?qualifyHint=False>).  
  
-   The user does not have the required permission (<xref:System.UnauthorizedAccessException?qualifyHint=False>).  
  
## See Also  
 <xref:Microsoft.VisualBasic.FileIO.FileSystem.RenameFile?qualifyHint=False>   
 [How to: Move a File in Visual Basic](../vs140/how-to--move-a-file-in-visual-basic.md)   
 [Creating, Deleting, and Moving Files and Directories in Visual Basic](../vs140/creating--deleting--and-moving-files-and-directories-in-visual-basic.md)   
 [How to: Create a Copy of a File in the Same Directory in Visual Basic](../vs140/how-to--create-a-copy-of-a-file-in-the-same-directory-in-visual-basic.md)   
 [How to: Create a Copy of a File in a Different Directory in Visual Basic](../vs140/how-to--create-a-copy-of-a-file-in-a-different-directory-in-visual-basic.md)