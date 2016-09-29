---
title: "reverse_iterator::base"
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
  - "reverse_iterator::base"
  - "base"
  - "iterator/std::reverse_iterator::base"
  - "std.reverse_iterator.base"
  - "reverse_iterator.base"
  - "std::reverse_iterator::base"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "base method"
ms.assetid: 71e56694-4538-4f16-a1b6-f9f6d47edfc4
caps.latest.revision: 17
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# reverse_iterator::base
Recovers the underlying iterator from its `reverse_iterator`.  
  
## Syntax  
  
```  
  
RandomIterator base( ) const;  
  
```  
  
## Return Value  
 The iterator underlying the `reverse_iterator`.  
  
## Remarks  
 The identity that relates all reverse iterators to their underlying iterators is:  
  
 &\*(`reverse_iterator` ( *i* ) ) == &\*( *i* – 1 ).  
  
 In practice, this means that in the reversed sequence the `reverse_iterator` will refer to the element one position beyond (to the right of) the element that the iterator had referred to in the original sequence. So if an iterator addressed the element 6 in the sequence (2, 4, 6, 8), then the `reverse_iterator` will address the element 4 in the reversed sequence (8, 6, 4, 2).  
  
## Example  
  
```  
// reverse_iterator_base.cpp  
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
      vec.push_back ( 2 * i );  
   }  
  
   vector <int>::iterator vIter;  
   cout << "The vector vec is: ( ";  
   for ( vIter = vec.begin ( ) ; vIter != vec.end ( ); vIter++ )  
      cout << *vIter << " ";  
   cout << ")." << endl;  
  
   vector <int>::reverse_iterator rvIter;  
   cout << "The vector vec reversed is: ( ";  
   for ( rvIter = vec.rbegin( ) ; rvIter != vec.rend( ); rvIter++)  
      cout << *rvIter << " ";  
   cout << ")." << endl;  
  
   vector <int>::iterator pos, bpos;  
   pos = find ( vec.begin ( ), vec.end ( ), 6 );  
   cout << "The iterator pos points to: " << *pos << "." << endl;  
  
   typedef reverse_iterator<vector<int>::iterator>::iterator_type it_vec_int_type;  
  
   reverse_iterator<it_vec_int_type> rpos ( pos );  
   cout << "The reverse_iterator rpos points to: " << *rpos   
        << "." << endl;  
  
   bpos = rpos.base ( );  
   cout << "The iterator underlying rpos is bpos & it points to: "   
        << *bpos << "." << endl;  
}  
```  
  
## Output  
  
```  
The vector vec is: ( 2 4 6 8 10 ).  
The vector vec reversed is: ( 10 8 6 4 2 ).  
The iterator pos points to: 6.  
The reverse_iterator rpos points to: 4.  
The iterator underlying rpos is bpos & it points to: 6.  
```  
  
## Requirements  
 **Header:** \<iterator>  
  
 **Namespace:** std  
  
## See Also  
 [reverse_iterator Class](../vs140/reverse_iterator-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)