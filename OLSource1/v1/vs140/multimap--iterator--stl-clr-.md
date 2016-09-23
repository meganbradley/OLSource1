---
title: "multimap::iterator (STL-CLR)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
H1: multimap::iterator (STL/CLR)
f1_keywords: 
  - cliext::multimap::iterator
dev_langs: 
  - C++
helpviewer_keywords: 
  - iterator member [STL/CLR]
ms.assetid: 2923f4bc-b216-477b-b10e-22bf15847c67
caps.latest.revision: 17
translation.priority.ht: 
  - de-de
  - ja-jp
---
# multimap::iterator (STL-CLR)
The type of an iterator for the controlled sequence.  
  
## Syntax  
  
```  
typedef T1 iterator;  
```  
  
## Remarks  
 The type describes an object of unspecified type `T1` that can serve as a bidirectional iterator for the controlled sequence.  
  
## Example  
  
```  
// cliext_multimap_iterator.cpp   
// compile with: /clr   
#include <cliext/map>   
  
typedef cliext::multimap<wchar_t, int> Mymultimap;   
int main()   
    {   
    Mymultimap c1;   
    c1.insert(Mymultimap::make_value(L'a', 1));   
    c1.insert(Mymultimap::make_value(L'b', 2));   
    c1.insert(Mymultimap::make_value(L'c', 3));   
  
// display contents " [a 1] [b 2] [c 3]"   
    Mymultimap::iterator it = c1.begin();   
    for (; it != c1.end(); ++it)   
        System::Console::Write(" [{0} {1}]", it->first, it->second);   
    System::Console::WriteLine();   
    return (0);   
    }  
  
```  
  
  **[a 1] [b 2] [c 3]**   
## Requirements  
 **Header:** <cliext/map>  
  
 **Namespace:** cliext  
  
## See Also  
 [multimap](../vs140/multimap--stl-clr-.md)   
 [const_iterator](../vs140/multimap--const_iterator--stl-clr-.md)