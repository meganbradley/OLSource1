---
title: "priority_queue::reference (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "priority_queue::reference (STL/CLR)"
f1_keywords: 
  - "cliext::priority_queue::reference"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "reference member [STL/CLR]"
ms.assetid: b063eaf1-c238-4aef-ac54-a81d0f671418
caps.latest.revision: 18
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# priority_queue::reference (STL-CLR)
The type of a reference to an element.  
  
## Syntax  
  
```  
typedef value_type% reference;  
```  
  
## Remarks  
 The type describes a reference to an element.  
  
## Example  
  
```  
// cliext_priority_queue_reference.cpp   
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
  
// modify top of priority_queue and redisplay   
    Mypriority_queue::reference ref = c1.top();   
    ref = L'x';   
    for each (wchar_t elem in c1.get_container())   
        System::Console::Write(" {0}", elem);   
    System::Console::WriteLine();   
    return (0);   
    }  
  
```  
  
  **c a b**  
 **x a b**   
## Requirements  
 **Header:** <cliext/queue>  
  
 **Namespace:** cliext  
  
## See Also  
 [priority_queue](../vs140/priority_queue--stl-clr-.md)   
 [const_reference](../vs140/priority_queue--const_reference--stl-clr-.md)   
 [value_type](../vs140/priority_queue--value_type--stl-clr-.md)