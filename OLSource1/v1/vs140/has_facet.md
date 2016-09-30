---
title: "has_facet"
ms.custom: na
ms.date: "09/21/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "std::has_facet"
  - "std.has_facet"
  - "locale/std::has_facet"
  - "has_facet"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "has_facet"
  - "has_facet function"
ms.assetid: 13564b12-0ce0-4066-b5b8-7f9895176fde
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# has_facet
Tests if a particular facet is stored in a specified locale.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The locale to be tested for the presence of a facet.  
  
## Return Value  
 **true** if the locale has the facet tested for; **false** if it does not.  
  
## Remarks  
 The template function is useful for checking whether nonmandatory facets are listed in a locale before <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is called to avoid the exception that would be thrown if it were not present.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **1**   
## Requirements  
 **Header:** \<locale>  
  
 **Namespace:** std