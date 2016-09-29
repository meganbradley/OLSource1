---
title: "-Oy (Frame-Pointer Omission)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/Oy (Frame-Pointer Omission)"
f1_keywords: 
  - "VC.Project.VCCLCompilerTool.OmitFramePointers"
  - "/oy"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "omit frame pointer"
  - "Oy compiler option [C++]"
  - "stack frame pointer compiler option [C++]"
  - "-Oy compiler option [C++]"
  - "frame pointer omission compiler option [C++]"
  - "suppress frame pointer creation"
  - "/Oy compiler option [C++]"
ms.assetid: c451da86-5297-4c5a-92bc-561d41379853
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -Oy (Frame-Pointer Omission)
Suppresses creation of frame pointers on the call stack.  
  
## Syntax  
  
```  
/Oy[-]  
```  
  
## Remarks  
 This option speeds function calls, because no frame pointers need to be set up and removed. It also frees one more register, (EBP on the Intel 386 or later) for storing frequently used variables and sub-expressions.  
  
 **/Oy** enables frame-pointer omission and **/Oy-** disables omission. **/Oy** is available only in x86 compilers.  
  
 If your code requires EBP-based addressing, you can specify the **/Oy–** option after the **/Ox** option or use [optimize](../VS_csharp/optimize.md) with the "**y**" and **off** arguments to gain maximum optimization with EBP-based addressing. The compiler detects most situations where EBP-based addressing is required (for instance, with the `_alloca` and `setjmp` functions and with structured exception handling).  
  
 The [/Ox (Full Optimization)](../VS_csharp/-ox--full-optimization-.md) and [/O1, /O2 (Minimize Size, Maximize Speed)](../VS_csharp/-o1---o2--minimize-size--maximize-speed-.md) options imply **/Oy**. Specifying **/Oy–** after the **/Ox**, **/O1**, or **/O2** option disables **/Oy**, whether it is explicit or implied.  
  
 The **/Oy** compiler option makes using the debugger more difficult because the compiler suppresses frame pointer information. If you specify a debug compiler option ([/Z7, /Zi, /ZI](../VS_csharp/-z7---zi---zi--debug-information-format-.md)), we recommend that you specify the **/Oy-** option after any other optimization compiler options.  
  
### To set this compiler option in the Visual Studio development environment  
  
1.  Open the project's **Property Pages** dialog box. For details, see [How to: Open Project Property Pages](../Topic/How%20to:%20Open%20Project%20Property%20Pages.md).  
  
2.  Click the **C/C++** folder.  
  
3.  Click the **Optimization** property page.  
  
4.  Modify the **Omit Frame Pointers** property. This property adds or removes only the **/Oy** option. If you want to add the **/Oy-** option, click **Command Line** and modify **Additional options**.  
  
### To set this compiler option programmatically  
  
-   See <xref:Microsoft.VisualStudio.VCProjectEngine.VCCLCompilerTool.OmitFramePointers*>.  
  
## See Also  
 [/O Options (Optimize Code)](../VS_csharp/-o-options--optimize-code-.md)   
 [Compiler Options](../VS_csharp/compiler-options.md)   
 [Setting Compiler Options](../VS_csharp/setting-compiler-options.md)