---
title: "hash_map::upper_bound (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "hash_map::upper_bound (STL/CLR)"
f1_keywords: 
  - "cliext::hash_map::upper_bound"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "upper_bound member [STL/CLR]"
ms.assetid: f83e88b4-e15e-49d5-90e4-cf7360c27c30
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_map::upper_bound (STL-CLR)
Finds end of range that matches a specified key.  
  
## Syntax  
  
```  
iterator upper_bound(key_type key);  
```  
  
#### Parameters  
 key  
 Key value to search for.  
  
## Remarks  
 The member function determines the last element `X` in the controlled sequence that hashes to the same bucket as `key` and has equivalent ordering to `key`. If no such element exists, or if `X` is the last element in the controlled sequence, it returns [end](../VS_csharp/hash_map--end--stl-clr-.md)`()`; otherwise it returns an iterator that designates the first element beyond `X`. You use it to locate the end of a sequence of elements currently in the controlled sequence that match a specified key.  
  
## Example  
  
```  
// cliext_hash_map_upper_bound.cpp   
// compile with: /clr   
#include <cliext/hash_map>   
  
typedef cliext::hash_map<wchar_t, int> Myhash_map;   
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
  
    System::Console::WriteLine("upper_bound(L'x')==end() = {0}",   
        c1.upper_bound(L'x') == c1.end());   
  
    Myhash_map::iterator it = c1.upper_bound(L'a');   
    System::Console::WriteLine("*upper_bound(L'a') = [{0} {1}]",   
        it->first, it->second);   
    it = c1.upper_bound(L'b');   
    System::Console::WriteLine("*upper_bound(L'b') = [{0} {1}]",   
        it->first, it->second);   
    return (0);   
    }  
  
```  
  
  **[a 1] [b 2] [c 3]**  
**upper_bound(L'x')==end() = True**  
**\*upper_bound(L'a') = [b 2]**  
**\*upper_bound(L'b') = [c 3]**   
## Requirements  
 **Header:** <cliext/hash_map>  
  
 **Namespace:** cliext  
  
## See Also  
 [hash_map](../VS_csharp/hash_map--stl-clr-.md)   
 [count](../VS_csharp/hash_map--count--stl-clr-.md)   
 [equal_range](../VS_csharp/hash_map--equal_range--stl-clr-.md)   
 [find](../VS_csharp/hash_map--find--stl-clr-.md)   
 [lower_bound](../VS_csharp/hash_map--lower_bound--stl-clr-.md)