---
title: "Task Element (MSBuild)"
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
  - "Task element [MSBuild]"
  - "<Task> element [MSBuild]"
ms.assetid: d82e2485-e5f0-4936-a357-745bacccc299
caps.latest.revision: 26
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Task Element (MSBuild)
Creates and executes an instance of an [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] task. The element name is determined by the name of the task being created.  
  
 \<Project>  
 \<Target>  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Attributes and Elements  
 The following sections describe attributes, child elements, and parent elements.  
  
### Attributes  
  
|Attribute|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|Optional attribute. Condition to be evaluated. For more information, see [MSBuild Conditions](../vs140/msbuild-conditions.md).|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|Optional attribute. Can contain one of the following values:\<br />\<br /> -   **WarnAndContinue** or **true**. When a task fails, subsequent tasks in the [Target](../vs140/target-element--msbuild-.md) element and the build continue to execute, and all errors from the task are treated as warnings.\<br />-   **ErrorAndContinue**. When a task fails, subsequent tasks in the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> element and the build continue to execute, and all errors from the task are treated as errors.\<br />-   **ErrorAndStop** or **false** (default). When a task fails, the remaining tasks in the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> element and the build aren't executed, and the entire <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> element and the build is considered to have failed.\<br />\<br /> Versions of the .NET Framework before 4.5 supported only the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> values.\<br />\<br /> For more information, see [How to: Ignore Errors in Tasks](../vs140/how-to--ignore-errors-in-tasks.md).|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|Required if the task class contains one or more properties labeled with the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> attribute.\<br />\<br /> A user-defined task parameter that contains the parameter value as its value. There can be any number of parameters in the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> element, with each attribute mapping to a .NET property in the task class.|  
  
### Child Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[Output](../vs140/output-element--msbuild-.md)|Stores outputs from the task in the project file. There may be zero or more <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> elements in a task.|  
  
### Parent Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[Target](../vs140/target-element--msbuild-.md)|Container element for [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] tasks.|  
  
## Remarks  
 A <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> element in an [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] project file creates an instance of a task, sets properties on it, and executes it. The <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> element stores output parameters in properties or items to be used elsewhere in the project file.  
  
 If there are any [OnError](../vs140/onerror-element--msbuild-.md) elements in the parent <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> element of a task, they will still be evaluated if the task fails and <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> has a value of <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>. For more information on tasks, see [MSBuild Tasks](../vs140/msbuild-tasks.md).  
  
## Example  
 The following code example creates an instance of the [Csc task](../vs140/csc-task.md) class, sets six of the properties, and executes the task. After execution, the value of the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> property of the object is placed into an item list named <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [MSBuild Tasks](../vs140/msbuild-tasks.md)   
 [MSBuild Task Reference](../vs140/msbuild-task-reference.md)   
 [MSBuild File Format](../vs140/msbuild-project-file-schema-reference.md)