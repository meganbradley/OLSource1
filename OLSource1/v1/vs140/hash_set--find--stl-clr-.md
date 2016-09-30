---
title: "hash_set::find (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "hash_set::find (STL/CLR)"
f1_keywords: 
  - "cliext::hash_set::find"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "find member [STL/CLR]"
ms.assetid: 758b7438-ef15-4af0-8001-a1126d5e9a9e
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_set::find (STL-CLR)
Finds an element that matches a specified key.  
  
## Syntax  
  
```  
iterator find(key_type key);  
```  
  
#### Parameters  
 key  
 Key value to search for.  
  
## Remarks  
 If at least one element in the controlled sequence has equivalent ordering with `key`, the member function returns an iterator designating one of those elements; otherwise it returns [end](../vs140/hash_set--end--stl-clr-.md)`()`. You use it to locate an element currently in the controlled sequence that matches a specified key.  
  
## Example  
  
```  
// cliext_hash_set_find.cpp   
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
  
    System::Console::WriteLine("find {0} = {1}",   
        L'A', c1.find(L'A') != c1.end());   
    System::Console::WriteLine("find {0} = {1}",   
        L'b', *c1.find(L'b'));   
    System::Console::WriteLine("find {0} = {1}",   
        L'C', c1.find(L'C') != c1.end());   
    return (0);   
    }  
  
```  
  
  **a b c**  
**find A = False**  
**find b = b**  
**find C = False**   
## Description  
 Note that `find` does not guarantee which of several element it finds.  
  
## Requirements  
 **Header:** \<cliext/hash_set>  
  
 **Namespace:** cliext  
  
## See Also  
 [hash_set](../vs140/hash_set--stl-clr-.md)   
 [equal_range](../vs140/hash_set--equal_range--stl-clr-.md)   
 [lower_bound](../vs140/hash_set--lower_bound--stl-clr-.md)   
 [upper_bound](../vs140/hash_set--upper_bound--stl-clr-.md)