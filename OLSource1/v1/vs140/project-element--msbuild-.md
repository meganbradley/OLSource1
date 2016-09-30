---
title: "Project Element (MSBuild)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "http://schemas.microsoft.com/developer/msbuild/2003#Project"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
helpviewer_keywords: 
  - "ToolsVersion attribute [MSBuild]"
  - "<Project> element [MSBuild]"
  - "Project element [MSBuild]"
ms.assetid: d1cda56a-dbef-4109-9201-39e962e3f653
caps.latest.revision: 32
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Project Element (MSBuild)
Required root element of an [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] project file.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Attributes and Elements  
 The following sections describe attributes, child elements, and parent elements.  
  
### Attributes  
  
|Attribute|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|Optional attribute.\<br />\<br /> The default target or targets to be the entry point of the build if no target has been specified. Multiple targets are semi-colon (;) delimited.\<br />\<br /> If no default target is specified in either the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> attribute or the [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] command line, the engine executes the first target in the project file after the [Import](../vs140/import-element--msbuild-.md) elements have been evaluated.|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|Optional attribute.\<br />\<br /> The initial target or targets to be run before the targets specified in the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> attribute or on the command line. Multiple targets are semi-colon (;) delimited.|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|Optional attribute.\<br />\<br /> The version of the toolset MSBuild uses to determine the values for $(MSBuildBinPath) and $(MSBuildToolsPath).|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|Optional attribute.\<br />\<br /> Property names that won't be considered to be global. This attribute prevents specific command-line properties from overriding property values that are set in a project or targets file and all subsequent imports. Multiple properties are semi-colon (;) delimited.\<br />\<br /> Normally, global properties override property values that are set in the project or targets file. If the property is listed in the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> value, the global property value doesn't override property values that are set in that file and any subsequent imports. For more information, see [How to: Build the Same Source Files with Different Options](../vs140/how-to--build-the-same-source-files-with-different-options.md). **Note:**  You set global properties  at a command prompt by using the **/property** (or **/p**) switch. You can also set or modify global properties for child projects in a multi-project build by using the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> attribute of the MSBuild task. For more information, see [MSBuild Task](../vs140/msbuild-task.md).|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|Required attribute.\<br />\<br /> The <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> attribute must have the value of "http://schemas.microsoft.com/developer/msbuild/2003".|  
  
### Child Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[Choose](../vs140/choose-element--msbuild-.md)|Optional element.\<br />\<br /> Evaluates child elements to select one set of <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> elements and/or <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> elements to evaluate.|  
|[Import](../vs140/import-element--msbuild-.md)|Optional element.\<br />\<br /> Enables a project file to import another project file. There may be zero or more <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> elements in a project.|  
|[ItemGroup](../vs140/itemgroup-element--msbuild-.md)|Optional element.\<br />\<br /> A grouping element for individual items. Items are specified by using the [Item](../vs140/item-element--msbuild-.md) element. There may be zero or more <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> elements in a project.|  
|[ProjectExtensions](../vs140/projectextensions-element--msbuild-.md)|Optional element.\<br />\<br /> Provides a way to persist non-[!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] information in an [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] project file. There may be zero or one <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> elements in a project.|  
|[PropertyGroup](../vs140/propertygroup-element--msbuild-.md)|Optional element.\<br />\<br /> A grouping element for individual properties. Properties are specified by using the [Property](../vs140/property-element--msbuild-.md) element. There may be zero or more <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> elements in a project.|  
|[Target](../vs140/target-element--msbuild-.md)|Optional element.\<br />\<br /> Contains a set of tasks for [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] to sequentially execute. Tasks are specified by using the [Task](../vs140/task-element--msbuild-.md) element. There may be zero or more <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> elements in a project.|  
|[UsingTask](../vs140/usingtask-element--msbuild-.md)|Optional element.\<br />\<br /> Provides a way to register tasks in [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)]. There may be zero or more <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> elements in a project.|  
  
### Parent Elements  
 None.  
  
## See Also  
 [How To: Specify Which Target to Build First](../vs140/how-to--specify-which-target-to-build-first.md)   
 [MSBuild Command Line Reference](../vs140/msbuild-command-line-reference.md)   
 [MSBuild File Format](../vs140/msbuild-project-file-schema-reference.md)   
 [MSBuild](../vs140/msbuild.md)