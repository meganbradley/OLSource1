---
title: "FormatVersion Task"
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
ms.assetid: 96e692f6-b581-46ca-8cc9-441a1861e371
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# FormatVersion Task
Appends the revision number to the version number.  
  
-   Case #1: Input: Version=\<undefined>;  Revision=\<don't care>;   Output: OutputVersion="1.0.0.0"  
  
-   Case #2: Input: Version="1.0.0.*"  Revision="5"  Output: OutputVersion="1.0.0.5"  
  
-   Case #3: Input: Version="1.0.0.0"  Revision=\<don't care>;  Output: OutputVersion="1.0.0.0"  
  
## Parameters  
 The following table describes the parameters of the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> task.  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> parameter.\<br />\<br /> Specifies the format type.\<br />\<br /> -   "Version" = version.\<br />-   "Path" = replace "." with "_";|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> output parameter.\<br />\<br /> Specifies the output version that includes the revision number.|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> parameter.\<br />\<br /> Specifies the revision to append to the version.|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> parameter.\<br />\<br /> Specifies the version number string to format.|  
  
## Remarks  
 In addition to having the parameters that are listed in the table, this task inherits parameters from the \<xref:Microsoft.Build.Tasks.TaskExtension*> class, which itself inherits from the \<xref:Microsoft.Build.Utilities.Task*> class. For a list of these additional parameters and their descriptions, see [TaskExtension Base Class](../vs140/taskextension-base-class.md).  
  
## See Also  
 [MSBuild Tasks](../vs140/msbuild-tasks.md)   
 [MSBuild Task Reference](../vs140/msbuild-task-reference.md)