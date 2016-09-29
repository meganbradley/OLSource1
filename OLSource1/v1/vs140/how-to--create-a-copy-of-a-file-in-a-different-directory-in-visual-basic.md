---
title: "How to: Create a Copy of a File in a Different Directory in Visual Basic"
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
ms.assetid: 88e2145c-d414-45a5-ad03-6f5d58ecca26
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Create a Copy of a File in a Different Directory in Visual Basic
The `My.Computer.FileSystem.CopyFile` method allows you to copy files. Its parameters provide the ability to overwrite existing files, rename the file, show the progress of the operation, and allow the user to cancel the operation.  
  
### To copy a text file to another folder  
  
-   Use the `CopyFile` method to copy a file, specifying a source file and the target directory. The`overwrite` parameter allows you to specify whether or not to overwrite existing files. The following code examples demonstrate how to use `CopyFile`.  
  
     [!code[VbFileIOMisc#24](../vs140/codesnippet/VisualBasic/how-to--create-a-copy-of-a-file-in-a-different-directory-in-visual-basic_1.vb)]  
  
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
 [How to: Create a Copy of a File in the Same Directory in Visual Basic](../vs140/how-to--create-a-copy-of-a-file-in-the-same-directory-in-visual-basic.md)   
 [How to: Copy a Directory to Another Directory in Visual Basic](../vs140/how-to--copy-a-directory-to-another-directory-in-visual-basic.md)   
 [How to: Rename a File in Visual Basic](../vs140/how-to--rename-a-file-in-visual-basic.md)