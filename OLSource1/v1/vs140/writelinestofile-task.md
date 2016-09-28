---
title: "WriteLinesToFile Task"
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
  - "http://schemas.microsoft.com/developer/msbuild/2003#WriteLinesToFile"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
helpviewer_keywords: 
  - "WriteLinesToFile task [MSBuild]"
  - "MSBuild, WriteLinesToFile task"
ms.assetid: 9c8862ac-8da5-4437-9430-ecc30421f1c9
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# WriteLinesToFile Task
Writes the paths of the specified items to the specified text file.  
  
## Task Parameters  
 The following table describes the parameters of the `WriteLinestoFile` task.  
  
|Parameter|Description|  
|---------------|-----------------|  
|`File`|Required <xref:Microsoft.Build.Framework.ITaskItem*> parameter.<br /><br /> Specifies the file to write the items to.|  
|`Lines`|Optional <xref:Microsoft.Build.Framework.ITaskItem*>`[]` parameter.<br /><br /> Specifies the items to write to the file.|  
|`Overwrite`|Optional `Boolean` parameter.<br /><br /> If `true`, the task overwrites any existing content in the file.|  
|`Encoding`|Optional `String` parameter.<br /><br /> Selects the character encoding, for example, "Unicode".  See also <xref:System.Text.Encoding*>.|  
  
## Remarks  
 If `Overwrite` is `true`, creates a new file, write the contents to the file, and then closes the file. If the target file already exists, it is overwritten. If `Overwrite` is `false`, appends the contents to file, creating the target file if it does not already exist.  
  
 In addition to the parameters listed above, this task inherits parameters from the <xref:Microsoft.Build.Tasks.TaskExtension*> class, which itself inherits from the <xref:Microsoft.Build.Utilities.Task*> class. For a list of these additional parameters and their descriptions, see [TaskExtension Base Class](../vs140/taskextension-base-class.md).  
  
## Example  
 The following example uses the `WriteLinesToFile` task to write the paths of the items in the `MyItems` item collection to the file specified by the `MyTextFile` item collection.  
  
```  
<Project xmlns="http://schemas.microsoft.com/developer/msbuild/2003">  
  
    <ItemGroup>  
        <MyTextFile Include="Items.txt"/>  
        <MyItems Include="*.cs"/>  
    </ItemGroup>  
  
    <Target Name="WriteToFile">  
        <WriteLinesToFile  
            File="@(MyTextFile)"  
            Lines="@(MyItems)"  
            Overwrite="true"  
            Encoding="Unicode"/>  
    </Target>  
  
</Project>  
```  
  
## See Also  
 [MSBuild Tasks](../vs140/msbuild-tasks.md)   
 [MSBuild Task Reference](../vs140/msbuild-task-reference.md)