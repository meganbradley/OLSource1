---
title: "priority_queue::pop (STL-CLR)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
H1: priority_queue::pop (STL/CLR)
f1_keywords: 
  - cliext::priority_queue::pop
dev_langs: 
  - C++
helpviewer_keywords: 
  - pop member [STL/CLR]
ms.assetid: d363b3f1-247b-466a-a300-c5918b0dfd4e
caps.latest.revision: 16
translation.priority.ht: 
  - de-de
  - ja-jp
---
# priority_queue::pop (STL-CLR)
Removes the highest-proirity element.  
  
## Syntax  
  
```  
void pop();  
```  
  
## Remarks  
 The member function removes the highest-priority element of the controlled sequence, which must be non-empty. You use it to shorten the queue by one element at the back.  
  
## Example  
  
```  
// cliext_priority_queue_pop.cpp   
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
  
// pop an element and redisplay   
    c1.pop();   
    for each (wchar_t elem in c1.get_container())   
        System::Console::Write(" {0}", elem);   
    System::Console::WriteLine();   
    return (0);   
    }  
  
```  
  
  **c a b**  
 **b a**   
## Requirements  
 **Header:** <cliext/queue>  
  
 **Namespace:** cliext  
  
## See Also  
 [priority_queue](../vs140/priority_queue--stl-clr-.md)   
 [push](../vs140/priority_queue--push--stl-clr-.md)