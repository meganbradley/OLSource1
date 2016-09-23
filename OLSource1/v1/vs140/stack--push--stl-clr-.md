---
title: "stack::push (STL-CLR)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
H1: stack::push (STL/CLR)
f1_keywords: 
  - cliext::stack::push
dev_langs: 
  - C++
helpviewer_keywords: 
  - push member [STL/CLR]
ms.assetid: 60e5b076-c80f-4af0-a018-62cda7e081db
caps.latest.revision: 17
translation.priority.ht: 
  - de-de
  - ja-jp
---
# stack::push (STL-CLR)
Adds a new last element.  
  
## Syntax  
  
```  
void push(value_type val);  
```  
  
## Remarks  
 The member function inserts an element with value `val` at the end of the controlled sequence. You use it to append another element to the stack.  
  
## Example  
  
```  
// cliext_stack_push.cpp   
// compile with: /clr   
#include <cliext/stack>   
  
typedef cliext::stack<wchar_t> Mystack;   
int main()   
    {   
    Mystack c1;   
    c1.push(L'a');   
    c1.push(L'b');   
    c1.push(L'c');   
  
// display contents " a b c"   
    for each (wchar_t elem in c1.get_container())   
        System::Console::Write(" {0}", elem);   
    System::Console::WriteLine();   
    return (0);   
    }  
  
```  
  
  **a b c**   
## Requirements  
 **Header:** <cliext/stack>  
  
 **Namespace:** cliext  
  
## See Also  
 [stack](../vs140/stack--stl-clr-.md)   
 [pop](../vs140/stack--pop--stl-clr-.md)