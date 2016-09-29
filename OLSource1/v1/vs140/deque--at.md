---
title: "deque::at"
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
  - "std.deque.at"
  - "at"
  - "deque::at"
  - "deque/std::deque::at"
  - "std::deque::at"
  - "deque.at"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "at method"
ms.assetid: 4cc40ef3-04bb-4a4f-ac0d-2777febd644e
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# deque::at
Returns a reference to the element at a specified location in the deque.  
  
## Syntax  
  
```  
  
      reference at(  
   size_type _Pos  
);  
const_reference at(  
   size_type _Pos  
) const;  
```  
  
#### Parameters  
 `_Pos`  
 The subscript (or position number) of the element to reference in the deque.  
  
## Return Value  
 If `_Pos` is greater than the size of the deque, **at** throws an exception.  
  
## Return Value  
 If the return value of **at** is assigned to a `const_reference`, the deque object cannot be modified. If the return value of **at** is assigned to a **reference**, the deque object can be modified.  
  
## Example  
  
```  
// deque_at.cpp  
// compile with: /EHsc  
#include <deque>  
#include <iostream>  
  
int main( )   
{  
   using namespace std;  
   deque <int> c1;  
  
   c1.push_back( 10 );  
   c1.push_back( 20 );  
  
   const int& i = c1.at( 0 );  
   int& j = c1.at( 1 );  
   cout << "The first element is " << i << endl;  
   cout << "The second element is " << j << endl;  
}  
```  
  
 **The first element is 10**  
**The second element is 20**   
## Requirements  
 **Header:** <deque\>  
  
 **Namespace:** std  
  
## See Also  
 [deque Class](../vs140/deque-class.md)   
 [deque::operatorand deque::at](../vs140/deque--operatorand-deque--at.md)   
 [Standard Template Library](../vs140/standard-template-library.md)