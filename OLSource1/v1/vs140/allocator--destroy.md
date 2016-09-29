---
title: "allocator::destroy"
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
  - "Destroy"
  - "memory/std::allocator::destroy"
  - "std::allocator::destroy"
  - "std.allocator.destroy"
  - "allocator::destroy"
  - "allocator.destroy"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "destroy method"
ms.assetid: c33d12fd-0185-4829-899a-cb3d1d0580fa
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# allocator::destroy
Calls an objects destructor without deallocating the memory where the object was stored.  
  
## Syntax  
  
```  
  
      void destroy(  
   pointer _Ptr  
);  
```  
  
#### Parameters  
 `_Ptr`  
 A pointer designating the address of the object to be destroyed.  
  
## Remarks  
 The member function destroys the object designated by `_Ptr`, by calling the destructor `_Ptr` ->**Type**::**~Type**.  
  
## Example  
  
```  
// allocator_destroy.cpp  
// compile with: /EHsc  
#include <memory>  
#include <iostream>  
#include <algorithm>  
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
  
   allocator<int>::pointer v1PtrA;  
   int kA = 12, kB = -99;  
   v1PtrA = v1Alloc.address( *find(v1.begin( ), v1.end( ), kA) );  
   v1Alloc.destroy ( v1PtrA );  
   v1Alloc.construct ( v1PtrA , kB );  
  
   cout << "The modified vector v1 is:\n ( " ;  
   for ( v1Iter = v1.begin( ) ; v1Iter != v1.end( ) ; v1Iter++ )  
      cout << *v1Iter << " ";  
   cout << ")." << endl;  
}  
```  
  
 **The original vector v1 is:**  
 **( 2 4 6 8 10 12 14 ).**  
**The modified vector v1 is:**  
 **( 2 4 6 8 10 -99 14 ).**   
## Requirements  
 **Header:** <memory\>  
  
 **Namespace:** std  
  
## See Also  
 [allocator Class](../vs140/allocator-class.md)