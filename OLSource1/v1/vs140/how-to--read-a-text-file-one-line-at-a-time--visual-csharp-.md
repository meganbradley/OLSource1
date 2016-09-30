---
title: "How to: Read a Text File One Line at a Time (Visual C#)"
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
  - "ReadLine method [C#]"
  - "reading text files, line by line"
  - "text files [C#]"
ms.assetid: d62e22c5-a13c-48db-af9b-f10c801b0cb1
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Read a Text File One Line at a Time (Visual C#)
This example reads the contents of a text file, one line at a time, into a string using the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> method of the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> class. Each text line is stored into the string <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> and displayed on the screen.  
  
## Example  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Compiling the Code  
 Copy the code and paste it into the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> method of a console application.  
  
 Replace <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> with the actual file name.  
  
## Robust Programming  
 The following conditions may cause an exception:  
  
-   The file may not exist.  
  
## .NET Framework Security  
 Do not make decisions about the contents of the file based on the name of the file. For example, the file <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> may not be a C# source file.  
  
## See Also  
 \<xref:System.IO*?displayProperty=fullName>   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [Files, Folders and Drives](../vs140/file-system-and-the-registry--csharp-programming-guide-.md)