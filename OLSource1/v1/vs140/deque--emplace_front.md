---
title: "deque::emplace_front"
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
  - "deque.emplace_front"
  - "emplace_front"
  - "std.deque.emplace_front"
  - "deque/std::deque::emplace_front"
  - "std::deque::emplace_front"
  - "deque::emplace_front"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "emplace_front method, deque class"
  - "emplace_front method"
ms.assetid: 8cb7469e-b201-4d0f-bb50-d71a356b85ce
caps.latest.revision: 11
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# deque::emplace_front
Adds an element constructed in place to the end of the deque.  
  
## Syntax  
  
```  
void emplace_front(  
   Type&&_Val  
);  
```  
  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|`_Val`|The element added to the beginning of the [deque](../vs140/deque-class.md).|  
  
## Example  
  
```  
// deque_emplace_front.cpp  
// compile with: /EHsc  
#include <deque>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;     
   deque <int> v1;  
  
   v1.push_back( 1 );  
   if ( v1.size( ) != 0 )  
      cout << "Last element: " << v1.back( ) << endl;  
  
   v1.push_back( 2 );  
   if ( v1.size( ) != 0 )  
      cout << "New last element: " << v1.back( ) << endl;  
  
// initialize a deque of deques by moving v1  
   deque < deque <int> > vv1;  
  
   vv1.emplace_front( move( v1 ) );  
   if ( vv1.size( ) != 0 && vv1[0].size( ) != 0 )  
      cout << "Moved last element: " << vv1[0].back( ) << endl;  
}  
```  
  
 **Last element: 1**  
**New last element: 2**  
**Moved last element: 2**   
## Requirements  
 **Header:** \<deque>  
  
 **Namespace:** std  
  
## See Also  
 [deque Class](../vs140/deque-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)