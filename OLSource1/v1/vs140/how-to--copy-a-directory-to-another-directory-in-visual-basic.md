---
title: "How to: Copy a Directory to Another Directory in Visual Basic"
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
  - "I/O [Visual Basic], copying directories"
  - "I/O [Visual Basic], copying folders"
  - "folders [Visual Basic], copying"
  - "directories [Visual Basic], copying"
ms.assetid: 2a370bd7-10ba-4219-afc4-4519d031eb6c
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Copy a Directory to Another Directory in Visual Basic
Use the \<xref:Microsoft.VisualBasic.FileIO.FileSystem.CopyDirectory*> method to copy a directory to another directory. This method copies the contents of the directory as well as the directory itself. If the target directory does not exist, it will be created. If a directory with the same name exists in the target location and <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, the contents of the two directories will be merged. You can specify a new name for the directory during the operation.  
  
 When copying files within a directory, exceptions may be thrown that are caused by specific file, such as a file existing during a merge while <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. When such exceptions are thrown, they are consolidated into a single exception, whose <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> property holds entries in which the file or directory path is the key and the specific exception message is contained in the corresponding value.  
  
### To copy a directory to another directory  
  
-   Use the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> method, specifying source and destination directory names. The following example copies the directory named <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> into <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, overwriting existing files.  
  
     [!code[VbVbcnMyFileSystem#16](../vs140/codesnippet/VisualBasic/how-to--copy-a-directory-to-another-directory-in-visual-basic_1.vb)]  
  
     This code example is also available as an IntelliSense code snippet. In the code snippet picker, it is located in **File system - Processing Drives, Folders, and Files**. For more information, see [Code Snippets](../vs140/code-snippets.md).  
  
## Robust Programming  
 The following conditions may cause an exception:  
  
-   The new name specified for the directory contains a colon (:) or slash (\ or /) (\<xref:System.ArgumentException*>).  
  
-   The path is not valid for one of the following reasons: it is a zero-length string, it contains only white space, it contains invalid characters, or it is a device path (starts with \\\\.\\) (\<xref:System.ArgumentException*>).  
  
-   The path is not valid because it is <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> (\<xref:System.ArgumentNullException*>).  
  
-   <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> or an empty string (\<xref:System.ArgumentNullException*>)  
  
-   The source directory does not exist (\<xref:System.IO.DirectoryNotFoundException*>).  
  
-   The source directory is a root directory (\<xref:System.IO.IOException*>).  
  
-   The combined path points to an existing file (\<xref:System.IO.IOException*>).  
  
-   The source path and target path are the same (\<xref:System.IO.IOException*>).  
  
-   <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> and the user cancels the operation, or one or more files in the directory cannot be copied (\<xref:System.OperationCanceledException*>).  
  
-   The operation is cyclic (\<xref:System.InvalidOperationException*>).  
  
-   The path contains a colon (:) (\<xref:System.NotSupportedException*>).  
  
-   The path exceeds the system-defined maximum length (\<xref:System.IO.PathTooLongException*>).  
  
-   A file or folder name in the path contains a colon (:) or is in an invalid format (\<xref:System.NotSupportedException*>).  
  
-   The user lacks necessary permissions to view the path (\<xref:System.Security.SecurityException*>).  
  
-   A destination file exists but cannot be accessed (\<xref:System.UnauthorizedAccessException*>).  
  
## See Also  
 \<xref:Microsoft.VisualBasic.FileIO.FileSystem.CopyDirectory*>   
 [How to: Find Subdirectories with a Specific Pattern in Visual Basic](../vs140/how-to--find-subdirectories-with-a-specific-pattern-in-visual-basic.md)   
 [How to: Get the Collection of Files in a Directory in Visual Basic](../vs140/how-to--get-the-collection-of-files-in-a-directory-in-visual-basic.md)