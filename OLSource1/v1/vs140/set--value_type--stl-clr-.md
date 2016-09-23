---
title: "set::value_type (STL-CLR)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
H1: set::value_type (STL/CLR)
f1_keywords: 
  - cliext::set::value_type
dev_langs: 
  - C++
helpviewer_keywords: 
  - value_type member [STL/CLR]
ms.assetid: 9af2fe12-9a8e-4919-9619-7a2f80988951
caps.latest.revision: 16
translation.priority.ht: 
  - de-de
  - ja-jp
---
# set::value_type (STL-CLR)
The type of an element.  
  
## Syntax  
  
```  
  
typedef generic_value value_type;  
  
```  
  
## Remarks  
 The type is a synonym for `generic_value`.  
  
## Example  
  
```  
// cliext_set_value_type.cpp   
// compile with: /clr   
#include <cliext/set>   
  
typedef cliext::set<wchar_t> Myset;   
int main()   
    {   
    Myset c1;   
    c1.insert(L'a');   
    c1.insert(L'b');   
    c1.insert(L'c');   
  
// display contents " a b c" using value_type   
    for (Myset::iterator it = c1.begin(); it != c1.end(); ++it)   
        {   // store element in value_type object   
        Myset::value_type val = *it;   
  
        System::Console::Write(" {0}", val);   
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
 [const_reference](../vs140/set--const_reference--stl-clr-.md)   
 [key_type](../vs140/set--key_type--stl-clr-.md)   
 [reference](../vs140/set--reference--stl-clr-.md)