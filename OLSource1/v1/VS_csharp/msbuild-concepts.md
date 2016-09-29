---
title: "MSBuild Concepts"
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
  - "MSBuild, concepts"
ms.assetid: 083b8ba3-e4ad-45af-bb5d-3bc81d406131
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# MSBuild Concepts
[!INCLUDE[vstecmsbuild](../VS_csharp/includes/vstecmsbuild_md.md)] provides a basic XML schema that you can use to control how the build platform builds software. To specify the components in the build and how they are to be built, use these four parts of MSBuild: properties, items, tasks, and targets.  
  
## Related Topics  
  
|Title|Description|  
|-----------|-----------------|  
|[MSBuild Properties](../VS_csharp/msbuild-properties.md)|Introduces properties and property collections. Properties are key/value pairs that you can use to configure builds.|  
|[MSBuild Items](../VS_csharp/msbuild-items.md)|Describes the general concepts behind the [!INCLUDE[vstecmsbuild](../VS_csharp/includes/vstecmsbuild_md.md)] file format and how the pieces fit together.|  
|[MSBuild Targets](../VS_csharp/msbuild-targets.md)|Explains how to group tasks together in a particular order and enable sections of the build process to be called on the command line.|  
|[MSBuild Tasks](../VS_csharp/msbuild-tasks.md)|Shows how to create a unit of executable code that can be used by [!INCLUDE[vstecmsbuild](../VS_csharp/includes/vstecmsbuild_md.md)] to perform atomic build operations.|  
|[Comparing Properties and Items](../VS_csharp/comparing-properties-and-items.md)|Compares MSBuild properties and items. Both are used to pass information to tasks, evaluate conditions, and store values that can be referenced throughout the project file.|  
|[MSBuild Special Characters](../VS_csharp/msbuild-special-characters.md)|Explains how to escape some characters that [!INCLUDE[vstecmsbuild](../VS_csharp/includes/vstecmsbuild_md.md)] reserves for special use in specific contexts.|  
|[Tutorial: How to Create a Project File from Scratch](../VS_csharp/walkthrough--creating-an-msbuild-project-file-from-scratch.md)|Shows how to create a basic project file incrementally, by using only a text editor.|  
|[Tutorial: How to Use MSBuild](../VS_csharp/walkthrough--using-msbuild.md)|Introduces the building blocks of MSBuild and shows how to write, manipulate, and debug MSBuild projects without closing the Visual Studio integrated development environment (IDE).|  
|[MSBuild Reference](../VS_csharp/msbuild-reference.md)|Links to documents that contain reference information.|  
|[MSBuild](../VS_csharp/msbuild.md)|Presents an overview of the XML schema for a project file and shows how it controls processes that builds software.|