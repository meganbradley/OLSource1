---
title: "-Oi (Generate Intrinsic Functions)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/Oi (Generate Intrinsic Functions)"
f1_keywords: 
  - "VC.Project.VCCLCompilerTool.EnableIntrinsicFunctions"
  - "/oi"
  - "VC.Project.VCCLWCECompilerTool.EnableIntrinsicFunctions"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Oi compiler option [C++]"
  - "intrinsic functions, generate"
  - "/Oi compiler option [C++]"
  - "-Oi compiler option [C++]"
  - "generate intrinsic functions compiler option [C++]"
ms.assetid: fa4a3bf6-0ed8-481b-91c0-add7636132b4
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -Oi (Generate Intrinsic Functions)
Replaces some function calls with intrinsic or otherwise special forms of the function that help your application run faster.  
  
## Syntax  
  
```  
/Oi[-]  
```  
  
## Remarks  
 Programs that use intrinsic functions are faster because they do not have the overhead of function calls, but may be larger because of the additional code created.  
  
 See [intrinsic](../vs140/intrinsic.md) for more information on which functions have intrinsic forms.  
  
 **/Oi** is only a request to the compiler to replace some function calls with intrinsics; the compiler may call the function (and not replace the function call with an intrinsic) if it will result in better performance.  
  
 **x86 Specific**  
  
 The intrinsic floating-point functions do not perform any special checks on input values and so work in restricted ranges of input, and have different exception handling and boundary conditions than the library routines with the same name. Using the true intrinsic forms implies loss of IEEE exception handling, and loss of `_matherr` and `errno` functionality; the latter implies loss of ANSI conformance. However, the intrinsic forms can considerably speed up floating-point-intensive programs, and for many programs, the conformance issues are of little practical value.  
  
 You can use the [Za](../vs140/-za---ze--disable-language-extensions-.md) compiler option to override generation of true intrinsic floating-point options. In this case, the functions are generated as library routines that pass arguments directly to the floating-point chip instead of pushing them onto the program stack.  
  
 **END x86 Specific**  
  
 You also use [intrinsic](../vs140/intrinsic.md) to create intrinsic functions, or [function (C/C++)](../vs140/function--c-c---.md) to explicitly force a function call.  
  
### To set this compiler option in the Visual Studio development environment  
  
1.  Open the project's **Property Pages** dialog box. For details, see [How to: Open Project Property Pages](../vs140/how-to--open-project-property-pages.md).  
  
2.  Click the **C/C++** folder.  
  
3.  Click the **Optimization** property page.  
  
4.  Modify the **Enable Intrinsic Functions** property.  
  
### To set this compiler option programmatically  
  
-   See <xref:Microsoft.VisualStudio.VCProjectEngine.VCCLCompilerTool.EnableIntrinsicFunctions*>.  
  
## See Also  
 [/O Options (Optimize Code)](../vs140/-o-options--optimize-code-.md)   
 [Compiler Options](../vs140/compiler-options.md)   
 [Setting Compiler Options](../vs140/setting-compiler-options.md)   
 [Compiler Intrinsics](../vs140/compiler-intrinsics.md)