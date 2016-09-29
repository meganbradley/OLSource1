---
title: "ReadLinesFromFile Task"
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
  - "http://schemas.microsoft.com/developer/msbuild/2003#ReadLinesFromFile"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
helpviewer_keywords: 
  - "MSBuild, ReadLinesFromFile task"
  - "ReadLinesFromFile task [MSBuild]"
ms.assetid: a18af929-b53a-4d9e-b7bf-e3d3737ee85f
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ReadLinesFromFile Task
Reads a list of items from a text file.  
  
## Parameters  
 The following table describes the parameters of the `ReadLinesFromFile` task.  
  
|Parameter|Description|  
|---------------|-----------------|  
|`File`|Required <xref:Microsoft.Build.Framework.ITaskItem*> parameter.<br /><br /> Specifies the file to read. The file must have one item on each line.|  
|`Lines`|Optional <xref:Microsoft.Build.Framework.ITaskItem*>`[]` output parameter.<br /><br /> Contains the lines read from the file.|  
  
## Remarks  
 In addition to the parameters listed above, this task inherits parameters from the <xref:Microsoft.Build.Tasks.TaskExtension*> class, which itself inherits from the <xref:Microsoft.Build.Utilities.Task*> class. For a list of these additional parameters and their descriptions, see [TaskExtension Base Class](../vs140/taskextension-base-class.md).  
  
## Example  
 The following example uses the `ReadLinesFromFile` task to create items from a list in a text file. The items read from the file are stored in the `ItemsFromFile` item collection.  
  
```  
<Project xmlns="http://schemas.microsoft.com/developer/msbuild/2003">  
  
    <ItemGroup>  
        <MyTextFile Include="Items.txt"/>  
    </ItemGroup>  
  
    <Target Name="ReadFromFile">  
        <ReadLinesFromFile  
            File="@(MyTextFile)" >  
            <Output  
                TaskParameter="Lines"  
                ItemName="ItemsFromFile"/>  
        </ReadLinesFromFile>  
    </Target>  
  
</Project>  
```  
  
## See Also  
 [MSBuild Task Reference](../vs140/msbuild-task-reference.md)   
 [MSBuild Concepts](../vs140/msbuild-concepts.md)   
 [MSBuild Tasks](../vs140/msbuild-tasks.md)