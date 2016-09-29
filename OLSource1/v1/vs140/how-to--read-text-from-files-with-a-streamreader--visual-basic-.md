---
title: "How to: Read Text from Files with a StreamReader (Visual Basic)"
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
  - "reading files, text"
  - "text, reading from files"
  - "reading text from files"
  - "files, reading"
ms.assetid: 384033c6-18f9-4d59-9610-36371226558f
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Read Text from Files with a StreamReader (Visual Basic)
The `My.Computer.FileSystem` object provides methods to open a <xref:System.IO.TextReader*> and a <xref:System.IO.TextWriter*>. These methods, `OpenTextFileWriter` and `OpenTextFileReader`, are advanced methods that do not appear in IntelliSense unless you select the **All** tab.  
  
### To read a line from a file with a text reader  
  
-   Use the `OpenTextFileReader` method to open the <xref:System.IO.TextReader*>, specifying the file. This example opens the file named `testfile.txt`, reads a line from it, and displays the line in a message box.  
  
     [!code[VbFileIORead#1](../vs140/codesnippet/VisualBasic/how-to--read-text-from-files-with-a-streamreader--visual-basic-_1.vb)]  
  
## Robust Programming  
 The file that is read must be a text file.  
  
 Do not make decisions about the contents of the file based on the name of the file. For example, the file Form1.vb may not be a Visual Basic source file.  
  
 Verify all inputs before using the data in your application. The contents of the file may not be what is expected, and methods to read from the file may fail.  
  
## .NET Framework Security  
 To read from a file, your assembly requires a privilege level granted by the <xref:System.Security.Permissions.FileIOPermission*> class. If you are running in a partial-trust context, the code might throw an exception due to insufficient privileges. For more information, see [Code Access Security Basics](assetId:///4eaa6535-d9fe-41a1-91d8-b437cfc16921). The user also needs access to the file. For more information, see [ACL Technology Overview](assetId:///06fbf66d-6f02-4378-b863-b2f12e349045).  
  
## See Also  
 <xref:Microsoft.VisualBasic.FileIO.FileSystem*>   
 <xref:System.Windows.Forms.OpenFileDialog*>   
 <xref:Microsoft.VisualBasic.FileIO.FileSystem.OpenTextFileWriter*>   
 <xref:Microsoft.VisualBasic.FileIO.FileSystem.OpenTextFileReader*>   
 [SaveFileDialog Component (Windows Forms)](assetId:///6f5d9321-37d7-4448-ac4c-a33c42b2a766)   
 [Reading from Files in Visual Basic](../vs140/reading-from-files-in-visual-basic.md)