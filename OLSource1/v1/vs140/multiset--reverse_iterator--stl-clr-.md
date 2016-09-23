---
title: "multiset::reverse_iterator (STL-CLR)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
H1: multiset::reverse_iterator (STL/CLR)
f1_keywords: 
  - cliext::multiset::reverse_iterator
dev_langs: 
  - C++
helpviewer_keywords: 
  - reverse_iterator member [STL/CLR]
ms.assetid: dde6ad36-ca59-4728-aa53-e3d117eb4f48
caps.latest.revision: 16
translation.priority.ht: 
  - de-de
  - ja-jp
---
# multiset::reverse_iterator (STL-CLR)
The type of a reverse iterator for the controlled sequence.  
  
## Syntax  
  
```  
typedef T3 reverse_iterator;  
```  
  
## Remarks  
 The type describes an object of unspecified type `T3` that can serve as a reverse iterator for the controlled sequence.  
  
## Example  
  
```  
// cliext_multiset_reverse_iterator.cpp   
// compile with: /clr   
#include <cliext/set>   
  
typedef cliext::multiset<wchar_t> Mymultiset;   
int main()   
    {   
    Mymultiset c1;   
    c1.insert(L'a');   
    c1.insert(L'b');   
    c1.insert(L'c');   
  
// display contents " a b c" reversed   
    Mymultiset::reverse_iterator rit = c1.rbegin();   
    for (; rit != c1.rend(); ++rit)   
        System::Console::Write(" {0}", *rit);   
    System::Console::WriteLine();   
    return (0);   
    }  
  
```  
  
  **c b a**   
## Requirements  
 **Header:** <cliext/set>  
  
 **Namespace:** cliext  
  
## See Also  
 [multiset](../vs140/multiset--stl-clr-.md)   
 [const_iterator](../vs140/multiset--const_iterator--stl-clr-.md)   
 [const_reverse_iterator](../vs140/multiset--const_reverse_iterator--stl-clr-.md)   
 [iterator](../vs140/multiset--iterator--stl-clr-.md)