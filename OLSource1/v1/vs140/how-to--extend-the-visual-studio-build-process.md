---
title: "How to: Extend the Visual Studio Build Process"
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
  - "MSBuild, overriding predefined targets"
  - "MSBuild, overriding DependsOn properties"
  - "MSBuild, extending Visual Studio builds"
  - "MSBuild, DependsOn properties"
ms.assetid: cb077613-4a59-41b7-96ec-d8516689163c
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Extend the Visual Studio Build Process
The [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] build process is defined by a series of [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] .targets files that are imported into your project file. One of these imported files, Microsoft.Common.targets, can be extended to allow you to run custom tasks at several points in the build process. This topic explains two methods you can use to extend the [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] build process:  
  
-   Overriding specific predefined targets defined in Microsoft.Common.targets.  
  
-   Overriding the "DependsOn" properties defined in Microsoft.Common.targets.  
  
## Overriding Predefined Targets  
 The Microsoft.Common.targets file contains a set of predefined empty targets that are called before and after some of the major targets in the build process. For example, [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] calls the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> target before the main <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> target and the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> target after the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> target. By default, the empty targets in Microsoft.Common.targets do nothing, but you can override their default behavior by defining the targets you want in a project file that imports Microsoft.Common.targets. By doing this, you can use [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] tasks to give you more control over the build process.  
  
#### To override a predefined target  
  
1.  Identify a predefined target in Microsoft.Common.targets that you want to override. See the table below for the complete list of targets that you can safely override.  
  
2.  Define the target or targets at the end of your project file, immediately before the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> tag. For example:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
3.  Build the project file.  
  
 The following table shows all of the targets in Microsoft.Common.targets that you can safely override.  
  
|Target Name|Description|  
|-----------------|-----------------|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|Tasks inserted in one of these targets run before or after core compilation is done. Most customizations are done in one of these two targets.|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|Tasks inserted in one of these targets will run before or after everything else in the build. **Note:**  The <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> targets are already defined in comments at the end of most project files. This allows you to easily add pre- and post-build events to your project file.|  
|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|Tasks inserted in one of these targets run before or after the core rebuild functionality is invoked. The order of target execution in Microsoft.Common.targets is: <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, and then <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|Tasks inserted in one of these targets run before or after the core clean functionality is invoked.|  
|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|Tasks inserted in one of these targets run before or after the core publish functionality is invoked.|  
|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|Tasks inserted in one of these targets run before or after assembly references are resolved.|  
|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|Tasks inserted in one of these targets run before or after resources are generated.|  
  
## Overriding "DependsOn" Properties  
 Overriding predefined targets is an easy way to extend the build process, but, because [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] evaluates the definition of targets sequentially, there is no way to prevent another project that imports your project from overriding the targets you already have overridden. So, for example, the last <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> target defined in the project file, after all other projects have been imported, will be the one that is used during the build.  
  
 You can guard against unintended overrides of targets by overriding the "DependsOn" properties that are used in <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> attributes throughout the Microsoft.Common.targets file. For example, the <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> target contains a <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> attribute value of <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>. Consider:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 This piece of XML indicates that before the <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> target can run, all the targets specified in the <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> property must run first. The <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> property is defined as:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 You can override this property value by declaring another property named <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> at the end of your project file. By including the previous <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> property in the new property, you can add new targets to the beginning and end of the target list. For example:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Projects that import your project files can override these properties without overwriting the customizations that you have made.  
  
#### To override a "DependsOn" property  
  
1.  Identify a predefined "DependsOn" property in Microsoft.Common.targets that you want to override. See the table below for a list of the commonly overridden "DependsOn" properties.  
  
2.  Define another instance of the property or properties at the end of your project file. Include the original property, for example <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>, in the new property.  
  
3.  Define your custom targets before or after the property definition.  
  
4.  Build the project file.  
  
### Commonly Overridden "DependsOn" Properties  
  
|Property Name|Description|  
|-------------------|-----------------|  
|<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>|The property to override if you want to insert custom targets before or after the entire build process.|  
|<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>|The property to override if you want to clean up output from your custom build process.|  
|<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>|The property to override if you want to insert custom processes before or after the compilation step.|  
  
## See Also  
 [Visual Studio Integration (MSBuild)](../vs140/visual-studio-integration--msbuild-.md)   
 [MSBuild Concepts](../vs140/msbuild-concepts.md)   
 [MSBuild .Targets Files](../vs140/msbuild-.targets-files.md)