---
title: "-Ge (Enable Stack Probes)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/Ge (Enable Stack Probes)"
f1_keywords: 
  - "/ge"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "-Ge compiler option [C++]"
  - "enable stack probes"
  - "/Ge compiler option [C++]"
  - "stack, stack probes"
  - "stack probes"
  - "stack checking calls"
  - "Ge compiler option [C++]"
ms.assetid: 4b54deae-4e3c-4bfa-95f3-ba23590f7258
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -Ge (Enable Stack Probes)
Activates stack probes for every function call that requires storage for local variables.  
  
## Syntax  
  
```  
/Ge  
```  
  
## Remarks  
 This mechanism is useful if you rewrite the functionality of the stack probe. It is recommended that you use [/Gh (Enable _penter Hook Function)](../vs140/-gh--enable-_penter-hook-function-.md) instead of rewriting the stack probe.  
  
 [/Gs (Control Stack Checking Calls)](../vs140/-gs--control-stack-checking-calls-.md) has the same effect.  
  
 **/Ge** is deprecated; the compiler will generate stack checking. For more information, see [Deprecated Compiler Options in Visual C++ 2005](assetId:///aa59fce3-50b8-4f66-9aeb-ce09a7a84cce).  
  
### To set this compiler option in the Visual Studio development environment  
  
1.  Open the project's **Property Pages** dialog box. For details, see [How to: Open Project Property Pages](../vs140/how-to--open-project-property-pages.md).  
  
2.  Click the **C/C++** folder.  
  
3.  Click the **Command Line** property page.  
  
4.  Type the compiler option in the **Additional Options** box.  
  
### To set this compiler option programmatically  
  
-   See <xref:Microsoft.VisualStudio.VCProjectEngine.VCCLCompilerTool.AdditionalOptions*>.  
  
## See Also  
 [Compiler Options](../vs140/compiler-options.md)   
 [Setting Compiler Options](../vs140/setting-compiler-options.md)