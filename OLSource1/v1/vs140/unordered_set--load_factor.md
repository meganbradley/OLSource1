---
title: "unordered_set::load_factor"
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
  - "unordered_set.load_factor"
  - "unordered_set::load_factor"
  - "load_factor"
  - "std::tr1::unordered_set::load_factor"
  - "std.tr1.unordered_set.load_factor"
  - "unordered_set/std::tr1::unordered_set::load_factor"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "load_factor method [TR1]"
ms.assetid: 2e63cc57-3602-4554-a700-33d05ed78414
caps.latest.revision: 20
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# unordered_set::load_factor
Counts the average elements per bucket.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The member function returns <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>[size](../vs140/unordered_set--size.md)<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>[bucket_count](../vs140/unordered_set--bucket_count.md)<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, the average number of elements per bucket.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **[c] [b] [a]**  
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
 **Header:** \<unordered_set>  
  
 **Namespace:** std  
  
## See Also  
 [\<unordered_set>](../vs140/-unordered_set-.md)   
 [unordered_set](../vs140/unordered_set-class.md)   
 [unordered_set::bucket_count](../vs140/unordered_set--bucket_count.md)   
 [unordered_set::max_load_factor](../vs140/unordered_set--max_load_factor.md)