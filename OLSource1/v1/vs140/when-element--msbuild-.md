---
title: "When Element (MSBuild)"
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
  - "http://schemas.microsoft.com/developer/msbuild/2003#When"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
helpviewer_keywords: 
  - "<When> Element [MSBuild]"
  - "When Element [MSBuild]"
ms.assetid: eb27de6f-4e71-4e87-87e2-d93f7bf5899c
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# When Element (MSBuild)
Specifies a possible block of code for the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> element to select.  
  
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
  
|Attribute|Description|  
|---------------|-----------------|  
|Condition|Required attribute.\<br />\<br /> Condition to evaluate. For more information, see [MSBuild Conditions](../vs140/msbuild-conditions.md).|  
  
### Child Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[Choose](../vs140/choose-element--msbuild-.md)|Optional element.\<br />\<br /> Evaluates child elements to select one section of code to execute. There may be zero or more <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> elements in a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> element.|  
|[ItemGroup](../vs140/itemgroup-element--msbuild-.md)|Optional element.\<br />\<br /> Contains a set of user-defined [Item](../vs140/item-element--msbuild-.md) elements. There may be zero or more <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> elements in a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> element.|  
|[PropertyGroup](../vs140/propertygroup-element--msbuild-.md)|Optional element.\<br />\<br /> Contains a set of user-defined [Property](../vs140/property-element--msbuild-.md) elements. There may be zero or more <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> elements in an <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> element.|  
  
### Parent Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[Choose Element (MSBuild)](../vs140/choose-element--msbuild-.md)|Evaluates child elements to select one section of code to execute.|  
  
## Remarks  
 If the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> attribute evaluates to true, the child <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> elements of the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> element are executed and all subsequent <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> elements are skipped.  
  
 The <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> elements are used together to provide a way to select one section of code to execute out of a number of possible alternatives. For more information, see [MSBuild Conditional Constructs](../vs140/msbuild-conditional-constructs.md).  
  
## Example  
 The following project uses the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> element to select which set of property values in the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> elements to set. If the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> attributes of both <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> elements evaluate to <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, the property values in the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> element are set.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [MSBuild Conditional Constructs](../vs140/msbuild-conditional-constructs.md)   
 [MSBuild Project File Schema Reference](../vs140/msbuild-project-file-schema-reference.md)