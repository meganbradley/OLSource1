---
title: "set::const_reference (STL-CLR)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
H1: set::const_reference (STL/CLR)
f1_keywords: 
  - cliext::set::const_reference
dev_langs: 
  - C++
helpviewer_keywords: 
  - const_reference member [STL/CLR]
ms.assetid: 25326f25-b4d3-4a92-950a-a843cdff7486
caps.latest.revision: 18
translation.priority.ht: 
  - de-de
  - ja-jp
---
# set::const_reference (STL-CLR)
The type of a constant reference to an element.  
  
## Syntax  
  
```  
typedef value_type% const_reference;  
```  
  
## Remarks  
 The type describes a constant reference to an element.  
  
## Example  
  
```  
// cliext_set_const_reference.cpp   
// compile with: /clr   
#include <cliext/set>   
  
typedef cliext::set<wchar_t> Myset;   
int main()   
    {   
    Myset c1;   
    c1.insert(L'a');   
    c1.insert(L'b');   
    c1.insert(L'c');   
  
// display initial contents " a b c"   
    Myset::const_iterator cit = c1.begin();   
    for (; cit != c1.end(); ++cit)   
        {   // get a const reference to an element   
        Myset::const_reference cref = *cit;   
        System::Console::Write(" {0}", cref);   
        }   
    System::Console::WriteLine();   
    return (0);   
    }  
  
```  
  
  **a b c**   
## Requirements  
 **Header:** <cliext/set>  
  
 **Namespace:** cliext  
  
## See Also  
 [set](../vs140/set--stl-clr-.md)   
 [reference](../vs140/set--reference--stl-clr-.md)   
 [value_type](../vs140/set--value_type--stl-clr-.md)