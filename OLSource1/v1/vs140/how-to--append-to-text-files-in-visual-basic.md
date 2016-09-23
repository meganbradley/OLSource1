---
title: "How to: Append to Text Files in Visual Basic"
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
  - I/O [Visual Basic], appending to files
  - I/O [Visual Basic], My.Computer.FileSystem.WriteAllText method
  - I/O [Visual Basic], WriteAllText method
ms.assetid: bbbd7fb5-f169-41a9-b53f-520ea9613913
caps.latest.revision: 17
translation.priority.ht: 
  - de-de
  - ja-jp
---
# How to: Append to Text Files in Visual Basic
The <xref:Microsoft.VisualBasic.FileIO.FileSystem.WriteAllText?qualifyHint=False> method can be used to append to a text file by specifying that the `append` parameter is set to `True`.  
  
### To append to a text file  
  
-   Use the `WriteAllText` method, specifying the target file and string to be appended and setting the `append` parameter to `True`.  
  
     This example writes the string `"This is a test string."` to the file named `Testfile.txt`.  
  
     [!code[VbFileIOWrite#6](../vs140/codesnippet/VisualBasic/how-to--append-to-text-files-in-visual-basic_1.vb)]
  
  
## Robust Programming  
 The following conditions may cause an exception:  
  
-   The path is not valid for one of the following reasons: it is a zero-length string, it contains only white space, it contains invalid characters, or it is a device path (starts with \\\\.\\) (<xref:System.ArgumentException?qualifyHint=False>).  
  
-   The path is not valid because it is `Nothing` (<xref:System.ArgumentNullException?qualifyHint=False>).  
  
-   `File` points to a path that does not exist (<xref:System.IO.FileNotFoundException?qualifyHint=False> or <xref:System.IO.DirectoryNotFoundException?qualifyHint=False>).  
  
-   The file is in use by another process, or an I/O error occurs (<xref:System.IO.IOException?qualifyHint=False>).  
  
-   The path exceeds the system-defined maximum length (<xref:System.IO.PathTooLongException?qualifyHint=False>).  
  
-   A file or directory name in the path contains a colon (:) or is in an invalid format (<xref:System.NotSupportedException?qualifyHint=False>).  
  
-   The user lacks necessary permissions to view the path (<xref:System.Security.SecurityException?qualifyHint=False>).  
  
## See Also  
 <xref:Microsoft.VisualBasic.FileIO.FileSystem.WriteAllText?qualifyHint=False>   
 <xref:Microsoft.VisualBasic.FileIO.FileSystem?qualifyHint=False>   
 [Writing to Files in Visual Basic](../vs140/writing-to-files-in-visual-basic.md)