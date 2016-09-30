---
title: "queue::front_item (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "queue::front_item (STL/CLR)"
f1_keywords: 
  - "cliext::queue::front_item"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "front_item member [STL/CLR]"
ms.assetid: 389ab030-4351-48e6-9b03-417f1d3fcb86
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# queue::front_item (STL-CLR)
Accesses the first element.  
  
## Syntax  
  
```  
property value_type front_item;  
```  
  
## Remarks  
 The property accesses the first element of the controlled sequence, which must be non-empty. You use it to read or write the first element, when you know it exists.  
  
## Example  
  
```  
// cliext_queue_front_item.cpp   
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
  
// inspect last item   
    System::Console::WriteLine("front_item = {0}", c1.front_item);   
  
// alter last item and reinspect   
    c1.front_item = L'x';   
    for each (wchar_t elem in c1.get_container())   
        System::Console::Write(" {0}", elem);   
    System::Console::WriteLine();   
    return (0);   
    }  
  
```  
  
  **a b c**  
**front_item = a**  
 **x b c**   
## Requirements  
 **Header:** \<cliext/queue>  
  
 **Namespace:** cliext  
  
## See Also  
 [queue](../vs140/queue--stl-clr-.md)   
 [back](../vs140/queue--back--stl-clr-.md)   
 [back_item](../vs140/queue--back_item--stl-clr-.md)   
 [front](../vs140/queue--front--stl-clr-.md)   
 [front](../vs140/queue--front--stl-clr-.md)