---
title: "allocator::const_reference"
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
  - "allocator.const_reference"
  - "const_reference"
  - "std.allocator.const_reference"
  - "memory/std::allocator::const_reference"
  - "std::allocator::const_reference"
  - "allocator::const_reference"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "const_reference method"
ms.assetid: 03a87636-c4dd-4b56-baec-dc7fc0c359a6
caps.latest.revision: 17
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# allocator::const_reference
A type that provides a constant reference to type of object managed by the allocator.  
  
## Syntax  
  
```  
typedef const value_type& const_reference;  
```  
  
## Remarks  
 The reference type describes an object that can designate any const object that an object of template class allocator can allocate.  
  
## Example  
  
```  
// allocator_const_ref.cpp  
// compile with: /EHsc  
#include <memory>  
#include <iostream>  
#include <vector>  
  
using namespace std;  
  
int main( )   
{  
   vector <double> v;  
   vector <double> ::iterator vIter, vfIter;  
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
  
   vfIter = v.begin( );  
   allocator<double>::const_reference vcref =*vfIter;  
   cout << "The value of the element referred to by vref is: "  
        << vcref << ",\n the first element in the vector." << endl;  
  
   // const references can have their elements modified,  
   // so the following would generate an error:  
   // vcref = 150;  
   // but the value of the first element could be modified through  
   // its nonconst iterator and the const reference would remain valid  
   *vfIter = 175;  
   cout << "The value of the element referred to by vcref,"  
        <<"\n after nofication through its nonconst iterator, is: "  
        << vcref << "." << endl;  
}  
```  
  
 **The original vector v is:**  
 **( 100 200 300 400 500 600 700 ).**  
**The value of the element referred to by vref is: 100,**  
 **the first element in the vector.**  
**The value of the element referred to by vcref,**  
 **after nofication through its nonconst iterator, is: 175.**   
## Requirements  
 **Header:** <memory\>  
  
 **Namespace:** std  
  
## See Also  
 [allocator Class](../vs140/allocator-class.md)