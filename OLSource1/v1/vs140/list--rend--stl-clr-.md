---
title: "list::rend (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "list::rend (STL/CLR)"
f1_keywords: 
  - "cliext::list::rend"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "rend member [STL/CLR]"
ms.assetid: b51030ad-1bca-42b0-b890-db47111d2921
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# list::rend (STL-CLR)
Designates the end of the reversed controlled sequence.  
  
## Syntax  
  
```  
reverse_iterator rend();  
```  
  
## Remarks  
 The member function returns a reverse iterator that points just beyond the beginning of the controlled sequence. Hence, it designates the `end` of the reverse sequence. You use it to obtain an iterator that designates the `current` end of the controlled sequence seen in reverse order, but its status can change if the length of the controlled sequence changes.  
  
## Example  
  
```  
// cliext_list_rend.cpp   
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
  
// inspect first two items   
    cliext::list<wchar_t>::reverse_iterator rit = c1.rend();   
    --rit;   
    System::Console::WriteLine("*-- --rend() = {0}", *--rit);   
    System::Console::WriteLine("*--rend() = {0}", *++rit);   
  
// alter first two items and reinspect   
    *--rit = L'x';   
    *++rit = L'y';   
    for each (wchar_t elem in c1)   
        System::Console::Write(" {0}", elem);   
    System::Console::WriteLine();   
    return (0);   
    }  
  
```  
  
  **a b c**  
**\*-- --rend() = b**  
**\*--rend() = a**  
 **y x c**   
## Requirements  
 **Header:** <cliext/list>  
  
 **Namespace:** cliext  
  
## See Also  
 [list](../vs140/list--stl-clr-.md)   
 [begin](../vs140/list--begin--stl-clr-.md)   
 [end](../vs140/list--end--stl-clr-.md)   
 [rbegin](../vs140/list--rbegin--stl-clr-.md)