---
title: "XmlPoke Task"
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
  - "XmlPoke task [MSBuild]"
  - "MSBuild, XmlPoke task"
ms.assetid: 6ba1953c-be3b-4df8-8561-e133408f8270
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# XmlPoke Task
Sets values as specified by an XPath query into an XML file.  
  
## Parameters  
 The following table describes the parameters of the `XmlPoke` task.  
  
|Parameter|Description|  
|---------------|-----------------|  
|`Namespaces`|Optional `String` parameter.<br /><br /> Specifies the namespaces for XPath query prefixes.|  
|`Query`|Optional `String` parameter.<br /><br /> Specifies the XPath query.|  
|`Value`|Required <xref:Microsoft.Build.Framework.ITaskItem*> parameter.<br /><br /> Specifies the output file.|  
|`XmlInputPath`|Optional <xref:Microsoft.Build.Framework.ITaskItem*> parameter.<br /><br /> Specifies the XML input as a file path.|  
  
## Remarks  
 In addition to having the parameters that are listed in the table, this task inherits parameters from the <xref:Microsoft.Build.Tasks.TaskExtension*> class, which itself inherits from the <xref:Microsoft.Build.Utilities.Task*> class. For a list of these additional parameters and their descriptions, see [TaskExtension Base Class](../VS_csharp/taskextension-base-class.md).  
  
## See Also  
 [MSBuild Tasks](../VS_csharp/msbuild-tasks.md)   
 [MSBuild Task Reference](../VS_csharp/msbuild-task-reference.md)