---
title: "How to: Create a File or Folder (C# Programming Guide)"
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
  - "folders [C#]"
  - "creating files [C#]"
  - "files [C#]"
  - "creating folders [C#]"
ms.assetid: 4582ee2d-d72d-4687-bcb9-08d336c62c25
caps.latest.revision: 26
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Create a File or Folder (C# Programming Guide)
You can programmatically create a folder on your computer, create a subfolder, create a file in the subfolder, and write data to the file.  
  
## Example  
 [!code[csFilesandFolders#10](../vs140/codesnippet/CSharp/how-to--create-a-file-or-folder--csharp-programming-guide-_1.cs)]  
  
 If the folder already exists, \<xref:System.IO.Directory.CreateDirectory*> does nothing, and no exception is thrown. However, \<xref:System.IO.File.Create*?displayProperty=fullName> replaces an existing file with a new file. The example uses an <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>-<CodeContentPlaceHolder>3\</CodeContentPlaceHolder> statement to prevent an existing file from being replaced.  
  
 By making the following changes in the example, you can specify different outcomes based on whether a file with a certain name already exists. If such a file doesn't exist, the code creates one. If such a file exists, the code appends data to that file.  
  
-   Specify a non-random file name.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
-   Replace the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>-<CodeContentPlaceHolder>5\</CodeContentPlaceHolder> statement with the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> statement in the following code.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Run the example several times to verify that data is added to the file each time.  
  
 For more <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> values that you can try, see \<xref:System.IO.FileMode*>.  
  
 The following conditions may cause an exception:  
  
-   The folder name is malformed. For example, it contains illegal characters or is only white space (\<xref:System.ArgumentException*> class). Use the \<xref:System.IO.Path*> class to create valid path names.  
  
-   The parent folder of the folder to be created is read-only (\<xref:System.IO.IOException*> class).  
  
-   The folder name is <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> (\<xref:System.ArgumentNullException*> class).  
  
-   The folder name is too long (\<xref:System.IO.PathTooLongException*> class).  
  
-   The folder name is only a colon, ":" (\<xref:System.IO.PathTooLongException*> class).  
  
## .NET Framework Security  
 An instance of the \<xref:System.Security.SecurityException*> class may be thrown in partial-trust situations.  
  
 If you don’t have permission to create the folder, the example throws an instance of the \<xref:System.UnauthorizedAccessException*> class.  
  
## See Also  
 \<xref:System.IO*?displayProperty=fullName>   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [Files, Folders and Drives](../vs140/file-system-and-the-registry--csharp-programming-guide-.md)