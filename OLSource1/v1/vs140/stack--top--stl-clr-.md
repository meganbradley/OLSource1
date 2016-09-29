---
title: "stack::top (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "stack::top (STL/CLR)"
f1_keywords: 
  - "cliext::stack::top"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "top member [STL/CLR]"
ms.assetid: 5d8b7b69-336e-4d01-8b91-413a17aa2533
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# stack::top (STL-CLR)
Accesses the last element.  
  
## Syntax  
  
```  
reference top();  
```  
  
## Remarks  
 The member function returns a reference to the last element of the controlled sequence, which must be non-empty. You use it to access the last element, when you know it exists.  
  
## Example  
  
```  
// cliext_stack_top.cpp   
// compile with: /clr   
#include <cliext/stack>   
  
typedef cliext::stack<wchar_t> Mystack;   
int main()   
    {   
    Mystack c1;   
    c1.push(L'a');   
    c1.push(L'b');   
    c1.push(L'c');   
  
// display initial contents " a b c"   
    for each (wchar_t elem in c1.get_container())   
        System::Console::Write(" {0}", elem);   
    System::Console::WriteLine();   
  
// inspect last item   
    System::Console::WriteLine("top() = {0}", c1.top());   
  
// alter last item and reinspect   
    c1.top() = L'x';   
    for each (wchar_t elem in c1.get_container())   
        System::Console::Write(" {0}", elem);   
    System::Console::WriteLine();   
    return (0);   
    }  
  
```  
  
  **a b c**  
**top() = c**  
 **a b x**   
## Requirements  
 **Header:** <cliext/stack>  
  
 **Namespace:** cliext  
  
## See Also  
 [stack](../vs140/stack--stl-clr-.md)   
 [top_item](../vs140/stack--top_item--stl-clr-.md)