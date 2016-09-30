---
title: "How to: Build Incrementally"
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
  - "MSBuild, incremental builds"
  - "incremental builds"
  - "MSBuild, building incrementally"
ms.assetid: 8d82d7d8-a2f1-4df6-9d2f-80b9e0cb3ac3
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Build Incrementally
When you build a large project, it is important that previously built components that are still up-to-date are not rebuilt. If all targets are built every time, each build will take a long time to complete. To enable incremental builds (builds in which only those targets that have not been built before or targets that are out of date, are rebuilt), the [!INCLUDE[vstecmsbuildengine](../vs140/includes/vstecmsbuildengine_md.md)] ([!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)]) can compare the timestamps of the input files with the timestamps of the output files and determine whether to skip, build, or partially rebuild a target. However, there must be a one-to-one mapping between inputs and outputs. You can use transforms to enable targets to identify this direct mapping. For more information on transforms, see [MSBuild Transforms](../vs140/msbuild-transforms.md).  
  
## Specifying Inputs and Outputs  
 A target can be built incrementally if the inputs and outputs are specified in the project file.  
  
#### To specify inputs and outputs for a target  
  
-   Use the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> attributes of the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> element. For example:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] can compare the timestamps of the input files with the timestamps of the output files and determine whether to skip, build, or partially rebuild a target. In the following example, if any file in the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> item list is newer than the hello.exe file, [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] will run the target; otherwise it will be skipped:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 When inputs and outputs are specified in a target, either each output can map to only one input or there can be no direct mapping between the outputs and inputs. In the previous [Csc Task](../vs140/csc-task.md), for example, the output, hello.exe, cannot be mapped to any single input – it depends on all of them.  
  
> [!NOTE]
>  A target in which there is no direct mapping between the inputs and outputs will always build more often than a target in which each output can map to only one input because [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] cannot determine which outputs need to be rebuilt if some of the inputs have changed.  
  
 Tasks in which you can identify a direct mapping between the outputs and inputs, such as the [LC Task](../vs140/lc-task.md), are most suitable for incremental builds, unlike tasks such as <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> and [Vbc](../vs140/vbc-task.md), which produce one output assembly from a number of inputs.  
  
## Example  
 The following example uses a project that builds Help files for a hypothetical Help system. The project works by converting source .txt files into intermediate .content files, which then are combined with XML metadata files to produce the final .help file used by the Help system. The project uses the following hypothetical tasks:  
  
-   <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>: Converts .txt files into .content files.  
  
-   <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>: Combines .content files and XML metadata files to build the final .help file.  
  
 The project uses transforms to create a one-to-one mapping between inputs and outputs in the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> task. For more information, see [MSBuild Transforms](../vs140/msbuild-transforms.md). Also, the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> element is set to automatically use the outputs from the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> task as the inputs for the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> task.  
  
 This project file contains both the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> targets. The <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> tasks are placed in the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> targets respectively so that each target can be built incrementally. By using the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> element, the outputs of the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> task are placed in the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> item list, where they can be used as inputs for the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> task. Using the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> element in this way automatically provides the outputs from one task as the inputs for another task so that you do not have to list the individual items or item lists manually in each task.  
  
> [!NOTE]
>  Although the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> target can build incrementally, all outputs from that target always are required as inputs for the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> target. [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] automatically provides all the outputs from one target as inputs for another target when you use the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> element.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [MSBuild Targets](../vs140/msbuild-targets.md)   
 [Target Element (MSBuild)](../vs140/target-element--msbuild-.md)   
 [MSBuild Transforms](../vs140/msbuild-transforms.md)   
 [Csc Task](../vs140/csc-task.md)   
 [Vbc Task](../vs140/vbc-task.md)