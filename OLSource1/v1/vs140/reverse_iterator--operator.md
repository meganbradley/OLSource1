---
title: "reverse_iterator::operator"
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
  - "std::reverse_iterator::operator[]"
  - "reverse_iterator::operator[]"
  - "[]"
  - "operator[]"
  - "iterator/std::reverse_iterator::[]"
  - "std.reverse_iterator.operator[]"
  - "reverse_iterator.operator[]"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator [], iterators"
  - "[] operator, with specific standard C++ objects"
  - "operator[], iterators"
ms.assetid: e4d3cee2-dc00-4e02-a88e-0518219e9aa1
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# reverse_iterator::operator
Returns a reference to an element offset from the element addressed by a `reverse_iterator` by a specified number of positions.  
  
## Syntax  
  
```  
  
      reference operator[](difference_type _Off) const;  
```  
  
#### Parameters  
 `_Off`  
 The offset from the `reverse_iterator` address.  
  
## Return Value  
 The reference to the element offset.  
  
## Remarks  
 The operator returns **\***(**\*this** + `_Off`).  
  
## Example  
  
```  
// reverse_iterator_ret_ref.cpp  
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
   for (i = 1 ; i < 6 ; ++i )  
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
  
   vector <int>::iterator pos;  
   pos = find ( vec.begin ( ), vec.end ( ), 8 );  
   reverse_iterator<vector<int>::iterator> rpos ( pos );  
  
   // Declare a difference type for a parameter  
   reverse_iterator<vector<int>::iterator>::difference_type diff = 2;  
  
   cout << "The iterator pos points to: " << *pos << "." << endl;  
   cout << "The iterator rpos points to: " << *rpos << "." << endl;  
  
   // Declare a reference return type & use operator[]  
   reverse_iterator<vector<int>::iterator>::reference refrpos = rpos [diff];  
   cout << "The iterator rpos now points to: " << refrpos << "." << endl;     
}  
```  
  
 **The vector vec is: ( 2 4 6 8 10 ).**  
**The vector vec reversed is: ( 10 8 6 4 2 ).**  
**The iterator pos points to: 8.**  
**The iterator rpos points to: 6.**  
**The iterator rpos now points to: 2.**   
## Requirements  
 **Header:** \<iterator>  
  
 **Namespace:** std  
  
## See Also  
 [reverse_iterator Class](../vs140/reverse_iterator-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)