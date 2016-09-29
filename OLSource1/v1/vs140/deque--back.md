---
title: "deque::back"
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
  - "std.deque.back"
  - "deque::back"
  - "back"
  - "std::deque::back"
  - "deque.back"
  - "Back"
  - "deque/std::deque::back"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "back method"
  - "back method, deque class"
ms.assetid: 81f8b210-324c-422e-b60c-e65dd1be93f9
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# deque::back
Returns a reference to the last element of the deque.  
  
## Syntax  
  
```  
  
      reference back( );   
const_reference back( ) const;  
```  
  
## Return Value  
 The last element of the deque. If the deque is empty, the return value is undefined.  
  
## Remarks  
 If the return value of **back** is assigned to a `const_reference`, the deque object cannot be modified. If the return value of **back** is assigned to a **reference**, the deque object can be modified.  
  
 When compiling with _SECURE_SCL 1, a runtime error will occur if you attempt to access an element in an empty deque.  See [Checked Iterators](../vs140/checked-iterators.md) for more information.  
  
## Example  
  
```  
// deque_back.cpp  
// compile with: /EHsc  
#include <deque>  
#include <iostream>  
  
int main( )   
{  
   using namespace std;  
   deque <int> c1;  
  
   c1.push_back( 10 );  
   c1.push_back( 11 );  
  
   int& i = c1.back( );  
   const int& ii = c1.front( );  
  
   cout << "The last integer of c1 is " << i << endl;  
   i--;  
   cout << "The next-to-last integer of c1 is " << ii << endl;  
}  
```  
  
 **The last integer of c1 is 11**  
**The next-to-last integer of c1 is 10**   
## Requirements  
 **Header:** \<deque>  
  
 **Namespace:** std  
  
## See Also  
 [deque Class](../vs140/deque-class.md)   
 [deque::front and deque::back](../vs140/deque--front-and-deque--back.md)   
 [Standard Template Library](../vs140/standard-template-library.md)