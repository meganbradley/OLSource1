---
title: "back_insert_iterator::operator="
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
  - "back_insert_iterator::operator="
  - "="
  - "operator="
  - "iterator/std::back_insert_iterator::operator="
  - "std::back_insert_iterator::operator="
  - "std.back_insert_iterator.operator="
  - "back_insert_iterator.operator="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator=, iterators"
  - "operator =, iterators"
  - "= operator, with specific standard C++ library objects"
ms.assetid: f0fa0a30-6b55-4c65-a9a8-240aec2ca0a6
caps.latest.revision: 22
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# back_insert_iterator::operator=
Appends or pushes a value onto the back end of a container.  
  
## Syntax  
  
```  
back_insert_iterator<Container>& operator=(  
   typename Container::const_reference _Val  
);  
 back_insert_iterator<Container>& operator=(  
   typename Container::value_type&& _Val  
);  
```  
  
#### Parameters  
 `_Val`  
 The value to be inserted into the container.  
  
## Return Value  
 A reference to the last element inserted at the back of the container.  
  
## Remarks  
 The first member operator evaluates `Container.push_back(_Val)`,  
  
 then returns `*this`. The second member operator evaluates  
  
 `container->push_back((typename Container::value_type&&)val)`,  
  
 then returns `*this`.  
  
## Example  
  
```  
// back_insert_iterator_op_assign.cpp  
// compile with: /EHsc  
#include <iterator>  
#include <vector>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   int i;  
  
   vector<int> vec;  
   for (i = 1 ; i < 4 ; ++i )    
   {  
      vec.push_back ( i );  
   }  
  
   vector <int>::iterator vIter;  
   cout << "The vector vec is: ( ";  
   for ( vIter = vec.begin ( ) ; vIter != vec.end ( ); vIter++)  
      cout << *vIter << " ";  
   cout << ")." << endl;  
  
   back_insert_iterator<vector<int> > backiter ( vec );  
   *backiter = 10;  
   backiter++;      // Increment to the next element  
   *backiter = 20;  
   backiter++;  
  
   cout << "After the insertions, the vector vec becomes: ( ";  
   for ( vIter = vec.begin ( ) ; vIter != vec.end ( ); vIter++)  
      cout << *vIter << " ";  
   cout << ")." << endl;  
}  
```  
  
## Output  
  
```  
The vector vec is: ( 1 2 3 ).  
After the insertions, the vector vec becomes: ( 1 2 3 10 20 ).  
```  
  
## Requirements  
 **Header:** <iterator\>  
  
 **Namespace:** std  
  
## See Also  
 [back_insert_iterator Class](../vs140/back_insert_iterator-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)