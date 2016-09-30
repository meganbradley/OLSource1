---
title: "How to: Write Text to Files in Visual Basic"
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
  - "files, writing to"
  - "text, writing to files"
  - "writing to files"
  - "examples [Visual Basic], text files"
ms.assetid: 304956eb-530d-4df7-b48f-9b4d1f2581a0
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Write Text to Files in Visual Basic
The \<xref:Microsoft.VisualBasic.FileIO.FileSystem.WriteAllText*> method can be used to write text to files. If the specified file does not exist, it is created.  
  
## Procedure  
  
#### To write text to a file  
  
-   Use the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> method to write text to a file, specifying the file and text to be written. This example writes the line <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> to the file named <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, appending the text to any existing text in the file.  
  
     [!code[VbFileIOWrite#3](../vs140/codesnippet/VisualBasic/how-to--write-text-to-files-in-visual-basic_1.vb)]  
  
#### To write a series of strings to a file  
  
-   Loop through the string collection. Use the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> method to write text to a file, specifying the target file and string to be added and setting <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
     This example writes the names of the files in the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> directory to <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, inserting a carriage return between each for better readability.  
  
     [!code[VbFileIOWrite#4](../vs140/codesnippet/VisualBasic/how-to--write-text-to-files-in-visual-basic_2.vb)]  
  
## Robust Programming  
 The following conditions may cause an exception:  
  
-   The path is not valid for one of the following reasons: it is a zero-length string, it contains only white space, it contains invalid characters, or it is a device path (starts with \\\\.\\) (\<xref:System.ArgumentException*>).  
  
-   The path is not valid because it is <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> (\<xref:System.ArgumentNullException*>).  
  
-   <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> points to a path that does not exist (\<xref:System.IO.FileNotFoundException*> or \<xref:System.IO.DirectoryNotFoundException*>).  
  
-   The file is in use by another process, or an I/O error occurs (\<xref:System.IO.IOException*>).  
  
-   The path exceeds the system-defined maximum length (\<xref:System.IO.PathTooLongException*>).  
  
-   A file or directory name in the path contains a colon (:) or is in an invalid format (\<xref:System.NotSupportedException*>).  
  
-   The user lacks necessary permissions to view the path (\<xref:System.Security.SecurityException*>).  
  
-   The disk is full, and the call to <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> fails (\<xref:System.IO.IOException*>).  
  
 If you are running in a partial-trust context, the code might throw an exception due to insufficient privileges. For more information, see [Code Access Security Basics](assetId:///4eaa6535-d9fe-41a1-91d8-b437cfc16921).  
  
## See Also  
 \<xref:Microsoft.VisualBasic.FileIO.FileSystem*>   
 \<xref:Microsoft.VisualBasic.FileIO.FileSystem.WriteAllText*>   
 [How to: Read From Text Files in Visual Basic](../vs140/how-to--read-from-text-files-in-visual-basic.md)