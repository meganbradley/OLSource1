---
title: "hash_multimap::key_type (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "hash_multimap::key_type (STL/CLR)"
f1_keywords: 
  - "cliext::hash_multimap::key_type"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "key_type member [STL/CLR]"
ms.assetid: fd6ef622-6812-4574-b459-d3ee110b0382
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_multimap::key_type (STL-CLR)
The type of an ordering key.  
  
## Syntax  
  
```  
typedef Key key_type;  
```  
  
## Remarks  
 The type is a synonym for the template parameter `Key`.  
  
## Example  
  
```  
// cliext_hash_multimap_key_type.cpp   
// compile with: /clr   
#include <cliext/hash_map>   
  
typedef cliext::hash_multimap<wchar_t, int> Myhash_multimap;   
int main()   
    {   
    Myhash_multimap c1;   
    c1.insert(Myhash_multimap::make_value(L'a', 1));   
    c1.insert(Myhash_multimap::make_value(L'b', 2));   
    c1.insert(Myhash_multimap::make_value(L'c', 3));   
  
// display contents " [a 1] [b 2] [c 3]" using key_type   
    for (Myhash_multimap::iterator it = c1.begin(); it != c1.end(); ++it)   
        {   // store element in key_type object   
        Myhash_multimap::key_type val = it->first;   
  
        System::Console::Write(" {0}", val);   
        }   
    System::Console::WriteLine();   
    return (0);   
    }  
  
```  
  
  **a b c**   
## Requirements  
 **Header:** <cliext/hash_map>  
  
 **Namespace:** cliext  
  
## See Also  
 [hash_multimap](../vs140/hash_multimap--stl-clr-.md)   
 [key_compare](../vs140/hash_multimap--key_compare--stl-clr-.md)   
 [mapped_type](../vs140/hash_multimap--mapped_type--stl-clr-.md)   
 [value_type](../vs140/hash_multimap--value_type--stl-clr-.md)