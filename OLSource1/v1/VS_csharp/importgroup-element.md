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
Contains a collection of `Import` elements that are grouped under an optional condition. For more information, see [Import](../VS_csharp/import-element--msbuild-.md).  
  
 <Project\>  
 <ImportGroup\>  
  
## Syntax  
  
```  
<ImportGroup Condition="'String A' == 'String B'">  
    <Import ... />  
    <Import ... />  
</ImportGroup>  
```  
  
## Attributes and Elements  
 The following sections describe attributes, child elements, and parent elements.  
  
### Attributes  
  
|Attribute|Description|  
|---------------|-----------------|  
|`Condition`|Optional attribute.<br /><br /> The condition to be evaluated. For more information, see [MSBuild Conditions](../VS_csharp/msbuild-conditions.md).|  
  
### Child Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[Import](../VS_csharp/import-element--msbuild-.md)|Imports the contents of one project file into another project file.|  
  
### Parent Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[Project](../VS_csharp/project-element--msbuild-.md)|Required root element of an [!INCLUDE[vstecmsbuild](../VS_csharp/includes/vstecmsbuild_md.md)] project file.|  
  
## Remarks  
  
## Example  
 The following code example shows the `ImportGroup` element.  
  
```  
<Project xmlns="http://schemas.microsoft.com/developer/msbuild/2003">  
    <ImportGroup>  
        <Import Project="$(Targets1.targets) />  
        <Import Project="$(Targets2.targets) />  
    </ImportGroup>  
...  
</Project>  
```  
  
## See Also  
 [MSBuild File Format](../VS_csharp/msbuild-project-file-schema-reference.md)   
 [MSBuild Items](../VS_csharp/msbuild-items.md)