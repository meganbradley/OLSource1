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
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# MSBuild Project File Schema Reference
Provides a table of all the [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] XML Schema elements with their available attributes and child elements.  
  
 [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] uses project files to instruct the build engine what to build and how to build it. [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] project files are XML files that adhere to the [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] XML schema. This section documents the XML schema definition (.xsd) file for [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)].  
  
## MSBuild XML Schema Elements  
 The following table lists all of the [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] XML schema elements along with their child elements and attributes.  
  
|Element|Child Elements|Attributes|  
|-------------|--------------------|----------------|  
|[Choose Element (MSBuild)](../vs140/choose-element--msbuild-.md)|Otherwise<br /><br /> When|--|  
|[Import Element (MSBuild)](../vs140/import-element--msbuild-.md)|--|Condition<br /><br /> Project|  
|[ImportGroup Element &#91;MSBuild&#93;](../vs140/importgroup-element.md)|Import|Condition|  
|[Item Element (MSBuild)](../vs140/item-element--msbuild-.md)|*ItemMetaData*|Condition<br /><br /> Exclude<br /><br /> Include<br /><br /> Remove|  
|[ItemDefinitionGroup Element (MSBuild)](../vs140/itemdefinitiongroup-element--msbuild-.md)|*Item*|Condition|  
|[ItemGroup Element (MSBuild)](../vs140/itemgroup-element--msbuild-.md)|*Item*|Condition|  
|[ItemMetaData Element (MSBuild)](../vs140/itemmetadata-element--msbuild-.md)|*Item*|Condition|  
|[OnError Element (MSBuild)](../vs140/onerror-element--msbuild-.md)|--|Condition<br /><br /> ExecuteTargets|  
|[Otherwise Element (MSBuild)](../vs140/otherwise-element--msbuild-.md)|Choose<br /><br /> ItemGroup<br /><br /> PropertyGroup|--|  
|[Output Element (MSBuild)](../vs140/output-element--msbuild-.md)|--|Condition<br /><br /> ItemName<br /><br /> PropertyName<br /><br /> TaskParameter|  
|[Parameter Element &#91;MSBuild&#93;](../vs140/parameter-element.md)|--|Output<br /><br /> ParameterType<br /><br /> Required|  
|[ParameterGroup Element &#91;MSBuild&#93;](../vs140/parametergroup-element.md)|*Parameter*|--|  
|[Project Element (MSBuild)](../vs140/project-element--msbuild-.md)|Choose<br /><br /> Import<br /><br /> ItemGroup<br /><br /> ProjectExtensions<br /><br /> PropertyGroup<br /><br /> Target<br /><br /> UsingTask|DefaultTargets<br /><br /> InitialTargets<br /><br /> ToolsVersion<br /><br /> TreatAsLocalProperty<br /><br /> xmlns|  
|[ProjectExtensions Element (MSBuild)](../vs140/projectextensions-element--msbuild-.md)|--|--|  
|[Property Element (MSBuild)](../vs140/property-element--msbuild-.md)|--|Condition|  
|[PropertyGroup Element (MSBuild)](../vs140/propertygroup-element--msbuild-.md)|*Property*|Condition|  
|[Target Element (MSBuild)](../vs140/target-element--msbuild-.md)|OnError<br /><br /> *Task*|AfterTargets<br /><br /> BeforeTargets<br /><br /> Condition<br /><br /> DependsOnTargets<br /><br /> Inputs<br /><br /> KeepDuplicateOutputs<br /><br /> Name<br /><br /> Outputs<br /><br /> Returns|  
|[Task Element (MSBuild)](../vs140/task-element--msbuild-.md)|Output|Condition<br /><br /> ContinueOnError<br /><br /> *Parameter*|  
|[TaskBody Element (MSBuild)](../vs140/taskbody-element--msbuild-.md)|*Data*|Evaluate|  
|[UsingTask Element (MSBuild)](../vs140/usingtask-element--msbuild-.md)|ParameterGroup<br /><br /> TaskBody|AssemblyFile<br /><br /> AssemblyName<br /><br /> Condition<br /><br /> TaskFactory<br /><br /> TaskName|  
|[When Element (MSBuild)](../vs140/when-element--msbuild-.md)|Choose<br /><br /> ItemGroup<br /><br /> PropertyGroup|Condition|  
  
## See Also  
 [MSBuild Task Reference](../vs140/msbuild-task-reference.md)   
 [MSBuild Conditions](../vs140/msbuild-conditions.md)   
 [MSBuild Reference](../vs140/msbuild-reference.md)   
 [MSBuild](../vs140/msbuild.md)