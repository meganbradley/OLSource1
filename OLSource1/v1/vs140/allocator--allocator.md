---
title: "allocator::allocator"
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
  - "allocator.allocator"
  - "std::allocator::allocator"
  - "allocator::allocator"
  - "allocator"
  - "std.allocator.allocator"
  - "memory/std::allocator::allocator"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "allocator class, constructor"
  - "allocator constructor"
ms.assetid: ed45a698-be8e-4184-8c6c-d07bfd1e993d
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# allocator::allocator
Constructors used to create allocator objects.  
  
## Syntax  
  
```  
  
      allocator( );   
allocator(  
   const allocator<Type>& _Right  
);  
template<class Other>  
   allocator(  
      const allocator<Other>& _Right  
   );  
```  
  
#### Parameters  
 `_Right`  
 The allocator object to be copied.  
  
## Remarks  
 The constructor does nothing. In general, however, an allocator object constructed from another allocator object should compare equal to it and permit intermixing of object allocation and freeing between the two allocator objects.  
  
## Example  
  
```  
// allocator_allocator.cpp  
// compile with: /EHsc  
#include <memory>  
#include <iostream>  
#include <vector>  
  
using namespace std;  
  
class Int {  
public:  
   Int( int i )   
   {  
      cout << "Constructing " << ( void* )this  << endl;   
      x = i;  
      bIsConstructed = true;  
   };  
   ~Int( )   
   {  
      cout << "Destructing " << ( void* )this << endl;   
      bIsConstructed = false;  
   };  
   Int &operator++( )   
   {  
      x++;  
      return *this;  
   };  
   int x;  
private:  
   bool bIsConstructed;  
};  
  
int main( )   
{  
   allocator<double> Alloc;  
   vector <Int>:: allocator_type v1Alloc;  
  
   allocator<double> cAlloc(Alloc);   
   allocator<Int> cv1Alloc(v1Alloc);  
  
   if ( cv1Alloc == v1Alloc )  
      cout << "The allocator objects cv1Alloc & v1Alloc are equal."  
           << endl;  
   else  
      cout << "The allocator objects cv1Alloc & v1Alloc are not equal."  
           << endl;  
  
   if ( cAlloc == Alloc )  
      cout << "The allocator objects cAlloc & Alloc are equal."  
           << endl;  
   else  
      cout << "The allocator objects cAlloc & Alloc are not equal."  
           << endl;  
}  
```  
  
 **The allocator objects cv1Alloc & v1Alloc are equal.**  
**The allocator objects cAlloc & Alloc are equal.**   
## Requirements  
 **Header:** \<memory>  
  
 **Namespace:** std  
  
## See Also  
 [allocator Class](../vs140/allocator-class.md)