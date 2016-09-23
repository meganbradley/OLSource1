---
title: "operator&gt; (deque) (STL-CLR)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
H1: operator&gt; (deque) (STL/CLR)
f1_keywords: 
  - cliext::deque::operator>
dev_langs: 
  - C++
helpviewer_keywords: 
  - operator> member [STL/CLR]
ms.assetid: b207be0a-c6d8-4d70-8b8d-beb48e859441
caps.latest.revision: 19
translation.priority.ht: 
  - de-de
  - ja-jp
---
# operator&gt; (deque) (STL-CLR)
Deque greater than comparison.  
  
## Syntax  
  
```  
template<typename Value>  
    bool operator>(deque<Value>% left,  
        deque<Value>% right);  
```  
  
#### Parameters  
 left  
 Left container to compare.  
  
 right  
 Right container to compare.  
  
## Remarks  
 The operator function returns `right` `<` `left`. You use it to test whether `left` is ordered after `right` when the two deques are compared element by element.  
  
## Example  
  
```  
// cliext_deque_operator_gt.cpp   
// compile with: /clr   
#include <cliext/deque>   
  
int main()   
    {   
    cliext::deque<wchar_t> c1;   
    c1.push_back(L'a');   
    c1.push_back(L'b');   
    c1.push_back(L'c');   
  
// display contents " a b c"   
    for each (wchar_t elem in c1)   
        System::Console::Write(" {0}", elem);   
    System::Console::WriteLine();   
  
// assign to a new container   
    cliext::deque<wchar_t> c2;   
    c2.push_back(L'a');   
    c2.push_back(L'b');   
    c2.push_back(L'd');   
  
// display contents " a b d"   
    for each (wchar_t elem in c2)   
        System::Console::Write(" {0}", elem);   
    System::Console::WriteLine();   
  
    System::Console::WriteLine("[a b c] > [a b c] is {0}",   
        c1 > c1);   
    System::Console::WriteLine("[a b d] > [a b c] is {0}",   
        c2 > c1);   
    return (0);   
    }  
  
```  
  
  **a b c**  
 **a b d**  
**[a b c] > [a b c] is False**  
**[a b d] > [a b c] is True**   
## Requirements  
 **Header:** <cliext/deque>  
  
 **Namespace:** cliext  
  
## See Also  
 [deque](../vs140/deque--stl-clr-.md)   
 [operator==](../vs140/operator==--deque---stl-clr-.md)   
 [operator!=](../vs140/deque--operator!=--stl-clr-.md)   
 [operator<](../vs140/operator---deque---stl-clr-.md)   
 [operator>=](../vs140/operator-=--deque---stl-clr-.md)   
 [operator<=](../vs140/operator-=--deque---stl-clr-.md)