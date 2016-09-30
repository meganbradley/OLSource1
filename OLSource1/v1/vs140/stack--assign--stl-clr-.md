---
title: "stack::assign (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "stack::assign (STL/CLR)"
f1_keywords: 
  - "cliext::stack::assign"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "assign member [STL/CLR]"
ms.assetid: 18cc35ad-23cf-4a5a-adae-d967dc5d6980
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# stack::assign (STL-CLR)
Replaces all elements.  
  
## Syntax  
  
```  
void assign(stack<Value, Container>% right);  
```  
  
#### Parameters  
 right  
 Container adapter to insert.  
  
## Remarks  
 The member function assigns `right``.get_container()` to the underlying container. You use it to change the entire contents of the stack.  
  
## Example  
  
```  
// cliext_stack_assign.cpp   
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
  
// assign a repetition of values   
    Mystack c2;   
    c2.assign(c1);   
    for each (wchar_t elem in c2.get_container())   
        System::Console::Write(" {0}", elem);   
    System::Console::WriteLine();   
    return (0);   
    }  
  
```  
  
  **a b c**  
 **a b c**   
## Requirements  
 **Header:** \<cliext/stack>  
  
 **Namespace:** cliext  
  
## See Also  
 [stack](../vs140/stack--stl-clr-.md)   
 [operator=](../vs140/stack--operator=--stl-clr-.md)