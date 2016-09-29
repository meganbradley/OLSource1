---
title: "list::reverse (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "list::reverse (STL/CLR)"
f1_keywords: 
  - "cliext::list::reverse"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "reverse member [STL/CLR]"
ms.assetid: de3bce1e-01fe-461d-a785-5cf4fcea988f
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# list::reverse (STL-CLR)
Reverses the controlled sequence.  
  
## Syntax  
  
```  
void reverse();  
```  
  
## Remarks  
 The member function reverses the order of all elements in the controlled sequence. You use it to reflect a list of elements.  
  
## Example  
  
```  
// cliext_list_reverse.cpp   
// compile with: /clr   
#include <cliext/list>   
  
int main()   
    {   
    cliext::list<wchar_t> c1;   
    c1.push_back(L'a');   
    c1.push_back(L'b');   
    c1.push_back(L'c');   
  
// display initial contents " a b c"   
    for each (wchar_t elem in c1)   
        System::Console::Write(" {0}", elem);   
    System::Console::WriteLine();   
  
// reverse and redisplay   
    c1.reverse();   
    for each (wchar_t elem in c1)   
        System::Console::Write(" {0}", elem);   
    System::Console::WriteLine();   
    return (0);   
    }  
  
```  
  
  **a b c**  
 **c b a**   
## Requirements  
 **Header:** <cliext/list>  
  
 **Namespace:** cliext  
  
## See Also  
 [list](../vs140/list--stl-clr-.md)   
 [sort](../vs140/list--sort--stl-clr-.md)