---
title: "WriteCodeFragment Task"
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
  - "MSBuild, WriteCodeFragment task"
  - "WriteCodeFragment task [MSBuild]"
ms.assetid: 1d2514b4-5bef-43bb-bebe-496da8ef063c
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# WriteCodeFragment Task
Generates a temporary code file from the specified generated code fragment. Does not delete the file.  
  
## Parameters  
 The following table describes the parameters of the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> task.  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|Optional \<xref:Microsoft.Build.Framework.ITaskItem*><CodeContentPlaceHolder>2\</CodeContentPlaceHolder> parameter.\<br />\<br /> Description of the attributes to write. The item <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> value is the full type name of the attribute, for example, "System.AssemblyVersionAttribute".\<br />\<br /> Each metadata is the name-value pair of a parameter, which must be of type <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. Some attributes only allow positional constructor arguments. However, you can use such arguments in any attribute. To set positional constructor attributes, use metadata names that resemble "_Parameter1", "_Parameter2", and so on.\<br />\<br /> A parameter index cannot be skipped.|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|Required <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> parameter.\<br />\<br /> Specifies the language of the code to generate.\<br />\<br /> <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> can be any language for which a CodeDom provider is available, for example, "C#" or "VisualBasic". The emitted file will have the default file name extension for that language.|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|Optional \<xref:Microsoft.Build.Framework.ITaskItem*> parameter.\<br />\<br /> Specifies the destination folder for the generated code, typically the intermediate folder.|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|Optional \<xref:Microsoft.Build.Framework.ITaskItem*> output parameter.\<br />\<br /> Specifies the path of the file that was generated. If this parameter is set by using a file name, the destination folder is prepended to the file name. If it is set by using a root, the destination folder is ignored.\<br />\<br /> If this parameter is not set, the output file name is the destination folder, an arbitrary file name, and the default file name extension for the specified language.|  
  
## Remarks  
 In addition to having the parameters that are listed in the table, this task inherits parameters from the \<xref:Microsoft.Build.Tasks.TaskExtension*> class, which itself inherits from the \<xref:Microsoft.Build.Utilities.Task*> class. For a list of these additional parameters and their descriptions, see [TaskExtension Base Class](../vs140/taskextension-base-class.md).  
  
## See Also  
 [MSBuild Tasks](../vs140/msbuild-tasks.md)   
 [MSBuild Task Reference](../vs140/msbuild-task-reference.md)