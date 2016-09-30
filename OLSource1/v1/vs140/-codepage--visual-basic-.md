---
title: "-codepage (Visual Basic)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/codepage (Visual Basic)"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "/codepage compiler option [Visual Basic]"
  - "codepage compiler option [Visual Basic]"
  - "-codepage compiler option [Visual Basic]"
ms.assetid: be36ec33-6800-4505-838c-4124564f5cc9
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -codepage (Visual Basic)
Specifies the code page to use for all source-code files in the compilation.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Arguments  
  
|||  
|-|-|  
|Term|Definition|  
|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|Required. The compiler uses the code page specified by <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> to interpret the encoding of the source files.|  
  
## Remarks  
 To compile source code saved with a specific encoding, you can use <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> to specify which code page should be used. The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> option applies to all source-code files in your compilation. For more information, see [Character Encoding in the .NET Framework](assetId:///bf6d9823-4c2d-48af-b280-919c5af66ae9).  
  
 The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> option is not needed if the source-code files were saved using the current ANSI code page, Unicode, or UTF-8 with a signature. [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] saves all source-code files with the current ANSI code page by default, unless the user specifies another encoding in the **Encoding** dialog box. [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] uses the **Encoding** dialog box to open source-code files saved with a different code page.  
  
> [!NOTE]
>  The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> option is not available from within the [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] development environment; it is available only when compiling from the command line.  
  
## See Also  
 [Visual Basic Command-Line Compiler](../vs140/visual-basic-command-line-compiler.md)