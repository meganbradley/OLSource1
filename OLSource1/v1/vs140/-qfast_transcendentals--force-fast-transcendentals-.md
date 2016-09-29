---
title: "-Qfast_transcendentals (Force Fast Transcendentals)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/Qfast_transcendentals (Force Fast Transcendentals)"
f1_keywords: 
  - "/Qfast_transcendentals"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "/Qfast_transcendentals"
  - "Force Fast Transcendentals"
ms.assetid: 4de24bd1-38e6-49d4-9a05-04c9937d24ac
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -Qfast_transcendentals (Force Fast Transcendentals)
Generates inline code for transcendental functions.  
  
## Syntax  
  
```  
/Qfast_transcendentals  
```  
  
## Remarks  
 This compiler option forces transcendental functions to be converted to inline code to improve execution speed. This option has an effect only when paired with **/fp:except** or **/fp:precise**. Generating inline code for transcendental functions is already the default behavior under **/fp:fast**.  
  
 This option is incompatible with **/fp:strict**. See [/fp (Specify Floating-Point Behavior)](../vs140/-fp--specify-floating-point-behavior-.md) for more information about floating point compiler options.  
  
### To set this compiler option in the Visual Studio development environment  
  
1.  Open the project's **Property Pages** dialog box. For details, see [How to: Open Project Property Pages](../vs140/how-to--open-project-property-pages.md).  
  
2.  Click the **C/C++** folder.  
  
3.  Click the **Command Line** property page.  
  
4.  Type the compiler option in the **Additional Options** box.  
  
### To set this compiler option programmatically  
  
-   See <xref:Microsoft.VisualStudio.VCProjectEngine.VCCLCompilerTool.AdditionalOptions*>.  
  
## See Also  
 [/Q Options (Low-Level Operations)](../vs140/-q-options--low-level-operations-.md)   
 [Compiler Options](../vs140/compiler-options.md)   
 [Setting Compiler Options](../vs140/setting-compiler-options.md)