---
title: "make_pair (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "make_pair (STL/CLR)"
f1_keywords: 
  - "cliext::make_pair"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "make_pair function [STL/CLR]"
ms.assetid: 74733f2c-97b0-4d69-b431-5ab8f0de9e3e
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# make_pair (STL-CLR)
Make a `pair` from a pair of values.  
  
## Syntax  
  
```  
template<typename Value1,  
    typename Value2>  
    pair<Value1, Value2> make_pair(Value1 first, Value2 second);  
```  
  
#### Parameters  
 Value1  
 The type of the first wrapped value.  
  
 Value2  
 The type of the second wrapped value.  
  
 first  
 First value to wrap.  
  
 second  
 Second value to wrap.  
  
## Remarks  
 The template function returns `pair<``Value1``,` `Value2``>(``first``,` `second``)`. You use it to construct a `pair``<``Value1``,` `Value2``>` object from a pair of values.  
  
## Example  
  
```  
// cliext_make_pair.cpp   
// compile with: /clr   
#include <cliext/utility>   
  
int main()   
    {   
    cliext::pair<wchar_t, int> c1(L'x', 3);   
    System::Console::WriteLine("[{0}, {1}]", c1.first, c1.second);   
  
    c1 = cliext::make_pair(L'y', 4);   
    System::Console::WriteLine("[{0}, {1}]", c1.first, c1.second);   
    return (0);   
    }  
  
```  
  
 **[x, 3]**  
**[y, 4]**   
## Requirements  
 **Header:** <cliext/utility>  
  
 **Namespace:** cliext  
  
## See Also  
 [range_adapter](../vs140/range_adapter--stl-clr-.md)