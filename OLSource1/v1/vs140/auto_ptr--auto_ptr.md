---
title: "auto_ptr::auto_ptr"
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
  - "std.auto_ptr.auto_ptr"
  - "auto_ptr.auto_ptr"
  - "std::auto_ptr::auto_ptr"
  - "auto_ptr::auto_ptr"
  - "memory/std::auto_ptr::auto_ptr"
  - "auto_ptr"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "auto_ptr class, constructor"
  - "auto_ptr method"
ms.assetid: 3848ab33-8739-4af7-b3a0-6084b75bbacc
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# auto_ptr::auto_ptr
The constructor for objects of type `auto_ptr`.  
  
## Syntax  
  
```  
  
      explicit auto  
      _  
      ptr(  
   Type* _Ptr = 0  
) throw( );  
auto_ptr(  
   auto_ptr<Type>& _Right  
) throw( );  
auto_ptr(  
   auto_ptr_ref<Type> _Right  
) throw( );  
template<class Other>  
   auto_ptr(  
   auto_ptr<Other>& _Right  
) throw( );  
```  
  
#### Parameters  
 `_Ptr`  
 The pointer to the object that `auto_ptr` encapsulates.  
  
 `_Right`  
 The `auto_ptr` object to be copied by the constructor.  
  
## Remarks  
 The first constructor stores `_Ptr` in **myptr**, the stored pointer to the allocated object. The second constructor transfers ownership of the pointer stored in `_Right`, by storing `_Right`.[release](../vs140/auto_ptr--release.md) in **myptr**.  
  
 The third constructor behaves the same as the second, except that it stores **right**.`ref`.**release** in **myptr**, where `ref` is the reference stored in `_Right`.  
  
 The template constructor behaves the same as the second constructor, provided that a pointer to **Other** can be implicitly converted to a pointer to **Type**.  
  
## Example  
  
```  
// auto_ptr_auto_ptr.cpp  
// compile with: /EHsc  
#include <memory>  
#include <iostream>  
#include <vector>  
  
using namespace std;  
  
class Int   
{  
public:  
   Int(int i)   
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
  
void function ( auto_ptr<Int> &pi )  
{  
   ++( *pi );  
   auto_ptr<Int> pi2( pi );  
   ++( *pi2 );  
   pi = pi2;  
}  
  
int main( )   
{  
   auto_ptr<Int> pi ( new Int( 5 ) );  
   cout << pi->x << endl;  
   function( pi );  
   cout << pi->x << endl;  
}  
```  
  
 **Constructing 00311AF8**  
**5**  
**7**  
**Destructing 00311AF8**   
## Requirements  
 **Header:** <memory\>  
  
 **Namespace:** std  
  
## See Also  
 [auto_ptr Class](../vs140/auto_ptr-class.md)