---
title: "CreateItem Task"
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
  - "http://schemas.microsoft.com/developer/msbuild/2003#CreateItem"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
helpviewer_keywords: 
  - "CreateItem task [MSBuild]"
  - "MSBuild, CreateItem task"
ms.assetid: c4311f38-979e-4324-b524-9e8c1cbdc41a
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CreateItem Task
Populates item collections with the input items. This allows items to be copied from one list to another.  
  
> [!NOTE]
>  This task is deprecated. Starting with .NET Framework 3.5, item groups may be placed within [Target](../vs140/target-element--msbuild-.md) elements. For more information, see [MSBuild Items](../vs140/msbuild-items.md).  
  
## Attributes  
 The following table describes the parameters of the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> task.  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> array parameter.\<br />\<br /> Specifies additional metadata to attach to the output items.  Specify the metadata name and value for the item with the following syntax:\<br />\<br /> *MetadataName* <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> *MetadataValue*\<br />\<br /> Multiple metadata name/value pairs should be separated with a semicolon. If either the name or the value contains a semicolon or any other special characters, they must be escaped. For more information, see [How To: Escape Special Characters in MSBuild](../vs140/how-to--escape-special-characters-in-msbuild.md).|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|Optional \<xref:Microsoft.Build.Framework.ITaskItem*><CodeContentPlaceHolder>6\</CodeContentPlaceHolder> output parameter.\<br />\<br /> Specifies the items to exclude from the output item collection. This parameter can contain wildcard specifications. For more information, see [MSBuild Items](../vs140/msbuild-items.md) and [How To: Build all Files in a Directory Except One](../vs140/how-to--exclude-files-from-the-build.md).|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|Required \<xref:Microsoft.Build.Framework.ITaskItem*><CodeContentPlaceHolder>8\</CodeContentPlaceHolder>parameter.\<br />\<br /> Specifies the items to include in the output item collection. This parameter can contain wildcard specifications.|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> parameter.\<br />\<br /> If <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, only apply the additional metadata if they do not already exist.|  
  
## Remarks  
 In addition to the parameters listed above, this task inherits parameters from the \<xref:Microsoft.Build.Tasks.TaskExtension*> class, which itself inherits from the \<xref:Microsoft.Build.Utilities.Task*> class. For a list of these additional parameters and their descriptions, see [TaskExtension Base Class](../vs140/taskextension-base-class.md).  
  
## Example  
 The following code example creates a new item collection named <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> from the item collection <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>. The <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> task populates the new item collection with the items in the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> item. It then adds an additional metadata entry named <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> with a value of <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> to each item in the new collection.  
  
 After the task is executed, the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> item collection contains the items <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, both with metadata entries for <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>. The <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> item collection is unchanged.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The following table describes the value of the output item after task execution. Item metadata is shown in parenthesis after the item.  
  
|Item collection|Contents|  
|---------------------|--------------|  
|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder> (<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>)\<br />\<br /> <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> (<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>)|  
  
## See Also  
 [MSBuild Task Reference](../vs140/msbuild-task-reference.md)   
 [MSBuild Tasks](../vs140/msbuild-tasks.md)