---
title: "hash_set::value_comp (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "hash_set::value_comp (STL/CLR)"
f1_keywords: 
  - "cliext::hash_set::value_comp"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "value_comp member [STL/CLR]"
ms.assetid: 7ef381ea-438b-48ce-b0cb-96d844ea5df7
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_set::value_comp (STL-CLR)
Copies the ordering delegate for two element values.  
  
## Syntax  
  
```  
value_compare^ value_comp();  
```  
  
## Remarks  
 The member function returns the ordering delegate used to order the controlled sequence. You use it to compare two element values.  
  
## Example  
  
```  
// cliext_hash_set_value_comp.cpp   
// compile with: /clr   
#include <cliext/hash_set>   
  
typedef cliext::hash_set<wchar_t> Myhash_set;   
int main()   
    {   
    Myhash_set c1;   
    Myhash_set::value_compare^ kcomp = c1.value_comp();   
  
    System::Console::WriteLine("compare(L'a', L'a') = {0}",   
        kcomp(L'a', L'a'));   
    System::Console::WriteLine("compare(L'a', L'b') = {0}",   
        kcomp(L'a', L'b'));   
    System::Console::WriteLine("compare(L'b', L'a') = {0}",   
        kcomp(L'b', L'a'));   
    System::Console::WriteLine();   
    return (0);   
    }  
  
```  
  
 **compare(L'a', L'a') = True**  
**compare(L'a', L'b') = True**  
**compare(L'b', L'a') = False**   
## Requirements  
 **Header:** <cliext/hash_set>  
  
 **Namespace:** cliext  
  
## See Also  
 [hash_set](../vs140/hash_set--stl-clr-.md)   
 [value_compare](../vs140/hash_set--value_compare--stl-clr-.md)   
 [value_type](../vs140/hash_set--value_type--stl-clr-.md)