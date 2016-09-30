---
title: "-Qpar (Auto-Parallelizer)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/Qpar (Auto-Parallelizer)"
f1_keywords: 
  - "VC.Project.VCCLCompilerTool.EnableParallelCodeGeneration"
dev_langs: 
  - "C++"
ms.assetid: 33ecf49d-c0d5-4f34-bce3-84ff03f38918
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -Qpar (Auto-Parallelizer)
Enables the [Auto-Parallelizer](../vs140/auto-parallelization-and-auto-vectorization.md) feature of the compiler to automatically parallelize loops in your code.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 When  the compiler automatically parallelizes loops in code, it spreads computation across multiple processor cores. A loop is parallelized only if the compiler determines that it is legal to do so and that parallelization would improve performance.  
  
 The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> directives are available to help the optimizer parallelize specific loops. For more information, see [#pragma loop()](../vs140/loop.md).  
  
 For information about how to enable output messages for the auto-parallelizer, see [/Qpar-report (Auto-Parallelizer Reporting Level)](../vs140/-qpar-report--auto-parallelizer-reporting-level-.md).  
  
### To set the /Qpar compiler option in Visual Studio  
  
1.  In **Solution Explorer**, open the shortcut menu for the project and then choose **Properties**.  
  
2.  In the **Property Pages** dialog box, under **C/C++**, select **Command Line**.  
  
3.  In the **Additional Options** box, enter <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
### To set the /Qpar compiler option programmatically  
  
-   Use the code example in \<xref:Microsoft.VisualStudio.VCProjectEngine.VCCLCompilerTool.AdditionalOptions*>.  
  
## See Also  
 [/Q Options (Low-Level Operations)](../vs140/-q-options--low-level-operations-.md)   
 [/Qpar-report](../vs140/-qpar-report--auto-parallelizer-reporting-level-.md)   
 [Compiler Options](../vs140/compiler-options.md)   
 [Setting Compiler Options](../vs140/setting-compiler-options.md)   
 [#pragma loop()](../vs140/loop.md)   
 [Parallel Programming in Native Code](http://go.microsoft.com/fwlink/?LinkId=263662)