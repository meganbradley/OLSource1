---
title: "-Qpar-report (Auto-Parallelizer Reporting Level)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/Qpar-report (Auto-Parallelizer Reporting Level)"
dev_langs: 
  - "C++"
ms.assetid: 562673b9-02da-4bf8-bb64-70bc25ef4651
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -Qpar-report (Auto-Parallelizer Reporting Level)
Enables the reporting feature of the compiler's [Auto-Parallelizer](../VS_csharp/auto-parallelization-and-auto-vectorization.md) and specifies the level of informational messages for output during compilation.  
  
## Syntax  
  
```  
/Qpar-report:{1}{2}  
```  
  
## Remarks  
 **/Qpar-report:1**  
 Outputs an informational message for loops that are parallelized.  
  
 **/Qpar-report:2**  
 Outputs an informational message for loops that are parallelized and also for loops that are not parallelized, together with a reason code.  
  
 Messages are reported to stdout. If no informational messages are reported, then either the code contains no loops, or the reporting level was not set to report loops that are not parallelized. For more information about reason codes and messages, see [Vectorizer/Parallelizer Messages](../VS_csharp/vectorizer-and-parallelizer-messages.md).  
  
### To set the /Qpar-report compiler option in Visual Studio  
  
1.  In **Solution Explorer**, open the shortcut menu for the project and then choose **Properties**.  
  
2.  In the **Property Pages** dialog box, under **C/C++**, select **Command Line**.  
  
3.  In the **Additional Options** box, enter `/Qpar-report:1` or `/Qpar-report:2`.  
  
### To set the /Qpar-report compiler option programmatically  
  
-   Use the code example in <xref:Microsoft.VisualStudio.VCProjectEngine.VCCLCompilerTool.AdditionalOptions*>.  
  
## See Also  
 [/Q Options (Low-Level Operations)](../VS_csharp/-q-options--low-level-operations-.md)   
 [Compiler Options](../VS_csharp/compiler-options.md)   
 [Setting Compiler Options](../VS_csharp/setting-compiler-options.md)   
 [Parallel Programming in Native Code](http://go.microsoft.com/fwlink/?LinkId=263662)