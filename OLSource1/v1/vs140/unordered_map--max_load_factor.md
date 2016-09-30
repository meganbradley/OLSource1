---
title: "unordered_map::max_load_factor"
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
  - "unordered_map.max_load_factor"
  - "std::tr1::unordered_map::max_load_factor"
  - "max_load_factor"
  - "unordered_map::max_load_factor"
  - "std.tr1.unordered_map.max_load_factor"
  - "unordered_map/std::tr1::unordered_map::max_load_factor"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "max_load_factor method [TR1]"
ms.assetid: a3256044-7164-45ad-9e6a-aa8fcef078d5
caps.latest.revision: 20
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# unordered_map::max_load_factor
Gets or sets the maximum elements per bucket.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The new maximum load factor.  
  
## Remarks  
 The first member function returns the stored maximum load factor. The second member function replaces the stored maximum load factor with <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **[c, 3] [b, 2] [a, 1]**  
**bucket_count() == 8**  
**load_factor() == 0.375**  
**max_bucket_count() == 8**  
**max_load_factor() == 4**  
**bucket_count() == 8**  
**load_factor() == 0.375**  
**max_bucket_count() == 8**  
**max_load_factor() == 0.1**  
**bucket_count() == 128**  
**load_factor() == 0.0234375**  
**max_bucket_count() == 128**  
**max_load_factor() == 0.1**   
## Requirements  
 **Header:** \<unordered_map>  
  
 **Namespace:** std  
  
## See Also  
 [\<unordered_map>](../vs140/-unordered_map-.md)   
 [unordered_map](../vs140/unordered_map-class.md)   
 [unordered_map::load_factor](../vs140/unordered_map--load_factor.md)   
 [unordered_map::rehash](../vs140/unordered_map--rehash.md)