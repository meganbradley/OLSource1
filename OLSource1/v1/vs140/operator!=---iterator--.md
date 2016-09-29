---
title: "operator!= (&lt;iterator&gt;)"
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
  - "iterator/std::operator!="
  - "std::!="
  - "!="
  - "std::operator!="
  - "std.operator!="
  - "std.!="
  - "operator!="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator !=, iterators"
  - "operator!=, iterators"
  - "!= operator"
ms.assetid: 646a26fb-0c5c-41b6-b89d-4897b76d9845
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# operator!= (&lt;iterator&gt;)
Tests if the iterator object on the left side of the operator is not equal to the iterator object on the right side.  
  
## Syntax  
  
```  
  
      template<class RandomIterator>  
   bool operator!=(  
      const reverse_iterator<RandomIterator>& _Left,  
      const reverse_iterator<RandomIterator>& _Right  
   );  
template<class Type, class CharType, class Traits, class Distance>  
   bool operator!=(  
      const istream_iterator<Type, CharType, Traits, Distance>& _Left,  
      const istream_iterator<Type, CharType, Traits, Distance>& _Right  
   );  
template<class CharType, class Tr>  
   bool operator!=(  
      const istreambuf_iterator<CharType, Traits>& _Left,  
      const istreambuf_iterator<CharType, Traits>& _Right  
);  
```  
  
#### Parameters  
 `_Left`  
 An object of type **iterator**.  
  
 `_Right`  
 An object of type **iterator**.  
  
## Return Value  
 **true** if the iterator objects are not equal; **false** if the iterator objects are equal.  
  
## Remarks  
 One iterator object is equal to another if they address the same elements in a container. If two iterators point to different elements in a container, then they are not equal.  
  
## Example  
  
```  
// iterator_op_ne.cpp  
// compile with: /EHsc  
#include <iterator>  
#include <vector>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   int i;  
  
   vector<int> vec;  
   for ( i = 1 ; i < 9 ; ++i )    
   {  
      vec.push_back ( i );  
   }  
  
   vector <int>::iterator vIter;  
  
   cout << "The vector vec is: ( ";  
   for ( vIter = vec.begin( ) ; vIter != vec.end( ); vIter++ )  
      cout << *vIter << " ";  
   cout << ")." << endl;  
  
   // Initializing reverse_iterators to the last element  
   vector <int>::reverse_iterator rVPOS1 = vec.rbegin ( ),   
           rVPOS2 = vec.rbegin ( );  
  
   cout << "The iterator rVPOS1 initially points to the first "  
        << "element\n in the reversed sequence: "  
        << *rVPOS1 << "." << endl;  
  
   if ( rVPOS1 != rVPOS2 )  
      cout << "The iterators are not equal." << endl;  
   else  
      cout << "The iterators are equal." << endl;  
  
   rVPOS1++;  
   cout << "The iterator rVPOS1 now points to the second "  
        << "element\n in the reversed sequence: "  
        << *rVPOS1 << "." << endl;  
  
   if ( rVPOS1 != rVPOS2 )  
      cout << "The iterators are not equal." << endl;  
   else  
      cout << "The iterators are equal." << endl;  
}  
```  
  
 **The vector vec is: ( 1 2 3 4 5 6 7 8 ).**  
**The iterator rVPOS1 initially points to the first element**  
 **in the reversed sequence: 8.**  
**The iterators are equal.**  
**The iterator rVPOS1 now points to the second element**  
 **in the reversed sequence: 7.**  
**The iterators are not equal.**   
## Requirements  
 **Header:** <iterator\>  
  
 **Namespace:** std  
  
## See Also  
 [Standard Template Library](../vs140/standard-template-library.md)