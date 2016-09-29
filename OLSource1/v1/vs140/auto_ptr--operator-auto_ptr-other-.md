---
title: "auto_ptr::operator auto_ptr&lt;Other&gt;"
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
  - "operatorauto_ptr<Other>"
  - "std.auto_ptr.operatorauto_ptr<Other>"
  - "auto_ptr::operatorauto_ptr<Other>"
  - "std::auto_ptr::operatorauto_ptr<Other>"
  - "memory/std::auto_ptr::operatorauto_ptr<Other>"
  - "auto_ptr<Other>"
  - "auto_ptr.operatorauto_ptr<Other>"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "auto_ptr<Other> operator"
  - "operator auto_ptr<Other>"
ms.assetid: d77dd9b0-3115-47ce-ab27-10bae32a803b
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# auto_ptr::operator auto_ptr&lt;Other&gt;
Casts from one kind of `auto_ptr` to another kind of `auto_ptr`.  
  
## Syntax  
  
```  
  
   template<class Other>  
operator auto_ptr<Other>( ) throw( );  
```  
  
## Return Value  
 The type cast operator returns `auto_ptr` <**Other**>(**\*this**).  
  
## Example  
  
```  
// auto_ptr_op_auto_ptr.cpp  
// compile with: /EHsc  
#include <memory>  
#include <iostream>  
#include <vector>  
  
using namespace std;  
int main()  
{  
   auto_ptr<int> pi ( new int( 5 ) );  
   auto_ptr<const int> pc = ( auto_ptr<const int> )pi;  
}  
```  
  
## Requirements  
 **Header:** <memory\>  
  
 **Namespace:** std  
  
## See Also  
 [auto_ptr Class](../vs140/auto_ptr-class.md)