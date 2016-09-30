---
title: "ResolveKeySource Task"
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
  - "http://schemas.microsoft.com/developer/msbuild/2003#ResolveKeySource"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
helpviewer_keywords: 
  - "ResolveKeySource task [MSBuild]"
  - "MSBuild, ResolveKeySource task"
ms.assetid: 449f06c2-e9aa-4236-ab1e-c45c25452b2e
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ResolveKeySource Task
Determines the strong name key source.  
  
## Task Parameters  
 The following table describes the parameters of the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> task.  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> parameter.\<br />\<br /> Gets or sets the amount of time, in seconds, to display the count down message.|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> parameter.\<br />\<br /> Gets or sets the amount of time, in seconds, to wait before closing the password prompt dialog.|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> parameter.\<br />\<br /> Gets or sets the path of the certificate file.|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> parameter.\<br />\<br /> Gets or sets the certificate thumbprint.|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> parameter.\<br />\<br /> Gets or sets the path of the key file.|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> output parameter.\<br />\<br /> Gets or sets the resolved key container.|  
|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> output parameter.\<br />\<br /> Gets or sets the resolved key file.|  
|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> output parameter.\<br />\<br /> Gets or sets the resolved certificate thumbprint.|  
|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> parameter.\<br />\<br /> If <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, show the import dialog despite previous failures.|  
|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> parameter.\<br />\<br /> Gets or sets a Boolean value that specifies whether the password prompt dialog should not auto-close.|  
  
## Remarks  
 In addition to the parameters listed above, this task inherits parameters from the \<xref:Microsoft.Build.Tasks.TaskExtension*> class, which itself inherits from the \<xref:Microsoft.Build.Utilities.Task*> class. For a list of these additional parameters and their descriptions, see [TaskExtension Base Class](../vs140/taskextension-base-class.md).  
  
## See Also  
 [MSBuild Tasks](../vs140/msbuild-tasks.md)   
 [MSBuild Task Reference](../vs140/msbuild-task-reference.md)