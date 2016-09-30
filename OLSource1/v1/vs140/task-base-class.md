---
title: "Task Base Class"
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
ms.assetid: 6c3f6238-b9f0-4325-b8b0-de61090bd0a2
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Task Base Class
Many tasks ultimately inherit from the \<xref:Microsoft.Build.Utilities.Task*> class. This class adds several parameters to the tasks that derive from them. These parameters are listed in this document.  
  
## Parameters  
 The following table describes the parameters of this base class.  
  
|Parameter|Description|  
|---------------|-----------------|  
|\<xref:Microsoft.Build.Utilities.Task.BuildEngine*>|Optional \<xref:Microsoft.Build.Framework.IBuildEngine*> parameter.\<br />\<br /> Specifies the build engine interface available to tasks. The build engine automatically sets this parameter to allow tasks to call back into it.|  
|\<xref:Microsoft.Build.Utilities.Task.BuildEngine2*>|Optional \<xref:Microsoft.Build.Framework.IBuildEngine2*> parameter.\<br />\<br /> Specifies the build engine interface available to tasks. The build engine automatically sets this parameter to allow tasks to call back into it.\<br />\<br /> This is a convenience property so that task authors inheriting from this class do not have to cast the value from <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.|  
|\<xref:Microsoft.Build.Utilities.Task.BuildEngine3*>|Optional \<xref:Microsoft.Build.Framework.IBuildEngine3*> parameter.\<br />\<br /> Specifies the build engine interface provided by the host.|  
|\<xref:Microsoft.Build.Utilities.Task.HostObject*>|Optional \<xref:Microsoft.Build.Framework.ITaskHost*> parameter.\<br />\<br /> Specifies the host object instance (can be null). The build engine sets this property if the host IDE has associated a host object with this particular task.|  
|\<xref:Microsoft.Build.Utilities.Task.Log*>|Optional \<xref:Microsoft.Build.Utilities.TaskLoggingHelper*> read-only parameter.\<br />\<br /> The logging helper object..|  
  
## See Also  
 [MSBuild Task Reference](../vs140/msbuild-task-reference.md)   
 [MSBuild Tasks](../vs140/msbuild-tasks.md)