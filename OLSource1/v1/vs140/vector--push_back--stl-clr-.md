---
title: "vector::push_back (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "vector::push_back (STL/CLR)"
f1_keywords: 
  - "cliext::vector::push_back"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "push_back member [STL/CLR]"
ms.assetid: 4a4c302b-e29f-4b68-b759-2f831814d896
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# vector::push_back (STL-CLR)
Adds a new last element.  
  
## Syntax  
  
```  
void push_back(value_type val);  
```  
  
## Remarks  
 The member function inserts an element with value `val` at the end of the controlled sequence. You use it to append another element to the vector.  
  
## Example  
  
```  
// cliext_vector_push_back.cpp   
// compile with: /clr   
#include <cliext/vector>   
  
int main()   
    {   
    cliext::vector<wchar_t> c1;   
    c1.push_back(L'a');   
    c1.push_back(L'b');   
    c1.push_back(L'c');   
  
// display contents " a b c"   
    for each (wchar_t elem in c1)   
        System::Console::Write(" {0}", elem);   
    System::Console::WriteLine();   
    return (0);   
    }  
  
```  
  
  **a b c**   
## Requirements  
 **Header:** \<cliext/vector>  
  
 **Namespace:** cliext  
  
## See Also  
 [vector](../vs140/vector--stl-clr-.md)   
 [pop_back](../vs140/vector--pop_back--stl-clr-.md)