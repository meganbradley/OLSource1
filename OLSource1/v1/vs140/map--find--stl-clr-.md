---
title: "map::find (STL-CLR)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
H1: map::find (STL/CLR)
f1_keywords: 
  - cliext::map::find
dev_langs: 
  - C++
helpviewer_keywords: 
  - find member [STL/CLR]
ms.assetid: 779dcbee-d584-4fbd-b788-481e094ece9d
caps.latest.revision: 18
translation.priority.ht: 
  - de-de
  - ja-jp
---
# map::find (STL-CLR)
Finds an element that matches a specified key.  
  
## Syntax  
  
```  
iterator find(key_type key);  
```  
  
#### Parameters  
 key  
 Key value to search for.  
  
## Remarks  
 If at least one element in the controlled sequence has equivalent ordering with `key`, the member function returns an iterator designating one of those elements; otherwise it returns [end](../vs140/map--end--stl-clr-.md)`()`. You use it to locate an element currently in the controlled sequence that matches a specified key.  
  
## Example  
  
```  
// cliext_map_find.cpp   
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
  
    System::Console::WriteLine("find {0} = {1}",   
        L'A', c1.find(L'A') != c1.end());   
  
    Mymap::iterator it = c1.find(L'b');   
    System::Console::WriteLine("find {0} = [{1} {2}]",   
        L'b', it->first, it->second);   
  
    System::Console::WriteLine("find {0} = {1}",   
        L'C', c1.find(L'C') != c1.end());   
    return (0);   
    }  
  
```  
  
  **[a 1] [b 2] [c 3]**  
**find A = False**  
**find b = [b 2]**  
**find C = False**   
## Description  
 Note that `find` does not guarantee which of several element it finds.  
  
## Requirements  
 **Header:** <cliext/map>  
  
 **Namespace:** cliext  
  
## See Also  
 [map](../vs140/map--stl-clr-.md)   
 [equal_range](../vs140/map--equal_range--stl-clr-.md)   
 [lower_bound](../vs140/map--lower_bound--stl-clr-.md)   
 [upper_bound](../vs140/map--upper_bound--stl-clr-.md)