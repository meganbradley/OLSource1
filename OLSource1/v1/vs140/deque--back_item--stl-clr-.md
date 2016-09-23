---
title: "deque::back_item (STL-CLR)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
H1: deque::back_item (STL/CLR)
f1_keywords: 
  - cliext::deque::back_item
dev_langs: 
  - C++
helpviewer_keywords: 
  - back_item member [STL/CLR]
ms.assetid: b112636a-2f18-4eb0-abd6-076acdabeff7
caps.latest.revision: 18
translation.priority.ht: 
  - de-de
  - ja-jp
---
# deque::back_item (STL-CLR)
Accesses the last element.  
  
## Syntax  
  
```  
property value_type back_item;  
```  
  
## Remarks  
 The property accesses the last element of the controlled sequence, which must be non-empty. You use it to read or write the last element, when you know it exists.  
  
## Example  
  
```  
// cliext_deque_back_item.cpp   
// compile with: /clr   
#include <cliext/deque>   
  
int main()   
    {   
    cliext::deque<wchar_t> c1;   
    c1.push_back(L'a');   
    c1.push_back(L'b');   
    c1.push_back(L'c');   
  
// display initial contents " a b c"   
    for each (wchar_t elem in c1)   
        System::Console::Write(" {0}", elem);   
    System::Console::WriteLine();   
  
// inspect last item   
    System::Console::WriteLine("back_item = {0}", c1.back_item);   
  
// alter last item and reinspect   
    c1.back_item = L'x';   
    for each (wchar_t elem in c1)   
        System::Console::Write(" {0}", elem);   
    System::Console::WriteLine();   
    return (0);   
    }  
  
```  
  
  **a b c**  
**back_item = c**  
 **a b x**   
## Requirements  
 **Header:** <cliext/deque>  
  
 **Namespace:** cliext  
  
## See Also  
 [deque](../vs140/deque--stl-clr-.md)   
 [back](../vs140/deque--back--stl-clr-.md)   
 [front](../vs140/deque--front--stl-clr-.md)   
 [front_item](../vs140/deque--front_item--stl-clr-.md)