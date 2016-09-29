---
title: "multiset::rend (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "multiset::rend (STL/CLR)"
f1_keywords: 
  - "cliext::multiset::rend"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "rend member [STL/CLR]"
ms.assetid: db84e142-efa7-4171-bad6-8132f3f5f741
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# multiset::rend (STL-CLR)
Designates the end of the reversed controlled sequence.  
  
## Syntax  
  
```  
reverse_iterator rend();  
```  
  
## Remarks  
 The member function returns a reverse iterator that points just beyond the beginning of the controlled sequence. Hence, it designates the `end` of the reverse sequence. You use it to obtain an iterator that designates the `current` end of the controlled sequence seen in reverse order, but its status can change if the length of the controlled sequence changes.  
  
## Example  
  
```  
// cliext_multiset_rend.cpp   
// compile with: /clr   
#include <cliext/set>   
  
typedef cliext::multiset<wchar_t> Mymultiset;   
int main()   
    {   
    Mymultiset c1;   
    c1.insert(L'a');   
    c1.insert(L'b');   
    c1.insert(L'c');   
  
// display initial contents " a b c"   
    for each (wchar_t elem in c1)   
        System::Console::Write(" {0}", elem);   
    System::Console::WriteLine();   
  
// inspect first two items   
    Mymultiset::reverse_iterator rit = c1.rend();   
    --rit;   
    System::Console::WriteLine("*-- --rend() = {0}", *--rit);   
    System::Console::WriteLine("*--rend() = {0}", *++rit);   
    return (0);   
    }  
  
```  
  
  **a b c**  
**\*-- --rend() = b**  
**\*--rend() = a**   
## Requirements  
 **Header:** <cliext/set>  
  
 **Namespace:** cliext  
  
## See Also  
 [multiset](../vs140/multiset--stl-clr-.md)   
 [begin](../vs140/multiset--begin--stl-clr-.md)   
 [end](../vs140/multiset--end--stl-clr-.md)   
 [rbegin](../vs140/multiset--rbegin--stl-clr-.md)