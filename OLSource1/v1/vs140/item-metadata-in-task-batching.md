---
title: "Item Metadata in Task Batching"
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
  - "MSBuild, batching"
  - "task batching [MSBuild]"
  - "MSBuild, task batching"
ms.assetid: 31e480f8-fe4d-4633-8c54-8ec498e2306d
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Item Metadata in Task Batching
[!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] has the ability to divide item lists into different categories, or batches, based on item metadata, and run a task one time with each batch. It can be confusing to understand exactly what items are being passed with which batch. This topic covers the following common scenarios that involve batching.  
  
-   Dividing an item list into batches  
  
-   Dividing several item lists into batches  
  
-   Batching one item at a time  
  
-   Filtering item lists  
  
 For more information on batching with [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)], see [MSBuild Batching](../vs140/msbuild-batching.md).  
  
## Dividing an Item list into Batches  
 Batching allows you to divide an item list into different batches based on item metadata, and pass each of the batches into a task separately. This is useful for building satellite assemblies.  
  
 The following example shows how to divide an item list into batches based on item metadata. The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> item list is divided into three batches based on the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> item metadata. The presence of <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>in the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> attribute notifies [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] that batching should be performed. The <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> item list is divided into three batches based on the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> metadata, and each batch is passed separately into the task.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The [Message](../vs140/message-task.md) task displays the following information:  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
  
## Dividing Several Item lists into Batches  
 [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] can divide multiple item lists into batches based on the same metadata. This makes it easy to divide different item lists into batches to build multiple assemblies. For example, you could have an item list of .cs files divided into an application batch and an assembly batch, and an item list of resource files divided into an application batch and an assembly batch. You could then use batching to pass these item lists into one task and build both the application and the assembly.  
  
> [!NOTE]
>  If an item list being passed into a task contains no items with the referenced metadata, every item in that item list is passed into every batch.  
  
 The following example shows how to divide multiple item list into batches based on item metadata. The <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> item lists are each divided into three batches based on the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> item metadata. The presence of <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>in the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> attribute notifies [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] that batching should be performed. The <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> item lists are divided into three batches based on the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> metadata, and each batch is passed separately into the task.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The [Message](../vs140/message-task.md) task displays the following information:  
  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
  
## Batching One Item at a Time  
 Batching can also be performed on well-known item metadata that is assigned to every item upon creation. This guarantees that every item in a collection will have some metadata to use for batching. The <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> metadata value is unique for every item, and is useful for dividing every item in an item list into a separate batch. For a complete list of well-known item metadata, see [MSBuild Well-known Item Metadata](../vs140/msbuild-well-known-item-metadata.md).  
  
 The following example shows how to batch each item in an item list one at a time. Because the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> metadata value of every item is unique, the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> item list is divided into six batches, each batch containing one item of the item list. The presence of <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>in the <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> attribute notifies [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] that batching should be performed.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The [Message](../vs140/message-task.md) task displays the following information:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## Filtering Item lists  
 Batching can be used to filter out certain items from an item list before passing it to a task. For example, filtering on the <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> well-known item metadata value allows you to run a task on only files with a specific extension.  
  
 The following example shows how to divide an item list into batches based on item metadata, and then filter those batches when they are passed into a task. The <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> item list is divided into three batches based on the <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> item metadata. The <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> attribute of the task specifies that only batches with a <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> item metadata value of <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> will be passed into the task  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The [Message](../vs140/message-task.md) task displays the following information:  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
## See Also  
 [MSBuild Well-known Item Metadata](../vs140/msbuild-well-known-item-metadata.md)   
 [Item Element (MSBuild)](../vs140/item-element--msbuild-.md)   
 [ItemMetaData Element (MSBuild)](../vs140/itemmetadata-element--msbuild-.md)   
 [MSBuild Batching](../vs140/msbuild-batching.md)   
 [MSBuild Concepts](../vs140/msbuild-concepts.md)   
 [MSBuild Reference](../vs140/msbuild-reference.md)