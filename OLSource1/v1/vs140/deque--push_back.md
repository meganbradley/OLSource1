---
title: "deque::push_back"
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
  - deque/std::deque::push_back
  - deque::push_back
  - deque.push_back
  - std::deque::push_back
  - std.deque.push_back
  - push_back
dev_langs: 
  - C++
helpviewer_keywords: 
  - push_back method
ms.assetid: caa61fbf-f015-4e2d-a59e-424ad7758519
caps.latest.revision: 18
translation.priority.ht: 
  - de-de
  - ja-jp
---
# deque::push_back
Adds an element to the end of the deque.  
  
## Syntax  
  
```  
void push_back(  
   const Type& _Val  
);  
void push_back(  
   Type&& _Val  
);  
```  
  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|`_Val`|The element added to the end of the deque.|  
  
## Remarks  
 If an exception is thrown, the deque is left unaltered and the exception is rethrown.  
  
## Code Example  
  
```  
// deque_push_back.cpp  
// compile with: /EHsc  
#include <deque>  
#include <iostream>  
  
int main( )   
{  
   using namespace std;  
   deque <int> d;  
  
   d.push_back( 1 );  
   d.push_back( 2 );  
   d.push_back( 3 );  
   for( deque<int>::const_iterator i = d.begin(); i != d.end(); ++i )  
   {  
      cout << *i << " ";  
   }  
   cout << endl;  
  
   d.push_front( 0 );  
   d.push_back( 4 );  
   for( deque<int>::const_iterator i = d.begin(); i != d.end(); ++i )  
   {  
      cout << *i << " ";  
   }  
   cout << endl;  
  
// move initialize a deque of deques by moving d  
   deque < deque <int> > dd;  
  
   dd.push_back( move( d ) );  
   cout << "Moved last element: " << dd[0].back( ) << endl;  
}  
```  
  
## Output  
  
```  
1 2 3  
0 1 2 3 4  
Moved last element: 4  
```  
  
## Requirements  
 **Header:** <deque\>  
  
 **Namespace:** std  
  
## See Also  
 [deque Class](../vs140/deque-class.md)   
 [deque::push_back and deque::pop_back](../vs140/deque--push_back-and-deque--pop_back.md)   
 [Standard Template Library](../vs140/standard-template-library.md)