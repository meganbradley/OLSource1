---
title: "map::lower_bound (STL-CLR)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
H1: map::lower_bound (STL/CLR)
f1_keywords: 
  - cliext::map::lower_bound
dev_langs: 
  - C++
helpviewer_keywords: 
  - lower_bound member [STL/CLR]
ms.assetid: 959651a0-f949-4cc1-859b-248b6930f16c
caps.latest.revision: 18
translation.priority.ht: 
  - de-de
  - ja-jp
---
# map::lower_bound (STL-CLR)
Finds beginning of range that matches a specified key.  
  
## Syntax  
  
```  
iterator lower_bound(key_type key);  
```  
  
#### Parameters  
 key  
 Key value to search for.  
  
## Remarks  
 The member function determines the first element `X` in the controlled sequence that has equivalent ordering to `key`. If no such element exists, it returns [end](../vs140/map--end--stl-clr-.md)`()`; otherwise it returns an iterator that designates `X`. You use it to locate the beginning of a sequence of elements currently in the controlled sequence that match a specified key.  
  
## Example  
  
```  
// cliext_map_lower_bound.cpp   
// compile with: /clr   
#include <cliext/map>   
  
typedef cliext::map<wchar_t, int> Mymap;   
int main()   
    {   
    Mymap c1;   
    c1.insert(Mymap::make_value(L'a', 1));   
    c1.insert(Mymap::make_value(L'b', 2));   
    c1.insert(Mymap::make_value(L'c', 3));   
  
// display contents " [a 1] [b 2] [c 3]"   
    for each (Mymap::value_type elem in c1)   
        System::Console::Write(" [{0} {1}]", elem->first, elem->second);   
    System::Console::WriteLine();   
  
    System::Console::WriteLine("lower_bound(L'x')==end() = {0}",   
        c1.lower_bound(L'x') == c1.end());   
  
    Mymap::iterator it = c1.lower_bound(L'a');   
    System::Console::WriteLine("*lower_bound(L'a') = [{0} {1}]",   
        it->first, it->second);   
    it = c1.lower_bound(L'b');   
    System::Console::WriteLine("*lower_bound(L'b') = [{0} {1}]",   
        it->first, it->second);   
    return (0);   
    }  
  
```  
  
  **[a 1] [b 2] [c 3]**  
**lower_bound(L'x')==end() = True**  
**\*lower_bound(L'a') = [a 1]**  
**\*lower_bound(L'b') = [b 2]**   
## Requirements  
 **Header:** <cliext/map>  
  
 **Namespace:** cliext  
  
## See Also  
 [map](../vs140/map--stl-clr-.md)   
 [count](../vs140/map--count--stl-clr-.md)   
 [equal_range](../vs140/map--equal_range--stl-clr-.md)   
 [find](../vs140/map--find--stl-clr-.md)   
 [upper_bound](../vs140/map--upper_bound--stl-clr-.md)