---
title: "-noconfig"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/noconfig"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "noconfig compiler option [Visual Basic]"
  - "-noconfig compiler option [Visual Basic]"
  - "/noconfig compiler option [Visual Basic]"
ms.assetid: a7405067-bd21-4171-adf4-a126fa3ad6c3
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -noconfig
Specifies that the compiler should not automatically reference the commonly used [!INCLUDE[dnprdnshort](../vs140/includes/dnprdnshort_md.md)] assemblies or import the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> namespaces.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> option tells the compiler not to compile with the Vbc.rsp file, which is located in the same directory as the Vbc.exe file. The Vbc.rsp file references the commonly used [!INCLUDE[dnprdnshort](../vs140/includes/dnprdnshort_md.md)] assemblies and imports the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> namespaces. The compiler implicitly references the System.dll assembly unless the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> option is specified. The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> option tells the compiler not to compile with Vbc.rsp or automatically reference the System.dll assembly.  
  
> [!NOTE]
>  The Mscorlib.dll and Microsoft.VisualBasic.dll assemblies are always referenced.  
  
 You can modify the Vbc.rsp file to specify additional compiler options that should be included in every Vbc.exe compilation (except when specifying the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> option). For more information, see [@ (Specify Response File)](../vs140/@--specify-response-file---visual-basic-.md).  
  
 The compiler processes the options passed to the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> command last. Therefore, any option on the command line overrides the setting of the same option in the Vbc.rsp file.  
  
> [!NOTE]
>  The <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> option is not available from within the Visual Studio development environment; it is available only when compiling from the command line.  
  
## See Also  
 [/nostdlib (Visual Basic)](../vs140/-nostdlib--visual-basic-.md)   
 [Visual Basic Command-Line Compiler](../vs140/visual-basic-command-line-compiler.md)   
 [@ (Specify Response File)](../vs140/@--specify-response-file---visual-basic-.md)   
 [/reference (Visual Basic)](../vs140/-reference--visual-basic-.md)