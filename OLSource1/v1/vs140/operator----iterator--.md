---
title: "operator- (&lt;iterator&gt;)"
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
  - "std.-"
  - "-"
  - "operator-"
  - "iterator/std::operator-"
  - "std.operator-"
  - "std::-"
  - "std::operator-"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "- operator"
  - "- operator, iterator"
ms.assetid: 17101465-ad41-498c-bac6-f333b99ac488
caps.latest.revision: 19
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# operator- (&lt;iterator&gt;)
Subtracts one iterator from another and returns the difference.  
  
## Syntax  
  
```  
template<class RandomIterator1, class RandomIterator2>  
    Tdiff operator-(  
        const move_iterator<RandomIterator1>& _Left,  
        const move_iterator<RandomIterator2>& _Right  
    );  
template<class RandomIterator1, class RandomIterator2>  
    Tdiff operator-(  
        const reverse_iterator<RandomIterator1>& _Left,  
        const reverse_iterator<RandomIterator2>& _Right  
);  
```  
  
#### Parameters  
 `_Left`  
 An iterator.  
  
 `_Right`  
 An iterator.  
  
## Return Value  
 The difference between two iterators`.`  
  
## Remarks  
 The first template operator returns `_Left.base() - _Right.base()`.  
  
 The second template operator returns `_Right.current - _Left.current`.  
  
 `Tdiff` is determined by the type of the returned expression. Otherwise, it is `RandomIterator1::difference_type`.  
  
## Example  
  
```  
// iterator_op_sub.cpp  
// compile with: /EHsc  
#include <iterator>  
#include <vector>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   int i;  
  
   vector<int> vec;  
   for (i = 0 ; i < 6 ; ++i )    
   {  
      vec.push_back ( 2 * i );  
   }  
  
   vector <int>::iterator vIter;  
  
   cout << "The initial vector vec is: ( ";  
   for ( vIter = vec.begin( ) ; vIter != vec.end( ); vIter++)  
      cout << *vIter << " ";  
   cout << ")." << endl;  
  
   vector <int>::reverse_iterator rVPOS1 = vec.rbegin ( ),   
          rVPOS2 = vec.rbegin ( );  
  
   cout << "The iterators rVPOS1 & rVPOS2 initially point to "  
        << "the first element\n in the reversed sequence: "  
        << *rVPOS1 << "." << endl;  
  
   for (i = 1; i < 5; ++i)    
   {  
      rVPOS2++;  
   }  
   cout << "The iterator rVPOS2 now points to the fifth "  
        << "element\n in the reversed sequence: "  
        << *rVPOS2 << "." << endl;  
  
   vector<int>::difference_type diff = rVPOS2 - rVPOS1;  
   cout << "The difference: rVPOS2 - rVPOS1= "  
        << diff << "." << endl;  
}  
```  
  
 **The initial vector vec is: ( 0 2 4 6 8 10 ).**  
**The iterators rVPOS1 & rVPOS2 initially point to the first element**  
 **in the reversed sequence: 10.**  
**The iterator rVPOS2 now points to the fifth element**  
 **in the reversed sequence: 2.**  
**The difference: rVPOS2 - rVPOS1= 4.**   
## Requirements  
 **Header:** <iterator\>  
  
 **Namespace:** std  
  
## See Also  
 [Standard Template Library](../vs140/standard-template-library.md)