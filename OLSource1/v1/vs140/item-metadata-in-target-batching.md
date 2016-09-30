---
title: "Item Metadata in Target Batching"
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
  - "batching [MSBuild]"
  - "MSBuild, target batching"
  - "target batching [MSBuild]"
ms.assetid: f3cc4186-6a4c-4161-bbe5-1ec638b4925b
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Item Metadata in Target Batching
[!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] has the ability to perform dependency analysis on the inputs and outputs of a build target. If it is determined that the inputs or outputs of the target are up-to-date, the target will be skipped and the build will procede. <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> elements use the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> attributes to specify the items to inspect during dependency analysis.  
  
 If a target contains a task that uses batched items as inputs or outputs, the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> element of the target should use batching in its <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> attributes to enable [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] to skip batches of items that are already up-to-date.  
  
## Batching Targets  
 The following example contains an item list named <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> that is divided into two batches based on the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> item metadata. Each of these batches is passed into the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> task, which creates an output assembly for each batch. By using batching on the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> attribute of the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> element, [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] can determine if each of the individual batches is up-to-date before running the target. Without using target batching, both batches of items would be run by the task every time the target was executed.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [How To: Build Incrementally](../vs140/how-to--build-incrementally.md)   
 [MSBuild Batching](../vs140/msbuild-batching.md)   
 [Target Element (MSBuild)](../vs140/target-element--msbuild-.md)   
 [How To: Batch Tasks with Item Metadata](../vs140/item-metadata-in-task-batching.md)