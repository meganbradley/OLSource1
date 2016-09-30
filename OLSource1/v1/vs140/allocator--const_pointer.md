---
title: "allocator::const_pointer"
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
  - "allocator.const_pointer"
  - "std.allocator.const_pointer"
  - "std::allocator::const_pointer"
  - "const_pointer"
  - "allocator::const_pointer"
  - "memory/std::allocator::const_pointer"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "const_pointer method"
ms.assetid: d8e0320a-ba57-4261-8413-0a78bf09792a
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# allocator::const_pointer
A type that provides a constant pointer to the type of object managed by the allocator.  
  
## Syntax  
  
```  
typedef const value_type *const_pointer;  
```  
  
## Remarks  
 The pointer type describes an object **ptr** that can designate, through the expression **\*ptr**, any const object that an object of template class allocator can allocate.  
  
## Example  
  
```  
// allocator_const_ptr.cpp  
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
      v1.push_back( i * 2 );  
   }  
  
   cout << "The original vector v1 is:\n ( " ;  
   for ( v1Iter = v1.begin( ) ; v1Iter != v1.end( ) ; v1Iter++ )  
      cout << *v1Iter << " ";  
   cout << ")." << endl;  
  
   allocator<int>::const_pointer v1Ptr;  
   const int k = 10;  
   v1Ptr = v1Alloc.address( k );  
  
   cout << "The integer's address found has a value of: "  
        << *v1Ptr << "." << endl;  
}  
```  
  
 **The original vector v1 is:**  
 **( 2 4 6 8 10 12 14 ).**  
**The integer's address found has a value of: 10.**   
## Requirements  
 **Header:** \<memory>  
  
 **Namespace:** std  
  
## See Also  
 [allocator Class](../vs140/allocator-class.md)