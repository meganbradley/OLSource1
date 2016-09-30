---
title: "TaskBody Element (MSBuild)"
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
  - "TaskBody element [MSBuild]"
  - "<TaskBody> element [MSBuild]"
ms.assetid: 49d8741b-f1ea-4470-94fd-a1ac27341a6a
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# TaskBody Element (MSBuild)
Contains the data that is passed to a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>. For more information, see [UsingTask](../vs140/usingtask-element--msbuild-.md).  
  
 \<Project>  
 \<UsingTask>  
 \<TaskBody>  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Attributes and Elements  
 The following sections describe attributes, child elements, and parent elements.  
  
### Attributes  
  
|Attribute|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|Optional Boolean attribute.\<br />\<br /> If <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, MSBuild evaluates any inner elements, and expands items and properties before it passes the information to the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> when the task is instantiated.|  
  
### Child Elements  
  
|Element|Description|  
|-------------|-----------------|  
|Data|The text between the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> tags is sent verbatim to the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.|  
  
### Parent Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[UsingTask](../vs140/usingtask-element--msbuild-.md)|Provides a way to register tasks in [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)]. There may be zero or more <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> elements in a project.|  
  
## Example  
 The following example shows how to use the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> element with an <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> attribute.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [MSBuild Tasks](../vs140/msbuild-tasks.md)   
 [MSBuild Task Reference](../vs140/msbuild-task-reference.md)   
 [MSBuild File Format](../vs140/msbuild-project-file-schema-reference.md)