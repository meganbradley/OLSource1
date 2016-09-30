---
title: "Property Element (MSBuild)"
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
  - "<Property> Element [MSBuild]"
  - "Property Element [MSBuild]"
ms.assetid: 69ab08ab-3e76-41dd-a01b-49aa1d2e0cac
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Property Element (MSBuild)
Contains a user defined property name and value. Every property used in an [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] project must be specified as a child of a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> element.  
  
 \<Project>  
 \<PropertyGroup>  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Attributes and Elements  
 The following sections describe attributes, child elements, and parent elements.  
  
### Attributes  
  
|Attribute|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|Optional attribute.\<br />\<br /> Condition to be evaluated. For more information, see [MSBuild Conditions](../vs140/msbuild-conditions.md).|  
  
### Child Elements  
 None.  
  
### Parent Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[PropertyGroup](../vs140/propertygroup-element--msbuild-.md)|Grouping element for properties.|  
  
## Text Value  
 A text value is optional.  
  
 This text specifies the property value and may contain XML.  
  
## Remarks  
 Property names are limited to ASCII chars only. Property values are referenced in the project by placing the property name between "<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>" and "<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>". For example, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> would resolve to "build\classes", if the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> property had the value <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>. For more information on properties, see [MSBuild Properties](../vs140/msbuild-properties.md).  
  
## Example  
 The following code sets the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> property to <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> and the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> property to <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> if the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> property is empty.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [MSBuild Properties](../vs140/msbuild-properties.md)   
 [MSBuild File Format](../vs140/msbuild-project-file-schema-reference.md)