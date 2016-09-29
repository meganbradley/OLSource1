---
title: "-cgthreads (Code Generation Threads)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/cgthreads (Code Generation Threads)"
f1_keywords: 
  - "/cgthreads"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "/cgthreads compiler option (C++)"
  - "-cgthreads compiler option (C++)"
  - "cgthreads compiler option (C++)"
  - "cgthreads"
ms.assetid: 64bc768c-6caa-4baf-9dea-7cfa1ffb01c2
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -cgthreads (Code Generation Threads)
Sets number of cl.exe threads to use for optimization and code generation.  
  
## Syntax  
  
```  
/cgthreads[1-8]  
```  
  
## Arguments  
 number  
 The maximum number of threads for cl.exe to use, in the range 1 to 8.  
  
## Remarks  
 The **/cgthreads** option specifies the maximum number of threads cl.exe uses in parallel for the optimization and code generation phases of compilation. Notice that there can be no space between **/cgthreads** and the `number` argument. By default, cl.exe uses four threads, as if **/cgthreads4** were specified. If more processor cores are available, a larger `number` value can improve build times. This option is especially useful when it's combined with [/GL (Whole Program Optimization)](../vs140/-gl--whole-program-optimization-.md).  
  
 Multiple levels of parallelism can be specified for a build. The msbuild.exe switch **/maxcpucount** specifies the number of MSBuild processes that can be run in parallel. The [/MP](../vs140/-mp--build-with-multiple-processes-.md) compiler flag specifies the number of cl.exe processes that simultaneously compile the source files. The **/cgthreads** option specifies the number of threads used by each cl.exe process. Because the processor can only run as many threads at the same time as there are processor cores, it's not useful to specify larger values for all of these options at the same time, and it can be counterproductive. For more information about how to build projects in parallel, see [Building Multiple Projects in Parallel with MSBuild](../vs140/building-multiple-projects-in-parallel-with-msbuild.md).  
  
### To set this compiler option in the Visual Studio development environment  
  
1.  Open the project's **Property Pages** dialog box. For details, see [Working with Project Properties](../vs140/working-with-project-properties.md).  
  
2.  Select the **Configuration Properties**, **C/C++** folder.  
  
3.  Select the **Command Line** property page.  
  
4.  Modify the **Additional Options** property to include **/cgthreads**`N`, where `N` is a value from 1 to 8, and then select **OK**.  
  
### To set this compiler option programmatically  
  
-   See <xref:Microsoft.VisualStudio.VCProjectEngine.VCCLCompilerTool.AdditionalOptions*>.  
  
## See Also  
 [Compiler Options](../vs140/compiler-options.md)   
 [Setting Compiler Options](../vs140/setting-compiler-options.md)