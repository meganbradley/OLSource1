---
title: "list::push_back (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "list::push_back (STL/CLR)"
f1_keywords: 
  - "cliext::list::push_back"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "push_back member [STL/CLR]"
ms.assetid: f2c70470-a899-4e5f-8f3e-b55d6a8bff0e
caps.latest.revision: 17
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# list::push_back (STL-CLR)
Adds a new last element.  
  
## Syntax  
  
```  
void push_back(value_type val);  
```  
  
## Remarks  
 The member function inserts an element with value `val` at the end of the controlled sequence. You use it to append another element to the list.  
  
## Example  
  
```  
// cliext_list_push_back.cpp   
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
    return (0);   
    }  
  
```  
  
  **a b c**   
## Requirements  
 **Header:** <cliext/list>  
  
 **Namespace:** cliext  
  
## See Also  
 [list](../vs140/list--stl-clr-.md)   
 [pop_back](../vs140/list--pop_back--stl-clr-.md)   
 [pop_front](../vs140/list--pop_front--stl-clr-.md)   
 [push_front](../vs140/list--push_front--stl-clr-.md)