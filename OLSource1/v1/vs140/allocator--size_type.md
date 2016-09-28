---
title: "allocator::size_type"
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
  - "memory/std::allocator::size_type"
  - "std.allocator.size_type"
  - "allocator::size_type"
  - "allocator.size_type"
  - "size_type"
  - "std::allocator::size_type"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "size_type typedef"
ms.assetid: 543981a6-fd69-4f6b-93bb-294aace2f8f4
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# allocator::size_type
An unsigned integral type that can represent the length of any sequence that an object of template class allocator can allocate.  
  
## Syntax  
  
```  
typedef size_t size_type;  
```  
  
## Example  
  
```  
// allocator_size_type.cpp  
// compile with: /EHsc  
#include <memory>  
#include <iostream>  
#include <vector>  
  
using namespace std;  
  
int main( )  
{  
   vector <double> v;  
   vector <double> ::iterator vIter;  
   vector <double> :: allocator_type vAlloc;  
  
   int j;  
   for ( j = 1 ; j <= 7 ; j++ )  
   {  
      v.push_back( 100.0 * j );  
   }  
  
   cout << "The original vector v is:\n ( " ;  
   for ( vIter = v.begin( ) ; vIter != v.end( ) ; vIter++ )  
      cout << *vIter << " ";  
   cout << ")." << endl;  
  
   allocator<double>::size_type vsize;  
   vsize = vAlloc.max_size( );  
  
   cout << "The number of doubles that can be allocated before\n"  
        << " the free memory in the vector v is used up is: "  
        << vsize << "." << endl;  
}  
```  
  
## Sample Output  
 The following output is for x86.  
  
```  
The original vector v is:  
 ( 100 200 300 400 500 600 700 ).  
The number of doubles that can be allocated before  
 the free memory in the vector v is used up is: 536870911.  
```  
  
## Requirements  
 **Header:** <memory\>  
  
 **Namespace:** std  
  
## See Also  
 [allocator Class](../vs140/allocator-class.md)