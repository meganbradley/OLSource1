---
title: "vector::clear (STL-CLR)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
H1: vector::clear (STL/CLR)
f1_keywords: 
  - cliext::vector::clear
dev_langs: 
  - C++
helpviewer_keywords: 
  - clear member [STL/CLR]
ms.assetid: 4ed20ec8-3089-4c36-b68f-1b51c639041f
caps.latest.revision: 17
translation.priority.ht: 
  - de-de
  - ja-jp
---
# vector::clear (STL-CLR)
Removes all elements.  
  
## Syntax  
  
```  
void clear();  
```  
  
## Remarks  
 The member function effectively calls [erase](../vs140/vector--erase--stl-clr-.md)`(` [begin](../vs140/vector--begin--stl-clr-.md)`(),` [end](../vs140/vector--end--stl-clr-.md)`())`. You use it to ensure that the controlled sequence is empty.  
  
## Example  
  
```  
// cliext_vector_clear.cpp   
// compile with: /clr   
#include <cliext/vector>   
  
int main()   
    {   
    cliext::vector<wchar_t> c1;   
    c1.push_back(L'a');   
    c1.push_back(L'b');   
    c1.push_back(L'c');   
  
// display initial contents " a b c"   
    for each (wchar_t elem in c1)   
        System::Console::Write(" {0}", elem);   
    System::Console::WriteLine();   
  
// clear the container and reinspect   
    c1.clear();   
    System::Console::WriteLine("size() = {0}", c1.size());   
  
// add elements and clear again   
    c1.push_back(L'a');   
    c1.push_back(L'b');   
  
    for each (wchar_t elem in c1)   
        System::Console::Write(" {0}", elem);   
    System::Console::WriteLine();   
    c1.clear();   
    System::Console::WriteLine("size() = {0}", c1.size());   
    return (0);   
    }  
  
```  
  
  **a b c**  
**size() = 0**  
 **a b**  
**size() = 0**   
## Requirements  
 **Header:** <cliext/vector>  
  
 **Namespace:** cliext  
  
## See Also  
 [vector](../vs140/vector--stl-clr-.md)   
 [erase](../vs140/vector--erase--stl-clr-.md)