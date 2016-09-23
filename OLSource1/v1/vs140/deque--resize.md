---
title: "deque::resize"
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
  - Resize
  - std::deque::resize
  - std.deque.resize
  - deque.resize
  - resize
  - deque/std::deque::resize
  - deque::resize
dev_langs: 
  - C++
helpviewer_keywords: 
  - resize method, deque class
  - resize method
ms.assetid: 8761c5d1-b5a9-4bbf-a30a-e1074343c5b1
caps.latest.revision: 16
translation.priority.ht: 
  - de-de
  - ja-jp
---
# deque::resize
Specifies a new size for a deque.  
  
## Syntax  
  
```  
  
      void resize(  
   size_type _Newsize  
);  
void resize(  
   size_type _Newsize,  
   Type _Val  
);  
```  
  
#### Parameters  
 `_Newsize`  
 The new size of the deque.  
  
 `_Val`  
 The value of the new elements to be added to the deque if the new size is larger that the original size. If the value is omitted, the new elements are assigned the default value for the class.  
  
## Remarks  
 If the deque's size is less than the requested size, `_Newsize`, elements are added to the deque until it reaches the requested size.  
  
 If the deque's size is larger than the requested size, the elements closest to the end of the deque are deleted until the deque reaches the size `_Newsize`.  
  
 If the present size of the deque is the same as the requested size, no action is taken.  
  
 [size](../vs140/deque--size.md) reflects the current size of the deque.  
  
## Example  
  
```  
// deque_resize.cpp  
// compile with: /EHsc  
#include <deque>  
#include <iostream>  
  
int main( )   
{   
   using namespace std;  
   deque <int> c1;  
  
   c1.push_back( 10 );  
   c1.push_back( 20 );  
   c1.push_back( 30 );  
  
   c1.resize( 4,40 );  
   cout << "The size of c1 is: " << c1.size( ) << endl;  
   cout << "The value of the last element is " << c1.back( ) << endl;  
  
   c1.resize( 5 );  
   cout << "The size of c1 is now: " << c1.size( ) << endl;  
   cout << "The value of the last element is now " << c1.back( ) << endl;  
  
   c1.resize( 2 );  
   cout << "The reduced size of c1 is: " << c1.size( ) << endl;  
   cout << "The value of the last element is now " << c1.back( ) << endl;  
}  
```  
  
 **The size of c1 is: 4**  
**The value of the last element is 40**  
**The size of c1 is now: 5**  
**The value of the last element is now 0**  
**The reduced size of c1 is: 2**  
**The value of the last element is now 20**   
## Requirements  
 **Header:** <deque\>  
  
 **Namespace:** std  
  
## See Also  
 [deque Class](../vs140/deque-class.md)   
 [deque::size and deque::resize](../vs140/deque--size-and-deque--resize.md)   
 [Standard Template Library](../vs140/standard-template-library.md)