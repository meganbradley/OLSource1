---
title: "remove_extent Class"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "std::tr1::remove_extent"
  - "std.tr1.remove_extent"
  - "remove_extent"
  - "std.remove_extent"
  - "std::remove_extent"
  - "type_traits/std::remove_extent"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "remove_extent class [TR1]"
  - "remove_extent"
ms.assetid: b9320862-3891-49fc-80bc-571eb2c035cf
caps.latest.revision: 20
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# remove_extent Class
Makes element type from array type.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The type to modify.  
  
## Remarks  
 An instance of <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> holds a modified-type that is <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> when <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is of the form <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, otherwise <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **remove_extent_t\<int> == int**  
**remove_extent_t\<int[5]> == int**  
**remove_extent_t\<int[5][10]> == int [10]**    
## Requirements  
 **Header:** \<type_traits>  
  
 **Namespace:** std  
  
## See Also  
 [\<type_traits>](../vs140/-type_traits-.md)   
 [remove_all_extents](../vs140/remove_all_extents-class.md)