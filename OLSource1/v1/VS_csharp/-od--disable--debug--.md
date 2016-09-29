---
title: "-Od (Disable (Debug))"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/Od (Disable (Debug))"
f1_keywords: 
  - "/od"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "no optimizations"
  - "fast compiling"
  - "/Od compiler option [C++]"
  - "disable optimizations"
  - "Od compiler option [C++]"
  - "-Od compiler option [C++]"
  - "disable (debug) compiler option [C++]"
ms.assetid: b1ac31b7-e086-4eeb-be5e-488f7513f5f5
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -Od (Disable (Debug))
Turns off all optimizations in the program and speeds compilation.  
  
## Syntax  
  
```  
/Od  
```  
  
## Remarks  
 This option is the default. Because **/Od** suppresses code movement, it simplifies the debugging process. For more information about compiler options for debugging, see [/Z7, /Zi, /ZI (Debug Information Format)](../VS_csharp/-z7---zi---zi--debug-information-format-.md).  
  
### To set this compiler option in the Visual Studio development environment  
  
1.  Open the project's **Property Pages** dialog box. For details, see [How to: Open Project Property Pages](../Topic/How%20to:%20Open%20Project%20Property%20Pages.md).  
  
2.  Click the **C/C++** folder.  
  
3.  Click the **Optimization** property page.  
  
4.  Modify the **Optimization** property.  
  
### To set this compiler option programmatically  
  
-   See <xref:Microsoft.VisualStudio.VCProjectEngine.VCCLCompilerTool.Optimization*>.  
  
## See Also  
 [/O Options (Optimize Code)](../VS_csharp/-o-options--optimize-code-.md)   
 [Compiler Options](../VS_csharp/compiler-options.md)   
 [Setting Compiler Options](../VS_csharp/setting-compiler-options.md)   
 [/Z7, /Zi, /ZI (Debug Information Format)](../VS_csharp/-z7---zi---zi--debug-information-format-.md)