---
title: "operator&gt; (pair) (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "operator&gt; (pair) (STL/CLR)"
f1_keywords: 
  - "cliext::pair::operator>"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator> member [STL/CLR]"
ms.assetid: c392a696-3425-49c8-9ddf-be2f2d2dd42e
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# operator&gt; (pair) (STL-CLR)
Pair greater than comparison.  
  
## Syntax  
  
```  
template<typename Value1,  
    typename Value2>  
    bool operator>(pair<Value1, Value2>% left,  
        pair<Value1, Value2>% right);  
```  
  
#### Parameters  
 left  
 Left pair to compare.  
  
 right  
 Right pair to compare.  
  
## Remarks  
 The operator function returns `right` `<` `left`. You use it to test whether `left` is ordered after `right` when the two pairs are compared element by element.  
  
## Example  
  
```  
// cliext_pair_operator_gt.cpp   
// compile with: /clr   
#include <cliext/utility>   
  
int main()   
    {   
    cliext::pair<wchar_t, int> c1(L'x', 3);   
    System::Console::WriteLine("[{0}, {1}]", c1.first, c1.second);   
    cliext::pair<wchar_t, int> c2(L'x', 4);   
    System::Console::WriteLine("[{0}, {1}]", c2.first, c2.second);   
  
    System::Console::WriteLine("[x 3] > [x 3] is {0}",   
        c1 > c1);   
    System::Console::WriteLine("[x 4] > [x 3] is {0}",   
        c2 > c1);   
    return (0);   
    }  
  
```  
  
 **[x, 3]**  
**[x, 4]**  
**[x 3] > [x 3] is False**  
**[x 4] > [x 3] is True**   
## Requirements  
 **Header:** <cliext/utility>  
  
 **Namespace:** cliext  
  
## See Also  
 [pair](../vs140/pair--stl-clr-.md)   
 [operator==](../vs140/operator==--pair---stl-clr-.md)   
 [operator!=](../vs140/operator!=--pair---stl-clr-.md)   
 [operator<](../vs140/operator---pair---stl-clr-.md)   
 [operator>=](../vs140/operator-=--pair---stl-clr-.md)   
 [operator<=](../vs140/operator-=--pair---stl-clr-.md)