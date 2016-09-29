---
title: "CPPClean Task"
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
  - "vc.task.cppclean"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
  - "C++"
helpviewer_keywords: 
  - "MSBuild (Visual C++), CPPClean task"
  - "CPPClean task (MSBuild (Visual C++))"
ms.assetid: b62a482e-8fb5-4999-b50b-6605a078e291
caps.latest.revision: 9
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPPClean Task
Deletes the temporary files that MSBuild creates when a Visual C++ project is built. The process of deleting build files is known as *cleaning*.  
  
## Parameters  
 The following table describes the parameters of the **CPPClean** task.  
  
|Parameter|Description|  
|---------------|-----------------|  
|**DeletedFiles**|Optional `ITaskItem[]` output parameter.<br /><br /> Defines an array of MSBuild output file items that can be consumed and emitted by tasks.|  
|**DoDelete**|Optional **Boolean** parameter.<br /><br /> If `true`, clean temporary build files.|  
|**FilePatternsToDeleteOnClean**|Required `String` parameter.<br /><br /> Specifies a semicolon-delimited list of file extensions of files to clean.|  
|**FilesExcludedFromClean**|Optional `String` parameter.<br /><br /> Specifies a semicolon-delimited list of files not to clean.|  
|**FoldersToClean**|Required `String` parameter.<br /><br /> Specifies a semicolon-delimited list of directories to clean. You can specify a full or a relative path, and the path can contain the wildcard symbol (**\***).|  
  
## Remarks  
  
## See Also  
 [MSBuild Task Reference](../vs140/msbuild-task-reference.md)