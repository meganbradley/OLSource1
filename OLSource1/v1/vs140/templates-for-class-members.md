---
title: "Templates for Class Members"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
dev_langs: 
  - C++
helpviewer_keywords: 
  - templates for class members
ms.assetid: 52ac432c-d1e8-4f4c-9809-ce4084badea7
caps.latest.revision: 11
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Templates for Class Members
When creating an out-of-line definition for a member of a template class, the template parameters should be specified on the type name and not on the member name.  
  
## Example  
  
```  
// templates_for_class_members.cpp  
// compile with: /EHsc  
#include <iostream>  
using namespace std;  
template <class T>  
struct X {  
   X();  
   void Test();  
   static const int i;  
};  
  
template <class T>  
   X< T >::X() {  
      cout << "X created." << endl;  
}  
  
template <class T>  
   void X< T >::Test() {  
      cout << "In Test." << endl;  
}  
template <class T>  
   const int X<T>::i = 9;  
  
int main() {  
   X<int> x;  
   x.Test();  
   cout << X<int>::i << endl;  
}  
```  
  
 **X created.**  
**In Test.**  
**9**   
## See Also  
 [Class Templates](../vs140/class-templates.md)