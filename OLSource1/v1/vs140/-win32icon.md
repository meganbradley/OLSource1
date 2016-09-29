---
title: "-win32icon"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/win32icon"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "win32icon compiler option [Visual Basic]"
  - "-win32icon compiler option [Visual Basic]"
  - "/win32icon compiler option [Visual Basic]"
ms.assetid: aecaab01-9353-46c5-941c-6edabd4eff92
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -win32icon
Inserts an .ico file in the output file. This .ico file represents the output file in **File Explorer**.  
  
## Syntax  
  
```  
/win32icon:filename  
```  
  
## Arguments  
  
|||  
|-|-|  
|Term|Definition|  
|`filename`|The .ico file to add to your output file. Enclose the file name in quotation marks (" ") if it contains a space.|  
  
## Remarks  
 You can create an .ico file with the Microsoft Windows Resource Compiler (RC). The resource compiler is invoked when you compile a Visual C++ program; an .ico file is created from the .rc file. The `/win32icon` and `/win32resource` options are mutually exclusive.  
  
 See [/linkresource (Visual Basic)](../vs140/-linkresource--visual-basic-.md) to reference a [!INCLUDE[dnprdnshort](../vs140/includes/dnprdnshort_md.md)] resource file, or [/resource (Visual Basic)](../vs140/-resource--visual-basic-.md) to attach a [!INCLUDE[dnprdnshort](../vs140/includes/dnprdnshort_md.md)] resource file. See [/win32resource](../vs140/-win32resource.md) to import a .res file.  
  
||  
|-|  
|To set /win32icon in the Visual Studio IDE|  
|1.  Have a project selected in **Solution Explorer**. On the **Project** menu, click **Properties**. For more information, see [Introduction to the Project Designer](assetId:///898dd854-c98d-430c-ba1b-a913ce3c73d7).<br />2.  Click the **Application** tab.<br />3.  Modify the value in the **Icon** box.|  
  
## Example  
 The following code compiles `In.vb` and attaches an .ico file, `Rf.ico`.  
  
```  
vbc /win32icon:rf.ico in.vb  
```  
  
## See Also  
 [Visual Basic Command-Line Compiler](../vs140/visual-basic-command-line-compiler.md)   
 [Sample Compilation Command Lines](../vs140/sample-compilation-command-lines--visual-basic-.md)