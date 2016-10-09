---
title: "-win32resource"
ms.custom: na
ms.date: "10/03/2016"
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
caps.latest.revision: 13
ms.author: "shoag"
manager: "wpickett"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# -win32resource
Inserts a Win32 resource file in the output file.  
  
## Syntax  
  
```  
/win32resource:filename  
```  
  
## Arguments  
 `filename`  
 The name of the resource file to add to your output file. Enclose the file name in quotation marks (" ") if it contains a space.  
  
## Remarks  
 You can create a Win32 resource file with the Microsoft Windows Resource Compiler (RC).  
  
 A Win32 resource can contain version or bitmap (icon) information that helps identify your application in **File Explorer**. If you do not specify `/win32resource`, the compiler generates version information based on the assembly version. The `/win32resource` and `/win32icon` options are mutually exclusive.  
  
 See [/linkresource (Visual Basic)](../VS_visualbasic/-linkresource--visual-basic-.md) to reference a [!INCLUDE[dnprdnshort](../VS_visualbasic/includes/dnprdnshort_md.md)] resource file, or [/resource (Visual Basic)](../VS_visualbasic/-resource--visual-basic-.md) to attach a [!INCLUDE[dnprdnshort](../VS_visualbasic/includes/dnprdnshort_md.md)] resource file.  
  
> [!NOTE]
>  The `/win32resource` option is not available from within the Visual Studio development environment; it is available only when compiling from the command line.  
  
## Example  
 The following code compiles `In.vb` and attaches a Win32 resource file, `Rf.res`:  
  
```  
vbc /win32resource:rf.res in.vb  
```  
  
## See Also  
 [Visual Basic Command-Line Compiler](../VS_visualbasic/visual-basic-command-line-compiler.md)   
 [Sample Compilation Command Lines](../VS_visualbasic/sample-compilation-command-lines--visual-basic-.md)