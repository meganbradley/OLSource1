---
title: "use_facet"
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
  - "std.use_facet"
  - "std::use_facet"
  - "xlocale/std::use_facet"
  - "use_facet"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "use_facet"
  - "use_facet function"
ms.assetid: cacbd60b-6263-45c2-84db-369730f46733
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# use_facet
Returns a reference to a facet of a specified type stored in a locale.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The const locale containing the type of facet being referenced.  
  
## Return Value  
 A reference to the facet of class <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> contained within the argument locale.  
  
## Remarks  
 The reference to the facet returned by the template function remains valid as long as any copy of the containing locale exists. If no such facet object of class <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is listed in the argument locale, the function throws a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> exception.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The character 'a' in locale loc1 is alphabetic.**  
**The character '!' in locale loc2 is not alphabetic.**   
## Requirements  
 **Header:** \<locale>  
  
 **Namespace:** std