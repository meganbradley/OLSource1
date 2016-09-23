---
title: "hash_multiset::equal_range (STL-CLR)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
H1: hash_multiset::equal_range (STL/CLR)
f1_keywords: 
  - cliext::hash_multiset::equal_range
dev_langs: 
  - C++
helpviewer_keywords: 
  - equal_range member [STL/CLR]
ms.assetid: a4141d7e-4964-4c78-8989-ae1d1258b50a
caps.latest.revision: 19
translation.priority.ht: 
  - de-de
  - ja-jp
---
# hash_multiset::equal_range (STL-CLR)
Finds range that matches a specified key.  
  
## Syntax  
  
```  
cliext::pair<iterator, iterator> equal_range(key_type key);  
```  
  
#### Parameters  
 key  
 Key value to search for.  
  
## Remarks  
 The member function returns a pair of iterators `cliext::pair<iterator, iterator>(` [lower_bound](../vs140/hash_multiset--lower_bound--stl-clr-.md)`(``key``),` [upper_bound](../vs140/hash_multiset--upper_bound--stl-clr-.md)`(``key``))`. You use it to determine the range of elements currently in the controlled sequence that match a specified key.  
  
## Example  
  
```  
// cliext_hash_multiset_equal_range.cpp   
// compile with: /clr   
#include <cliext/hash_set>   
  
typedef cliext::hash_multiset<wchar_t> Myhash_multiset;   
typedef Myhash_multiset::pair_iter_iter Pairii;   
int main()   
    {   
    Myhash_multiset c1;   
    c1.insert(L'a');   
    c1.insert(L'b');   
    c1.insert(L'c');   
  
// display initial contents " a b c"   
    for each (wchar_t elem in c1)   
        System::Console::Write(" {0}", elem);   
    System::Console::WriteLine();   
  
// display results of failed search   
    Pairii pair1 = c1.equal_range(L'x');   
    System::Console::WriteLine("equal_range(L'x') empty = {0}",   
        pair1.first == pair1.second);   
  
// display results of successful search   
    pair1 = c1.equal_range(L'b');   
    for (; pair1.first != pair1.second; ++pair1.first)   
        System::Console::Write(" {0}", *pair1.first);   
    System::Console::WriteLine();   
    return (0);   
    }  
  
```  
  
  **a b c**  
**equal_range(L'x') empty = True**  
 **b**   
## Requirements  
 **Header:** <cliext/hash_set>  
  
 **Namespace:** cliext  
  
## See Also  
 [hash_multiset](../vs140/hash_multiset--stl-clr-.md)   
 [count](../vs140/hash_multiset--count--stl-clr-.md)   
 [find](../vs140/hash_multiset--find--stl-clr-.md)   
 [lower_bound](../vs140/hash_multiset--lower_bound--stl-clr-.md)   
 [upper_bound](../vs140/hash_multiset--upper_bound--stl-clr-.md)