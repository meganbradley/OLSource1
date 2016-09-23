---
title: "deque::push_front"
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
  - deque::push_front
  - push_front
  - std.deque.push_front
  - std::deque::push_front
  - deque/std::deque::push_front
  - deque.push_front
dev_langs: 
  - C++
helpviewer_keywords: 
  - push_front method
ms.assetid: 4f602a35-aa21-412e-a708-36a133c6d736
caps.latest.revision: 17
translation.priority.mt: 
  - de-de
  - ja-jp
---
# deque::push_front
Adds an element to the beginning of the deque.  
  
## Syntax  
  
```  
  
      void push_front(  
   const Type& _Val  
);  
void push_front(  
   Type&& _Val  
);  
```  
  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|`_Val`|The element added to the beginning of the deque.|  
  
## Remarks  
 If an exception is thrown, the deque is left unaltered and the exception is rethrown.  
  
## Example  
  
```  
// deque_push_front.cpp  
// compile with: /EHsc  
#include <deque>  
#include <iostream>  
#include <string>  
  
int main( )   
{  
   using namespace std;  
   deque <int> c1;  
  
   c1.push_front( 1 );  
   if ( c1.size( ) != 0 )  
      cout << "First element: " << c1.front( ) << endl;  
  
   c1.push_front( 2 );  
   if ( c1.size( ) != 0 )  
      cout << "New first element: " << c1.front( ) << endl;  
  
// move initialize a deque of strings  
   deque <string> c2;  
   string str("a");  
  
   c2.push_front( move( str ) );  
   cout << "Moved first element: " << c2.front( ) << endl;  
}  
```  
  
 **First element: 1**  
**New first element: 2**  
**Moved first element: a**   
## Requirements  
 **Header:** <deque\>  
  
 **Namespace:** std  
  
## See Also  
 [deque Class](../vs140/deque-class.md)   
 [deque::push_front and deque::pop_front](../vs140/deque--push_front-and-deque--pop_front.md)   
 [Standard Template Library](../vs140/standard-template-library.md)