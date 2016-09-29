---
title: "deque::pop_front (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "deque::pop_front (STL/CLR)"
f1_keywords: 
  - "cliext::deque::pop_front"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "pop_front member [STL/CLR]"
ms.assetid: 5042df47-b226-4b16-982e-6a4543b8e00b
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# deque::pop_front (STL-CLR)
Removes the first element.  
  
## Syntax  
  
```  
void pop_front();  
```  
  
## Remarks  
 The member function removes the first element of the controlled sequence, which must be non-empty. You use it to shorten the deque by one element at the front.  
  
## Example  
  
```  
// cliext_deque_pop_front.cpp   
// compile with: /clr   
#include <cliext/deque>   
  
int main()   
    {   
    cliext::deque<wchar_t> c1;   
    c1.push_back(L'a');   
    c1.push_back(L'b');   
    c1.push_back(L'c');   
  
// display contents " a b c"   
    for each (wchar_t elem in c1)   
        System::Console::Write(" {0}", elem);   
    System::Console::WriteLine();   
  
// pop an element and redisplay   
    c1.pop_front();   
    for each (wchar_t elem in c1)   
        System::Console::Write(" {0}", elem);   
    System::Console::WriteLine();   
    return (0);   
    }  
  
```  
  
  **a b c**  
 **b c**   
## Requirements  
 **Header:** <cliext/deque>  
  
 **Namespace:** cliext  
  
## See Also  
 [deque](../VS_csharp/deque--stl-clr-.md)   
 [pop_back](../VS_csharp/deque--pop_back--stl-clr-.md)   
 [push_back](../VS_csharp/deque--push_back--stl-clr-.md)   
 [push_front](../VS_csharp/deque--push_front--stl-clr-.md)