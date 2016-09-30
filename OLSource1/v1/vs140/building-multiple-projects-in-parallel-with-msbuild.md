---
title: "Building Multiple Projects in Parallel with MSBuild"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "parallel project builds"
  - "building multiple projects in parallel"
  - "msbuild, building projects in parallel"
ms.assetid: c8c9aadc-33ad-4aa1-b07d-b879e9eabda0
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Building Multiple Projects in Parallel with MSBuild
You can use MSBuild to build multiple projects faster by running them in parallel. To run builds in parallel, you use the following settings on a multi-core or multiple processor computer:  
  
-   The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> switch at a command prompt.  
  
-   The \<xref:Microsoft.Build.Tasks.MSBuild.BuildInParallel*> task parameter on an MSBuild task.  
  
> [!NOTE]
>  The **/verbosity** (**/v**) switch in a command line can also affect build performance. Your build performance might decrease if the verbosity of your build log information is set to detailed or diagnostic, which are used for troubleshooting. For more information, see [Overview of Logging in MSBuild](../vs140/obtaining-build-logs-with-msbuild.md) and [MSBuild Command-Line Reference](../vs140/msbuild-command-line-reference.md).  
  
## /maxcpucount Switch  
 If you use the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> switch, or <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> for short, MSBuild can create the specified number of MSBuild.exe processes that may be run in parallel. These processes are also known as "worker processes." Each worker process uses a separate core or processor, if any are available, to build a project at the same time as other available processors may be building other projects. For example, setting this switch to a value of "4" causes MSBuild to create four worker processes to build the project.  
  
 If you include the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> switch without specifying a value, MSBuild will use up to the number of processors on the computer.  
  
 For more information about this switch, which was introduced in MSBuild 3.5, see [MSBuild Command-Line Reference](../vs140/msbuild-command-line-reference.md).  
  
 The following example instructs MSBuild to use three worker processes. If you use this configuration, MSBuild can build three projects at the same time.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## BuildInParallel Task Parameter  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is an optional boolean parameter on a [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] task. When <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> (its default value), multiple worker processes are generated to build as many projects at the same time as possible. For this to work correctly, the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> switch must be set to a value greater than 1, and the system must be at least dual-core or have two or more processors.  
  
 The following is an example, taken from microsoft.common.targets, about how to set the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> parameter.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Taking Advantage of Multiple Processors for Building Projects](../vs140/using-multiple-processors-to-build-projects.md)   
 [Writing Multi-Proc Aware Loggers](../vs140/writing-multi-processor-aware-loggers.md)   
 [Tuning C++ Build Parallelism blog](http://go.microsoft.com/fwlink/?LinkId=251457)