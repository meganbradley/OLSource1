---
title: "How to: Write Text to Files in the My Documents Directory in Visual Basic"
ms.custom: na
ms.date: "09/21/2016"
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
  - "examples [Visual Basic], text files"
  - "writing to files, in My Documents"
ms.assetid: 1c726124-781d-4976-9baa-ed46814ff3fe
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Write Text to Files in the My Documents Directory in Visual Basic
The `My.Computer.FileSystem.SpecialDirectories` object allows you to access special directories, such as the **MyDocuments** directory.  
  
## Procedure  
  
#### To write new text files in the My Documents directory  
  
1.  Use the `My.Computer.FileSystem.SpecialDirectories.MyDocuments` property to supply the path.  
  
     [!code[VbFileIOWrite#1](../vs140/codesnippet/VisualBasic/how-to--write-text-to-files-in-the-my-documents-directory-in-visual-basic_1.vb)]  
  
2.  Use the `WriteAllText` method to write text to the specified file.  
  
     [!code[VbVbcnMyFileSystem#14](../vs140/codesnippet/VisualBasic/how-to--write-text-to-files-in-the-my-documents-directory-in-visual-basic_2.vb)]  
  
## Example  
 [!code[VbFileIOWrite#2](../vs140/codesnippet/VisualBasic/how-to--write-text-to-files-in-the-my-documents-directory-in-visual-basic_3.vb)]  
  
## Compiling the Code  
 Replace `test.txt` with the name of the file you want to write to.  
  
## Robust Programming  
 This code rethrows all the exceptions that may occur when writing text to the file. You can reduce the likelihood of exceptions by using Windows Forms controls such as the [OpenFileDialog](assetId:///d2efa832-a272-42ff-aa26-c4ac13ff59ba) and the [SaveFileDialog](assetId:///6f5d9321-37d7-4448-ac4c-a33c42b2a766) components that limit the user choices to valid file names. Using these controls is not foolproof, however. The file system can change between the time the user selects a file and the time that the code executes. Exception handling is therefore nearly always necessary when with working with files.  
  
## .NET Framework Security  
 If you are running in a partial-trust context, the code might throw an exception due to insufficient privileges. For more information, see [Code Access Security Basics](assetId:///4eaa6535-d9fe-41a1-91d8-b437cfc16921).  
  
 This example creates a new file. If an application needs to create a file, that application needs Create permission for the folder. Permissions are set using access control lists. If the file already exists, the application needs only Write permission, a lesser privilege. Where possible, it is more secure to create the file during deployment, and only grant Read privileges to a single file, rather than to grant Create privileges for a folder. Also, it is more secure to write data to user folders than to the root folder or the **Program Files** folder. For more information, see [ACL Technology Overview](assetId:///06fbf66d-6f02-4378-b863-b2f12e349045).  
  
## See Also  
 \<xref:System.IO.Path.Combine*?displayProperty=fullName>   
 \<xref:Microsoft.VisualBasic.Devices.Computer*>   
 \<xref:Microsoft.VisualBasic.FileIO.FileSystem*>   
 \<xref:Microsoft.VisualBasic.FileIO.FileSystem.WriteAllText*>   
 \<xref:Microsoft.VisualBasic.FileIO.SpecialDirectories*>