---
title: "How to: Write to Binary Files in Visual Basic"
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
  - files, binary access
  - WriteAllBytes method
  - binary files, writing in Visual Basic
ms.assetid: 59fae125-de5b-4c96-883c-209f4a55112c
caps.latest.revision: 20
translation.priority.ht: 
  - de-de
  - ja-jp
---
# How to: Write to Binary Files in Visual Basic
The <xref:Microsoft.VisualBasic.FileIO.FileSystem.WriteAllBytes?qualifyHint=False> method writes data to a binary file. If the `append` parameter is `True`, it will append the data to the file; otherwise data in the file is overwritten.  
  
 If the specified path excluding the file name is not valid, a <xref:System.IO.DirectoryNotFoundException?qualifyHint=False> exception will be thrown. If the path is valid but the file does not exist, the file will be created.  
  
### To write to a binary file  
  
-   Use the `WriteAllBytes` method, supplying the file path and name and the bytes to be written. This example appends the data array `CustomerData` to the file named `CollectedData.dat`.  
  
     [!code[VbVbcnMyFileSystem#27](../vs140/codesnippet/VisualBasic/how-to--write-to-binary-files-in-visual-basic_1.vb)]
  
  
## Robust Programming  
 The following conditions may create an exception:  
  
-   The path is not valid for one of the following reasons: it is a zero-length string; it contains only white space; or it contains invalid characters. (<xref:System.ArgumentException?qualifyHint=False>).  
  
-   The path is not valid because it is `Nothing` (<xref:System.ArgumentNullException?qualifyHint=False>).  
  
-   `File` points to a path that does not exist (<xref:System.IO.FileNotFoundException?qualifyHint=False> or <xref:System.IO.DirectoryNotFoundException?qualifyHint=False>).  
  
-   The file is in use by another process, or an I/O error occurs (<xref:System.IO.IOException?qualifyHint=False>).  
  
-   The path exceeds the system-defined maximum length (<xref:System.IO.PathTooLongException?qualifyHint=False>).  
  
-   A file or directory name in the path contains a colon (:) or is in an invalid format (<xref:System.NotSupportedException?qualifyHint=False>).  
  
-   The user lacks necessary permissions to view the path (<xref:System.Security.SecurityException?qualifyHint=False>).  
  
## See Also  
 <xref:Microsoft.VisualBasic.FileIO.FileSystem.WriteAllBytes?qualifyHint=False>   
 [How to: Write Text to Files in Visual Basic](../vs140/how-to--write-text-to-files-in-visual-basic.md)