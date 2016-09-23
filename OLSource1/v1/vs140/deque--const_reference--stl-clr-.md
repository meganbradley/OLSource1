---
title: "deque::const_reference (STL-CLR)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
H1: deque::const_reference (STL/CLR)
f1_keywords: 
  - cliext::deque::const_reference
dev_langs: 
  - C++
helpviewer_keywords: 
  - const_reference member [STL/CLR]
ms.assetid: daa4a3dc-cae9-46da-b62c-c2870edb120f
caps.latest.revision: 18
translation.priority.ht: 
  - de-de
  - ja-jp
---
# deque::const_reference (STL-CLR)
The type of a constant reference to an element.  
  
## Syntax  
  
```  
typedef value_type% const_reference;  
```  
  
## Remarks  
 The type describes a constant reference to an element.  
  
## Example  
  
```  
// cliext_deque_const_reference.cpp   
// compile with: /clr   
#include <cliext/deque>   
  
int main()   
    {   
    cliext::deque<wchar_t> c1;   
    c1.push_back(L'a');   
    c1.push_back(L'b');   
    c1.push_back(L'c');   
  
// display initial contents " a b c"   
    cliext::deque<wchar_t>::const_iterator cit = c1.begin();   
    for (; cit != c1.end(); ++cit)   
        {   // get a const reference to an element   
        cliext::deque<wchar_t>::const_reference cref = *cit;   
        System::Console::Write(" {0}", cref);   
        }   
    System::Console::WriteLine();   
    return (0);   
    }  
  
```  
  
  **a b c**   
## Requirements  
 **Header:** <cliext/deque>  
  
 **Namespace:** cliext  
  
## See Also  
 [deque](../vs140/deque--stl-clr-.md)   
 [reference](../vs140/deque--reference--stl-clr-.md)   
 [value_type](../vs140/deque--value_type--stl-clr-.md)