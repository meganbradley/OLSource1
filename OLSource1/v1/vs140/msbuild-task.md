---
title: "MSBuild Task"
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
  - "http://schemas.microsoft.com/developer/msbuild/2003#MSBuild"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
helpviewer_keywords: 
  - "MSBuild task [MSBuild]"
  - "MSBuild, MSBuild task"
ms.assetid: 76577f6c-7669-44ad-a840-363e37a04d34
caps.latest.revision: 36
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# MSBuild Task
Builds [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] projects from another [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] project.  
  
## Parameters  
 The following table describes the parameters of the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> task.  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> parameter.\<br />\<br /> If <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, the projects specified in the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> parameter are built in parallel if it is possible. Default is <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|Required \<xref:Microsoft.Build.Framework.ITaskItem*><CodeContentPlaceHolder>13\</CodeContentPlaceHolder> parameter.\<br />\<br /> Specifies the project files to build.|  
|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> parameter.\<br />\<br /> A semicolon-delimited list of property name/value pairs to apply as global properties to the child project. When you specify this parameter, it is functionally equivalent to setting properties that have the **/property** switch when you build with [MSBuild.exe](../vs140/msbuild-command-line-reference.md). For example:\<br />\<br /> <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>\<br />\<br /> When you pass properties to the project through the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> parameter, [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] creates a new instance of the project even if the project file has already been loaded. When a new instance of the project has been created, [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] treats it as a different project that has different global properties and that can be built in parallel with other instances of the project. For example, a Release configuration could build at the same time as a Debug configuration.|  
|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> parameter.\<br />\<br /> If <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, the relative paths of target output items from the built projects have their paths adjusted to be relative to the calling project. Default is <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> parameter.\<br />\<br /> Specifies the set of global properties to remove.|  
|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> parameter.\<br />\<br /> If <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>, the [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] task invokes each target in the list passed to [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] one at a time, instead of at the same time. Setting this parameter to <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> guarantees that subsequent targets are invoked even if previously invoked targets failed. Otherwise, a build error would stop invocation of all subsequent targets. Default is <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> parameter.\<br />\<br /> If <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>, project files that do not exist on the disk will be skipped. Otherwise, such projects will cause an error.|  
|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> parameter.\<br />\<br /> If <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>, when one of the projects fails to build, no more projects will be built. Currently this is not supported when building in parallel (with multiple processors).|  
|<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> parameter.\<br />\<br /> Specifies a list of targets and properties as <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> item metadata). Separators will be un-escaped before processing. e.g. %3B (an escaped ';') will be treated as if it were an un-escaped ';'.|  
|<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>|Optional \<xref:Microsoft.Build.Framework.ITaskItem*><CodeContentPlaceHolder>39\</CodeContentPlaceHolder> read-only output parameter.\<br />\<br /> Returns the outputs of the built targets from all the project files. Only the outputs from the targets that were specified are returned, not any outputs that may exist on targets that those targets depend on.\<br />\<br /> The <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> parameter also contains the following metadata:\<br />\<br /> -   <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>: The [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] project file that contains the target that set the outputs.\<br />-   <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>: The target that set the outputs. **Note:**  If you want to identify the outputs from each project file or target separately, run the <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> task separately for each project file or target. If you run the <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> task only once to build all the project files, the outputs of all the targets are collected into one array.|  
|<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> parameter.\<br />\<br /> Specifies the target or targets to build in the project files. Use a semicolon to separate a list of target names. If no targets are specified in the <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> task, the default targets specified in the project files are built. **Note:**  The targets must occur in all the project files. If they do not, a build error occurs.|  
|<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> parameter.\<br />\<br /> Specifies the <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> to use when building projects passed to this task.\<br />\<br /> Enables an [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] task to build a project that targets a different version of the [!INCLUDE[dnprdnshort](../vs140/includes/dnprdnshort_md.md)] than the one specified in the project. Valid values are <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>. Default value is <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>55\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> parameter.\<br />\<br /> If <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>, the project will be unloaded once the operation is complete.|  
|<CodeContentPlaceHolder>58\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> parameter.\<br />\<br /> If <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>, the cached result will be returned, if present. If theMSBuild task is run, its result will be cached in a scope (ProjectFileName, GlobalProperties)[TargetNames]\<br />\<br /> as a list of build items|  
  
