---
title: "How to: Copy, Delete, and Move Files and Folders (C# Programming Guide)"
ms.custom: na
ms.date: "10/03/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "How to: Copy, Delete, and Move Files and Folders (C# Programming Guide)"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "I/O [C#]"
ms.assetid: 62e52cd7-9597-4e4a-acf9-1315f5cdbf05
caps.latest.revision: 13
ms.author: "shoag"
manager: "wpickett"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# How to: Copy, Delete, and Move Files and Folders (C# Programming Guide)
The following examples show how to copy, move, and delete files and folders in a synchronous manner by using the \<xref:System.IO.File?displayProperty=fullName>, \<xref:System.IO.Directory?displayProperty=fullName>, \<xref:System.IO.FileInfo?displayProperty=fullName>, and \<xref:System.IO.DirectoryInfo?displayProperty=fullName> classes from the \<xref:System.IO?displayProperty=fullName> namespace. These examples do not provide a progress bar or any other user interface. If you want to provide a standard progress dialog box, see [How to: Provide a Progress Dialog Box for File Operations](../VS_csharp/how-to--provide-a-progress-dialog-box-for-file-operations--csharp-programming-guide-.md).  
  
 Use \<xref:System.IO.FileSystemWatcher?displayProperty=fullName> to provide events that will enable you to calculate the progress when operating on multiple files. Another approach is to use platform invoke to call the relevant file-related methods in the Windows Shell. For information about how to perform these file operations asynchronously, see [Asynchronous File I/O](../Topic/Asynchronous%20File%20I-O.md).  
  
## Example  
 The following example shows how to copy files and directories.  
  
 [!code[csFilesandFolders#7](../VS_csharp/codesnippet/CSharp/how-to--copy--delete--and-move-files-and-folders--csharp-programming-guide-_1.cs)]  
  
## Example  
 The following example shows how to move files and directories.  
  
 [!code[csFilesandFolders#8](../VS_csharp/codesnippet/CSharp/how-to--copy--delete--and-move-files-and-folders--csharp-programming-guide-_2.cs)]  
  
## Example  
 The following example shows how to delete files and directories.  
  
 [!code[csFilesandFolders#9](../VS_csharp/codesnippet/CSharp/how-to--copy--delete--and-move-files-and-folders--csharp-programming-guide-_3.cs)]  
  
## See Also  
 \<xref:System.IO?displayProperty=fullName>   
 [C# Programming Guide](../VS_csharp/csharp-programming-guide.md)   
 [File System and the Registry (C# Programming Guide)](../VS_csharp/file-system-and-the-registry--csharp-programming-guide-.md)   
 [How to: Provide a Progress Dialog Box for File Operations](../VS_csharp/how-to--provide-a-progress-dialog-box-for-file-operations--csharp-programming-guide-.md)   
 [File and Stream I-O](../Topic/File%20and%20Stream%20I-O.md)   
 [Common I/O Tasks](../Topic/Common%20I-O%20Tasks.md)