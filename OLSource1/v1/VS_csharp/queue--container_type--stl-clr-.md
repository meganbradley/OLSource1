---
title: "queue::container_type (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "queue::container_type (STL/CLR)"
f1_keywords: 
  - "cliext::queue::container_type"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "container_type member [STL/CLR]"
ms.assetid: 118168f9-e5ed-47e2-a4f5-26b0b56e41e1
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# queue::container_type (STL-CLR)
The type of the underlying container.  
  
## Syntax  
  
```  
typedef Container value_type;  
```  
  
## Remarks  
 The type is a synonym for the template parameter `Container`.  
  
## Example  
  
```  
// cliext_queue_container_type.cpp   
// compile with: /clr   
#include <cliext/queue>   
  
typedef cliext::queue<wchar_t> Myqueue;   
int main()   
    {   
    Myqueue c1;   
    c1.push(L'a');   
    c1.push(L'b');   
    c1.push(L'c');   
  
// display contents " a b c" using container_type   
    Myqueue::container_type wc1 = c1.get_container();   
    for each (wchar_t elem in wc1)   
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
 [queue](../VS_csharp/queue--stl-clr-.md)   
 [get_container](../VS_csharp/queue--get_container--stl-clr-.md)