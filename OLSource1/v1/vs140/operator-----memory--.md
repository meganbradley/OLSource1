---
title: "operator&lt;&lt; (&lt;memory&gt;)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "memory/std::tr1::operator<<"
  - "std.tr1.memory.operator<<"
  - "memory.operator<<"
  - "memory::operator<<"
  - "std::tr1::memory::operator<<"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator<< operator [TR1]"
ms.assetid: 7133c45d-79f7-4159-a765-3f8dda87ca4a
caps.latest.revision: 19
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# operator&lt;&lt; (&lt;memory&gt;)
shared_ptr inserter.  
  
## Syntax  
  
```  
template<class Elem, class Tr, class Ty>  
    std::basic_ostream<Elem, Tr>& operator<<(std::basic_ostream<Elem, Tr>& out,  
    shared_ptr<Ty>& sp);  
```  
  
#### Parameters  
 `Elem`  
 The type of the stream element.  
  
 `Tr`  
 The type the stream element traits.  
  
 `Ty`  
 The type controlled by the shared pointer.  
  
 `out`  
 The output stream.  
  
 `sp`  
 The shared pointer.  
  
## Remarks  
 The template function returns `out << sp.get()`.  
  
## Example  
  
```  
// std_tr1__memory__operator_sl.cpp   
// compile with: /EHsc   
#include <memory>   
#include <iostream>   
  
int main()   
    {   
    std::shared_ptr<int> sp0(new int(5));   
  
    std::cout << "sp0 == " << sp0 << " (varies)" << std::endl;   
  
    return (0);   
    }  
  
```  
  
 **sp0 == 3f3040 (varies)**   
## Requirements  
 **Header:** <memory\>  
  
 **Namespace:** std  
  
## See Also  
 [<memory\> Members](assetId:///0d39e979-01a0-4d3e-a1ed-af6bb6957c29)   
 [shared_ptr](../vs140/shared_ptr-class.md)