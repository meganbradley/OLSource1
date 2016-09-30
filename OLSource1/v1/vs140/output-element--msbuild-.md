---
title: "Output Element (MSBuild)"
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
  - "http://schemas.microsoft.com/developer/msbuild/2003#Output"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
helpviewer_keywords: 
  - "<Output> Element [MSBuild]"
  - "Output Element [MSBuild]"
ms.assetid: 34bc7cd1-efd3-4b57-b691-4584eeb6a0e9
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Output Element (MSBuild)
Stores task output values in items and properties.  
  
 \<Project>  
 \<Target>  
 \<Task>  
 \<Output>  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Attributes and Elements  
 The following sections describe attributes, child elements, and parent elements.  
  
### Attributes  
  
|Attribute|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|Required attribute.\<br />\<br /> The name of the task's output parameter.|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|Either the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> attribute is required.\<br />\<br /> The property that receives the task's output parameter value. Your project can then reference the property with the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>*PropertyName*<CodeContentPlaceHolder>7\</CodeContentPlaceHolder> syntax. This property name can either be a new property name or a name that is already defined in the project.\<br />\<br /> This attribute cannot be used if <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is also being used.|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|Either the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> attribute is required.\<br />\<br /> The item that receives the task's output parameter value. Your project can then reference the item with the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>*ItemName*<CodeContentPlaceHolder>13\</CodeContentPlaceHolder> syntax. The item name can either be a new item name or a name that is already defined in the project.\<br />\<br /> This attribute cannot be used if <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is also being used.|  
|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|Optional attribute.\<br />\<br /> Condition to be evaluated. For more information, see [MSBuild Conditions](../vs140/msbuild-conditions.md).|  
  
### Child Elements  
 None.  
  
### Parent Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[Task](../vs140/task-element--msbuild-.md)|Creates and executes an instance of an [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] task.|  
  
## Example  
 The following code example shows the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> task being executed inside of a <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> element. The items and properties passed to the task parameters are declared outside of the scope of this example. The value from the output parameter <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> is stored in the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> item, and the value from the output parameter <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> is stored in the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> property. For more information, see [MSBuild Tasks](../vs140/msbuild-tasks.md).  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [MSBuild Project File Schema Reference](../vs140/msbuild-project-file-schema-reference.md)   
 [MSBuild Tasks](../vs140/msbuild-tasks.md)