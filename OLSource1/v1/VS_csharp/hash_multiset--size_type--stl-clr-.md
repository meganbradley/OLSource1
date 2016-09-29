---
title: "hash_multiset::size_type (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "hash_multiset::size_type (STL/CLR)"
f1_keywords: 
  - "cliext::hash_multiset::size_type"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "size_type member [STL/CLR]"
ms.assetid: cf4e2a5f-6d46-4ade-9bb4-407e12f310b3
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_multiset::size_type (STL-CLR)
The type of a signed distance between two element.  
  
## Syntax  
  
```  
typedef int size_type;  
```  
  
## Remarks  
 The type describes a non-negative element count.  
  
## Example  
  
```  
// cliext_hash_multiset_size_type.cpp   
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
  
// compute positive difference   
    Myhash_multiset::size_type diff = 0;   
    for (Myhash_multiset::iterator it = c1.begin(); it != c1.end(); ++it)   
        ++diff;   
    System::Console::WriteLine("end()-begin() = {0}", diff);   
    return (0);   
    }  
  
```  
  
  **a b c**  
**end()-begin() = 3**   
## Requirements  
 **Header:** <cliext/hash_set>  
  
 **Namespace:** cliext  
  
## See Also  
 [hash_multiset](../VS_csharp/hash_multiset--stl-clr-.md)   
 [empty](../VS_csharp/hash_multiset--empty--stl-clr-.md)