## Remarks  
 In addition to the parameters listed above, this task inherits parameters from the \<xref:Microsoft.Build.Tasks.TaskExtension*> class, which itself inherits from the \<xref:Microsoft.Build.Utilities.Task*> class. For a list of these additional parameters and their descriptions, see [TaskExtension Base Class](../vs140/taskextension-base-class.md).  
  
 Unlike using the [Exec Task](../vs140/exec-task.md) to start MSBuild.exe, this task uses the same [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] process to build the child projects. The list of already-built targets that can be skipped is shared between the parent and child builds. This task is also faster because no new [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] process is created.  
  
 This task can process not only project files but also solution files.  
  
 Any configuration that is required by [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] to enable projects to build at the same time, even if the configuration involves remote infrastructure (for example, ports, protocols, timeouts, retries, and so forth), must be made configurable by using a configuration file. When possible, configuration items should be able to be specified as task parameters on the <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> task.  
  
 Beginning in [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] 3.5, Solution projects now surface TargetOutputs from all of the sub-projects it builds.  
  
## Passing Properties to Projects  
 In versions of [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] prior to [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] 3.5, passing different sets of properties to different projects listed in the [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] item was challenging. If you used the Properties attribute of the [MSBuild Task](../vs140/msbuild-task.md), then its setting was applied to all of the projects being built unless you batched the [MSBuild Task](../vs140/msbuild-task.md) and conditionally provided different properties for each project in the item list.  
  
 [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] 3.5, however, provides two new reserved metadata items, Properties and AdditionalProperties, that provide you a flexible way to pass different properties for different projects being built using the [MSBuild Task](../vs140/msbuild-task.md).  
  
> [!NOTE]
>  These new metadata items are applicable only to items passed in the Projects attribute of the [MSBuild Task](../vs140/msbuild-task.md).  
  
## Multi-Processor Build Benefits  
 One of the major benefits of using this new metadata occurs when you build your projects in parallel on a multi-processor system. The metadata allows you to consolidate all projects into a single [MSBuild Task](../vs140/msbuild-task.md) call without having to perform any batching or conditional [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] tasks. And when you call only a single [MSBuild Task](../vs140/msbuild-task.md), all of the projects listed in the Projects attribute will be built in parallel. (Only, however, if the <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> attribute is present in the [MSBuild Task](../vs140/msbuild-task.md).) For more information, see [Building Multiple Projects in Parallel](../vs140/building-multiple-projects-in-parallel-with-msbuild.md).  
  
## Properties Metadata  
 A common scenario is when you are building multiple solution files using the [MSBuild Task](../vs140/msbuild-task.md), only using different build configurations. You may want to build solution a1 using the Debug configuration and solution a2 using the Release configuration. In [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] 2.0, this project file would look like the following:  
  
> [!NOTE]
>  In the following example, "…" represents additional solution files.  
  
### a.proj  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 By using the Properties metadata, however, you can simplify this to use a single [MSBuild Task](../vs140/msbuild-task.md), as shown by the following:  
  
### a.proj  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 \- or -  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## AdditionalProperties Metadata  
 Consider the following scenario where you are building two solution files using the [MSBuild Task](../vs140/msbuild-task.md), both using the Release configuration, but one using the x86 architecture and the other using the ia64 architecture. In [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] 2.0, you would need to create multiple instances of the [MSBuild Task](../vs140/msbuild-task.md): one to build the project using the Release configuration with the x86 Architecture, the other using the Release configuration with the ia64 architecture. Your project file would look like the following:  
  
### a.proj  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 By using the AdditionalProperties metadata, you can simplify this to use a single [MSBuild Task](../vs140/msbuild-task.md) by using the following:  
  
### a.proj  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
## Example  
 The following example uses the <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> task to build the projects specified by the <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> item collection. The resulting target outputs are stored in the <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> item collection.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
## See Also  
 [MSBuild Tasks](../vs140/msbuild-tasks.md)   
 [MSBuild Task Reference](../vs140/msbuild-task-reference.md)