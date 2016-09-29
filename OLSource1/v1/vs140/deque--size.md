---
title: "deque::size"
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
  - "deque::size"
  - "deque/std::deque::size"
  - "std::deque::size"
  - "size"
  - "std.deque.size"
  - "deque.size"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "size method"
ms.assetid: 2df4f143-4fbc-440e-92dd-62aabbfded47
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# deque::size
Returns the number of elements in the deque.  
  
## Syntax  
  
```  
  
size_type size( ) const;  
  
```  
  
## Return Value  
 The current length of the deque.  
  
## Example  
  
```  
// deque_size.cpp  
// compile with: /EHsc  
#include <deque>  
#include <iostream>  
  
int main( )   
{  
   using namespace std;  
   deque <int> c1;  
   deque <int>::size_type i;  
  
   c1.push_back( 1 );  
   i = c1.size( );  
   cout << "The deque length is " << i << "." << endl;  
  
   c1.push_back( 2 );  
   i = c1.size( );  
   cout << "The deque length is now " << i << "." << endl;  
}  
```  
  
 **The deque length is 1.**  
**The deque length is now 2.**   
## Requirements  
 **Header:** <deque\>  
  
 **Namespace:** std  
  
## See Also  
 [deque Class](../vs140/deque-class.md)   
 [deque::size and deque::resize](../vs140/deque--size-and-deque--resize.md)   
 [Standard Template Library](../vs140/standard-template-library.md)