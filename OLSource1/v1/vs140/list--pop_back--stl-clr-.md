---
title: "list::pop_back (STL-CLR)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
H1: list::pop_back (STL/CLR)
f1_keywords: 
  - cliext::list::pop_back
dev_langs: 
  - C++
helpviewer_keywords: 
  - pop_back member [STL/CLR]
ms.assetid: 03fe8e0e-461b-41c4-8e20-97d0d4ed0feb
caps.latest.revision: 16
translation.priority.ht: 
  - de-de
  - ja-jp
---
# list::pop_back (STL-CLR)
Removes the last element.  
  
## Syntax  
  
```  
void pop_back();  
```  
  
## Remarks  
 The member function removes the last element of the controlled sequence, which must be non-empty. You use it to shorten the list by one element at the back.  
  
## Example  
  
```  
// cliext_list_pop_back.cpp   
// compile with: /clr   
#include <cliext/list>   
  
int main()   
    {   
    cliext::list<wchar_t> c1;   
    c1.push_back(L'a');   
    c1.push_back(L'b');   
    c1.push_back(L'c');   
  
// display contents " a b c"   
    for each (wchar_t elem in c1)   
        System::Console::Write(" {0}", elem);   
    System::Console::WriteLine();   
  
// pop an element and redisplay   
    c1.pop_back();   
    for each (wchar_t elem in c1)   
        System::Console::Write(" {0}", elem);   
    System::Console::WriteLine();   
    return (0);   
    }  
  
```  
  
  **a b c**  
 **a b**   
## Requirements  
 **Header:** <cliext/list>  
  
 **Namespace:** cliext  
  
## See Also  
 [list](../vs140/list--stl-clr-.md)   
 [pop_front](../vs140/list--pop_front--stl-clr-.md)   
 [push_back](../vs140/list--push_back--stl-clr-.md)   
 [push_front](../vs140/list--push_front--stl-clr-.md)