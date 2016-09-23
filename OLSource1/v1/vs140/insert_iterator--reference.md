---
title: "insert_iterator::reference"
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
  - iterator/std::insert_iterator::reference
  - Reference
  - insert_iterator.reference
  - std.insert_iterator.reference
  - std::insert_iterator::reference
  - insert_iterator::reference
dev_langs: 
  - C++
helpviewer_keywords: 
  - reference method
ms.assetid: c94991d5-3e59-45f5-b397-308fbbe1ec2f
caps.latest.revision: 18
translation.priority.ht: 
  - de-de
  - ja-jp
---
# insert_iterator::reference
A type that provides a reference to an element in a sequence controlled by the associated container.  
  
## Syntax  
  
```  
  
typedef typename Container::reference reference;  
  
```  
  
## Remarks  
 The type describes a reference to an element of the sequence controlled by the associated container.  
  
## Example  
  
```  
// insert_iterator_container_reference.cpp  
// compile with: /EHsc  
#include <iterator>  
#include <list>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
  
   list<int> L;  
   insert_iterator<list<int> > iivIter( L , L.begin ( ) );  
   *iivIter = 10;  
   *iivIter = 20;  
   *iivIter = 30;  
  
   list<int>::iterator LIter;  
   cout << "The list L is: ( ";  
   for ( LIter = L.begin ( ) ; LIter != L.end ( ); LIter++ )  
      cout << *LIter << " ";  
   cout << ")." << endl;  
  
   insert_iterator<list<int> >::reference   
        RefFirst = *(L.begin ( ));  
   cout << "The first element in the list L is: "   
        << RefFirst << "." << endl;  
}  
```  
  
 **The list L is: ( 10 20 30 ).**  
**The first element in the list L is: 10.**   
## Requirements  
 **Header:** <iterator\>  
  
 **Namespace:** std  
  
## See Also  
 [insert_iterator Class](../vs140/insert_iterator-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)