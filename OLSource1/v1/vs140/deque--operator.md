---
title: "deque::operator"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - deque::operator[]
  - []
  - std::deque::operator[]
  - operator[]
  - std.deque.operator[]
  - deque.operator[]
  - deque/std::deque::operator[]
dev_langs: 
  - C++
helpviewer_keywords: 
  - operator[], deque objects
  - operator [], deque objects
  - [] operator, with specific standard C++ objects
ms.assetid: 49e561ef-f3e6-4bd5-8fd6-2ee6c3e55485
caps.latest.revision: 17
translation.priority.ht: 
  - de-de
  - ja-jp
---
# deque::operator
Returns a reference to the deque element at a specified position.  
  
## Syntax  
  
```  
  
      reference operator[](size_type _Pos);  
const_reference operator[](size_type _Pos) const;  
```  
  
#### Parameters  
 `_Pos`  
 The position of the deque element to be referenced.  
  
## Return Value  
 A reference to the element whose position is specified in the argument. If the position specified is greater than the size of the deque, the result is undefined.  
  
## Remarks  
 If the return value of `operator[]` is assigned to a `const_reference`, the deque object cannot be modified. If the return value of `operator[]` is assigned to a **reference**, the deque object can be modified.  
  
 When compiling with _SECURE_SCL 1, a runtime error will occur if you attempt to access an element outside the bounds of the deque.  See [Checked Iterators](../vs140/checked-iterators.md) for more information.  
  
## Example  
  
```  
// deque_op_ref.cpp  
// compile with: /EHsc  
#include <deque>  
#include <iostream>  
  
int main( )   
{  
   using namespace std;  
   deque <int> c1;  
  
   c1.push_back( 10 );  
   c1.push_back( 20 );  
   cout << "The first integer of c1 is " << c1[0] << endl;  
   int& i = c1[1];  
   cout << "The second integer of c1 is " << i << endl;  
  
}  
```  
  
 **The first integer of c1 is 10**  
**The second integer of c1 is 20**   
## Requirements  
 **Header:** <deque\>  
  
 **Namespace:** std  
  
## See Also  
 [deque Class](../vs140/deque-class.md)   
 [deque::operatorand deque::at](../vs140/deque--operatorand-deque--at.md)   
 [Standard Template Library](../vs140/standard-template-library.md)