---
title: "queue::get_container (STL-CLR)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
H1: queue::get_container (STL/CLR)
f1_keywords: 
  - cliext::queue::get_container
dev_langs: 
  - C++
helpviewer_keywords: 
  - get_container member [STL/CLR]
ms.assetid: d87e7433-a352-4bea-8041-1ffc03287436
caps.latest.revision: 16
translation.priority.ht: 
  - de-de
  - ja-jp
---
# queue::get_container (STL-CLR)
Accesses the underlying container.  
  
## Syntax  
  
```  
container_type^ get_container();  
```  
  
## Remarks  
 The member function returns the underlying container. You use it to bypass the restrictions imposed by the container wrapper.  
  
## Example  
  
```  
// cliext_queue_get_container.cpp   
// compile with: /clr   
#include <cliext/queue>   
  
typedef cliext::queue<wchar_t> Myqueue;   
int main()   
    {   
    Myqueue c1;   
    c1.push(L'a');   
    c1.push(L'b');   
    c1.push(L'c');   
  
// display initial contents " a b c"   
    for each (wchar_t elem in c1.get_container())   
        System::Console::Write(" {0}", elem);   
    System::Console::WriteLine();   
    return (0);   
    }  
  
```  
  
  **a b c**   
## Requirements  
 **Header:** <cliext/queue>  
  
 **Namespace:** cliext  
  
## See Also  
 [queue](../vs140/queue--stl-clr-.md)   
 [container_type](../vs140/queue--container_type--stl-clr-.md)