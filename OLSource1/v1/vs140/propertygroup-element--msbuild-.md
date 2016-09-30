---
title: "PropertyGroup Element (MSBuild)"
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
  - "http://schemas.microsoft.com/developer/msbuild/2003#PropertyGroup"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
helpviewer_keywords: 
  - "<PropertyGroup> element [MSBuild]"
  - "PropertyGroup element [MSBuild]"
ms.assetid: ff1e6c68-b9a1-4263-a1ce-dc3b829a64d4
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# PropertyGroup Element (MSBuild)
Contains a set of user-defined [Property](../vs140/property-element--msbuild-.md) elements. Every <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> element used in an [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] project must be a child of a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> element.  
  
 \<Project>  
 \<PropertyGroup>  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Attributes and Elements  
 The following sections describe attributes, child elements, and parent elements.  
  
### Attributes  
  
|Attribute|Description|  
|---------------|-----------------|  
|Condition|Optional attribute.\<br />\<br /> Condition to be evaluated. For more information, see [MSBuild Conditions](../vs140/msbuild-conditions.md).|  
  
### Child Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[Property](../vs140/property-element--msbuild-.md)|Optional element.\<br />\<br /> A user defined property name, which contains the property value. There may be zero or more *Property* elements in a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> element.|  
  
### Parent Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[Project](../vs140/project-element--msbuild-.md)|Required root element of an [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] project file.|  
  
## Example  
 The following code example shows how to set properties based on a condition. In this example, if the value of the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> property is <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> properties inside of the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> element are set.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [MSBuild Project File Schema Reference](../vs140/msbuild-project-file-schema-reference.md)   
 [MSBuild Properties](../vs140/msbuild-properties.md)