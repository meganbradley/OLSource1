---
title: "priority_queue::get_container (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "priority_queue::get_container (STL/CLR)"
f1_keywords: 
  - "cliext::priority_queue::get_container"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "get_container member [STL/CLR]"
ms.assetid: bd3cc63b-776f-495c-bf81-a9e8ba189a56
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# priority_queue::get_container (STL-CLR)
Accesses the underlying container.  
  
## Syntax  
  
```  
container_type get_container();  
```  
  
## Remarks  
 The member function returns the underlying container. You use it to bypass the restrictions imposed by the container wrapper.  
  
## Example  
  
```  
// cliext_priority_queue_get_container.cpp   
// compile with: /clr   
#include <cliext/queue>   
  
typedef cliext::priority_queue<wchar_t> Mypriority_queue;   
int main()   
    {   
    Mypriority_queue c1;   
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
  
  **c a b**   
## Requirements  
 **Header:** <cliext/queue>  
  
 **Namespace:** cliext  
  
## See Also  
 [priority_queue](../vs140/priority_queue--stl-clr-.md)   
 [container_type](../vs140/priority_queue--container_type--stl-clr-.md)