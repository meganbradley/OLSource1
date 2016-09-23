---
title: "How to: Parse File Paths in Visual Basic"
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
  - file names, parsing [Visual Basic]
  - parsing, file paths [Visual Basic]
ms.assetid: c1bd99c9-8160-456a-b5ab-60a49139b923
caps.latest.revision: 22
translation.priority.ht: 
  - de-de
  - ja-jp
---
# How to: Parse File Paths in Visual Basic
The <xref:Microsoft.VisualBasic.FileIO.FileSystem?qualifyHint=False> object offers a number of useful methods when parsing file paths.  
  
-   The <xref:Microsoft.VisualBasic.FileIO.FileSystem.CombinePath?qualifyHint=False> method takes two paths and returns a properly formatted combined path.  
  
-   The <xref:Microsoft.VisualBasic.FileIO.FileSystem.GetParentPath?qualifyHint=False> method returns the absolute path of the parent of the provided path.  
  
-   The <xref:Microsoft.VisualBasic.FileIO.FileSystem.GetFileInfo?qualifyHint=False> method returns a <xref:System.IO.FileInfo?qualifyHint=False> object that can be queried to determine the file's properties, such as its name and path.  
  
 Do not make decisions about the contents of the file based on the file name extension. For example, the file Form1.vb may not be a Visual Basic source file.  
  
### To determine a file's name and path  
  
-   Use the <xref:System.IO.FileInfo.DirectoryName?qualifyHint=False> and <xref:System.IO.FileInfo.Name?qualifyHint=False> properties of the <xref:System.IO.FileInfo?qualifyHint=False> object to determine a file's name and path. This example determines the name and path and displays them.  
  
     [!code[VbVbcnMyFileSystem#54](../vs140/codesnippet/VisualBasic/how-to--parse-file-paths-in-visual-basic_1.vb)]
  
  
### To combine a file's name and directory to create the full path  
  
-   Use the `CombinePath` method, supplying the directory and name. This example takes the strings `folderPath` and `fileName` created in the previous example, combines them, and displays the result.  
  
     [!code[VbVbcnMyFileSystem#55](../vs140/codesnippet/VisualBasic/how-to--parse-file-paths-in-visual-basic_2.vb)]
  
  
## See Also  
 <xref:Microsoft.VisualBasic.FileIO.FileSystem?qualifyHint=False>   
 <xref:Microsoft.VisualBasic.FileIO.FileSystem.CombinePath?qualifyHint=False>   
 <xref:System.IO.FileInfo?qualifyHint=False>   
 <xref:Microsoft.VisualBasic.FileIO.FileSystem.GetFileInfo?qualifyHint=False>   
 [How to: Get the Collection of Files in a Directory in Visual Basic](../vs140/how-to--get-the-collection-of-files-in-a-directory-in-visual-basic.md)