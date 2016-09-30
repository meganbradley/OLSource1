---
title: "unordered_map::rehash"
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
  - "std.tr1.unordered_map.rehash"
  - "unordered_map::rehash"
  - "unordered_map/std::tr1::unordered_map::rehash"
  - "std::tr1::unordered_map::rehash"
  - "rehash"
  - "unordered_map.rehash"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "rehash method [TR1]"
ms.assetid: 1cd7629a-1869-4db7-baca-301331439ac4
caps.latest.revision: 20
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# unordered_map::rehash
Rebuilds the hash table.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The requested number of buckets.  
  
## Remarks  
 The member function alters the number of buckets to be at least <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> and rebuilds the hash table as needed.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **[c, 3] [b, 2] [a, 1]**  
**bucket_count() == 8**  
**load_factor() == 0.375**  
**max_load_factor() == 4**  
**bucket_count() == 8**  
**load_factor() == 0.375**  
**max_load_factor() == 0.1**  
**bucket_count() == 128**  
**load_factor() == 0.0234375**  
**max_load_factor() == 0.1**   
## Requirements  
 **Header:** \<unordered_map>  
  
 **Namespace:** std  
  
## See Also  
 [\<unordered_map>](../vs140/-unordered_map-.md)   
 [unordered_map](../vs140/unordered_map-class.md)   
 [unordered_map::max_load_factor](../vs140/unordered_map--max_load_factor.md)