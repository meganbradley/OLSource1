---
title: "collection_adapter::mapped_type (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "collection_adapter::mapped_type (STL/CLR)"
f1_keywords: 
  - "cliext::collection_adapter::mapped_type"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "mapped_type member [STL/CLR]"
ms.assetid: eece6a47-611a-47d4-8dfc-cfbbc4aeb67b
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# collection_adapter::mapped_type (STL-CLR)
The type of a dictionary value.  
  
## Syntax  
  
```  
typedef Value mapped_type;  
```  
  
## Remarks  
 The type is a synonym for the template parameter `Value`, in a specialization for `IDictionary` or `IDictionary<Value>`; otherwise it is not defined.  
  
## Example  
  
```  
// cliext_collection_adapter_mapped_type.cpp   
// compile with: /clr   
#include <cliext/adapter>   
#include <cliext/map>   
  
typedef cliext::map<wchar_t, int> Mymap;   
typedef cliext::collection_adapter<   
    System::Collections::Generic::IDictionary<wchar_t, int>> Mycoll;   
typedef System::Collections::Generic::KeyValuePair<wchar_t,int> Mypair;   
int main()   
    {   
    Mymap d1;   
    d1.insert(Mymap::make_value(L'a', 1));   
    d1.insert(Mymap::make_value(L'b', 2));   
    d1.insert(Mymap::make_value(L'c', 3));   
    Mycoll c1(%d1);   
  
// display contents " [a 1] [b 2] [c 3]"   
    for each (Mypair elem in c1)   
        {   
        Mycoll::key_type key = elem.Key;   
        Mycoll::mapped_type value = elem.Value;   
        System::Console::Write(" [{0} {1}]", key, value);   
        }   
    System::Console::WriteLine();   
    return (0);   
    }  
  
```  
  
  **[a 1] [b 2] [c 3]**   
## Requirements  
 **Header:** <cliext/adapter>  
  
 **Namespace:** cliext  
  
## See Also  
 [collection_adapter](../vs140/collection_adapter--stl-clr-.md)   
 [key_type](../vs140/collection_adapter--key_type--stl-clr-.md)