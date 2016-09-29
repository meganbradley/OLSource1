---
title: "XmlPeek Task"
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
  - "XmlPeek task [MSBuild]"
  - "MSBuild, XmlPeek task"
ms.assetid: 19196031-a3bc-41b5-9c4a-f2572630e179
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# XmlPeek Task
Returns values as specified by XPath Query from an XML file.  
  
## Parameters  
 The following table describes the parameters of the `XmlPeek` task.  
  
|Parameter|Description|  
|---------------|-----------------|  
|`Namespaces`|Optional `String` parameter.<br /><br /> Specifies the namespaces for the XPath query prefixes.|  
|`Query`|Optional `String` parameter.<br /><br /> Specifies the XPath query.|  
|`Result`|Optional <xref:Microsoft.Build.Framework.ITaskItem*>`[]` output parameter.<br /><br /> Contains the results that are returned by this task.|  
|`XmlContent`|Optional `String` parameter.<br /><br /> Specifies the XML input as a string.|  
|`XmlInputPath`|Optional <xref:Microsoft.Build.Framework.ITaskItem*> parameter.<br /><br /> Specifies the XML input as a file path.|  
  
## Remarks  
 In addition to having the parameters that are listed in the table, this task inherits parameters from the <xref:Microsoft.Build.Tasks.TaskExtension*> class, which itself inherits from the <xref:Microsoft.Build.Utilities.Task*> class. For a list of these additional parameters and their descriptions, see [TaskExtension Base Class](../vs140/taskextension-base-class.md).  
  
## See Also  
 [MSBuild Tasks](../vs140/msbuild-tasks.md)   
 [MSBuild Task Reference](../vs140/msbuild-task-reference.md)