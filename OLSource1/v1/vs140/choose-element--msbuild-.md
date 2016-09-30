---
title: "Choose Element (MSBuild)"
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
  - "http://schemas.microsoft.com/developer/msbuild/2003#Choose"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
helpviewer_keywords: 
  - "<Choose> Element [MSBuild]"
  - "Choose Element [MSBuild]"
ms.assetid: 7b8b025a-d944-4f5c-9018-c89fc2ef146d
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Choose Element (MSBuild)
Evaluates child elements to select one set of <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> elements and/or <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> elements to evaluate.  
  
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
|[Otherwise](../vs140/otherwise-element--msbuild-.md)|Optional element.\<br />\<br /> Specifies the block of code <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> elements to evaluate if the conditions of all <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> elements evaluate to <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. There may be zero or one <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> elements in a <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> element, and it must be the last element.|  
|[When](../vs140/when-element--msbuild-.md)|Required element.\<br />\<br /> Specifies a possible block of code for the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> element to select. There may be one or more <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> elements in a <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> element.|  
  
### Parent Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[Otherwise](../vs140/otherwise-element--msbuild-.md)|Specifies the block of code to execute if the conditions of all <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> elements evaluate to <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.|  
|[Project](../vs140/project-element--msbuild-.md)|Required root element of an [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] project file.|  
|[When](../vs140/when-element--msbuild-.md)|Specifies a possible block of code for the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> element to select.|  
  
## Remarks  
 The <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> elements are used together to provide a way to select one section of code to execute out of a number of possible alternatives. For more information, see [MSBuild Conditional Constructs](../vs140/msbuild-conditional-constructs.md).  
  
## Example  
 The following project uses the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> element to select which set of property values in the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> elements to set. If the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> attributes of both <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> elements evaluate to <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>, the property values in the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> element are set.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [MSBuild Conditional Constructs](../vs140/msbuild-conditional-constructs.md)   
 [MSBuild Project File Schema Reference](../vs140/msbuild-project-file-schema-reference.md)