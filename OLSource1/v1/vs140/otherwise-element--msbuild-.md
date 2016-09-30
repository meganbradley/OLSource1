---
title: "Otherwise Element (MSBuild)"
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
  - "http://schemas.microsoft.com/developer/msbuild/2003#Otherwise"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
helpviewer_keywords: 
  - "<Otherwise> Element [MSBuild]"
  - "Otherwise Element [MSBuild]"
ms.assetid: de3997e9-1595-4263-a886-95530b56a319
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Otherwise Element (MSBuild)
Specifies the block of code to execute if and only if the conditions of all <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> elements evaluate to <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 \<Project>  
 \<Choose>  
 \<When>  
 \<Choose>  
 ...  
 \<Otherwise>  
 \<Choose>  
 ...  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Attributes and Elements  
 The following sections describe attributes, child elements, and parent elements.  
  
### Attributes  
 None.  
  
### Child Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[Choose](../vs140/choose-element--msbuild-.md)|Optional element.\<br />\<br /> Evaluates child elements to select one section of code to execute. There may be zero or more <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> elements in an <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> element.|  
|[ItemGroup](../vs140/itemgroup-element--msbuild-.md)|Optional element.\<br />\<br /> Contains a set of user-defined [Item](../vs140/item-element--msbuild-.md) elements. There may be zero or more <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> elements in an <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> element.|  
|[PropertyGroup](../vs140/propertygroup-element--msbuild-.md)|Optional element.\<br />\<br /> Contains a set of user-defined [Property](../vs140/property-element--msbuild-.md) elements. There may be zero or more <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> elements in an <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> element.|  
  
### Parent Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[Choose](../vs140/choose-element--msbuild-.md)|Evaluates child elements to select one section of code to execute.|  
  
## Remarks  
 There may be only one <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> element in a <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> element, and it must be last element.  
  
 The <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> elements are used together to provide a way to select one section of code to execute out of a number of possible alternatives. For more information, see [MSBuild Conditional Constructs](../vs140/msbuild-conditional-constructs.md).  
  
## Example  
 The following project uses the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> element to select which set of property values in the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> elements to set. If the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> attributes of both <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> elements evaluate to <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, the property values in the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> element are set.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [MSBuild Conditional Constructs](../vs140/msbuild-conditional-constructs.md)   
 [MSBuild Project File Schema Reference](../vs140/msbuild-project-file-schema-reference.md)