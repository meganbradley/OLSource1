---
title: "vector::end (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "vector::end (STL/CLR)"
f1_keywords: 
  - "cliext::vector::end"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "end member [STL/CLR]"
ms.assetid: 21fcaf1b-7f14-4dc4-a312-fa30e631ea0d
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# vector::end (STL-CLR)
Designates the end of the controlled sequence.  
  
## Syntax  
  
```  
iterator end();  
```  
  
## Remarks  
 The member function returns a random-access iterator that points just beyond the end of the controlled sequence. You use it to obtain an iterator that designates the `current` end of the controlled sequence, but its status can change if the length of the controlled sequence changes.  
  
## Example  
  
```  
// cliext_vector_end.cpp   
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
  
// inspect last two items   
    cliext::vector<wchar_t>::iterator it = c1.end();   
    --it;   
    System::Console::WriteLine("*-- --end() = {0}", *--it);   
    System::Console::WriteLine("*--end() = {0}", *++it);   
  
// alter first two items and reinspect   
    *--it = L'x';   
    *++it = L'y';   
    for each (wchar_t elem in c1)   
        System::Console::Write(" {0}", elem);   
    System::Console::WriteLine();   
    return (0);   
    }  
  
```  
  
  **a b c**  
**\*-- --end() = b**  
**\*--end() = c**  
 **a x y**   
## Requirements  
 **Header:** \<cliext/vector>  
  
 **Namespace:** cliext  
  
## See Also  
 [vector](../vs140/vector--stl-clr-.md)   
 [back](../vs140/vector--back--stl-clr-.md)   
 [back_item](../vs140/vector--back_item--stl-clr-.md)   
 [begin](../vs140/vector--begin--stl-clr-.md)