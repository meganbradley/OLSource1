---
title: "front_insert_iterator::reference"
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
  - "std.front_insert_iterator.reference"
  - "Reference"
  - "iterator/std::front_insert_iterator::reference"
  - "front_insert_iterator::reference"
  - "front_insert_iterator.reference"
  - "std::front_insert_iterator::reference"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "reference method"
ms.assetid: 056a9c0b-5df6-41b7-9516-b14784946b35
caps.latest.revision: 18
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# front_insert_iterator::reference
A type that provides a reference to an element in a sequence controlled by the associated container.  
  
## Syntax  
  
```  
  
typedef typename Container::reference reference;  
  
```  
  
## Example  
  
```  
// front_insert_iterator_reference.cpp  
// compile with: /EHsc  
#include <iterator>  
#include <list>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
  
   list<int> L;  
   front_insert_iterator<list<int> > fiivIter( L );  
   *fiivIter = 10;  
   *fiivIter = 20;  
   *fiivIter = 30;  
  
   list<int>::iterator LIter;  
   cout << "The list L is: ( ";  
   for ( LIter = L.begin ( ) ; LIter != L.end ( ); LIter++)  
      cout << *LIter << " ";  
   cout << ")." << endl;  
  
   front_insert_iterator<list<int> >::reference   
        RefFirst = *(L.begin ( ));  
   cout << "The first element in the list L is: "   
        << RefFirst << "." << endl;  
}  
```  
  
 **The list L is: ( 30 20 10 ).**  
**The first element in the list L is: 30.**   
## Requirements  
 **Header:** <iterator\>  
  
 **Namespace:** std  
  
## See Also  
 [front_insert_iterator Class](../vs140/front_insert_iterator-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)