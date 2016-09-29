---
title: "allocator::max_size"
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
  - "allocator::max_size"
  - "std.allocator.max_size"
  - "max_size"
  - "std::allocator::max_size"
  - "allocator.max_size"
  - "memory/std::allocator::max_size"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "max_size method"
ms.assetid: 2261778d-9771-459c-95a7-820d4f780bf8
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# allocator::max_size
Returns the number of elements of type **Type** that could be allocated by an object of class allocator before the free memory is used up.  
  
## Syntax  
  
```  
  
size  
_  
type max  
_  
size( ) const;  
  
```  
  
## Return Value  
 The number of elements that could be allocated.  
  
## Example  
  
```  
// allocator_max_size.cpp  
// compile with: /EHsc  
#include <memory>  
#include <iostream>  
#include <vector>  
  
using namespace std;  
  
int main( )   
{  
   vector <int> v1;  
   vector <int>::iterator v1Iter;  
   vector <int>:: allocator_type v1Alloc;  
  
   int i;  
   for ( i = 1 ; i <= 7 ; i++ )  
   {  
      v1.push_back( i );  
   }  
  
   cout << "The original vector v1 is:\n ( " ;  
   for ( v1Iter = v1.begin( ) ; v1Iter != v1.end( ) ; v1Iter++ )  
      cout << *v1Iter << " ";  
   cout << ")." << endl;  
  
   vector <double> v2;  
   vector <double> ::iterator v2Iter;  
   vector <double> :: allocator_type v2Alloc;  
   allocator<int>::size_type v1size;  
   v1size = v1Alloc.max_size( );  
  
   cout << "The number of integers that can be allocated before\n"  
        << " the free memory in the vector v1 is used up is: "  
        << v1size << "." << endl;  
  
   int ii;  
   for ( ii = 1 ; ii <= 7 ; ii++ )  
   {  
      v2.push_back( ii * 10.0 );  
   }  
  
   cout << "The original vector v2 is:\n ( " ;  
   for ( v2Iter = v2.begin( ) ; v2Iter != v2.end( ) ; v2Iter++ )  
      cout << *v2Iter << " ";  
   cout << ")." << endl;  
   allocator<double>::size_type v2size;  
   v2size = v2Alloc.max_size( );  
  
   cout << "The number of doubles that can be allocated before\n"  
        << " the free memory in the vector v2 is used up is: "  
        << v2size << "." << endl;  
}  
```  
  
## Sample Output  
 The following output is for x86.  
  
```  
The original vector v1 is:  
 ( 1 2 3 4 5 6 7 ).  
The number of integers that can be allocated before  
 the free memory in the vector v1 is used up is: 1073741823.  
The original vector v2 is:  
 ( 10 20 30 40 50 60 70 ).  
The number of doubles that can be allocated before  
 the free memory in the vector v2 is used up is: 536870911.  
```  
  
## Requirements  
 **Header:** \<memory>  
  
 **Namespace:** std  
  
## See Also  
 [allocator Class](../vs140/allocator-class.md)