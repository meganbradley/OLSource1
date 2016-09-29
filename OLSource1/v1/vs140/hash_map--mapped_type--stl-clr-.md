---
title: "hash_map::mapped_type (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "hash_map::mapped_type (STL/CLR)"
f1_keywords: 
  - "cliext::hash_map::mapped_type"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "mapped_type member [STL/CLR]"
ms.assetid: 00c8738f-7dd9-418d-9566-a2e05fd7e7f6
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_map::mapped_type (STL-CLR)
The type of a mapped value associated with each key.  
  
## Syntax  
  
```  
typedef Mapped mapped_type;  
```  
  
## Remarks  
 The type is a synonym for the template parameter `Mapped`.  
  
## Example  
  
```  
// cliext_hash_map_mapped_type.cpp   
// compile with: /clr   
#include <cliext/hash_map>   
  
typedef cliext::hash_map<wchar_t, int> Myhash_map;   
int main()   
    {   
    Myhash_map c1;   
    c1.insert(Myhash_map::make_value(L'a', 1));   
    c1.insert(Myhash_map::make_value(L'b', 2));   
    c1.insert(Myhash_map::make_value(L'c', 3));   
  
// display contents " [a 1] [b 2] [c 3]" using mapped_type   
    for (Myhash_map::iterator it = c1.begin(); it != c1.end(); ++it)   
        {   // store element in mapped_type object   
        Myhash_map::mapped_type val = it->second;   
  
        System::Console::Write(" {0}", val);   
        }   
    System::Console::WriteLine();   
    return (0);   
    }  
  
```  
  
  **1 2 3**   
## Requirements  
 **Header:** <cliext/hash_map>  
  
 **Namespace:** cliext  
  
## See Also  
 [hash_map](../vs140/hash_map--stl-clr-.md)   
 [key_compare](../vs140/hash_map--key_compare--stl-clr-.md)   
 [value_type](../vs140/hash_map--value_type--stl-clr-.md)