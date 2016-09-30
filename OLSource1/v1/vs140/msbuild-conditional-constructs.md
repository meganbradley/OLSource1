---
title: "MSBuild Conditional Constructs"
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
  - "<Choose> Element [MSBuild]"
  - "Choose Element [MSBuild]"
  - "conditional constructs [MSBuild]"
  - "MSBuild, conditional constructs"
  - "<When> Element [MSBuild]"
  - "<Otherwise> Element [MSBuild]"
  - "Otherwise Element [MSBuild]"
  - "When Element [MSBuild]"
ms.assetid: dd54258e-f4fb-448f-9da4-d1817e0cbaf2
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# MSBuild Conditional Constructs
[!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] provides a mechanism for either/or processing with the [Choose](../vs140/choose-element--msbuild-.md), [When](../vs140/when-element--msbuild-.md), and [Otherwise](../vs140/otherwise-element--msbuild-.md) elements.  
  
## Using the Choose Element  
 The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> element contains a series of <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> elements with <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> attributes that are tested in order from top to bottom until one evaluates to <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. If more than one <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> element evaluates to <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, only the first one is used. An <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> element, if present, will be evaluated if no condition on a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> element evaluates to <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> elements can be used as child elements of <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> elements. <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> elements can have <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> child elements.  
  
## Example  
 The following example uses the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> elements for either/or processing. The properties and items for the project are set depending on the value of the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> property.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [Choose Element (MSBuild)](../vs140/choose-element--msbuild-.md)   
 [When Element (MSBuild)](../vs140/when-element--msbuild-.md)   
 [Otherwise Element (MSBuild)](../vs140/otherwise-element--msbuild-.md)   
 [MSBuild Reference](../vs140/msbuild-reference.md)