---
title: "multimap::value_compare (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "multimap::value_compare (STL/CLR)"
f1_keywords: 
  - "cliext::multimap::value_compare"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "value_compare member [STL/CLR]"
ms.assetid: a066968b-df6e-40a7-83fd-b8520b07a1e0
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# multimap::value_compare (STL-CLR)
The ordering delegate for two element values.  
  
## Syntax  
  
```  
Microsoft::VisualC::StlClr::BinaryDelegate<generic_value, generic_value, bool>  
    value_compare;  
```  
  
## Remarks  
 The type is a synonym for the delegate that determines the ordering of its value arguments.  
  
## Example  
  
```  
// cliext_multimap_value_compare.cpp   
// compile with: /clr   
#include <cliext/map>   
  
typedef cliext::map<wchar_t, int> Mymultimap;   
int main()   
    {   
    Mymultimap c1;   
    Mymultimap::value_compare^ kcomp = c1.value_comp();   
  
    System::Console::WriteLine("compare([L'a', 1], [L'a', 1]) = {0}",   
        kcomp(Mymultimap::make_value(L'a', 1),   
            Mymultimap::make_value(L'a', 1)));   
    System::Console::WriteLine("compare([L'a', 1], [L'b', 2]) = {0}",   
        kcomp(Mymultimap::make_value(L'a', 1),   
            Mymultimap::make_value(L'b', 2)));   
    System::Console::WriteLine("compare([L'b', 2], [L'a', 1]) = {0}",   
        kcomp(Mymultimap::make_value(L'b', 2),   
            Mymultimap::make_value(L'a', 1)));   
    System::Console::WriteLine();   
    return (0);   
    }  
  
```  
  
 **compare([L'a', 1], [L'a', 1]) = False**  
**compare([L'a', 1], [L'b', 2]) = True**  
**compare([L'b', 2], [L'a', 1]) = False**   
## Requirements  
 **Header:** <cliext/map>  
  
 **Namespace:** cliext  
  
## See Also  
 [multimap](../vs140/multimap--stl-clr-.md)   
 [key_compare](../vs140/multimap--key_compare--stl-clr-.md)   
 [value_comp](../vs140/multimap--value_comp--stl-clr-.md)   
 [value_type](../vs140/multimap--value_type--stl-clr-.md)