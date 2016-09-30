---
title: "unordered_map::load_factor"
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
  - "std.tr1.unordered_map.load_factor"
  - "unordered_map::load_factor"
  - "std::tr1::unordered_map::load_factor"
  - "load_factor"
  - "unordered_map.load_factor"
  - "unordered_map/std::tr1::unordered_map::load_factor"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "load_factor method [TR1]"
ms.assetid: 2f113538-379c-4d1a-b1ad-3cad7926c681
caps.latest.revision: 20
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# unordered_map::load_factor
Counts the average elements per bucket.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The member function returns <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>[size](../vs140/unordered_map--size.md)<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>[bucket_count](../vs140/unordered_map--bucket_count.md)<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, the average number of elements per bucket.  
  
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
 [unordered_map::bucket_count](../vs140/unordered_map--bucket_count.md)   
 [unordered_map::max_load_factor](../vs140/unordered_map--max_load_factor.md)