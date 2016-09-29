---
title: "multimap::value_type (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "multimap::value_type (STL/CLR)"
f1_keywords: 
  - "cliext::multimap::value_type"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "value_type member [STL/CLR]"
ms.assetid: c10d75f9-2efe-41f7-babc-655c68c14a4f
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# multimap::value_type (STL-CLR)
The type of an element.  
  
## Syntax  
  
```  
typedef generic_value value_type;  
```  
  
## Remarks  
 The type is a synonym for `generic_value`.  
  
## Example  
  
```  
// cliext_multimap_value_type.cpp   
// compile with: /clr   
#include <cliext/map>   
  
typedef cliext::multimap<wchar_t, int> Mymultimap;   
int main()   
    {   
    Mymultimap c1;   
    c1.insert(Mymultimap::make_value(L'a', 1));   
    c1.insert(Mymultimap::make_value(L'b', 2));   
    c1.insert(Mymultimap::make_value(L'c', 3));   
  
// display contents " [a 1] [b 2] [c 3]" using value_type   
    for (Mymultimap::iterator it = c1.begin(); it != c1.end(); ++it)   
        {   // store element in value_type object   
        Mymultimap::value_type val = *it;   
        System::Console::Write(" [{0} {1}]", val->first, val->second);   
        }   
    System::Console::WriteLine();   
    return (0);   
    }  
  
```  
  
  **[a 1] [b 2] [c 3]**   
## Requirements  
 **Header:** <cliext/map>  
  
 **Namespace:** cliext  
  
## See Also  
 [multimap](../VS_csharp/multimap--stl-clr-.md)   
 [const_reference](../VS_csharp/multimap--const_reference--stl-clr-.md)   
 [key_type](../VS_csharp/multimap--key_type--stl-clr-.md)   
 [reference](../VS_csharp/multimap--reference--stl-clr-.md)