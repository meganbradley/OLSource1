---
title: "multimap::clear (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "multimap::clear (STL/CLR)"
f1_keywords: 
  - "cliext::multimap::clear"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "clear member [STL/CLR]"
ms.assetid: 2c4aae4b-0aac-42ba-abf4-eaf2d5734817
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# multimap::clear (STL-CLR)
Removes all elements.  
  
## Syntax  
  
```  
void clear();  
```  
  
## Remarks  
 The member function effectively calls [erase](../vs140/multimap--erase--stl-clr-.md)`(` [begin](../vs140/multimap--begin--stl-clr-.md)`(),` [end](../vs140/multimap--end--stl-clr-.md)`())`. You use it to ensure that the controlled sequence is empty.  
  
## Example  
  
```  
// cliext_multimap_clear.cpp   
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
    for each (Mymultimap::value_type elem in c1)   
        System::Console::Write(" [{0} {1}]", elem->first, elem->second);   
    System::Console::WriteLine();   
  
// clear the container and reinspect   
    c1.clear();   
    System::Console::WriteLine("size() = {0}", c1.size());   
  
    c1.insert(Mymultimap::make_value(L'a', 1));   
    c1.insert(Mymultimap::make_value(L'b', 2));   
  
// display contents " [a 1] [b 2]"   
    for each (Mymultimap::value_type elem in c1)   
        System::Console::Write(" [{0} {1}]", elem->first, elem->second);   
    System::Console::WriteLine();   
    c1.clear();   
    System::Console::WriteLine("size() = {0}", c1.size());   
    return (0);   
    }  
  
```  
  
  **[a 1] [b 2] [c 3]**  
**size() = 0**  
 **[a 1] [b 2]**  
**size() = 0**   
## Requirements  
 **Header:** <cliext/map>  
  
 **Namespace:** cliext  
  
## See Also  
 [multimap](../vs140/multimap--stl-clr-.md)   
 [erase](../vs140/multimap--erase--stl-clr-.md)