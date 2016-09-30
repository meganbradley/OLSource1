---
title: "hash_map::load_factor (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "hash_map::load_factor (STL/CLR)"
f1_keywords: 
  - "cliext::hash_map::load_factor"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "load_factor member [STL/CLR]"
ms.assetid: e3a29b1f-ea20-4153-87b0-3935044d4d7a
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_map::load_factor (STL-CLR)
Counts the average elements per bucket.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The member function returns <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>[size](../vs140/hash_map--size--stl-clr-.md)<CodeContentPlaceHolder>3\</CodeContentPlaceHolder> [bucket_count](../vs140/hash_map--bucket_count--stl-clr-.md)<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. You use it to determine the average bucket size.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **[a 1] [b 2] [c 3]**  
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
 **Header:** \<cliext/hash_map>  
  
 **Namespace:** cliext  
  
## See Also  
 [hash_map](../vs140/hash_map--stl-clr-.md)   
 [bucket_count](../vs140/hash_map--bucket_count--stl-clr-.md)   
 [max_load_factor](../vs140/hash_map--max_load_factor--stl-clr-.md)