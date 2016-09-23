---
title: "insert_iterator::container_type"
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
  - insert_iterator::container_type
  - std.insert_iterator.container_type
  - iterator/std::insert_iterator::container_type
  - std::insert_iterator::container_type
  - insert_iterator.container_type
dev_langs: 
  - C++
helpviewer_keywords: 
  - container_type typedef
ms.assetid: 5623617f-fc17-4026-afac-350fbb22f7ad
caps.latest.revision: 17
translation.priority.ht: 
  - de-de
  - ja-jp
---
# insert_iterator::container_type
A type that represents the container into which a general insertion is to be made.  
  
## Syntax  
  
```  
  
typedef Container container_type;  
  
```  
  
## Remarks  
 The type is a synonym for the template parameter **Container**.  
  
## Example  
  
```  
// insert_iterator_container_type.cpp  
// compile with: /EHsc  
#include <iterator>  
#include <list>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
  
   list<int> L1;  
   insert_iterator<list<int> >::container_type L2 = L1;  
   inserter ( L2, L2.end ( ) ) = 20;  
   inserter ( L2, L2.end ( ) ) = 10;  
   inserter ( L2, L2.begin ( ) ) = 40;  
  
   list <int>::iterator vIter;  
   cout << "The list L2 is: ( ";  
   for ( vIter = L2.begin ( ) ; vIter != L2.end ( ); vIter++ )  
      cout << *vIter << " ";  
   cout << ")." << endl;  
}  
```  
  
 **The list L2 is: ( 40 20 10 ).**   
## Requirements  
 **Header:** <iterator\>  
  
 **Namespace:** std  
  
## See Also  
 [insert_iterator Class](../vs140/insert_iterator-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)