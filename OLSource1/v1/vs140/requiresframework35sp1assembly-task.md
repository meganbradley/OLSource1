---
title: "RequiresFramework35SP1Assembly Task"
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
  - "RequiresFramework35SP1Assembly task [MSBuild]"
  - "MSBuild, RequiresFramework35SP1Assembly task"
ms.assetid: 755c018a-8a8b-4c94-8aee-3f171fc419e5
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# RequiresFramework35SP1Assembly Task
Determines whether the application requires the .NET Framework 3.5 SP1.  
  
## Parameters  
 The following table describes the parameters of the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> task.  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|Optional \<xref:Microsoft.Build.Framework.ITaskItem*><CodeContentPlaceHolder>2\</CodeContentPlaceHolder> parameter.\<br />\<br /> Specifies the assemblies that are referenced in the application.|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> parameter.\<br />\<br /> If <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, creates a shortcut icon on the desktop during installation.|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|Optional \<xref:Microsoft.Build.Framework.ITaskItem*> parameter.\<br />\<br /> Specifies the manifest file name for the application.|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|Optional \<xref:Microsoft.Build.Framework.ITaskItem*> parameter.\<br />\<br /> Specifies the assembly that should be executed when the application is run.|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> parameter.\<br />\<br /> Specifies the Web site that is displayed in dialog boxes that are encountered during ClickOnce installations.|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|Optional \<xref:Microsoft.Build.Framework.ITaskItem*><CodeContentPlaceHolder>11\</CodeContentPlaceHolder> parameter.\<br />\<br /> Specifies the list of files that will be deployed when the application is published.|  
|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|Optional \<xref:Microsoft.Build.Framework.ITaskItem*><CodeContentPlaceHolder>13\</CodeContentPlaceHolder> parameter.\<br />\<br /> Specifies the assemblies that are referenced in the project.|  
|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> output parameter.\<br />\<br /> If <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, the application requires the .NET Framework 3.5 SP1.|  
|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> output parameter.\<br />\<br /> If <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, the ClickOnce manifests are signed.|  
|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> parameter.\<br />\<br /> Specifies the name of the folder on the **Start** menu in which the application will be installed.|  
|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> parameter.\<br />\<br /> Specifies the version of the .NET Framework that this application targets.|  
  
## Remarks  
 In addition to having the parameters that are listed in the table, this task inherits parameters from the \<xref:Microsoft.Build.Tasks.TaskExtension*> class, which itself inherits from the \<xref:Microsoft.Build.Utilities.Task*> class. For a list of these additional parameters and their descriptions, see [TaskExtension Base Class](../vs140/taskextension-base-class.md).  
  
## See Also  
 [MSBuild Tasks](../vs140/msbuild-tasks.md)   
 [MSBuild Task Reference](../vs140/msbuild-task-reference.md)