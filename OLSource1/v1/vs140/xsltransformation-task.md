---
title: "XslTransformation Task"
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
  - "MSBuild, XslTransformation task"
  - "XslTransformation task [MSBuild]"
ms.assetid: 6f3a7d81-3ae3-4703-9a06-870b32b69d80
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# XslTransformation Task
Transforms an XML input by using an XSLT or compiled XSLT and outputs to an output device or a file.  
  
## Parameters  
 The following table describes the parameters of the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> task.  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|Required \<xref:Microsoft.Build.Framework.ITaskItem*><CodeContentPlaceHolder>2\</CodeContentPlaceHolder> parameter.\<br />\<br /> Specifies the output files for the XML transformation.|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> parameter.\<br />\<br /> Specifies the parameters to the XSLT Input document.|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> parameter.\<br />\<br /> Specifies the XML input as a string.|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|Optional \<xref:Microsoft.Build.Framework.ITaskItem*><CodeContentPlaceHolder>8\</CodeContentPlaceHolder> parameter.\<br />\<br /> Specifies the XML input files.|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|Optional \<xref:Microsoft.Build.Framework.ITaskItem*> parameter.\<br />\<br /> Specifies the compiled XSLT.|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> parameter.\<br />\<br /> Specifies the XSLT input as a string.|  
|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|Optional \<xref:Microsoft.Build.Framework.ITaskItem*> parameter.\<br />\<br /> Specifies the XSLT input file.|  
  
## Remarks  
 In addition to having the parameters that are listed in the table, this task inherits parameters from the \<xref:Microsoft.Build.Tasks.TaskExtension*> class, which itself inherits from the \<xref:Microsoft.Build.Utilities.Task*> class. For a list of these additional parameters and their descriptions, see [TaskExtension Base Class](../vs140/taskextension-base-class.md).  
  
## See Also  
 [MSBuild Tasks](../vs140/msbuild-tasks.md)   
 [MSBuild Task Reference](../vs140/msbuild-task-reference.md)