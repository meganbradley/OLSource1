---
title: "-filealign"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/filealign"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "sections compiler option [Visual Basic]"
  - "alignment compiler option [Visual Basic]"
  - "-filealign compiler option [Visual Basic]"
  - "section alignment"
  - "/filealign compiler option [Visual Basic]"
  - "filealign compiler option [Visual Basic]"
ms.assetid: cc61ec3d-ad38-4b28-9659-099d73cad099
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -filealign
Specifies where to align the sections of the output file.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Arguments  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Required. A value that specifies the alignment of sections in the output file. Valid values are 512, 1024, 2048, 4096, and 8192. These values are in bytes.  
  
## Remarks  
 You can use the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> option to specify the alignment of sections in your output file. Sections are blocks of contiguous memory in a Portable Executable (PE) file that contains either code or data. The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> option lets you compile your application with a nonstandard alignment; most developers do not need to use this option.  
  
 Each section is aligned on a boundary that is a multiple of the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> value. There is no fixed default. If <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is not specified, the compiler picks a default at compile time.  
  
 By specifying the section size, you can change the size of the output file. Modifying section size may be useful for programs that will run on smaller devices.  
  
> [!NOTE]
>  The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> option is not available from within the Visual Studio development environment; it is available only when compiling from the command line.  
  
## See Also  
 [Visual Basic Command-Line Compiler](../vs140/visual-basic-command-line-compiler.md)