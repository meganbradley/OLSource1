---
title: "How to: Create a Copy of a File in the Same Directory in Visual Basic"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "File.Copy"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "My.Computer.FileSystem.CopyFile method, copying files [Visual Basic]"
  - "files, copying"
  - "CopyFile method, copying files in Visual Basic"
  - "I/O [Visual Basic], copying files"
ms.assetid: b2fdda86-e666-42c2-9706-9527e9fa68ff
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Create a Copy of a File in the Same Directory in Visual Basic
Use the `My.Computer.FileSystem.CopyFile` method to copy files. The parameters allow you to overwrite existing files, rename the file, show the progress of the operation, and allow the user to cancel the operation.  
  
### To create a copy of a file in the same folder  
  
-   Use the `CopyFile` method, supplying the target file and the location. The following example creates a copy of `test.txt` called `test2.txt`.  
  
     [!code[VbVbcnMyFileSystem#51](../vs140/codesnippet/VisualBasic/how-to--create-a-copy-of-a-file-in-the-same-directory-in-visual-basic_1.vb)]  
  
### To create a copy of a file in the same folder, overwriting existing files  
  
-   Use the `CopyFile` method, supplying the target file and location, and setting `overwrite` to `True`. The following example creates a copy of `test.txt` called `test2.txt` and overwrites any existing files by that name.  
  
     [!code[VbVbcnMyFileSystem#52](../vs140/codesnippet/VisualBasic/how-to--create-a-copy-of-a-file-in-the-same-directory-in-visual-basic_2.vb)]  
  
## Robust Programming  
 The following conditions may cause an exception to be thrown:  
  
-   The path is not valid for one of the following reasons: it is a zero-length string, it contains only white space, it contains invalid characters, or it is a device path (starts with \\\\.\\) (<xref:System.ArgumentException*>).  
  
-   The system could not retrieve the absolute path (<xref:System.ArgumentException*>).  
  
-   The path is not valid because it is `Nothing` (<xref:System.ArgumentNullException*>).  
  
-   The source file is not valid or does not exist (<xref:System.IO.FileNotFoundException*>).  
  
-   The combined path points to an existing directory (<xref:System.IO.IOException*>).  
  
-   The destination file exists and `overwrite` is set to `False` (<xref:System.IO.IOException*>).  
  
-   The user does not have sufficient permissions to access the file (<xref:System.IO.IOException*>).  
  
-   A file in the target folder with the same name is in use (<xref:System.IO.IOException*>).  
  
-   A file or folder name in the path contains a colon (:) or is in an invalid format (<xref:System.NotSupportedException*>).  
  
-   `ShowUI` is set to `True`, `onUserCancel` is set to `ThrowException`, and the user has cancelled the operation (<xref:System.OperationCanceledException*>).  
  
-   `ShowUI` is set to `True`, `onUserCancel` is set to `ThrowException`, and an unspecified I/O error occurs (<xref:System.OperationCanceledException*>).  
  
-   The path exceeds the system-defined maximum length (<xref:System.IO.PathTooLongException*>).  
  
-   The user does not have required permission (<xref:System.UnauthorizedAccessException*>).  
  
-   The user lacks necessary permissions to view the path (<xref:System.Security.SecurityException*>).  
  
## See Also  
 <xref:Microsoft.VisualBasic.FileIO.FileSystem*>   
 <xref:Microsoft.VisualBasic.FileIO.FileSystem.CopyFile*>   
 <xref:Microsoft.VisualBasic.FileIO.UICancelOption*>   
 [How to: Copy Files with a Specific Pattern to a Directory in Visual Basic](../vs140/how-to--copy-files-with-a-specific-pattern-to-a-directory-in-visual-basic.md)   
 [How to: Create a Copy of a File in a Different Directory in Visual Basic](../vs140/how-to--create-a-copy-of-a-file-in-a-different-directory-in-visual-basic.md)   
 [How to: Copy a Directory to Another Directory in Visual Basic](../vs140/how-to--copy-a-directory-to-another-directory-in-visual-basic.md)   
 [How to: Rename a File in Visual Basic](../vs140/how-to--rename-a-file-in-visual-basic.md)