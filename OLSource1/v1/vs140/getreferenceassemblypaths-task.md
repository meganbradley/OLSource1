---
title: "GetReferenceAssemblyPaths Task"
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
ms.assetid: 178ef49c-5dee-405b-a14b-a37f41dc0609
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# GetReferenceAssemblyPaths Task
Returns the reference assembly paths of the various frameworks.  
  
## Parameters  
 The following table describes the parameters of the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> task.  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> output parameter.\<br />\<br /> Returns the path, based on the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> parameter. If the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is null or empty, this path will be <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> output parameter.\<br />\<br /> Returns the path, based on the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> parameter, without considering the profile part of the moniker. If the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is null or empty, this path will be <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> parameter.\<br />\<br /> Specifies the target framework moniker that is associated with the reference assembly paths.|  
|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> parameter.\<br />\<br /> Specifies the root path to use to generate the reference assembly path.|  
|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|Optional [Boolean](assetId:///Boolean?qualifyHint=False&autoUpgrade=True) parameter.\<br />\<br /> If <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, bypasses the basic checks that <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> performs by default to ensure that certain runtime frameworks are installed, depending on the target framework.|  
|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> output parameter.\<br />\<br /> Specifies the display name for the target framework moniker.|  
  
## Remarks  
 In addition to having the parameters that are listed in the table, this task inherits parameters from the \<xref:Microsoft.Build.Tasks.TaskExtension*> class, which itself inherits from the \<xref:Microsoft.Build.Utilities.Task*> class. For a list of these additional parameters and their descriptions, see [TaskExtension Base Class](../vs140/taskextension-base-class.md).  
  
## See Also  
 [MSBuild Tasks](../vs140/msbuild-tasks.md)   
 [MSBuild Task Reference](../vs140/msbuild-task-reference.md)