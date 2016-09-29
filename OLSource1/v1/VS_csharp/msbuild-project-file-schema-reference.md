---
title: "MSBuild Project File Schema Reference"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
helpviewer_keywords: 
  - "MSBuild, file schema"
ms.assetid: d9a68146-1f43-4621-ac78-2c8c3f400936
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# MSBuild Project File Schema Reference
Provides a table of all the [!INCLUDE[vstecmsbuild](../VS_csharp/includes/vstecmsbuild_md.md)] XML Schema elements with their available attributes and child elements.  
  
 [!INCLUDE[vstecmsbuild](../VS_csharp/includes/vstecmsbuild_md.md)] uses project files to instruct the build engine what to build and how to build it. [!INCLUDE[vstecmsbuild](../VS_csharp/includes/vstecmsbuild_md.md)] project files are XML files that adhere to the [!INCLUDE[vstecmsbuild](../VS_csharp/includes/vstecmsbuild_md.md)] XML schema. This section documents the XML schema definition (.xsd) file for [!INCLUDE[vstecmsbuild](../VS_csharp/includes/vstecmsbuild_md.md)].  
  
## MSBuild XML Schema Elements  
 The following table lists all of the [!INCLUDE[vstecmsbuild](../VS_csharp/includes/vstecmsbuild_md.md)] XML schema elements along with their child elements and attributes.  
  
|Element|Child Elements|Attributes|  
|-------------|--------------------|----------------|  
|[Choose Element (MSBuild)](../VS_csharp/choose-element--msbuild-.md)|Otherwise<br /><br /> When|--|  
|[Import Element (MSBuild)](../VS_csharp/import-element--msbuild-.md)|--|Condition<br /><br /> Project|  
|[ImportGroup Element &#91;MSBuild&#93;](../VS_csharp/importgroup-element.md)|Import|Condition|  
|[Item Element (MSBuild)](../VS_csharp/item-element--msbuild-.md)|*ItemMetaData*|Condition<br /><br /> Exclude<br /><br /> Include<br /><br /> Remove|  
|[ItemDefinitionGroup Element (MSBuild)](../VS_csharp/itemdefinitiongroup-element--msbuild-.md)|*Item*|Condition|  
|[ItemGroup Element (MSBuild)](../VS_csharp/itemgroup-element--msbuild-.md)|*Item*|Condition|  
|[ItemMetaData Element (MSBuild)](../VS_csharp/itemmetadata-element--msbuild-.md)|*Item*|Condition|  
|[OnError Element (MSBuild)](../VS_csharp/onerror-element--msbuild-.md)|--|Condition<br /><br /> ExecuteTargets|  
|[Otherwise Element (MSBuild)](../VS_csharp/otherwise-element--msbuild-.md)|Choose<br /><br /> ItemGroup<br /><br /> PropertyGroup|--|  
|[Output Element (MSBuild)](../VS_csharp/output-element--msbuild-.md)|--|Condition<br /><br /> ItemName<br /><br /> PropertyName<br /><br /> TaskParameter|  
|[Parameter Element &#91;MSBuild&#93;](../VS_csharp/parameter-element.md)|--|Output<br /><br /> ParameterType<br /><br /> Required|  
|[ParameterGroup Element &#91;MSBuild&#93;](../VS_csharp/parametergroup-element.md)|*Parameter*|--|  
|[Project Element (MSBuild)](../VS_csharp/project-element--msbuild-.md)|Choose<br /><br /> Import<br /><br /> ItemGroup<br /><br /> ProjectExtensions<br /><br /> PropertyGroup<br /><br /> Target<br /><br /> UsingTask|DefaultTargets<br /><br /> InitialTargets<br /><br /> ToolsVersion<br /><br /> TreatAsLocalProperty<br /><br /> xmlns|  
|[ProjectExtensions Element (MSBuild)](../VS_csharp/projectextensions-element--msbuild-.md)|--|--|  
|[Property Element (MSBuild)](../VS_csharp/property-element--msbuild-.md)|--|Condition|  
|[PropertyGroup Element (MSBuild)](../VS_csharp/propertygroup-element--msbuild-.md)|*Property*|Condition|  
|[Target Element (MSBuild)](../VS_csharp/target-element--msbuild-.md)|OnError<br /><br /> *Task*|AfterTargets<br /><br /> BeforeTargets<br /><br /> Condition<br /><br /> DependsOnTargets<br /><br /> Inputs<br /><br /> KeepDuplicateOutputs<br /><br /> Name<br /><br /> Outputs<br /><br /> Returns|  
|[Task Element (MSBuild)](../VS_csharp/task-element--msbuild-.md)|Output|Condition<br /><br /> ContinueOnError<br /><br /> *Parameter*|  
|[TaskBody Element (MSBuild)](../VS_csharp/taskbody-element--msbuild-.md)|*Data*|Evaluate|  
|[UsingTask Element (MSBuild)](../VS_csharp/usingtask-element--msbuild-.md)|ParameterGroup<br /><br /> TaskBody|AssemblyFile<br /><br /> AssemblyName<br /><br /> Condition<br /><br /> TaskFactory<br /><br /> TaskName|  
|[When Element (MSBuild)](../VS_csharp/when-element--msbuild-.md)|Choose<br /><br /> ItemGroup<br /><br /> PropertyGroup|Condition|  
  
## See Also  
 [MSBuild Task Reference](../VS_csharp/msbuild-task-reference.md)   
 [MSBuild Conditions](../VS_csharp/msbuild-conditions.md)   
 [MSBuild Reference](../VS_csharp/msbuild-reference.md)   
 [MSBuild](../VS_csharp/msbuild.md)