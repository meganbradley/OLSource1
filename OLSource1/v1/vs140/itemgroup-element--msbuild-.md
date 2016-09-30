---
title: "ItemGroup Element (MSBuild)"
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
  - "http://schemas.microsoft.com/developer/msbuild/2003#ItemGroup"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
helpviewer_keywords: 
  - "ItemGroup element [MSBuild]"
  - "<ItemGroup> element [MSBuild]"
ms.assetid: aac894e3-a9f1-4bbc-a796-6ef07001f35b
caps.latest.revision: 28
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ItemGroup Element (MSBuild)
Contains a set of user-defined [Item](../vs140/item-element--msbuild-.md) elements. Every item used in a [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] project must be specified as a child of an <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> element.  
  
 \<Project>  
 \<ItemGroup>  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Attributes and Elements  
 The following sections describe attributes, child elements, and parent elements.  
  
### Attributes  
  
|Attribute|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|Optional attribute. Condition to be evaluated. For more information, see [MSBuild Conditions](../vs140/msbuild-conditions.md).|  
  
### Child Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[Item](../vs140/item-element--msbuild-.md)|Defines the inputs for the build process. There may be zero or more <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> elements in an <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.|  
  
### Parent Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[Project](../vs140/project-element--msbuild-.md)|Required root element of an [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] project file.|  
|[Target](../vs140/target-element--msbuild-.md)|Starting with .NET Framework 3.5, the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> element can appear inside a <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> element. For more information, see [MSBuild Targets](../vs140/msbuild-targets.md).|  
  
## Remarks  
  
## Example  
 The following code example shows the user-defined item collections <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> declared inside of an <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> element. Each of the items in the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> item collection contains a user-defined child [ItemMetadata](../vs140/itemmetadata-element--msbuild-.md) element.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [MSBuild File Format](../vs140/msbuild-project-file-schema-reference.md)   
 [MSBuild Items](../vs140/msbuild-items.md)   
 [Common MSBuild Project Items](../vs140/common-msbuild-project-items.md)