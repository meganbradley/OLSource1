---
title: "insert_iterator::operator++"
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
  - "std.insert_iterator.operator++"
  - "operator++"
  - "++"
  - "iterator/std::insert_iterator::operator++"
  - "std::insert_iterator::operator++"
  - "insert_iterator.operator++"
  - "insert_iterator::operator++"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "++ operator"
  - "operator++"
  - "++ operator, with specific objects"
ms.assetid: aa71ffe0-f6f3-416a-b70b-ef63a930564a
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# insert_iterator::operator++
Increments the **insert_iterator** to the next location into which a value may be stored.  
  
## Syntax  
  
```  
insert_iterator<Container>& operator++( );  
insert_iterator<Container> operator++( int );  
```  
  
#### Parameters  
 A `insert_iterator` addressing the next location into which a value may be stored.  
  
## Remarks  
 Both preincrementation and postincrementation operators return the same result.  
  
## Example  
  
```  
// insert_iterator_op_incr.cpp  
// compile with: /EHsc  
#include <iterator>  
#include <vector>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   int i;  
  
   vector<int> vec;  
   for (i = 1 ; i < 5 ; ++i )   
   {  
      vec.push_back (  i );  
   }  
  
   vector <int>::iterator vIter;  
   cout << "The vector vec is:\n ( ";  
   for ( vIter = vec.begin ( ) ; vIter != vec.end ( ); vIter++ )  
      cout << *vIter << " ";  
   cout << ")." << endl;  
  
   insert_iterator<vector<int> > ii ( vec, vec.begin ( ) );  
   *ii = 30;  
   ii++;  
   *ii = 40;  
   ii++;  
   *ii = 50;  
  
   cout << "After the insertions, the vector vec becomes:\n ( ";  
   for ( vIter = vec.begin ( ) ; vIter != vec.end ( ); vIter++ )  
      cout << *vIter << " ";  
   cout << ")." << endl;  
}  
```  
  
 **The vector vec is:**  
 **( 1 2 3 4 ).**  
**After the insertions, the vector vec becomes:**  
 **( 30 40 50 1 2 3 4 ).**   
## Requirements  
 **Header:** <iterator\>  
  
 **Namespace:** std  
  
## See Also  
 [insert_iterator Class](../vs140/insert_iterator-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)