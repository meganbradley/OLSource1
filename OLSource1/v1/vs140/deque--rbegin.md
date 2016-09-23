---
title: "deque::rbegin"
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
  - deque::rbegin
  - std::deque::rbegin
  - rbegin
  - deque.rbegin
  - std.deque.rbegin
  - deque/std::deque::rbegin
dev_langs: 
  - C++
helpviewer_keywords: 
  - rbegin method
ms.assetid: 3248eded-ce82-4f04-b4a3-c78c6bfcb6f6
caps.latest.revision: 16
translation.priority.ht: 
  - de-de
  - ja-jp
---
# deque::rbegin
Returns an iterator to the first element in a reversed deque.  
  
## Syntax  
  
```  
  
      const_reverse_iterator rbegin( ) const;   
reverse_iterator rbegin( );  
```  
  
## Return Value  
 A reverse random-access iterator addressing the first element in a reversed deque or addressing what had been the last element in the unreversed deque.  
  
## Remarks  
 `rbegin` is used with a reversed deque just as [begin](../vs140/deque--begin.md) is used with a deque.  
  
 If the return value of `rbegin` is assigned to a `const_reverse_iterator`, the deque object cannot be modified. If the return value of `rbegin` is assigned to a `reverse_iterator`, the deque object can be modified.  
  
 `rbegin` can be used to iterate through a deque backwards.  
  
## Example  
  
```  
// deque_rbegin.cpp  
// compile with: /EHsc  
#include <deque>  
#include <iostream>  
  
int main( )   
{  
   using namespace std;  
   deque <int> c1;  
   deque <int>::iterator c1_Iter;  
   deque <int>::reverse_iterator c1_rIter;  
  
   // If the following line had replaced the line above, an error   
   // would have resulted in the line modifying an element   
   // (commented below) because the iterator would have been const  
   // deque <int>::const_reverse_iterator c1_rIter;  
  
   c1.push_back( 10 );  
   c1.push_back( 20 );  
   c1.push_back( 30 );  
  
   c1_rIter = c1.rbegin( );  
   cout << "Last element in the deque is " << *c1_rIter << "." << endl;  
  
   cout << "The deque contains the elements: ";  
   for ( c1_Iter = c1.begin( ); c1_Iter != c1.end( ); c1_Iter++ )  
      cout << *c1_Iter << " ";  
   cout << "in that order.";  
   cout << endl;  
  
   // rbegin can be used to iterate through a deque in reverse order  
   cout << "The reversed deque is: ";  
   for ( c1_rIter = c1.rbegin( ); c1_rIter != c1.rend( ); c1_rIter++ )  
      cout << *c1_rIter << " ";  
   cout << endl;  
  
   c1_rIter = c1.rbegin( );  
   *c1_rIter = 40;  // This would have caused an error if a   
                    // const_reverse iterator had been declared as   
                    // noted above  
   cout << "Last element in deque is now " << *c1_rIter << "." << endl;  
}  
```  
  
 **Last element in the deque is 30.**  
**The deque contains the elements: 10 20 30 in that order.**  
**The reversed deque is: 30 20 10**   
**Last element in deque is now 40.**   
## Requirements  
 **Header:** <deque\>  
  
 **Namespace:** std  
  
## See Also  
 [deque Class](../vs140/deque-class.md)   
 [deque::rbegin and deque::rend](../vs140/deque--rbegin-and-deque--rend.md)   
 [Standard Template Library](../vs140/standard-template-library.md)