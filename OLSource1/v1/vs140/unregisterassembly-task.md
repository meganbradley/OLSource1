---
title: "UnregisterAssembly Task"
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
  - "http://schemas.microsoft.com/developer/msbuild/2003#UnregisterAssembly"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
helpviewer_keywords: 
  - "MSBuild, UnregisterAssembly task"
  - "UnregisterAssembly task [MSBuild]"
ms.assetid: 04f549dd-3591-4dda-9c3a-cf6ede9df2c3
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# UnregisterAssembly Task
Unregisters the specified assemblies for COM interop purposes. Performs the reverse of the [RegisterAssembly task](../vs140/registerassembly-task.md).  
  
## Parameters  
 The following table describes the parameters of the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> task.  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|Optional \<xref:Microsoft.Build.Framework.ITaskItem*><CodeContentPlaceHolder>3\</CodeContentPlaceHolder> parameter.\<br />\<br /> Specifies the assemblies to be unregistered.|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|Optional \<xref:Microsoft.Build.Framework.ITaskItem*> parameter.\<br />\<br /> Contains information about the state between the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> task and the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> task. This prevents the task from attempting to unregister an assembly that failed to register in the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> task.\<br />\<br /> If this parameter is specified, the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> parameters are ignored.|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|Optional \<xref:Microsoft.Build.Framework.ITaskItem*><CodeContentPlaceHolder>11\</CodeContentPlaceHolder> output parameter.\<br />\<br /> Unregisters the specified type library from the specified assembly. **Note:**  This parameter is only necessary if the type library file name is different than the assembly name.|  
  
## Remarks  
 It is not required that the assembly exists for this task to be successful. If you attempt to unregister an assembly that does not exist, the task will succeed with a warning. This occurs because it is the job of this task to remove the assembly registration from the registry. If the assembly does not exist, it is not in the registry, and therefore, the task succeeded.  
  
 In addition to the parameters listed above, this task inherits parameters from the \<xref:Microsoft.Build.Tasks.AppDomainIsolatedTaskExtension*> class, which itself inherits from the \<xref:System.MarshalByRefObject*> class. The <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> class provides the same functionality as the \<xref:Microsoft.Build.Utilities.Task*> class, but it can be instantiated in its own application domain.  
  
## Example  
 The following example uses the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> task to unregister the assembly at the path specified by the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> properties, if it exists.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [RegisterAssembly Task](../vs140/registerassembly-task.md)   
 [MSBuild Tasks](../vs140/msbuild-tasks.md)   
 [MSBuild Task Reference](../vs140/msbuild-task-reference.md)