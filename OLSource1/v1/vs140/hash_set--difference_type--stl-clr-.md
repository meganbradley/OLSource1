---
title: "hash_set::difference_type (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "hash_set::difference_type (STL/CLR)"
f1_keywords: 
  - "cliext::hash_set::difference_type"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "difference_type member [STL/CLR]"
ms.assetid: 56c6edee-4d58-4be4-9824-0f26c02a0cfa
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_set::difference_type (STL-CLR)
The types of a signed distance between two elements.  
  
## Syntax  
  
```  
typedef int difference_type;  
```  
  
## Remarks  
 The type describes a possibly negative element count.  
  
## Example  
  
```  
// cliext_hash_set_difference_type.cpp   
// compile with: /clr   
#include <cliext/hash_set>   
  
typedef cliext::hash_set<wchar_t> Myhash_set;   
int main()   
    {   
    Myhash_set c1;   
    c1.insert(L'a');   
    c1.insert(L'b');   
    c1.insert(L'c');   
  
// display initial contents " a b c"   
    for each (wchar_t elem in c1)   
        System::Console::Write(" {0}", elem);   
    System::Console::WriteLine();   
  
// compute positive difference   
    Myhash_set::difference_type diff = 0;   
    for (Myhash_set::iterator it = c1.begin(); it != c1.end(); ++it)   
        ++diff;   
    System::Console::WriteLine("end()-begin() = {0}", diff);   
  
// compute negative difference   
    diff = 0;   
    for (Myhash_set::iterator it = c1.end(); it != c1.begin(); --it)   
        --diff;   
    System::Console::WriteLine("begin()-end() = {0}", diff);   
    return (0);   
    }  
  
```  
  
  **a b c**  
**end()-begin() = 3**  
**begin()-end() = -3**   
## Requirements  
 **Header:** \<cliext/hash_set>  
  
 **Namespace:** cliext  
  
## See Also  
 [hash_set](../vs140/hash_set--stl-clr-.md)   
 [size_type](../vs140/hash_set--size_type--stl-clr-.md)