---
title: "hash_multiset::load_factor (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "hash_multiset::load_factor (STL/CLR)"
f1_keywords: 
  - "cliext::hash_multiset::load_factor"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "load_factor member [STL/CLR]"
ms.assetid: 67125c97-1018-4d0f-858f-b4c09e7f0b09
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_multiset::load_factor (STL-CLR)
Counts the average elements per bucket.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The member function returns <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>[size](../vs140/hash_multiset--size--stl-clr-.md)<CodeContentPlaceHolder>3\</CodeContentPlaceHolder> [bucket_count](../vs140/hash_multiset--bucket_count--stl-clr-.md)<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. You use it to determine the average bucket size.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **a b c**  
**bucket_count() = 16**  
**load_factor() = 0.1875**  
**max_load_factor() = 4**  
**bucket_count() = 16**  
**load_factor() = 0.1875**  
**max_load_factor() = 0.25**  
**bucket_count() = 128**  
**load_factor() = 0.0234375**  
**max_load_factor() = 0.25**   
## Requirements  
 **Header:** \<cliext/hash_set>  
  
 **Namespace:** cliext  
  
## See Also  
 [hash_multiset](../vs140/hash_multiset--stl-clr-.md)   
 [bucket_count](../vs140/hash_multiset--bucket_count--stl-clr-.md)   
 [max_load_factor](../vs140/hash_multiset--max_load_factor--stl-clr-.md)