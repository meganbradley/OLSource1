---
title: "back_insert_iterator::back_insert_iterator"
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
  - "std::back_insert_iterator::back_insert_iterator"
  - "iterator/std::back_insert_iterator::back_insert_iterator"
  - "back_insert_iterator.back_insert_iterator"
  - "back_insert_iterator"
  - "std.back_insert_iterator.back_insert_iterator"
  - "back_insert_iterator::back_insert_iterator"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "back_insert_iterator method"
  - "back_insert_iterator class, constructor"
ms.assetid: 074128fd-d376-4f02-930f-d6cfe1bfc4f8
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# back_insert_iterator::back_insert_iterator
Constructs a `back_insert_iterator` that inserts elements after the last element in a container.  
  
## Syntax  
  
```  
  
      explicit back_insert_iterator(  
   Container& _Cont  
);  
```  
  
#### Parameters  
 `_Cont`  
 The container that the `back_insert_iterator` is to insert an element into.  
  
## Return Value  
 A `back_insert_iterator` for the parameter container.  
  
## Example  
  
```  
// back_insert_iterator_back_insert_iterator.cpp  
// compile with: /EHsc  
#include <iterator>  
#include <vector>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   int i;  
  
   vector<int> vec;  
   for ( i = 1 ; i < 4 ; ++i )    
   {  
      vec.push_back ( i );  
   }  
  
   vector <int>::iterator vIter;  
   cout << "The initial vector vec is: ( ";  
   for ( vIter = vec.begin ( ) ; vIter != vec.end ( ); vIter++)  
      cout << *vIter << " ";  
   cout << ")." << endl;  
  
   // Insertions with member function  
   back_inserter ( vec ) = 40;  
   back_inserter ( vec ) = 50;  
  
   // Alternatively, insertions can be done with template function  
   back_insert_iterator<vector<int> > backiter ( vec );  
   *backiter = 600;  
   backiter++;  
   *backiter = 700;  
  
   cout << "After the insertions, the vector vec is: ( ";  
   for ( vIter = vec.begin ( ) ; vIter != vec.end ( ); vIter++)  
      cout << *vIter << " ";  
   cout << ")." << endl;  
}  
```  
  
 **The initial vector vec is: ( 1 2 3 ).**  
**After the insertions, the vector vec is: ( 1 2 3 40 50 600 700 ).**   
## Requirements  
 **Header:** \<iterator>  
  
 **Namespace:** std  
  
## See Also  
 [back_insert_iterator Class](../vs140/back_insert_iterator-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)