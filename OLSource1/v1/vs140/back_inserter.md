---
title: "back_inserter"
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
  - "std.back_inserter"
  - "std::back_inserter"
  - "iterator/std::back_inserter"
  - "back_inserter"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "back_inserter function"
  - "back_inserter"
ms.assetid: e7744787-699f-4dd9-b776-f7ad22116e0d
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# back_inserter
Creates an iterator that can insert elements at the back of a specified container.  
  
## Syntax  
  
```  
  
   template<class Container>  
back_insert_iterator<Container> back_inserter(  
   Container& _Cont  
);  
```  
  
#### Parameters  
 `_Cont`  
 The container into which the back insertion is to be executed.  
  
## Return Value  
 A `back_insert_iterator` associated with the container object `_Cont`.  
  
## Remarks  
 Within the Standard Template Library, the argument must refer to one of the three sequence containers that have the member function `push_back`: [deque Class](../vs140/deque-class.md), [list Class](../vs140/list-class.md), or [vector Class](../vs140/vector-class.md).  
  
## Example  
  
```  
// iterator_back_inserter.cpp  
// compile with: /EHsc  
#include <iterator>  
#include <vector>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   int i;  
  
   vector<int> vec;  
   for ( i = 0 ; i < 3 ; ++i )    
   {  
      vec.push_back ( i );  
   }  
  
   vector <int>::iterator vIter;  
   cout << "The initial vector vec is: ( ";  
   for ( vIter = vec.begin ( ) ; vIter != vec.end ( ); vIter++)  
      cout << *vIter << " ";  
   cout << ")." << endl;  
  
   // Insertions can be done with template function  
   back_insert_iterator<vector<int> > backiter ( vec );  
   *backiter = 30;  
   backiter++;  
   *backiter = 40;  
  
   // Alternatively, insertions can be done with the  
   // back_insert_iterator member function  
   back_inserter ( vec ) = 500;  
   back_inserter ( vec ) = 600;  
  
   cout << "After the insertions, the vector vec is: ( ";  
   for ( vIter = vec.begin ( ) ; vIter != vec.end ( ); vIter++ )  
      cout << *vIter << " ";  
   cout << ")." << endl;  
}  
```  
  
 **The initial vector vec is: ( 0 1 2 ).**  
**After the insertions, the vector vec is: ( 0 1 2 30 40 500 600 ).**   
## Requirements  
 **Header:** \<iterator>  
  
 **Namespace:** std  
  
## See Also  
 [Standard Template Library](../vs140/standard-template-library.md)