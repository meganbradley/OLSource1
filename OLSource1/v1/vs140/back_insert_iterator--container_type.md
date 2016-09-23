---
title: "back_insert_iterator::container_type"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - container_type
  - iterator/std::back_insert_iterator::container_type
  - back_insert_iterator::container_type
  - back_insert_iterator.container_type
  - std.back_insert_iterator.container_type
  - std::back_insert_iterator::container_type
dev_langs: 
  - C++
helpviewer_keywords: 
  - container_type typedef
ms.assetid: 791678bf-72e3-4b51-829b-66053aa343e7
caps.latest.revision: 17
translation.priority.ht: 
  - de-de
  - ja-jp
---
# back_insert_iterator::container_type
A type that provides a container for the `back_insert_iterator`.  
  
## Syntax  
  
```  
  
typedef Container container_type;  
```  
  
## Remarks  
 The type is a synonym for the template parameter **Container**.  
  
## Example  
  
```  
// back_insert_iterator_container_type.cpp  
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
      vec.push_back (  i );  
   }  
  
   vector <int>::iterator vIter;  
   cout << "The original vector vec is: ( ";  
   for ( vIter = vec.begin ( ) ; vIter != vec.end ( ); vIter++)  
      cout << *vIter << " ";  
   cout << ")." << endl;  
  
   back_insert_iterator<vector<int> >::container_type vec1 = vec;  
   back_inserter ( vec1 ) = 40;  
  
   cout << "After the insertion, the vector is: ( ";  
   for ( vIter = vec1.begin ( ) ; vIter != vec1.end ( ); vIter++)  
      cout << *vIter << " ";  
   cout << ")." << endl;  
}  
```  
  
 **The original vector vec is: ( 1 2 3 ).**  
**After the insertion, the vector is: ( 1 2 3 40 ).**   
## Requirements  
 **Header:** <iterator\>  
  
 **Namespace:** std  
  
## See Also  
 [back_insert_iterator Class](../vs140/back_insert_iterator-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)