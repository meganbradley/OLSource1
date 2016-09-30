---
title: "AssignProjectConfiguration Task"
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
ms.assetid: 09633a0b-8f6f-4aba-8058-7cb4d13ce2c0
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AssignProjectConfiguration Task
This task accepts a list configuration strings and assigns them to specified projects.  
  
## Task Parameters  
 The following table describes the parameters of the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> task.  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> output parameter.\<br />\<br /> Contains an XML string containing a project configuration for each project. The configurations are assigned to the named projects.|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> output parameter.\<br />\<br /> Contains a semicolon-delimited list of mappings from the platform names used\<br />\<br /> by most types to those used by .vcxproj files.\<br />\<br /> For example:\<br />\<br /> <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|Optional\<br />\<br /> <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> output parameter.\<br />\<br /> Contains a semicolon-delimited list of mappings from .vcxproj platform names to the platform names use by most types.\<br />\<br /> For example:\<br />\<br /> <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> output parameter.\<br />\<br /> Contains the configuration for the current project.|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> output parameter.\<br />\<br /> Contains the platform for the current project.|  
|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> output parameter.\<br />\<br /> Contains a flag indicating that references should be built even if they were disabled in the project configuration.|  
|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> output parameter.\<br />\<br /> Contains a flag indicating if the parent configuration and platform should be unset.|  
|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> output parameter.\<br />\<br /> Contains the output type for the project.|  
|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> output parameter.\<br />\<br /> Contains a flag indicating if the build should use the default mappings to resolve the configuration and platform of the passed in project references.|  
|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|Optional \<xref:Microsoft.Build.Framework.ITaskItem*><CodeContentPlaceHolder>22\</CodeContentPlaceHolder> output parameter.\<br />\<br /> Contains the list of resolved reference paths.|  
|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|Optional \<xref:Microsoft.Build.Framework.ITaskItem*><CodeContentPlaceHolder>24\</CodeContentPlaceHolder> output parameter.\<br />\<br /> Contains the list of project reference items that could not be resolved using the pre-resolved list of outputs.|  
  
## Remarks  
 In addition to the parameters listed above, this task inherits parameters from the \<xref:Microsoft.Build.Tasks.TaskExtension*> class, which itself inherits from the \<xref:Microsoft.Build.Utilities.Task*> class. For a list of these additional parameters and their descriptions, see [TaskExtension Base Class](../vs140/taskextension-base-class.md).  
  
## See Also  
 [MSBuild Tasks](../vs140/msbuild-tasks.md)   
 [MSBuild Task Reference](../vs140/msbuild-task-reference.md)