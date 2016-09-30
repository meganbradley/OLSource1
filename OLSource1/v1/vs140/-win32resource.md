---
title: "-win32resource"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/win32resource"
f1_keywords: 
  - "/win32resource"
  - "win32resource"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "/win32resource compiler option [Visual Basic]"
  - "-win32resource compiler option [Visual Basic]"
  - "win32resource compiler option [Visual Basic]"
ms.assetid: e226946d-19ce-4cc9-91f5-aed24f77aa2b
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -win32resource
Inserts a Win32 resource file in the output file.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Arguments  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The name of the resource file to add to your output file. Enclose the file name in quotation marks (" ") if it contains a space.  
  
## Remarks  
 You can create a Win32 resource file with the Microsoft Windows Resource Compiler (RC).  
  
 A Win32 resource can contain version or bitmap (icon) information that helps identify your application in **File Explorer**. If you do not specify <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, the compiler generates version information based on the assembly version. The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> options are mutually exclusive.  
  
 See [/linkresource (Visual Basic)](../vs140/-linkresource--visual-basic-.md) to reference a [!INCLUDE[dnprdnshort](../vs140/includes/dnprdnshort_md.md)] resource file, or [/resource (Visual Basic)](../vs140/-resource--visual-basic-.md) to attach a [!INCLUDE[dnprdnshort](../vs140/includes/dnprdnshort_md.md)] resource file.  
  
> [!NOTE]
>  The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> option is not available from within the Visual Studio development environment; it is available only when compiling from the command line.  
  
## Example  
 The following code compiles <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> and attaches a Win32 resource file, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Visual Basic Command-Line Compiler](../vs140/visual-basic-command-line-compiler.md)   
 [Sample Compilation Command Lines](../vs140/sample-compilation-command-lines--visual-basic-.md)