---
title: "reverse_iterator::operator+"
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
  - "+"
  - "operator+"
  - "reverse_iterator.operator+"
  - "std.reverse_iterator.operator+"
  - "xutility/std::reverse_iterator::operator+"
  - "std::reverse_iterator::operator+"
  - "reverse_iterator::operator+"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator +, iterators"
  - "+ operator, iterator"
  - "+ operator"
  - "operator+, iterators"
ms.assetid: bae7dde4-6501-42da-b524-ea7db95bbcf9
caps.latest.revision: 18
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# reverse_iterator::operator+
Adds an offset to an iterator and returns the new `reverse_iterator` addressing the inserted element at the new offset position.  
  
## Syntax  
  
```  
reverse_iterator<RandomIterator> operator+(  
   difference_type _Off  
) const;  
```  
  
#### Parameters  
 `_Off`  
 The offset to be added to the reverse iterator.  
  
## Return Value  
 A `reverse_iterator` addressing the offset element.  
  
## Remarks  
 This member function may only be used if the `reverse_iterator` satisfies the requirements for a random-access iterator.  
  
## Example  
  
```  
// reverse_iterator_op_add.cpp  
// compile with: /EHsc  
#include <iterator>  
#include <vector>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   int i;  
  
   vector<int> vec;  
   for (i = 1 ; i < 6 ; ++i )    
   {  
      vec.push_back ( 2 * i );  
   }  
  
   vector <int>::iterator vIter;  
   cout << "The vector vec is: ( ";  
   for ( vIter = vec.begin( ) ; vIter != vec.end( ); vIter++)  
      cout << *vIter << " ";  
   cout << ")." << endl;  
  
   vector <int>::reverse_iterator rvIter;  
   cout << "The vector vec reversed is: ( ";  
   for ( rvIter = vec.rbegin( ) ; rvIter != vec.rend( ); rvIter++)  
      cout << *rvIter << " ";  
   cout << ")." << endl;  
  
   // Initializing reverse_iterators to the first element  
   vector <int>::reverse_iterator rVPOS1 = vec.rbegin ( );  
  
   cout << "The iterator rVPOS1 initially points to the first "  
        << "element\n in the reversed sequence: "  
        << *rVPOS1 << "." << endl;  
  
   vector <int>::reverse_iterator rVPOS2 =rVPOS1 + 2; // offset added  
   cout << "After the +2 offset, the iterator rVPOS2 points\n"  
        << " to the 3rd element in the reversed sequence: "  
        << *rVPOS2 << "." << endl;  
}  
```  
  
 **The vector vec is: ( 2 4 6 8 10 ).**  
**The vector vec reversed is: ( 10 8 6 4 2 ).**  
**The iterator rVPOS1 initially points to the first element**  
 **in the reversed sequence: 10.**  
**After the +2 offset, the iterator rVPOS2 points**  
 **to the 3rd element in the reversed sequence: 6.**   
## Requirements  
 **Header:** <iterator\>  
  
 **Namespace:** std  
  
## See Also  
 [reverse_iterator Class](../vs140/reverse_iterator-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)