---
title: "@ (Specify a Compiler Response File)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "@"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "response files, C/C++ compiler"
  - "@ compiler option"
  - "cl.exe compiler, specifying response files"
ms.assetid: 400fffee-909d-4f60-bf76-45833e822685
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# @ (Specify a Compiler Response File)
Specifies a compiler response file.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Arguments  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A text file containing compiler commands.  
  
## Remarks  
 A response file can contain any commands that you would specify on the command line. This can be useful if your command-line arguments exceed 127 characters.  
  
 It is not possible to specify the **@** option from within a response file. That is, a response file cannot embed another response file.  
  
 From the command line you can specify as many response file options (for example, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>) as you want.  
  
### To set this compiler option in the Visual Studio development environment  
  
-   A response file cannot be specified from within the development environment and must be specified at the command line.  
  
### To set this compiler option programmatically  
  
-   This compiler option cannot be changed programmatically.  
  
## See Also  
 [Compiler Options](../vs140/compiler-options.md)   
 [Setting Compiler Options](../vs140/setting-compiler-options.md)