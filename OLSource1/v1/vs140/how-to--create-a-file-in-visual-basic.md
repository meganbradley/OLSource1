---
title: "How to: Create a File in Visual Basic"
ms.custom: na
ms.date: 09/21/2016
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
  - text files, creating
  - files, creating
ms.assetid: 0253bb6d-5519-4a50-b882-b93ef5cca0d9
caps.latest.revision: 19
translation.priority.ht: 
  - de-de
  - ja-jp
---
# How to: Create a File in Visual Basic
This example creates an empty text file at the specified path using the <xref:System.IO.File.Create?qualifyHint=False> method in the <xref:System.IO.File?qualifyHint=False> class.  
  
## Example  
 [!code[VbFileIOMisc#1](../vs140/codesnippet/VisualBasic/how-to--create-a-file-in-visual-basic_1.vb)]
  
  
## Compiling the Code  
 Use the `file` variable to write to the file.  
  
## Robust Programming  
 If the file already exists, it is replaced.  
  
 The following conditions may cause an exception:  
  
-   The path name is malformed. For example, it contains illegal characters or is only white space (<xref:System.ArgumentException?qualifyHint=False>).  
  
-   The path is read-only (<xref:System.IO.IOException?qualifyHint=False>).  
  
-   The path name is `Nothing` (<xref:System.ArgumentNullException?qualifyHint=False>).  
  
-   The path name is too long (<xref:System.IO.PathTooLongException?qualifyHint=False>).  
  
-   The path is invalid (<xref:System.IO.DirectoryNotFoundException?qualifyHint=False>).  
  
-   The path is only a colon ":" (<xref:System.NotSupportedException?qualifyHint=False>).  
  
## .NET Framework Security  
 A <xref:System.Security.SecurityException?qualifyHint=False> may be thrown in partial-trust environments.  
  
 The call to the <xref:System.IO.File.Create?qualifyHint=False> method requires <xref:System.Security.Permissions.FileIOPermission?qualifyHint=False>.  
  
 An <xref:System.UnauthorizedAccessException?qualifyHint=False> is thrown if the user does not have permission to create the file.  
  
## See Also  
 <xref:System.IO?qualifyHint=False>   
 <xref:System.IO.File.Create?qualifyHint=False>   
 [Using Libraries from Partially Trusted Code](assetId:///dd66cd4c-b087-415f-9c3e-94e3a1835f74)   
 [Code Access Security Basics](assetId:///4eaa6535-d9fe-41a1-91d8-b437cfc16921)