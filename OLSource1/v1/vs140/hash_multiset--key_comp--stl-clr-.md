---
title: "hash_multiset::key_comp (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "hash_multiset::key_comp (STL/CLR)"
f1_keywords: 
  - "cliext::hash_multiset::key_comp"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "key_comp member [STL/CLR]"
ms.assetid: b9653dd2-20f3-4ef3-875f-265749839ba6
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_multiset::key_comp (STL-CLR)
Copies the ordering delegate for two keys.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The member function returns the ordering delegate used to order the controlled sequence. You use it to compare two keys.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **compare(L'a', L'a') = True**  
**compare(L'a', L'b') = True**  
**compare(L'b', L'a') = False**  
**compare(L'a', L'a') = False**  
**compare(L'a', L'b') = False**  
**compare(L'b', L'a') = True**   
## Requirements  
 **Header:** \<cliext/hash_set>  
  
 **Namespace:** cliext  
  
## See Also  
 [hash_multiset](../vs140/hash_multiset--stl-clr-.md)   
 [key_compare](../vs140/hash_multiset--key_compare--stl-clr-.md)   
 [key_type](../vs140/hash_multiset--key_type--stl-clr-.md)