---
title: "CreateVisualBasicManifestResourceName Task"
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
  - "MSBuild, CreateVisualBasicManifestResourceName task"
  - "CreateVisualBasicManifestResourceName task [MSBuild]"
ms.assetid: 251c47b9-de32-414b-a138-bf45290af12e
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CreateVisualBasicManifestResourceName Task
Creates a [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)]-style manifest name from a given .resx file name or other resource.  
  
## Parameters  
 The following table describes the parameters of the [CreateVisualBasicManifestResourceName Task](../vs140/createvisualbasicmanifestresourcename-task.md).  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>|\<xref:Microsoft.Build.Framework.ITaskItem*> <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> output read-only parameter.\<br />\<br /> The resulting manifest names.|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|Required <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> parameter.\<br />\<br /> The name of the resource file from which to create the [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] manifest name.|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> parameter.\<br />\<br /> The root namespace of the resource file, typically taken from the project file. May be <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> parameter.\<br />\<br /> If <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, the culture name is added as a directory name just before the manifest resource name. Default value is <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|Optional read-only <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> output parameter.\<br />\<br /> Returns the name of the resource file that now includes the manifest resource name.|  
  
## Remarks  
 The [CreateVisualBasicManifestResourceName Task](../vs140/createvisualbasicmanifestresourcename-task.md) determines the appropriate manifest resource name to assign to a given .resx or other resource file. The task provides a logical name to a resource file, and then attaches it to an output parameter as metadata.  
  
 In addition to the parameters listed above, this task inherits parameters from the \<xref:Microsoft.Build.Tasks.TaskExtension*> class, which itself inherits from the \<xref:Microsoft.Build.Utilities.Task*> class. For a list of these additional parameters and their descriptions, see [TaskExtension Base Class](../vs140/taskextension-base-class.md).  
  
## See Also  
 [MSBuild Tasks](../vs140/msbuild-tasks.md)   
 [MSBuild Task Reference](../vs140/msbuild-task-reference.md)