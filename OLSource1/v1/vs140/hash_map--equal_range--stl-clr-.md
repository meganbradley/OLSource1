---
title: "hash_map::equal_range (STL-CLR)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
H1: hash_map::equal_range (STL/CLR)
f1_keywords: 
  - cliext::hash_map::equal_range
dev_langs: 
  - C++
helpviewer_keywords: 
  - equal_range member [STL/CLR]
ms.assetid: 9b9a18b8-42fd-4d17-91bd-df85e583cf61
caps.latest.revision: 20
translation.priority.ht: 
  - de-de
  - ja-jp
---
# hash_map::equal_range (STL-CLR)
Finds range that matches a specified key.  
  
## Syntax  
  
```  
cliext::pair<iterator, iterator> equal_range(key_type key);  
```  
  
#### Parameters  
 key  
 Key value to search for.  
  
## Remarks  
 The member function returns a pair of iterators `cliext::pair<iterator, iterator>(` [lower_bound](../vs140/hash_map--lower_bound--stl-clr-.md)`(``key``),` [upper_bound](../vs140/hash_map--upper_bound--stl-clr-.md)`(``key``))`. You use it to determine the range of elements currently in the controlled sequence that match a specified key.  
  
## Example  
  
```  
// cliext_hash_map_equal_range.cpp   
// compile with: /clr   
#include <cliext/hash_map>   
  
typedef cliext::hash_map<wchar_t, int> Myhash_map;   
typedef Myhash_map::pair_iter_iter Pairii;   
int main()   
    {   
    Myhash_map c1;   
    c1.insert(Myhash_map::make_value(L'a', 1));   
    c1.insert(Myhash_map::make_value(L'b', 2));   
    c1.insert(Myhash_map::make_value(L'c', 3));   
  
// display contents " [a 1] [b 2] [c 3]"   
    for each (Myhash_map::value_type elem in c1)   
        System::Console::Write(" [{0} {1}]", elem->first, elem->second);   
    System::Console::WriteLine();   
  
// display results of failed search   
    Pairii pair1 = c1.equal_range(L'x');   
    System::Console::WriteLine("equal_range(L'x') empty = {0}",   
        pair1.first == pair1.second);   
  
// display results of successful search   
    pair1 = c1.equal_range(L'b');   
    for (; pair1.first != pair1.second; ++pair1.first)   
        System::Console::Write(" [{0} {1}]",   
            pair1.first->first, pair1.first->second);   
    System::Console::WriteLine();   
    return (0);   
    }  
  
```  
  
  **[a 1] [b 2] [c 3]**  
**equal_range(L'x') empty = True**  
 **[b 2]**   
## Requirements  
 **Header:** <cliext/hash_map>  
  
 **Namespace:** cliext  
  
## See Also  
 [hash_map](../vs140/hash_map--stl-clr-.md)   
 [count](../vs140/hash_map--count--stl-clr-.md)   
 [find](../vs140/hash_map--find--stl-clr-.md)   
 [lower_bound](../vs140/hash_map--lower_bound--stl-clr-.md)   
 [upper_bound](../vs140/hash_map--upper_bound--stl-clr-.md)