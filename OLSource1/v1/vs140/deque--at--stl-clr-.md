---
title: "deque::at (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "deque::at (STL/CLR)"
f1_keywords: 
  - "cliext::deque::at"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "at member [STL/CLR]"
ms.assetid: 9af83d8a-c519-4b2a-a25f-d3dc8bbb87fb
caps.latest.revision: 20
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# deque::at (STL-CLR)
Accesses an element at a specified position.  
  
## Syntax  
  
```  
reference at(size_type pos);  
```  
  
#### Parameters  
 pos  
 Position of element to access.  
  
## Remarks  
 The member function returns a reference to the element of the controlled sequence at position `pos`. You use it to read or write an element whose position you know.  
  
## Example  
  
```  
// cliext_deque_at.cpp   
// compile with: /clr   
#include <cliext/deque>   
  
int main()   
    {   
    cliext::deque<wchar_t> c1;   
    c1.push_back(L'a');   
    c1.push_back(L'b');   
    c1.push_back(L'c');   
  
// display contents " a b c" using at   
    for (int i = 0; i < c1.size(); ++i)   
        System::Console::Write(" {0}", c1.at(i));   
    System::Console::WriteLine();   
  
// change an entry and redisplay   
    c1.at(1) = L'x';   
    for (int i = 0; i < c1.size(); ++i)   
        System::Console::Write(" {0}", c1[i]);   
    System::Console::WriteLine();   
    return (0);   
    }  
  
```  
  
  **a b c**  
 **a x c**   
## Requirements  
 **Header:** <cliext/deque>  
  
 **Namespace:** cliext  
  
## See Also  
 [deque](../vs140/deque--stl-clr-.md)   
 [operator&#91;&#93;](../vs140/deque--operator-stl-clr-.md)