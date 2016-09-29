---
title: "pair::operator= (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "pair::operator= (STL/CLR)"
f1_keywords: 
  - "cliext::pair::operator="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator= member [STL/CLR]"
ms.assetid: b6228037-914e-4efa-8491-65dbb0e93f61
caps.latest.revision: 10
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# pair::operator= (STL-CLR)
Replaces the stored pair of values.  
  
## Syntax  
  
```  
pair<Value1, Value2>% operator=(pair<Value1, Value2>% right);  
```  
  
#### Parameters  
 right  
 Pair to copy.  
  
## Remarks  
 The member operator copies `right` to the object, then returns `*this`. You use it to replace the stored pair of values with a copy of the stored pair of values in `right`.  
  
## Example  
  
```  
// cliext_pair_operator_as.cpp   
// compile with: /clr   
#include <cliext/utility>   
  
int main()   
    {   
    cliext::pair<wchar_t, int> c1(L'x', 3);   
    System::Console::WriteLine("[{0}, {1}]", c1.first, c1.second);   
  
// assign to a new pair   
    cliext::pair<wchar_t, int> c2;   
    c2 = c1;   
    System::Console::WriteLine("[{0}, {1}]", c2.first, c2.second);   
    return (0);   
    }  
  
```  
  
 **[x, 3]**  
**[x, 3]**   
## Requirements  
 **Header:** <cliext/utility>  
  
 **Namespace:** cliext  
  
## See Also  
 [pair](../vs140/pair--stl-clr-.md)