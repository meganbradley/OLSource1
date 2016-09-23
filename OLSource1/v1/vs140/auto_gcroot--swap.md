---
title: "auto_gcroot::swap"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - msclr.auto_gcroot.swap
  - msclr::auto_gcroot::swap
  - auto_gcroot::swap
  - auto_gcroot.swap
dev_langs: 
  - C++
helpviewer_keywords: 
  - auto_gcroot::swap
ms.assetid: 4915c629-6a53-432c-8155-3a7511dc70cb
caps.latest.revision: 14
translation.priority.ht: 
  - de-de
  - ja-jp
---
# auto_gcroot::swap
Swaps objects with another `auto_gcroot`.  
  
## Syntax  
  
```  
void swap(  
   auto_gcroot<_element_type> & _right  
);  
```  
  
#### Parameters  
 `_right`  
 The `auto_gcroot` with which to swap objects.  
  
## Example  
  
```  
// msl_auto_gcroot_swap.cpp  
// compile with: /clr  
#include <msclr\auto_gcroot.h>  
  
using namespace System;  
using namespace msclr;  
  
int main() {  
   auto_gcroot<String^> s1 = "string one";  
   auto_gcroot<String^> s2 = "string two";  
  
   Console::WriteLine( "s1 = '{0}', s2 = '{1}'",  
      s1->ToString(), s2->ToString() );  
   s1.swap( s2 );  
   Console::WriteLine( "s1 = '{0}', s2 = '{1}'",  
      s1->ToString(), s2->ToString() );  
}  
```  
  
 **s1 = 'string one', s2 = 'string two'**  
**s1 = 'string two', s2 = 'string one'**   
## Requirements  
 **Header file** <msclr\auto_gcroot.h>  
  
 **Namespace** msclr  
  
## See Also  
 [auto_gcroot Members](../vs140/auto_gcroot-members.md)   
 [swap Function (<auto_gcroot.h>)](../vs140/swap-function--auto_gcroot-.md)