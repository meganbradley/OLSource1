---
title: "priority_queue::generic_value (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "priority_queue::generic_value (STL/CLR)"
f1_keywords: 
  - "cliext::priority_queue::generic_value"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "generic_value member [STL/CLR]"
ms.assetid: d534e95b-7939-4fb4-bb71-2164e2b97c4f
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# priority_queue::generic_value (STL-CLR)
The type of an element for use with the generic interface for the container.  
  
## Syntax  
  
```  
typedef GValue generic_value;  
```  
  
## Remarks  
 The type describes an object of type `GValue` that describes the stored element value for use with the generic interface for this template container class. (`GValue` is either `value_type` or `value_type^` if `value_type` is a ref type.)  
  
## Example  
  
```  
// cliext_priority_queue_generic_value.cpp   
// compile with: /clr   
#include <cliext/queue>   
  
typedef cliext::priority_queue<wchar_t> Mypriority_queue;   
int main()   
    {   
    Mypriority_queue c1;   
    c1.push(L'a');   
    c1.push(L'b');   
    c1.push(L'c');   
  
// display contents " a b c"   
    for each (wchar_t elem in c1.get_container())   
        System::Console::Write(" {0}", elem);   
    System::Console::WriteLine();   
  
// get interface to container   
    Mypriority_queue::generic_container^ gc1 = %c1;   
    for each (wchar_t elem in gc1->get_container())   
        System::Console::Write(" {0}", elem);   
    System::Console::WriteLine();   
  
// display in priority order using generic_value   
    for (; !gc1->empty(); gc1->pop())   
        {   
        Mypriority_queue::generic_value elem = gc1->top();   
  
        System::Console::Write(" {0}", elem);   
        }   
    System::Console::WriteLine();   
    return (0);   
    }  
  
```  
  
  **c a b**  
 **c a b**  
 **c b a**   
## Requirements  
 **Header:** <cliext/queue>  
  
 **Namespace:** cliext  
  
## See Also  
 [priority_queue](../VS_csharp/priority_queue--stl-clr-.md)   
 [generic_container](../VS_csharp/priority_queue--generic_container--stl-clr-.md)   
 [value_type](../VS_csharp/priority_queue--value_type--stl-clr-.md)