---
title: "ImportGroup Element"
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
  - "<ImportGroup> element [MSBuild]"
  - "ImportGroup element [MSBuild]"
ms.assetid: dac3fa2d-6678-4017-af35-93686f53f302
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ImportGroup Element
Contains a collection of <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> elements that are grouped under an optional condition. For more information, see [Import](../vs140/import-element--msbuild-.md).  
  
 \<Project>  
 \<ImportGroup>  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Attributes and Elements  
 The following sections describe attributes, child elements, and parent elements.  
  
### Attributes  
  
|Attribute|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|Optional attribute.\<br />\<br /> The condition to be evaluated. For more information, see [MSBuild Conditions](../vs140/msbuild-conditions.md).|  
  
### Child Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[Import](../vs140/import-element--msbuild-.md)|Imports the contents of one project file into another project file.|  
  
### Parent Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[Project](../vs140/project-element--msbuild-.md)|Required root element of an [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] project file.|  
  
## Remarks  
  
## Example  
 The following code example shows the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> element.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [MSBuild File Format](../vs140/msbuild-project-file-schema-reference.md)   
 [MSBuild Items](../vs140/msbuild-items.md)