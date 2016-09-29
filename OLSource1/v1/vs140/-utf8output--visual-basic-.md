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
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -utf8output (Visual Basic)
Displays compiler output using UTF-8 encoding.  
  
## Syntax  
  
```  
/utf8output[+ | -]  
```  
  
## Arguments  
 `+` &#124; `-`  
 Optional. The default for this option is `/utf8output-`, which means compiler output does not use UTF-8 encoding. Specifying `/utf8output` is the same as specifying `/utf8output+`.  
  
## Remarks  
 In some international configurations, compiler output cannot be displayed correctly in the console. In such situations, use `/utf8output` and redirect compiler output to a file.  
  
> [!NOTE]
>  The `/utf8output` option is not available from within the Visual Studio development environment; it is available only when compiling from the command line.  
  
## Example  
 The following code compiles `In.vb` and directs the compiler to display output using UTF-8 encoding.  
  
```  
vbc /utf8output in.vb  
```  
  
## See Also  
 [Visual Basic Command-Line Compiler](../vs140/visual-basic-command-line-compiler.md)   
 [Sample Compilation Command Lines](../vs140/sample-compilation-command-lines--visual-basic-.md)