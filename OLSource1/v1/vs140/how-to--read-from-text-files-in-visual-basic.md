---
title: "How to: Read From Text Files in Visual Basic"
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
  - "extended characters, reading"
  - "reading text files"
  - "reading data, text files"
  - "examples [Visual Basic], reading text files"
  - "text files, reading"
ms.assetid: 735fe9d7-0f7a-4185-ba02-f35e580ec4b8
caps.latest.revision: 31
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Read From Text Files in Visual Basic
The [ReadAllText](assetId:///M:Microsoft.VisualBasic.MyServices.FileSystemProxy.ReadAllText(System.String)?qualifyHint=False&autoUpgrade=True) method of the `My.Computer.FileSystem` object allows you to read from a text file. The file encoding can be specified if the contents of the file use an encoding such as ASCII or UTF-8.  
  
 If you are reading from a file with extended characters, you will need to specify the file encoding.  
  
> [!NOTE]
>  To read a file a single line of text at a time, use the [OpenTextFileReader](assetId:///M:Microsoft.VisualBasic.MyServices.FileSystemProxy.OpenTextFileReader(System.String)?qualifyHint=False&autoUpgrade=True) method of the `My.Computer.FileSystem` object. The `OpenTextFileReader` method returns a <xref:System.IO.StreamReader*> object. You can use the <xref:System.IO.StreamReader.ReadLine*> method of the `StreamReader` object to read a file one line at a time. You can test for the end of the file using the <xref:System.IO.StreamReader.EndOfStream*> method of the `StreamReader` object.  
  
### To read from a text file  
  
-   Use the `ReadAllText` method of the `My.Computer.FileSystem` object to read the contents of a text file into a string, supplying the path. The following example reads the contents of test.txt into a string and then displays it in a message box.  
  
     [!code[VbFileIORead#2](../vs140/codesnippet/VisualBasic/how-to--read-from-text-files-in-visual-basic_1.vb)]  
  
### To read from a text file that is encoded  
  
-   Use the `ReadAllText` method of the `My.Computer.FileSystem` object to read the contents of a text file into a string, supplying the path and file encoding type. The following example reads the contents of the UTF32 file test.txt into a string and then displays it in a message box.  
  
     [!code[VbFileIORead#3](../vs140/codesnippet/VisualBasic/how-to--read-from-text-files-in-visual-basic_2.vb)]  
  
## Robust Programming  
 The following conditions may cause an exception:  
  
-   The path is not valid for one of the following reasons: it is a zero-length string, it contains only white space, it contains invalid characters, or it is a device path (<xref:System.ArgumentException*>).  
  
-   The path is not valid because it is `Nothing` (<xref:System.ArgumentNullException*>).  
  
-   The file does not exist (<xref:System.IO.FileNotFoundException*>).  
  
-   The file is in use by another process or an I/O error occurs (<xref:System.IO.IOException*>).  
  
-   The path exceeds the system-defined maximum length (<xref:System.IO.PathTooLongException*>).  
  
-   A file or directory name in the path contains a colon (:) or is in an invalid format (<xref:System.NotSupportedException*>).  
  
-   There is not enough memory to write the string to buffer (<xref:System.OutOfMemoryException*>).  
  
-   The user lacks necessary permissions to view the path (<xref:System.Security.SecurityException*>).  
  
 Do not make decisions about the contents of the file based on the name of the file. For example, the file Form1.vb may not be a [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] source file.  
  
 Verify all inputs before using the data in your application. The contents of the file may not be what is expected, and methods to read from the file may fail.  
  
## See Also  
 <xref:Microsoft.VisualBasic.FileIO.FileSystem*>   
 [ReadAllText](assetId:///M:Microsoft.VisualBasic.FileIO.FileSystem.ReadAllText(System.String)?qualifyHint=False&autoUpgrade=True)   
 [Reading from Files in Visual Basic](../vs140/reading-from-files-in-visual-basic.md)   
 [How to: Read From a Comma-Delimited Text File in Visual Basic](../vs140/how-to--read-from-comma-delimited-text-files-in-visual-basic.md)   
 [How to: Read From a Fixed-width Text File in Visual Basic](../vs140/how-to--read-from-fixed-width-text-files-in-visual-basic.md)   
 [How to: Read From a Text File with Multiple Formats in Visual Basic](../vs140/how-to--read-from-text-files-with-multiple-formats-in-visual-basic.md)   
 [Troubleshooting: Reading and Writing to Text Files](../vs140/troubleshooting--reading-from-and-writing-to-text-files--visual-basic-.md)   
 [Walkthrough: Manipulating Files and Directories in Visual Basic](../vs140/walkthrough--manipulating-files-and-directories-in-visual-basic.md)   
 [File Encodings](../vs140/file-encodings--visual-basic-.md)