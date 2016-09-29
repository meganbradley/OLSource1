---
title: "allocator::address"
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
  - "memory/std::allocator::address"
  - "allocator::address"
  - "allocator.address"
  - "std.allocator.address"
  - "address"
  - "std::allocator::address"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "address function"
ms.assetid: 5e80e4b8-9eef-4566-b774-5ac107126419
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# allocator::address
Finds the address of an object whose value is specified.  
  
## Syntax  
  
```  
  
      pointer address(  
   reference _Val  
   ) const;  
const_pointer address(  
   const_reference _Val  
   ) const;  
```  
  
#### Parameters  
 `_Val`  
 The const or nonconst value of the object whose address is being searched for.  
  
## Return Value  
 A const or nonconst pointer to the object found of, respectively, const or nonconst value.  
  
## Remarks  
 The member functions return the address of `_Val`, in the form that pointers must take for allocated elements.  
  
## Example  
  
```  
// allocator_address.cpp  
// compile with: /EHsc  
#include <memory>  
#include <algorithm>  
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
      v1.push_back( 2 * i );  
   }  
  
   cout << "The original vector v1 is:\n ( " ;  
   for ( v1Iter = v1.begin( ) ; v1Iter != v1.end( ) ; v1Iter++ )  
      cout << *v1Iter << " ";  
   cout << ")." << endl;  
  
   allocator<int>::const_pointer v1Ptr;  
   const int k = 8;  
   v1Ptr = v1Alloc.address( *find(v1.begin( ), v1.end( ), k) );  
   // v1Ptr = v1Alloc.address( k );  
   cout << "The integer addressed by v1Ptr has a value of: "  
        << "*v1Ptr = " << *v1Ptr << "." << endl;  
}  
```  
  
 **The original vector v1 is:**  
 **( 2 4 6 8 10 12 14 ).**  
**The integer addressed by v1Ptr has a value of: \*v1Ptr = 8.**   
## Requirements  
 **Header:** <memory\>  
  
 **Namespace:** std  
  
## See Also  
 [allocator Class](../vs140/allocator-class.md)