---
title: "reverse_iterator::reverse_iterator"
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
  - "reverse_iterator"
  - "reverse_iterator.reverse_iterator"
  - "reverse_iterator::reverse_iterator"
  - "std::reverse_iterator::reverse_iterator"
  - "xutility/std::reverse_iterator::reverse_iterator"
  - "std.reverse_iterator.reverse_iterator"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "reverse_iterator method"
  - "reverse_iterator class, constructor"
ms.assetid: e52a9cfd-9657-43b8-a316-9ba5b115c108
caps.latest.revision: 17
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# reverse_iterator::reverse_iterator
Constructs a default `reverse_iterator` or a `reverse_iterator` from an underlying iterator.  
  
## Syntax  
  
```  
  
      reverse_iterator( );   
explicit reverse_iterator(  
   RandomIterator _Right  
);  
template<class Type>  
   reverse_iterator(  
      const reverse_iterator<Type>& _Right  
   );  
```  
  
#### Parameters  
 `_Right`  
 The iterator that is to be adapted to a `reverse_iterator`.  
  
## Return Value  
 A default `reverse_iterator` or a `reverse_iterator` adapting an underlying iterator.  
  
## Remarks  
 The identity which relates all reverse iterators to their underlying iterators is:  
  
 &\*(`reverse_iterator` ( *i* ) ) == &\*( *i* – 1 ).  
  
 In practice, this means that in the reversed sequence the reverse_iterator will refer to the element one position beyond (to the right of) the element that the iterator had referred to in the original sequence. So if an iterator addressed the element 6 in the sequence (2, 4, 6, 8), then the `reverse_iterator` will address the element 4 in the reversed sequence (8, 6, 4, 2).  
  
## Example  
  
```  
// reverse_iterator_reverse_iterator.cpp  
// compile with: /EHsc  
#include <iterator>  
#include <algorithm>  
#include <vector>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   int i;  
  
   vector<int> vec;  
   for ( i = 1 ; i < 6 ; ++i )  
   {  
      vec.push_back ( i );  
   }  
  
   vector <int>::iterator vIter;  
   cout << "The vector vec is: ( ";  
   for ( vIter = vec.begin ( ) ; vIter != vec.end ( ); vIter++)  
      cout << *vIter << " ";  
   cout << ")." << endl;  
  
   vector <int>::reverse_iterator rvIter;  
   cout << "The vector vec reversed is: ( ";  
   for ( rvIter = vec.rbegin( ) ; rvIter != vec.rend( ); rvIter++)  
      cout << *rvIter << " ";  
   cout << ")." << endl;  
  
   vector <int>::iterator pos;  
   pos = find ( vec.begin ( ), vec.end ( ), 4 );  
   cout << "The iterator pos = " << *pos << "." << endl;  
  
   vector <int>::reverse_iterator rpos ( pos );  
   cout << "The reverse_iterator rpos = " << *rpos   
        << "." << endl;  
}  
```  
  
## Output  
  
```  
The vector vec is: ( 1 2 3 4 5 ).  
The vector vec reversed is: ( 5 4 3 2 1 ).  
The iterator pos = 4.  
The reverse_iterator rpos = 3.  
```  
  
## Requirements  
 **Header:** \<iterator>  
  
 **Namespace:** std  
  
## See Also  
 [reverse_iterator Class](../vs140/reverse_iterator-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)