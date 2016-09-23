---
title: "Value of type &#39;&lt;type1&gt;&#39; cannot be converted to &#39;&lt;type2&gt;&#39; because &#39;&lt;type3&gt;&#39; is not derived from &#39;&lt;type4&gt;&#39;"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - vbc30332
  - bc30332
helpviewer_keywords: 
  - BC30332
ms.assetid: 290081f8-eeb5-4b5c-818b-7159fe91f1ec
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Value of type &#39;&lt;type1&gt;&#39; cannot be converted to &#39;&lt;type2&gt;&#39; because &#39;&lt;type3&gt;&#39; is not derived from &#39;&lt;type4&gt;&#39;
A statement attempts to convert an array type to another array type in a situation where the data types of the elements of the arrays are not both reference types, or where a conversion, either widening or narrowing, is not possible between the element types of the two arrays.  
  
 **Error ID:** BC30332  
  
### To correct this error  
  
-   Check the data types of the elements of both arrays to determine the source of the error.  
  
## See Also  
 [Arrays](../vs140/arrays-in-visual-basic.md)   
 [Array Conversions](../vs140/array-conversions--visual-basic-.md)