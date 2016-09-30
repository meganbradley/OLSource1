---
title: "hash_set::key_compare (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "hash_set::key_compare (STL/CLR)"
f1_keywords: 
  - "cliext::hash_set::key_compare"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "key_compare member [STL/CLR]"
ms.assetid: 93a94dde-3296-4e34-b461-3e2a20801041
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_set::key_compare (STL-CLR)
The ordering delegate for two keys.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The type is a synonym for the delegate that determines the ordering of its key arguments.  
  
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
 [hash_set](../vs140/hash_set--stl-clr-.md)   
 [key_comp](../vs140/hash_set--key_comp--stl-clr-.md)   
 [key_type](../vs140/hash_set--key_type--stl-clr-.md)   
 [value_compare](../vs140/hash_set--value_compare--stl-clr-.md)