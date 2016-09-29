---
title: "vector::operator(STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "vector::operator(STL/CLR)"
f1_keywords: 
  - "cliext::vector::operator[]"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operatormember [] [STL/CLR]"
ms.assetid: 379a7029-460d-4de8-918b-c79e3e13b9d4
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# vector::operator(STL-CLR)
Accesses an element at a specified position.  
  
## Syntax  
  
```  
reference operator[](size_type pos);  
```  
  
#### Parameters  
 pos  
 Position of element to access.  
  
## Remarks  
 The member operator returns a referene to the element at position `pos`. You use it to access an element whose position you know.  
  
## Example  
  
```  
// cliext_vector_operator_sub.cpp   
// compile with: /clr   
#include <cliext/vector>   
  
int main()   
    {   
    cliext::vector<wchar_t> c1;   
    c1.push_back(L'a');   
    c1.push_back(L'b');   
    c1.push_back(L'c');   
  
// display contents " a b c" using subscripting   
    for (int i = 0; i < c1.size(); ++i)   
        System::Console::Write(" {0}", c1[i]);   
    System::Console::WriteLine();   
  
// change an entry and redisplay   
    c1[1] = L'x';   
    for (int i = 0; i < c1.size(); ++i)   
        System::Console::Write(" {0}", c1[i]);   
    System::Console::WriteLine();   
    return (0);   
    }  
  
```  
  
  **a b c**  
 **a x c**   
## Requirements  
 **Header:** <cliext/vector>  
  
 **Namespace:** cliext  
  
## See Also  
 [vector](../vs140/vector--stl-clr-.md)   
 [at](../vs140/vector--at--stl-clr-.md)