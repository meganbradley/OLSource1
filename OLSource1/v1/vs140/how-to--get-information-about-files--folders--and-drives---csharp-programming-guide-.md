---
title: "How to: Get Information About Files, Folders, and Drives  (C# Programming Guide)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
dev_langs: 
  - CSharp
helpviewer_keywords: 
  - files [C#], getting information about
ms.assetid: 22fc2da6-5494-405b-995e-c0b99142a93e
caps.latest.revision: 34
translation.priority.ht: 
  - de-de
  - ja-jp
---
# How to: Get Information About Files, Folders, and Drives  (C# Programming Guide)
In the .NET Framework, you can access file system information by using the following classes:  
  
-   <xref:System.IO.FileInfo?qualifyHint=True>  
  
-   <xref:System.IO.DirectoryInfo?qualifyHint=True>  
  
-   <xref:System.IO.DriveInfo?qualifyHint=True>  
  
-   <xref:System.IO.Directory?qualifyHint=True>  
  
-   <xref:System.IO.File?qualifyHint=True>  
  
 The <xref:System.IO.FileInfo?qualifyHint=False> and <xref:System.IO.DirectoryInfo?qualifyHint=False> classes represent a file or directory and contain properties that expose many of the file attributes that are supported by the NTFS file system. They also contain methods for opening, closing, moving, and deleting files and folders. You can create instances of these classes by passing a string that represents the name of the file, folder, or drive in to the constructor:  
  
```c#  
System.IO.DriveInfo di = new System.IO.DriveInfo(@"C:\");  
```  
  
 You can also obtain the names of files, folders, or drives by using calls to <xref:System.IO.DirectoryInfo.GetDirectories?qualifyHint=True>, <xref:System.IO.DirectoryInfo.GetFiles?qualifyHint=True>, and <xref:System.IO.DriveInfo.RootDirectory?qualifyHint=True>.  
  
 The <xref:System.IO.Directory?qualifyHint=True> and <xref:System.IO.File?qualifyHint=True> classes provide static methods for retrieving information about directories and files.  
  
## Example  
 The following example shows various ways to access information about files and folders.  
  
 [!code[csFilesandFolders#6](../vs140/codesnippet/CSharp/how-to--get-information-about-files--folders--and-drives---csharp-programming-guide-_1.cs)]
  
  
## Robust Programming  
 When you process user-specified path strings, you should also handle exceptions for the following conditions:  
  
-   The file name is malformed. For example, it contains invalid characters or only white space.  
  
-   The file name is null.  
  
-   The file name is longer than the system-defined maximum length.  
  
-   The file name contains a colon (:).  
  
 If the application does not have sufficient permissions to read the specified file, the `Exists` method returns `false` regardless of whether a path exists; the method does not throw an exception.  
  
## See Also  
 <xref:System.IO?qualifyHint=True>   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [File System and the Registry](../vs140/file-system-and-the-registry--csharp-programming-guide-.md)