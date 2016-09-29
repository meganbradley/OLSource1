---
title: "hash_multiset::begin (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "hash_multiset::begin (STL/CLR)"
f1_keywords: 
  - "cliext::hash_multiset::begin"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "begin member [STL/CLR]"
ms.assetid: f03fc205-cbc9-4054-ac6d-41ad526edfea
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_multiset::begin (STL-CLR)
Designates the beginning of the controlled sequence.  
  
## Syntax  
  
```  
iterator begin();  
```  
  
## Remarks  
 The member function returns a bidirectional iterator that designates the first element of the controlled sequence, or just beyond the end of an empty sequence. You use it to obtain an iterator that designates the `current` beginning of the controlled sequence, but its status can change if the length of the controlled sequence changes.  
  
## Example  
  
```  
// cliext_hash_multiset_begin.cpp   
// compile with: /clr   
#include <cliext/hash_set>   
  
typedef cliext::hash_multiset<wchar_t> Myhash_multiset;   
int main()   
    {   
    Myhash_multiset c1;   
    c1.insert(L'a');   
    c1.insert(L'b');   
    c1.insert(L'c');   
  
// display initial contents " a b c"   
    for each (wchar_t elem in c1)   
        System::Console::Write(" {0}", elem);   
    System::Console::WriteLine();   
  
// inspect first two items   
    Myhash_multiset::iterator it = c1.begin();   
    System::Console::WriteLine("*begin() = {0}", *it);   
    System::Console::WriteLine("*++begin() = {0}", *++it);   
    return (0);   
    }  
  
```  
  
  **a b c**  
**\*begin() = a**  
**\*++begin() = b**   
## Requirements  
 **Header:** <cliext/hash_set>  
  
 **Namespace:** cliext  
  
## See Also  
 [hash_multiset](../VS_csharp/hash_multiset--stl-clr-.md)   
 [end](../VS_csharp/hash_multiset--end--stl-clr-.md)