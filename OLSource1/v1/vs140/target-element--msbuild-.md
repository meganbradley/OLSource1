---
title: "Target Element (MSBuild)"
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
  - "http://schemas.microsoft.com/developer/msbuild/2003#Target"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
helpviewer_keywords: 
  - "Target element [MSBuild]"
  - "<Target> element [MSBuild]"
ms.assetid: 350f6fc2-86b3-45f2-a31e-ece0e6bd4dca
caps.latest.revision: 38
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Target Element (MSBuild)
Contains a set of tasks for [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] to execute sequentially.  
  
 \<Project>  
 \<Target>  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Attributes and Elements  
 The following sections describe attributes, child elements, and parent elements.  
  
### Attributes  
  
|Attribute|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|Required attribute.\<br />\<br /> The name of the target.|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|Optional attribute.\<br />\<br /> The condition to be evaluated. If the condition evaluates to <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, the target will not execute the body of the target or any targets that are set in the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> attribute. For more information about conditions, see [MSBuild Conditions](../vs140/msbuild-conditions.md).|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|Optional attribute.\<br />\<br /> The files that form inputs into this target. Multiple files are separated by semicolons. The timestamps of the files will be compared with the timestamps of files in <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> to determine whether the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is up to date. For more information, see [Incremental Builds](../vs140/incremental-builds.md), [How to: Build Incrementally](../vs140/how-to--build-incrementally.md), and [MSBuild Transforms](../vs140/msbuild-transforms.md).|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|Optional attribute.\<br />\<br /> The files that form outputs into this target. Multiple files are separated by semicolons. The timestamps of the files will be compared with the timestamps of files in <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> to determine whether the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is up to date. For more information, see [Incremental Builds](../vs140/incremental-builds.md), [How to: Build Incrementally](../vs140/how-to--build-incrementally.md), and [MSBuild Transforms](../vs140/msbuild-transforms.md).|  
|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|Optional attribute.\<br />\<br /> The set of items that will be made available to tasks that invoke this target, for example, MSBuild tasks. Multiple targets are separated by semicolons. If the targets in the file have no <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> attributes, the Outputs attributes are used instead for this purpose.|  
|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|Optional Boolean attribute.\<br />\<br /> If <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, multiple references to the same item in the target's Returns are recorded.  By default, this attribute is <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|Optional attribute.\<br />\<br /> A semicolon-separated list of target names.  When specified, indicates that this target should run before the specified target or targets. This lets the project author extend an existing set of targets without modifying them directly. For more information, see [Target Build Order](../vs140/target-build-order.md).|  
|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|Optional attribute.\<br />\<br /> A semicolon-separated list of target names. When specified, indicates that this target should run after the specified target or targets. This lets the project author extend an existing set of targets without modifying them directly. For more information, see [Target Build Order](../vs140/target-build-order.md).|  
|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|Optional attribute.\<br />\<br /> The targets that must be executed before this target can be executed or top-level dependency analysis can occur. Multiple targets are separated by semicolons.|  
|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|Optional attribute.\<br />\<br /> An identifier that can identify or order system and user elements.|  
  
### Child Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[Task](../vs140/task-element--msbuild-.md)|Creates and executes an instance of an [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] task. There may be zero or more tasks in a target.|  
|[PropertyGroup](../vs140/propertygroup-element--msbuild-.md)|Contains a set of user-defined <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> elements. Starting in the .NET Framework 3.5, a <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> element may contain <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> elements.|  
|[ItemGroup](../vs140/itemgroup-element--msbuild-.md)|Contains a set of user-defined <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> elements. Starting in the .NET Framework 3.5, a <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> element may contain <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> elements. For more information, see [MSBuild Items](../vs140/msbuild-items.md).|  
|[OnError](../vs140/onerror-element--msbuild-.md)|Causes one or more targets to execute if the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> attribute is ErrorAndStop (or <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>) for a failed task. There may be zero or more <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> elements in a target. If <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> elements are present, they must be the last elements in the <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> element.\<br />\<br /> For information about the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> attribute, see [Task Element (MSBuild)](../vs140/task-element--msbuild-.md).|  
  
### Parent Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[Project](../vs140/project-element--msbuild-.md)|Required root element of an [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] project file.|  
  
## Remarks  
 The first target to execute is specified at run time. Targets can have dependencies on other targets. For example, a target for deployment depends on a target for compilation. The [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] engine executes dependencies in the order in which they appear in the <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> attribute, from left to right. For more information, see [MSBuild Targets](../vs140/msbuild-targets.md).  
  
 A target is only executed once during a build, even if more than one target has a dependency on it.  
  
 If a target is skipped because its <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> attribute evaluates to <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>, it can still be executed if it is invoked later in the build and its <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> attribute evaluates to <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> at that time.  
  
 Before MSBuild 4, <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> returned any items that were specified in the <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> attribute.  To do this, MSBuild had to record these items in case tasks later in the build requested them. Because there was no way to indicate which targets had outputs that callers would require, MSBuild accumulated all items from all <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> on all invoked <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>s. This lead to scaling problems for builds that had a large number of output items.  
  
 If the user specifies a <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> on any <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> element in a project, then only those <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>s that have a <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> attribute record those items.  
  
 A <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> may contain both an <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> attribute and a <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> attribute.  <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> is used with <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> to determine whether the target is up-to-date. <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>, if present, overrides the value of <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> to determine which items are returned to callers.  If <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> is not present, then <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> will be made available to callers except in the case described earlier.  
  
 Before MSBuild 4, any time that a <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> included multiple references to the same item in its <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>, those duplicate items would be recorded. In very large builds that had a large number of outputs and many project interdependencies, this would cause a large amount of memory to be wasted because the duplicate items were not of any use. When the <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> attribute is set to <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>, these duplicates are recorded.  
  
## Example  
 The following code example shows a <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> element that executes the <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> task.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [MSBuild Targets](../vs140/msbuild-targets.md)   
 [MSBuild Project File Schema Reference](../vs140/msbuild-project-file-schema-reference.md)