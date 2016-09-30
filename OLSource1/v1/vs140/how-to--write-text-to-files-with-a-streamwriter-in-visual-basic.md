---
title: "How to: Write Text to Files with a StreamWriter in Visual Basic"
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
  - "writing to files, StreamWriter"
ms.assetid: 99762e57-ef46-4dcc-8959-a8f79c22f067
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Write Text to Files with a StreamWriter in Visual Basic
This example opens a \<xref:System.IO.StreamWriter*> object with the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> method and uses it to write a string to a text file with the \<xref:System.IO.TextWriter.WriteLine*> method of the \<xref:System.IO.StreamWriter*> class.  
  
## Example  
 [!code[VbFileIOWrite#5](../vs140/codesnippet/VisualBasic/how-to--write-text-to-files-with-a-streamwriter-in-visual-basic_1.vb)]  
  
## Robust Programming  
 The following conditions may cause an exception:  
  
-   The file exists and is read-only (\<xref:System.IO.IOException*>).  
  
-   The disk is full (\<xref:System.IO.IOException*>).  
  
-   The pathname is too long (\<xref:System.IO.PathTooLongException*>).  
  
## .NET Framework Security  
 This example creates a new file, if the file does not already exist. If an application needs to create a file, that application needs <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> access for the folder. If the file already exists, the application needs only <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> access, a lesser privilege. Where possible, it is more secure to create the file during deployment, and only grant <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> access to a single file, rather than <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> access for a folder.  
  
## See Also  
 \<xref:System.IO.StreamWriter*>   
 \<xref:Microsoft.VisualBasic.FileIO.FileSystem.OpenTextFileWriter*>   
 [How to: Read from Text Files](../vs140/how-to--read-from-text-files-in-visual-basic.md)   
 [Writing to Files in Visual Basic](../vs140/writing-to-files-in-visual-basic.md)