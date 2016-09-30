---
title: "deque::erase"
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
  - "erase"
  - "std.deque.erase"
  - "deque::erase"
  - "deque.erase"
  - "Erase"
  - "deque/std::deque::erase"
  - "std::deque::erase"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "erase method"
ms.assetid: e95bcb2e-2b08-4fbb-9bc0-2fe903c209bb
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# deque::erase
Removes an element or a range of elements in a deque from specified positions.  
  
## Syntax  
  
```  
  
      iterator erase(  
   iterator _Where  
);  
iterator erase(  
   iterator _First,  
   iterator _Last  
);  
```  
  
#### Parameters  
 `_Where`  
 Position of the element to be removed from the deque.  
  
 `_First`  
 Position of the first element removed from the deque.  
  
 `_Last`  
 Position just beyond the last element removed from the deque.  
  
## Return Value  
 A random-access iterator that designates the first element remaining beyond any elements removed, or a pointer to the end of the deque if no such element exists.  
  
## Remarks  
 For more information on **erase**, see [deque::erase and deque::clear](../vs140/deque--erase-and-deque--clear.md).  
  
 **erase** never throws an exception.  
  
## Example  
  
```  
// deque_erase.cpp  
// compile with: /EHsc  
#include <deque>  
#include <iostream>  
  
int main( )   
{  
   using namespace std;  
   deque <int> c1;  
   deque <int>::iterator Iter;  
  
   c1.push_back( 10 );  
   c1.push_back( 20 );  
   c1.push_back( 30 );  
   c1.push_back( 40 );  
   c1.push_back( 50 );  
   cout << "The initial deque is: ";  
   for ( Iter = c1.begin( ); Iter != c1.end( ); Iter++ )  
      cout << *Iter << " ";  
   cout << endl;  
   c1.erase( c1.begin( ) );  
   cout << "After erasing the first element, the deque becomes:  ";  
   for ( Iter = c1.begin( ); Iter != c1.end( ); Iter++ )  
      cout << *Iter << " ";  
   cout << endl;  
   Iter = c1.begin( );  
   Iter++;  
   c1.erase( Iter, c1.end( ) );  
   cout << "After erasing all elements but the first, deque becomes: ";  
   for ( Iter = c1.begin( ); Iter != c1.end( ); Iter++ )  
      cout << *Iter << " ";  
   cout << endl;  
}  
```  
  
 **The initial deque is: 10 20 30 40 50**   
**After erasing the first element, the deque becomes:  20 30 40 50**   
**After erasing all elements but the first, deque becomes: 20**    
## Requirements  
 **Header:** \<deque>  
  
 **Namespace:** std  
  
## See Also  
 [deque Class](../vs140/deque-class.md)   
 [deque::erase and deque::clear](../vs140/deque--erase-and-deque--clear.md)   
 [Standard Template Library](../vs140/standard-template-library.md)