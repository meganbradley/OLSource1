---
title: "allocator::pointer"
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
  - "allocator.pointer"
  - "std.allocator.pointer"
  - "allocator::pointer"
  - "memory/std::allocator::pointer"
  - "pointer"
  - "std::allocator::pointer"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "pointer method"
ms.assetid: 70b8aca0-8eaa-4381-86fb-c8a9091a292a
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# allocator::pointer
A type that provides a pointer to the type of object managed by the allocator.  
  
## Syntax  
  
```  
typedef value_type *pointer;  
```  
  
## Remarks  
 The pointer type describes an object **ptr** that can designate, through the expression **\*ptr**, any object that an object of template class allocator can allocate.  
  
## Example  
  
```  
// allocator_ptr.cpp  
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
      v1.push_back( 3 * i );  
   }  
  
   cout << "The original vector v1 is:\n ( " ;  
   for ( v1Iter = v1.begin( ) ; v1Iter != v1.end( ) ; v1Iter++ )  
      cout << *v1Iter << " ";  
   cout << ")." << endl;  
  
   allocator<int>::const_pointer v1Ptr;  
   const int k = 12;  
   v1Ptr = v1Alloc.address( k );  
  
   cout << "The integer addressed by v1Ptr has a value of: "  
        << "*v1Ptr = " << *v1Ptr << "." << endl;     
}  
```  
  
 **The original vector v1 is:**  
 **( 3 6 9 12 15 18 21 ).**  
**The integer addressed by v1Ptr has a value of: \*v1Ptr = 12.**   
## Requirements  
 **Header:** \<memory>  
  
 **Namespace:** std  
  
## See Also  
 [allocator Class](../vs140/allocator-class.md)