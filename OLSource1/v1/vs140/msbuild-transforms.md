---
title: "MSBuild Transforms"
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
  - "MSBuild, transforms"
  - "transforms [MSBuild]"
ms.assetid: d0bcfc3c-14fa-455e-805c-63ccffa4a3bf
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# MSBuild Transforms
A transform is a one-to-one conversion of one item list to another. In addition to enabling a project to convert item lists, a transform enables a target to identify a direct mapping between its inputs and outputs. This topic explains transforms and how [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] uses them to build projects more efficiently.  
  
## Transform Modifiers  
 Transforms are not arbitrary, but are limited by special syntax in which all transform modifiers must be in the format %(*ItemMetaDataName*). Any item metadata can be used as a transform modifier. This includes the well-known item metadata that is assigned to every item when it is created. For a list of well-known item metadata, see [MSBuild Well-known Item Metadata](../vs140/msbuild-well-known-item-metadata.md).  
  
 In the following example, a list of .resx files is transformed into a list of .resources files. The %(filename) transform modifier specifies that each .resources file has the same file name as the corresponding .resx file.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
> [!NOTE]
>  You can specify a custom separator for a transformed item list in the same way you specify a separator for a standard item list. For example, to separate a transformed item list by using a comma (,) instead of the default semicolon (;), use the following XML.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 For example, if the items in the @(RESXFile) item list are <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, the outputs in the transformed list will be <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
## Using Multiple Modifiers  
 A transform expression can contain multiple modifiers, which can be combined in any order and can be repeated. In the following example, the name of the directory that contains the files is changed but the files retain the original name and file name extension.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 For example, if the items that are contained in the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> item list are <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, the outputs in the transformed list will be <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>.  
  
## Dependency Analysis  
 Transforms guarantee a one-to-one mapping between the transformed item list and the original item list. Therefore, if a target creates outputs that are transforms of the inputs, [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] can analyze the timestamps of the inputs and outputs, and decide whether to skip, build, or partially rebuild a target.  
  
 In the [Copy Task](../vs140/copy-task.md) in the following example, every file in the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> item list maps to a file in the destination folder of the task, specified by using a transform in the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> attribute. If a file in the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> item list changes, the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> task will be run only for the changed file and all other files will be skipped. For more information about dependency analysis and how to use transforms, see [How To: Build Incrementally](../vs140/how-to--build-incrementally.md).  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## Example  
  
### Description  
 The following example shows an [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] project file that uses transforms. This example assumes that there is just one .xsd file in the c:\sub0\sub1\sub2\sub3 directory, and that the working directory is c:\sub0.  
  
### Code  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Comments  
 This example produces the following output.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
## See Also  
 [MSBuild Concepts](../vs140/msbuild-concepts.md)   
 [MSBuild Reference](../vs140/msbuild-reference.md)   
 [How To: Build Incrementally](../vs140/how-to--build-incrementally.md)