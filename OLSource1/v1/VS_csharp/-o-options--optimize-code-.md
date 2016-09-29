---
title: "-O Options (Optimize Code)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/O Options (Optimize Code)"
f1_keywords: 
  - "VC.Project.VCCLCompilerTool.Optimization"
  - "/o"
  - "VC.Project.VCCLWCECompilerTool.Optimization"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "performance, cle.exe compiler"
  - "cl.exe compiler, performance"
ms.assetid: 77997af9-5555-4b3d-aa57-6615b27d4d5d
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -O Options (Optimize Code)
The **/O** options control various optimizations that help you create code for maximum speed or minimum size.  
  
-   [/O1](../VS_csharp/-o1---o2--minimize-size--maximize-speed-.md) optimizes code for minimum size.  
  
-   [/O2](../VS_csharp/-o1---o2--minimize-size--maximize-speed-.md) optimizes code for maximum speed.  
  
-   [/Ob](../VS_csharp/-ob--inline-function-expansion-.md) controls inline function expansion.  
  
-   [/Od](../VS_csharp/-od--disable--debug--.md) disables optimization, speeding compilation and simplifying debugging.  
  
-   [/Og](../VS_csharp/-og--global-optimizations-.md) enables global optimizations.  
  
-   [/Oi](../VS_csharp/-oi--generate-intrinsic-functions-.md) generates intrinsic functions for appropriate function calls.  
  
-   [/Os](../VS_csharp/-os---ot--favor-small-code--favor-fast-code-.md) tells the compiler to favor optimizations for size over optimizations for speed.  
  
-   [/Ot](../VS_csharp/-os---ot--favor-small-code--favor-fast-code-.md) (a default setting) tells the compiler to favor optimizations for speed over optimizations for size.  
  
-   [/Ox](../VS_csharp/-ox--full-optimization-.md) selects full optimization.  
  
-   [/Oy](../VS_csharp/-oy--frame-pointer-omission-.md) suppresses the creation of frame pointers on the call stack for quicker function calls.  
  
## Remarks  
 You can also combine multiple **/O** options into a single option statement. For example, `/Odi` is the same as `/Od /Oi`.  
  
## See Also  
 [Compiler Options](../VS_csharp/compiler-options.md)   
 [Setting Compiler Options](../VS_csharp/setting-compiler-options.md)