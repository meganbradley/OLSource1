---
title: "deque::emplace_back"
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
  - "deque/std::deque::emplace_back"
  - "deque.emplace_back"
  - "std.deque.emplace_back"
  - "emplace_back"
  - "std::deque::emplace_back"
  - "deque::emplace_back"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "emplace_back method"
  - "emplace_back method, deque class"
ms.assetid: cb66115a-ec08-4a5d-b052-1462c6c93afb
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# deque::emplace_back
Adds an element constructed in place to the end of the deque.  
  
## Syntax  
  
```  
void emplace_back(  
   Type&&_Val  
);  
```  
  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|`_Val`|The element added to the end of the [deque](../vs140/deque-class.md).|  
  
## Example  
  
```  
// deque_emplace_back.cpp  
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
  
   vv1.emplace_back( move( v1 ) );  
   if ( vv1.size( ) != 0 && vv1[0].size( ) != 0 )  
      cout << "Moved last element: " << vv1[0].back( ) << endl;  
}  
```  
  
 **Last element: 1**  
**New last element: 2**  
**Moved last element: 2**   
## Requirements  
 **Header:** <deque\>  
  
 **Namespace:** std  
  
## See Also  
 [deque Class](../vs140/deque-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)