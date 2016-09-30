---
title: "MSBuild Targets"
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
  - "MSBuild, targets"
ms.assetid: 8060b4d2-e4a9-48cf-a437-852649ceb417
caps.latest.revision: 30
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# MSBuild Targets
Targets group tasks together in a particular order and allow the build process to be factored into smaller units. For example, one target may delete all files in the output directory to prepare for the build, while another compiles the inputs for the project and places them in the empty directory. For more information on tasks, see [MSBuild Tasks](../vs140/msbuild-tasks.md).  
  
## Declaring Targets in the Project File  
 Targets are declared in a project file with the [Target](../vs140/target-element--msbuild-.md) element. For example, the following XML creates a target named Construct, which then calls the Csc task with the Compile item type.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 Like MSBuild properties, targets can be redefined. For example,  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 If AfterBuild executes, it displays only "Second occurrence".  
  
## Target Build Order  
 Targets must be ordered if the input to one target depends on the output of another target. There are several ways to specify the order in which targets run.  
  
-   Initial targets  
  
-   Default targets  
  
-   First target  
  
-   Target dependencies  
  
-   <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> (MSBuild 4.0)  
  
 A target never runs twice during a single build, even if a subsequent target in the build depends on it. Once a target runs, its contribution to the build is complete.  
  
 For details and more information about the target build order, see [Target Build Order](../vs140/target-build-order.md).  
  
## Target Batching  
 A target element may have an <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> attribute which specifies metadata in the form %(Metadata). If so, MSBuild runs the target once for each unique metadata value, grouping or "batching" the items that have that metadata value. For example,  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 batches the Reference items by their RequiredTargetFramework metadata. The output of the target looks like this:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Target batching is seldom used in real builds. Task batching is more common. For more information, see [MSBuild Batching](../vs140/msbuild-batching.md).  
  
## Incremental Builds  
 Incremental builds are builds that are optimized so that targets with output files that are up-to-date with respect to their corresponding input files are not executed. A target element can have both <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> attributes, indicating what items the target expects as input, and what items it produces as output.  
  
 If all output items are up-to-date, MSBuild skips the target, which significantly improves the build speed. This is called an incremental build of the target. If only some files are up-to-date, MSBuild executes the target without the up-to-date items. This is called a partial incremental build of the target. For more information, see [Incremental Builds](../vs140/incremental-builds.md).  
  
## See Also  
 [MSBuild Concepts](../vs140/msbuild-concepts.md)   
 [How To: Use the Same Target in Multiple Project Files](../vs140/how-to--use-the-same-target-in-multiple-project-files.md)