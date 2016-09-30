---
title: "ProjectExtensions Element (MSBuild)"
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
  - "http://schemas.microsoft.com/developer/msbuild/2003#ProjectExtensions"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
helpviewer_keywords: 
  - "<ProjectExtensions> element [MSBuild]"
  - "ProjectExtensions element [MSBuild]"
ms.assetid: f95f312f-ff92-41eb-9469-ad99e236a307
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ProjectExtensions Element (MSBuild)
Allows [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] project files to contain non-[!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] information. Anything inside of a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> element will be ignored by [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)].  
  
 \<Project>  
 \<ProjectExtensions>  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Attributes and Elements  
 The following sections describe attributes, child elements, and parent elements.  
  
### Attributes  
 None  
  
### Child Elements  
 None  
  
### Parent Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[Project](../vs140/project-element--msbuild-.md)|Required root element of an [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] project file.|  
  
## Remarks  
 Only one <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> element may be used in an [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] project.  
  
## Example  
 The following code example shows information from the integrated development environment being stored in a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> element.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [MSBuild Project File Schema Reference](../vs140/msbuild-project-file-schema-reference.md)   
 [MSBuild](../vs140/msbuild.md)