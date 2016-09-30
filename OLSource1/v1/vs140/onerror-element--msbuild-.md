---
title: "OnError Element (MSBuild)"
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
  - "http://schemas.microsoft.com/developer/msbuild/2003#OnError"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
helpviewer_keywords: 
  - "OnError Element [MSBuild]"
  - "<OnError Element [MSBuild]"
ms.assetid: 765767d3-ecb7-4cd9-ba1e-d9468964dddc
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# OnError Element (MSBuild)
Causes one or more targets to execute, if the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> attribute is <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> for a failed task.  
  
 \<Project>  
 \<Target>  
 \<OnError>  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Attributes and Elements  
 The following sections describe attributes, child elements, and parent elements.  
  
### Attributes  
  
|Attribute|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|Optional attribute.\<br />\<br /> Condition to be evaluated. For more information, see [MSBuild Conditions](../vs140/msbuild-conditions.md).|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|Required attribute.\<br />\<br /> The targets to execute if a task fails. Separate multiple targets with semicolons. Multiple targets are executed in the order specified.|  
  
### Child Elements  
 None.  
  
### Parent Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[Target](../vs140/target-element--msbuild-.md)|Container element for [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] tasks.|  
  
## Remarks  
 [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] executes the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> element if one of the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> element's tasks fails with the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> attribute set to <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> (or <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>). When the task fails, the targets specified in the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> attribute is executed. If there is more than one <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> element in the target, the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> elements are executed sequentially when the task fails.  
  
 For information about the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> attribute, see [Task Element (MSBuild)](../vs140/task-element--msbuild-.md). For information about targets, see [MSBuild Targets](../vs140/msbuild-targets.md).  
  
## Example  
 The following code executes the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> tasks. If <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> fails, [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] evaluates the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> element and executes the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> target.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [MSBuild Project File Schema Reference](../vs140/msbuild-project-file-schema-reference.md)   
 [MSBuild Targets](../vs140/msbuild-targets.md)