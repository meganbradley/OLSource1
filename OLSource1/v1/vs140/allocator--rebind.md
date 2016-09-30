---
title: "allocator::rebind"
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
  - "allocator::rebind"
  - "std.allocator.rebind"
  - "allocator.rebind"
  - "memory/std::allocator::rebind"
  - "rebind"
  - "std::allocator::rebind"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "rebind method"
ms.assetid: f064506f-30b0-43cc-b3f4-0ff34785c6a1
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# allocator::rebind
A structure that enables an allocator for objects of one type to allocate storage for objects of another type.  
  
## Syntax  
  
```  
  
   template<class _Other>  
struct rebind {  
typedef allocator<_Other> other;  
};  
```  
  
#### Parameters  
 *other*  
 The type of element for which memory is being allocated.  
  
## Remarks  
 This structure is useful for allocating memory for type that differs from the element type of the container being implemented.  
  
 The member template class defines the type other. Its sole purpose is to provide the type name **allocator**\<_**Other**>, given the type name **allocator**\<**Type**>.  
  
 For example, given an allocator object **al** of type **A**, you can allocate an object of type **_Other** with the expression:  
  
```  
A::rebind<Other>::other(al).allocate(1, (Other *)0)  
```  
  
 Or, you can name its pointer type by writing the type:  
  
```  
A::rebind<Other>::other::pointer  
```  
  
## Example  
  
```  
// allocator_rebind.cpp  
// compile with: /EHsc  
#include <memory>  
#include <iostream>  
#include <algorithm>  
#include <vector>  
  
using namespace std;  
  
typedef vector<int>::allocator_type IntAlloc;  
int main( )   
{  
   IntAlloc v1Iter;  
   vector<int> v1;  
  
   IntAlloc::rebind<char>::other::pointer pszC =  
      IntAlloc::rebind<char>::other(v1.get_allocator()).allocate(1, (void *)0);  
  
   int * pInt = v1Iter.allocate(10);  
}  
```  
  
## Requirements  
 **Header:** \<memory>  
  
 **Namespace:** std  
  
## See Also  
 [allocator Class](../vs140/allocator-class.md)