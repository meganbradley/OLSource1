---
title: "deque::push_front (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "deque::push_front (STL/CLR)"
f1_keywords: 
  - "cliext::deque::push_front"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "push_front member [STL/CLR]"
ms.assetid: a452c94e-abad-4e28-af41-c73ec805ec6f
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# deque::push_front (STL-CLR)
Adds a new first element.  
  
## Syntax  
  
```  
void push_front(value_type val);  
```  
  
## Remarks  
 The member function inserts an element with value `val` at the beginning of the controlled sequence. You use it to prepend another element to the deque.  
  
## Example  
  
```  
// cliext_deque_push_front.cpp   
// compile with: /clr   
#include <cliext/deque>   
  
int main()   
    {   
    cliext::deque<wchar_t> c1;   
    c1.push_front(L'a');   
    c1.push_front(L'b');   
    c1.push_front(L'c');   
  
// display contents " c b a"   
    for each (wchar_t elem in c1)   
        System::Console::Write(" {0}", elem);   
    System::Console::WriteLine();   
    return (0);   
    }  
  
```  
  
  **c b a**   
## Requirements  
 **Header:** <cliext/deque>  
  
 **Namespace:** cliext  
  
## See Also  
 [deque](../VS_csharp/deque--stl-clr-.md)   
 [pop_back](../VS_csharp/deque--pop_back--stl-clr-.md)   
 [pop_front](../VS_csharp/deque--pop_front--stl-clr-.md)   
 [push_back](../VS_csharp/deque--push_back--stl-clr-.md)