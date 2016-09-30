---
title: "&lt;RelatedProducts&gt; Element (Bootstrapper)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-deployment"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "MSBuild.GenerateBootstrapper.MissingDependency"
  - "MSBuild.GenerateBootstrapper.DuplicateItems"
  - "MSBuild.GenerateBootstrapper.IncludedProductIncluded"
  - "MSBuild.GenerateBootstrapper.DependencyNotFound"
  - "MSBuild.GenerateBootstrapper.PackageFileNotFound"
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "<RelatedProducts> element [bootstrapper]"
ms.assetid: bf152712-4c1e-48bd-9b7f-311cf0fdb832
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &lt;RelatedProducts&gt; Element (Bootstrapper)
The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> element defines other products that either depend upon or are included in the current product.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Elements and Attributes  
 The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> element is a child of the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> element. It has no attributes.  
  
## DependsOnProduct  
 The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> element signifies that the current product depends upon the named product, and that the named product should be installed before the current one. It is a child of the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> element. A <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> element might have one or more <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> elements.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> has the following attribute.  
  
|Attribute|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|The code name of the included product, as specified by the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> attribute of the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> element. For more information, see [\<Product> Element (ClickOnce Bootstrapper)](../vs140/-product--element--bootstrapper-.md).|  
  
## EitherProducts  
 The <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> element defines zero or more <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> elements, and has no attributes. At least one <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> in this set must be installed before the current product. A <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> element can have zero or more <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> elements.  
  
## IncludesProduct  
 The <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> element signifies that a product is included with the current install, and does not require a separate installation. It is a child of the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> element. A <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> element might have one or more <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> elements.  
  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> has the following attribute.  
  
|Attribute|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|The code name of the included product, as specified by the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> attribute of the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> element. For more information, see [\<Product> Element (ClickOnce Bootstrapper)](../vs140/-product--element--bootstrapper-.md).|  
  
## Example  
 The following code example specifies that the Microsoft Installer is installed with the [!INCLUDE[dnprdnshort](../vs140/includes/dnprdnshort_md.md)], and therefore will not need a separate installation.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [\<Product> Element (ClickOnce Bootstrapper)](../vs140/-product--element--bootstrapper-.md)