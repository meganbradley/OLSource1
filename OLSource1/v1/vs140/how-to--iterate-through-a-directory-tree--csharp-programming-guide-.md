---
title: "How to: Iterate Through a Directory Tree (C# Programming Guide)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "iterating through folders [C#]"
  - "file iteration [C#]"
ms.assetid: c4be4a75-6b1b-46a7-9d38-bab353091ed7
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Iterate Through a Directory Tree (C# Programming Guide)
The phrase "iterate a directory tree" means to access each file in each nested subdirectory under a specified root folder, to any depth. You do not necessarily have to open each file. You can just retrieve the name of the file or subdirectory as a `string`, or you can retrieve additional information in the form of a \<xref:System.IO.FileInfo*?displayProperty=fullName> or \<xref:System.IO.DirectoryInfo*?displayProperty=fullName> object.  
  
> [!NOTE]
>  In Windows, the terms "directory" and "folder" are used interchangeably. Most documentation and user interface text uses the term "folder," but the [!INCLUDE[dnprdnshort](../vs140/includes/dnprdnshort_md.md)] class library uses the term "directory."  
  
 In the simplest case, in which you know for certain that you have access permissions for all directories under a specified root, you can use the `System.IO.SearchOption.AllDirectories` flag. This flag returns all the nested subdirectories that match the specified pattern. The following example shows how to use this flag.  
  
```c#  
root.GetDirectories("*.*", System.IO.SearchOption.AllDirectories);  
```  
  
 The weakness in this approach is that if any one of the subdirectories under the specified root causes a \<xref:System.IO.DirectoryNotFoundException*> or \<xref:System.UnauthorizedAccessException*>, the whole method fails and returns no directories. The same is true when you use the \<xref:System.IO.DirectoryInfo.GetFiles*> method. If you have to handle these exceptions on specific subfolders, you must manually walk the directory tree, as shown in the following examples.  
  
 When you manually walk a directory tree, you can handle the subdirectories first (*pre-order traversal*), or the files first (*post-order traversal*). If you perform a pre-order traversal, you walk the whole tree under the current folder before iterating through the files that are directly in that folder itself. The examples later in this document perform post-order traversal, but you can easily modify them to perform pre-order traversal.  
  
 Another option is whether to use recursion or a stack-based traversal. The examples later in this document show both approaches.  
  
 If you have to perform a variety of operations on files and folders, you can modularize these examples by refactoring the operation into separate functions that you can invoke by using a single delegate.  
  
> [!NOTE]
>  NTFS file systems can contain *reparse points* in the form of *junction points*, *symbolic links*, and *hard links*. The .NET Framework methods such as \<xref:System.IO.DirectoryInfo.GetFiles*> and \<xref:System.IO.DirectoryInfo.GetDirectories*> will not return any subdirectories under a reparse point. This behavior guards against the risk of entering into an infinite loop when two reparse points refer to each other. In general, you should use extreme caution when you deal with reparse points to ensure that you do not unintentionally modify or delete files. If you require precise control over reparse points, use platform invoke or native code to call the appropriate Win32 file system methods directly.  
  
## Example  
 The following example shows how to walk a directory tree by using recursion. The recursive approach is elegant but has the potential to cause a stack overflow exception if the directory tree is large and deeply nested.  
  
 The particular exceptions that are handled, and the particular actions that are performed on each file or folder, are provided as examples only. You should modify this code to meet your specific requirements. See the comments in the code for more information.  
  
 [!code[csFilesandFolders#1](../vs140/codesnippet/CSharp/how-to--iterate-through-a-directory-tree--csharp-programming-guide-_1.cs)]  
  
## Example  
 The following example shows how to iterate through files and folders in a directory tree without using recursion. This technique uses the generic <xref:System.Collections.Generic.Stack`1*> collection type, which is a last in first out (LIFO) stack.  
  
 The particular exceptions that are handled, and the particular actions that are performed on each file or folder, are provided as examples only. You should modify this code to meet your specific requirements. See the comments in the code for more information.  
  
 [!code[csFilesandFolders#2](../vs140/codesnippet/CSharp/how-to--iterate-through-a-directory-tree--csharp-programming-guide-_2.cs)]  
  
 It is generally too time-consuming to test every folder to determine whether your application has permission to open it. Therefore, the code example just encloses that part of the operation in a `try/catch` block. You can modify the `catch` block so that when you are denied access to a folder, you try to elevate your permissions and then access it again. As a rule, only catch those exceptions that you can handle without leaving your application in an unknown state.  
  
 If you must store the contents of a directory tree, either in memory or on disk, the best option is to store only the <xref:System.IO.FileSystemInfo.FullName*> property (of type `string`) for each file. You can then use this string to create a new \<xref:System.IO.FileInfo*> or \<xref:System.IO.DirectoryInfo*> object as necessary, or open any file that requires additional processing.  
  
## Robust Programming  
 Robust file iteration code must take into account many complexities of the file system. For more information, see [NTFS Technical Reference](http://go.microsoft.com/fwlink/?LinkId=79488).  
  
## See Also  
 \<xref:System.IO*>   
 [LINQ and File Directories](../vs140/linq-and-file-directories.md)   
 [Files, Folders and Drives (Visual C#)](../vs140/file-system-and-the-registry--csharp-programming-guide-.md)