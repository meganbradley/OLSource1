---
title: "-WX (Treat Linker Warnings as Errors)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
H1: /WX (Treat Linker Warnings as Errors)
f1_keywords: 
  - /WX
dev_langs: 
  - C++
helpviewer_keywords: 
  - /WX linker option
  - -WX linker option
  - WX linker option
ms.assetid: e4ba97c7-93f7-43ae-a4bb-d866790926c9
caps.latest.revision: 11
translation.priority.ht: 
  - de-de
  - ja-jp
---
# -WX (Treat Linker Warnings as Errors)
```  
/WX[:NO]  
```  
  
## Remarks  
 /WX causes no output file to be generated if the linker generates a warning.  
  
 This is similar to **/WX** for the compiler (see [/w, /Wn, /WX, /Wall, /wln, /wdn, /wen, /won (Warning Level)](../vs140/-w---w0---w1---w2---w3---w4---w1---w2---w3---w4---wall---wd---we---wo---wv---wx--warning-level-.md) for more information). However, specifying **/WX** for the compilation does not imply that **/WX** will also be in effect for the link phase; you must explicitly specify **/WX** for each tool.  
  
 By default, **/WX** is not in effect. To treat linker warnings as errors, specify **/WX**. **/WX:NO** is the same as not specifying **/WX**.  
  
### To set this linker option in the Visual Studio development environment  
  
1.  Open the project's **Property Pages** dialog box. For details, see [Setting Visual C++ Project Properties](../vs140/working-with-project-properties.md).  
  
2.  Click the **Linker** folder.  
  
3.  Click the **Command Line** property page.  
  
4.  Type the option into the **Additional Options** box.  
  
### To set this linker option programmatically  
  
1.  See <xref:Microsoft.VisualStudio.VCProjectEngine.VCCLCompilerTool.AdditionalOptions?qualifyHint=False>.  
  
## See Also  
 [Setting Linker Options](../vs140/setting-linker-options.md)   
 [Linker Options](../vs140/linker-options.md)