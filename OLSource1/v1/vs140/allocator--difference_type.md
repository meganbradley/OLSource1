---
title: "allocator::difference_type"
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
  - "allocator::difference_type"
  - "std.allocator.difference_type"
  - "difference_type"
  - "memory/std::allocator::difference_type"
  - "allocator.difference_type"
  - "std::allocator::difference_type"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "difference_type typedef"
ms.assetid: 8f8f2845-4794-459f-be4f-f6adf4eb12eb
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# allocator::difference_type
A signed integral type that can represent the difference between values of pointers to the type of object managed by the allocator.  
  
## Syntax  
  
```  
typedef ptrdiff_t difference_type;  
```  
  
## Remarks  
 The signed integer type describes an object that can represent the difference between the addresses of any two elements in a sequence that an object of template class allocator can allocate.  
  
## Example  
  
```  
// allocator_diff_type.cpp  
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
   for ( i = 0 ; i <= 7 ; i++ )  
   {  
      v1.push_back( i * 2 );  
   }  
  
   cout << "The original vector v1 is:\n ( " ;  
   for ( v1Iter = v1.begin( ) ; v1Iter != v1.end( ) ; v1Iter++ )  
      cout << *v1Iter << " ";  
   cout << ")." << endl;  
  
   allocator<int>::const_pointer v1PtrA, v1PtrB;  
   const int kA = 4, kB =12;  
   v1PtrA = v1Alloc.address( kA );  
   v1PtrB = v1Alloc.address( kB );  
   allocator<int>::difference_type v1diff = *v1PtrB - *v1PtrA;  
  
   cout << "Pointer v1PtrA addresses " << *v1PtrA << "." << endl;  
   cout << "Pointer v1PtrB addresses " << *v1PtrB <<  "." << endl;  
   cout << "The difference between the integer's addresses is: "  
        << v1diff << "." << endl;  
}  
```  
  
 **The original vector v1 is:**  
 **( 0 2 4 6 8 10 12 14 ).**  
**Pointer v1PtrA addresses 4.**  
**Pointer v1PtrB addresses 12.**  
**The difference between the integer's addresses is: 8.**   
## Requirements  
 **Header:** \<memory>  
  
 **Namespace:** std  
  
## See Also  
 [allocator Class](../vs140/allocator-class.md)