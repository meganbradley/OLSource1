---
title: "allocator::reference"
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
  - Reference
  - memory/std::allocator::reference
  - std.allocator.reference
  - std::allocator::reference
  - allocator.reference
  - allocator::reference
dev_langs: 
  - C++
helpviewer_keywords: 
  - reference method
ms.assetid: 4c4afb05-5232-44a4-abc2-031d942d6cad
caps.latest.revision: 17
translation.priority.ht: 
  - de-de
  - ja-jp
---
# allocator::reference
A type that provides a reference to the type of object managed by the allocator.  
  
## Syntax  
  
```  
typedef value_type& reference;  
```  
  
## Remarks  
 The reference type describes an object that can designate any object that an object of template class allocator can allocate.  
  
## Example  
  
```  
// allocator_reference.cpp  
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
   allocator<double>::reference vref =*vfIter;  
   cout << "The value of the element referred to by vref is: "  
        << vref << ",\n the first element in the vector." << endl;  
  
   // nonconst references can have their elements modified  
   vref = 150;  
   cout << "The element referred to by vref after being modified is: "  
        << vref << "." << endl;  
}  
```  
  
 **The original vector v is:**  
 **( 100 200 300 400 500 600 700 ).**  
**The value of the element referred to by vref is: 100,**  
 **the first element in the vector.**  
**The element referred to by vref after being modified is: 150.**   
## Requirements  
 **Header:** <memory\>  
  
 **Namespace:** std  
  
## See Also  
 [allocator Class](../vs140/allocator-class.md)