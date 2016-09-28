---
title: "auto_ptr::operator auto_ptr_ref&lt;Other&gt;"
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
  - "auto_ptr.operatorauto_ptr_ref<Other>"
  - "std::auto_ptr::operatorauto_ptr_ref<Other>"
  - "auto_ptr_ref<Other>"
  - "std.auto_ptr.operatorauto_ptr_ref<Other>"
  - "memory/std::auto_ptr::operatorauto_ptr_ref<Other>"
  - "operatorauto_ptr_ref<Other>"
  - "auto_ptr::operatorauto_ptr_ref<Other>"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator auto_ptr_ref<Other>"
  - "auto_ptr_ref<Other> operator"
ms.assetid: 59bfdca7-45bb-4e7b-bbaa-d1d4f2281e4c
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# auto_ptr::operator auto_ptr_ref&lt;Other&gt;
Casts from an `auto_ptr` to an **auto_ptr_ref**.  
  
## Syntax  
  
```  
  
   template<class Other>  
operator auto_ptr_ref<Other>( ) throw( );  
```  
  
## Return Value  
 The type cast operator returns **auto_ptr_ref**<**Other**>(**\*this**).  
  
## Example  
  
```  
// auto_ptr_op_auto_ptr_ref.cpp  
// compile with: /EHsc  
#include <memory>  
#include <iostream>  
#include <vector>  
  
using namespace std;  
  
class C{  
   public:  
   C(int _i) : m_i(_i){  
   }  
   ~C(){  
      cout << "~C:  "<< m_i <<"\n";  
   }  
   C &operator =(const int &x){  
      m_i = x;  
      return *this;  
   }  
   int m_i;  
};  
void f(auto_ptr<C> arg ){  
};  
int main()  
{  
   const auto_ptr<C> ciap ( new C(1) );  
   auto_ptr<C> iap ( new C(2) );  
  
   // Error: this implies transfer of ownership of iap's pointer  
   // f(ciap);   
   f(iap); // compiles, but gives up ownership of pointer  
  
   // here, iap owns a destroyed pointer so the following is bad:  
   // *iap = 5; // BOOM  
  
   cout << "main exiting\n";  
}  
```  
  
 **~C:  2**  
**main exiting**  
**~C:  1**   
## Requirements  
 **Header:** <memory\>  
  
 **Namespace:** std  
  
## See Also  
 [auto_ptr Class](../vs140/auto_ptr-class.md)