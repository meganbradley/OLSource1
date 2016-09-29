---
title: "How to: Read From a Text File (C# Programming Guide)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "StreamReader.ReadToEnd"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "text files, writing to"
  - "reading text files"
  - "reading data, text files"
  - "text files, reading"
ms.assetid: 92246c5b-e819-4eea-9370-1a9460e12de3
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Read From a Text File (C# Programming Guide)
This example reads the contents of a text file by using the static methods <xref:System.IO.File.ReadAllText*> and <xref:System.IO.File.ReadAllLines*> from the <xref:System.IO.File*?displayProperty=fullName> class.  
  
 For an example that uses <xref:System.IO.StreamReader*>, see [How to: Read a Text File One Line at a Time (Visual C#)](../vs140/how-to--read-a-text-file-one-line-at-a-time--visual-csharp-.md).  
  
> [!NOTE]
>  The files that are used in this example are created in the topic [How to: Write to a Text File (C# Programming Guide)](../vs140/how-to--write-to-a-text-file--csharp-programming-guide-.md).  
  
## Example  
 [!code[csFilesandFolders#4](../vs140/codesnippet/CSharp/how-to--read-from-a-text-file--csharp-programming-guide-_1.cs)]  
  
## Compiling the Code  
 Copy the code and paste it into a C# console application.  
  
 If you are not using the text files from [How to: Write to a Text File (C# Programming Guide)](../vs140/how-to--write-to-a-text-file--csharp-programming-guide-.md), replace the argument to `ReadAllText` and `ReadAllLines` with the appropriate path and file name on your computer.  
  
## Robust Programming  
 The following conditions may cause an exception:  
  
-   The file doesn't exist or doesn't exist at the specified location. Check the path and the spelling of the file name.  
  
## .NET Framework Security  
 Do not rely on the name of a file to determine the contents of the file. For example, the file `myFile.cs` might not be a C# source file.  
  
## See Also  
 <xref:System.IO*?displayProperty=fullName>   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [Files, Folders and Drives](../vs140/file-system-and-the-registry--csharp-programming-guide-.md)