---
title: "deque::emplace"
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
  - "deque/std::deque::emplace"
  - "std::deque::emplace"
  - "deque::emplace"
  - "deque.emplace"
  - "emplace"
  - "std.deque.emplace"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "emplace method"
  - "emplace method, deque class"
ms.assetid: b3ea8ce1-87f8-4a76-8881-c3f92fcae96f
caps.latest.revision: 11
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# deque::emplace
Inserts an element constructed in place into the deque at a specified position.  
  
## Syntax  
  
```  
iterator emplace(  
   const_iterator _Where,  
   Type&& _Val  
);  
```  
  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|`_Where`|The position in the [deque](../vs140/deque-class.md) where the first element is inserted.|  
|`_Val`|The value of the element being inserted into the `deque`.|  
  
## Return Value  
 The function returns an iterator that points to the position where the new element was inserted into the deque.  
  
## Remarks  
 Any insertion operation can be expensive, see `deque` for a discussion of `deque` performance.  
  
## Example  
  
```  
// deque_emplace.cpp  
// compile with: /EHsc  
#include <deque>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;     
   deque <int> v1;  
   deque <int>::iterator Iter;  
  
   v1.push_back( 10 );  
   v1.push_back( 20 );  
   v1.push_back( 30 );  
  
   cout << "v1 =" ;  
   for ( Iter = v1.begin( ) ; Iter != v1.end( ) ; Iter++ )  
      cout << " " << *Iter;  
   cout << endl;  
  
// initialize a deque of deques by moving v1  
   deque < deque <int> > vv1;  
  
   vv1.emplace( vv1.begin(), move( v1 ) );  
   if ( vv1.size( ) != 0 && vv1[0].size( ) != 0 )  
      {  
      cout << "vv1[0] =";  
      for (Iter = vv1[0].begin( ); Iter != vv1[0].end( ); Iter++ )  
         cout << " " << *Iter;  
      cout << endl;  
      }  
}  
```  
  
 **v1 = 10 20 30**  
**vv1[0] = 10 20 30**   
## Requirements  
 **Header:** \<deque>  
  
 **Namespace:** std  
  
## See Also  
 [deque Class](../vs140/deque-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)