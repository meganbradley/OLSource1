---
title: "deque::front"
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
  - "deque.front"
  - "std.deque.front"
  - "deque/std::deque::front"
  - "front"
  - "std::deque::front"
  - "deque::front"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "front method, deque class"
ms.assetid: e9e72309-cce8-4665-8e65-1102ce662c0f
caps.latest.revision: 17
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# deque::front
Returns a reference to the first element in a deque.  
  
## Syntax  
  
```  
  
      reference front( );   
const_reference front( ) const;  
```  
  
## Return Value  
 If the deque is empty, the return is undefined.  
  
## Remarks  
 If the return value of `front` is assigned to a `const_reference`, the deque object cannot be modified. If the return value of `front` is assigned to a **reference**, the deque object can be modified.  
  
 When compiling with _SECURE_SCL 1, a runtime error will occur if you attempt to access an element in an empty deque.  See [Checked Iterators](../vs140/checked-iterators.md) for more information.  
  
## Example  
  
```  
// deque_front.cpp  
// compile with: /EHsc  
#include <deque>  
#include <iostream>  
  
int main( )   
{  
   using namespace std;  
   deque <int> c1;  
  
   c1.push_back( 10 );  
   c1.push_back( 11 );  
  
   int& i = c1.front( );  
   const int& ii = c1.front( );  
  
   cout << "The first integer of c1 is " << i << endl;  
   i++;  
   cout << "The second integer of c1 is " << ii << endl;  
}  
```  
  
 **The first integer of c1 is 10**  
**The second integer of c1 is 11**   
## Requirements  
 **Header:** <deque\>  
  
 **Namespace:** std  
  
## See Also  
 [deque Class](../vs140/deque-class.md)   
 [deque::front and deque::back](../vs140/deque--front-and-deque--back.md)   
 [Standard Template Library](../vs140/standard-template-library.md)