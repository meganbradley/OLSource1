---
title: "multiset::key_comp (STL-CLR)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
H1: multiset::key_comp (STL/CLR)
f1_keywords: 
  - cliext::multiset::key_comp
dev_langs: 
  - C++
helpviewer_keywords: 
  - key_comp member [STL/CLR]
ms.assetid: 79ea90d1-b9b0-4b32-a4cf-c04242b8e42f
caps.latest.revision: 17
translation.priority.ht: 
  - de-de
  - ja-jp
---
# multiset::key_comp (STL-CLR)
Copies the ordering delegate for two keys.  
  
## Syntax  
  
```  
key_compare^key_comp();  
```  
  
## Remarks  
 The member function returns the ordering delegate used to order the controlled sequence. You use it to compare two keys.  
  
## Example  
  
```  
// cliext_multiset_key_comp.cpp   
// compile with: /clr   
#include <cliext/set>   
  
typedef cliext::multiset<wchar_t> Mymultiset;   
int main()   
    {   
    Mymultiset c1;   
    Mymultiset::key_compare^ kcomp = c1.key_comp();   
  
    System::Console::WriteLine("compare(L'a', L'a') = {0}",   
        kcomp(L'a', L'a'));   
    System::Console::WriteLine("compare(L'a', L'b') = {0}",   
        kcomp(L'a', L'b'));   
    System::Console::WriteLine("compare(L'b', L'a') = {0}",   
        kcomp(L'b', L'a'));   
    System::Console::WriteLine();   
  
// test a different ordering rule   
    Mymultiset c2 = cliext::greater<wchar_t>();   
    kcomp = c2.key_comp();   
  
    System::Console::WriteLine("compare(L'a', L'a') = {0}",   
        kcomp(L'a', L'a'));   
    System::Console::WriteLine("compare(L'a', L'b') = {0}",   
        kcomp(L'a', L'b'));   
    System::Console::WriteLine("compare(L'b', L'a') = {0}",   
        kcomp(L'b', L'a'));   
    return (0);   
    }  
  
```  
  
 **compare(L'a', L'a') = False**  
**compare(L'a', L'b') = True**  
**compare(L'b', L'a') = False**  
**compare(L'a', L'a') = False**  
**compare(L'a', L'b') = False**  
**compare(L'b', L'a') = True**   
## Requirements  
 **Header:** <cliext/set>  
  
 **Namespace:** cliext  
  
## See Also  
 [multiset](../vs140/multiset--stl-clr-.md)   
 [key_compare](../vs140/multiset--key_compare--stl-clr-.md)   
 [key_type](../vs140/multiset--key_type--stl-clr-.md)