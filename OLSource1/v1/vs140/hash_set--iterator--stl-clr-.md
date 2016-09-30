---
title: "hash_set::iterator (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "hash_set::iterator (STL/CLR)"
f1_keywords: 
  - "cliext::hash_set::iterator"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "iterator member [STL/CLR]"
ms.assetid: b75fc54f-6a9e-4ce8-a168-988afe7fe7e5
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_set::iterator (STL-CLR)
The type of an iterator for the controlled sequence.  
  
## Syntax  
  
```  
typedef T1 iterator;  
```  
  
## Remarks  
 The type describes an object of unspecified type `T1` that can serve as a bidirectional iterator for the controlled sequence.  
  
## Example  
  
```  
// cliext_hash_set_iterator.cpp   
// compile with: /clr   
#include <cliext/hash_set>   
  
typedef cliext::hash_set<wchar_t> Myhash_set;   
int main()   
    {   
    Myhash_set c1;   
    c1.insert(L'a');   
    c1.insert(L'b');   
    c1.insert(L'c');   
  
// display contents " a b c"   
    Myhash_set::iterator it = c1.begin();   
    for (; it != c1.end(); ++it)   
        System::Console::Write(" {0}", *it);   
    System::Console::WriteLine();   
    return (0);   
    }  
  
```  
  
  **a b c**   
## Requirements  
 **Header:** \<cliext/hash_set>  
  
 **Namespace:** cliext  
  
## See Also  
 [hash_set](../vs140/hash_set--stl-clr-.md)   
 [const_iterator](../vs140/hash_set--const_iterator--stl-clr-.md)