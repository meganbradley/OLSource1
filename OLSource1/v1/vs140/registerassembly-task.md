---
title: "RegisterAssembly Task"
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
  - "http://schemas.microsoft.com/developer/msbuild/2003#RegisterAssembly"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
helpviewer_keywords: 
  - "MSBuild, RegisterAssembly task"
  - "RegisterAssembly task [MSBuild]"
ms.assetid: ba5f19ac-6764-4d28-9b79-a86de58f8987
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# RegisterAssembly Task
Reads the metadata within the specified assembly and adds the necessary entries to the registry, which allows COM clients to create [!INCLUDE[dnprdnshort](../vs140/includes/dnprdnshort_md.md)] classes transparently. The behavior of this task is similar, but not identical, to that of the [Assembly Registration Tool (Regasm.exe)](assetId:///e190e342-36ef-4651-a0b4-0e8c2c0281cb).  
  
## Parameters  
 The following table describes the parameters of the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> task.  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|Required \<xref:Microsoft.Build.Framework.ITaskItem*><CodeContentPlaceHolder>3\</CodeContentPlaceHolder> parameter.\<br />\<br /> Specifies the assemblies to be registered with COM.|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|Optional \<xref:Microsoft.Build.Framework.ITaskItem*> parameter.\<br />\<br /> Contains information about the state between the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> task and the [UnregisterAssembly](../vs140/unregisterassembly-task.md) task. This prevents the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> task from attempting to unregister an assembly that failed to register in the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> task.|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> parameter.\<br />\<br /> If <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, creates a codebase entry in the registry, which specifies the file path for an assembly that is not installed in the global assembly cache. You should not specify this option if you will subsequently install the assembly that you are registering into the global assembly cache.|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|Optional \<xref:Microsoft.Build.Framework.ITaskItem*><CodeContentPlaceHolder>12\</CodeContentPlaceHolder> output parameter.\<br />\<br /> Specifies the type library to generate from the specified assembly. The generated type library contains definitions of the accessible types defined within the assembly. The type library is only generated if one of the following is true:\<br />\<br /> -   A type library of that name does not exist at that location.\<br />-   A type library exists but it is older than the assembly being passed in.\<br />\<br /> If the type library is newer than the assembly being passed, a new one will not be created, but the assembly will still be registered.\<br />\<br /> If this parameter is specified, it must have the same number of items as the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> parameter or the task will fail. If no inputs are specified, the task will default to the name of the assembly and change the extension of the item to .tlb.|  
  
## Remarks  
 In addition to the parameters listed above, this task inherits parameters from the \<xref:Microsoft.Build.Tasks.TaskExtension*> class, which itself inherits from the \<xref:Microsoft.Build.Utilities.Task*> class. For a list of these additional parameters and their descriptions, see [TaskExtension Base Class](../vs140/taskextension-base-class.md).  
  
## Example  
 The following example uses the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> task to register the assembly specified by the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> item collection.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [MSBuild Tasks](../vs140/msbuild-tasks.md)   
 [MSBuild Task Reference](../vs140/msbuild-task-reference.md)