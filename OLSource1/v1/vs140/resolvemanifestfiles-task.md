---
title: "ResolveManifestFiles Task"
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
  - "ResolveManifestFiles task [MSBuild]"
  - "MSBuild, ResolveManifestFiles task"
ms.assetid: e1e14f67-9b69-433f-94d4-a783a68676b2
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ResolveManifestFiles Task
Resolves the following items in the build process to files for manifest generation: built items, dependencies, satellites, content, debug symbols, and documentation.  
  
## Parameters  
 The following table describes the parameters of the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> task.  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|Optional \<xref:Microsoft.Build.Framework.ITaskItem*> parameter.\<br />\<br /> Specifies the name of the deployment manifest.|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|Optional \<xref:Microsoft.Build.Framework.ITaskItem*> parameter.\<br />\<br /> Specifies the managed assembly or ClickOnce manifest reference that is the entry point to the manifest.|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|Optional \<xref:Microsoft.Build.Framework.ITaskItem*><CodeContentPlaceHolder>4\</CodeContentPlaceHolder> parameter.\<br />\<br /> Specifies the extra files.|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|Optional \<xref:Microsoft.Build.Framework.ITaskItem*><CodeContentPlaceHolder>6\</CodeContentPlaceHolder> parameter.\<br />\<br /> Specifies the managed assemblies.|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|Optional \<xref:Microsoft.Build.Framework.ITaskItem*><CodeContentPlaceHolder>8\</CodeContentPlaceHolder> parameter.\<br />\<br /> Specifies the native assemblies.|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|Optional \<xref:Microsoft.Build.Framework.ITaskItem*><CodeContentPlaceHolder>10\</CodeContentPlaceHolder> output parameter.\<br />\<br /> Specifies the generated assemblies.|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|Optional \<xref:Microsoft.Build.Framework.ITaskItem*> output parameter.\<br />\<br /> Specifies the output deployment manifest entry point.|  
|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|Optional \<xref:Microsoft.Build.Framework.ITaskItem*> output parameter.\<br />\<br /> Specifies the output entry point.|  
|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|Optional \<xref:Microsoft.Build.Framework.ITaskItem*><CodeContentPlaceHolder>14\</CodeContentPlaceHolder> output parameter.\<br />\<br /> Specifies the output files.|  
|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|Optional \<xref:Microsoft.Build.Framework.ITaskItem*><CodeContentPlaceHolder>16\</CodeContentPlaceHolder> parameter.\<br />\<br /> Specifies the publish files.|  
|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|Optional \<xref:Microsoft.Build.Framework.ITaskItem*><CodeContentPlaceHolder>18\</CodeContentPlaceHolder> parameter.\<br />\<br /> Specifies the satellite assemblies.|  
|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> parameter.\<br />\<br /> If <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, the manifests are signed.|  
|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> parameter.\<br />\<br /> Specifies the target culture for satellite assemblies.|  
|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> parameter.\<br />\<br /> Specifies the target .NET Framework version.|  
  
## Remarks  
 In addition to having the parameters that are listed in the table, this task inherits parameters from the \<xref:Microsoft.Build.Tasks.TaskExtension*> class, which itself inherits from the \<xref:Microsoft.Build.Utilities.Task*> class. For a list of these additional parameters and their descriptions, see [TaskExtension Base Class](../vs140/taskextension-base-class.md).  
  
## See Also  
 [MSBuild Tasks](../vs140/msbuild-tasks.md)   
 [MSBuild Task Reference](../vs140/msbuild-task-reference.md)