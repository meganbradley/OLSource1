---
title: "multiset::value_compare (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "multiset::value_compare (STL/CLR)"
f1_keywords: 
  - "cliext::multiset::value_compare"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "value_compare member [STL/CLR]"
ms.assetid: 962e5a3b-5841-4b44-8801-5f5349e95c8f
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# multiset::value_compare (STL-CLR)
The ordering delegate for two element values.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The type is a synonym for the delegate that determines the ordering of its value arguments.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **compare(L'a', L'a') = False**  
**compare(L'a', L'b') = True**  
**compare(L'b', L'a') = False**   
## Requirements  
 **Header:** \<cliext/set>  
  
 **Namespace:** cliext  
  
## See Also  
 [multiset](../vs140/multiset--stl-clr-.md)   
 [key_compare](../vs140/multiset--key_compare--stl-clr-.md)   
 [value_comp](../vs140/multiset--value_comp--stl-clr-.md)   
 [value_type](../vs140/multiset--value_type--stl-clr-.md)