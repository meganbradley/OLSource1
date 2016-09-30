---
title: "LC Task"
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
  - "http://schemas.microsoft.com/developer/msbuild/2003#LC"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
helpviewer_keywords: 
  - "MSBuild, LC task"
  - "LC task [MSBuild]"
ms.assetid: d5a53472-6f2a-42b8-a6db-593ca99c9790
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# LC Task
Wraps LC.exe, which generates a .license file from a .licx file. For more information on LC.exe, see [License Compiler (Lc.exe)](assetId:///2de803b8-495e-4982-b209-19a72aba0460).  
  
## Parameters  
 The following table describes the paramters for the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> task.  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|Required \<xref:Microsoft.Build.Framework.ITaskItem*> parameter.\<br />\<br /> Specifies the executable for which the .licenses files are generated.|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> parameter.\<br />\<br /> Suppresses the Microsoft startup banner display.|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> parameter.\<br />\<br /> Specifies the directory in which to place the output .licenses files.|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|Optional \<xref:Microsoft.Build.Framework.ITaskItem*> output parameter.\<br />\<br /> Specifies the name of the .licenses file. If you do not specify a name, the name of the .licx file is used and the .licenses file is placed in the directory that contains the .licx file.|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|Optional \<xref:Microsoft.Build.Framework.ITaskItem*><CodeContentPlaceHolder>9\</CodeContentPlaceHolder> parameter.\<br />\<br /> Specifies the referenced components to load when generating the .license file.|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> parameter.\<br />\<br /> Specifies the path to the SDK tools, such as resgen.exe.|  
|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|Required \<xref:Microsoft.Build.Framework.ITaskItem*><CodeContentPlaceHolder>13\</CodeContentPlaceHolder> parameter.\<br />\<br /> Specifies the items that contain licensed components to include in the .licenses file. For more information, see the documentation for the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> switch in [License Compiler (Lc.exe)](assetId:///2de803b8-495e-4982-b209-19a72aba0460).|  
  
 In addition to the parameters listed above, this task inherits parameters from the \<xref:Microsoft.Build.Tasks.ToolTaskExtension*> class, which itself inherits from the \<xref:Microsoft.Build.Utilities.ToolTask*> class. For a list of these additional parameters and their descriptions, see [ToolTaskExtension Base Class](../vs140/tooltaskextension-base-class.md).  
  
## Example  
 The following example uses the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> task to compile licenses.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [MSBuild Tasks](../vs140/msbuild-tasks.md)   
 [MSBuild Task Reference](../vs140/msbuild-task-reference.md)