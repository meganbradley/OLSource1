---
title: "multiset::upper_bound (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "multiset::upper_bound (STL/CLR)"
f1_keywords: 
  - "cliext::multiset::upper_bound"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "upper_bound member [STL/CLR]"
ms.assetid: 4a5af99f-a2a1-45be-9b01-c0055d4d0e35
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# multiset::upper_bound (STL-CLR)
Finds end of range that matches a specified key.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 key  
 Key value to search for.  
  
## Remarks  
 The member function determines the last element <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> in the controlled sequence that has equivalent ordering to <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. If no such element exists, or if <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is the last element in the controlled sequence, it returns [end](../vs140/multiset--end--stl-clr-.md)<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>; otherwise it returns an iterator that designates the first element beyond <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. You use it to locate the end of a sequence of elements currently in the controlled sequence that match a specified key.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **a b c**  
**upper_bound(L'x')==end() = True**  
**\*upper_bound(L'a') = b**  
**\*upper_bound(L'b') = c**   
## Requirements  
 **Header:** \<cliext/set>  
  
 **Namespace:** cliext  
  
## See Also  
 [multiset](../vs140/multiset--stl-clr-.md)   
 [count](../vs140/multiset--count--stl-clr-.md)   
 [equal_range](../vs140/multiset--equal_range--stl-clr-.md)   
 [find](../vs140/multiset--find--stl-clr-.md)   
 [lower_bound](../vs140/multiset--lower_bound--stl-clr-.md)