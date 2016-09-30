---
title: "-utf8output (Visual Basic)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/utf8output (Visual Basic)"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "-utf8output compiler option [Visual Basic]"
  - "utf8output compiler option [Visual Basic]"
  - "/utf8output compiler option [Visual Basic]"
ms.assetid: 8ab36b1e-027a-49ac-85b4-f48997d9e4d6
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -utf8output (Visual Basic)
Displays compiler output using UTF-8 encoding.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Arguments  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> &#124; <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Optional. The default for this option is <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, which means compiler output does not use UTF-8 encoding. Specifying <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is the same as specifying <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
## Remarks  
 In some international configurations, compiler output cannot be displayed correctly in the console. In such situations, use <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> and redirect compiler output to a file.  
  
> [!NOTE]
>  The <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> option is not available from within the Visual Studio development environment; it is available only when compiling from the command line.  
  
## Example  
 The following code compiles <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> and directs the compiler to display output using UTF-8 encoding.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Visual Basic Command-Line Compiler](../vs140/visual-basic-command-line-compiler.md)   
 [Sample Compilation Command Lines](../vs140/sample-compilation-command-lines--visual-basic-.md)