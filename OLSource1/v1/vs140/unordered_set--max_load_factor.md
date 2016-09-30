---
title: "unordered_set::max_load_factor"
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
  - "max_load_factor"
  - "unordered_set/std::tr1::unordered_set::max_load_factor"
  - "std.tr1.unordered_set.max_load_factor"
  - "std::tr1::unordered_set::max_load_factor"
  - "unordered_set::max_load_factor"
  - "unordered_set.max_load_factor"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "max_load_factor method [TR1]"
ms.assetid: 16ed9119-c84a-41c5-bd0f-6a0f1c8a4350
caps.latest.revision: 20
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# unordered_set::max_load_factor
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
 [unordered_set::load_factor](../vs140/unordered_set--load_factor.md)   
 [unordered_set::rehash](../vs140/unordered_set--rehash.md)