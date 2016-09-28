---
title: "vector::swap"
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
  - "vector::swap"
  - "std::vector::swap"
  - "vector.swap"
  - "std.vector.swap"
  - "swap"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "swap method"
ms.assetid: c0d84486-3ac0-4820-8446-7ba6c4547a2c
caps.latest.revision: 18
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# vector::swap
Exchanges the elements of two vectors.  
  
## Syntax  
  
```  
void swap(  
   vector<Type, Allocator>& _Right  
);  
friend void swap(  
   vector<Type, Allocator >& _Left,  
   vector<Type, Allocator >& _Right  
);  
```  
  
#### Parameters  
 `_Right`  
 A vector providing the elements to be swapped, or a vector whose elements are to be exchanged with those of the vector `_Left`.  
  
 `_Left`  
 A vector whose elements are to be exchanged with those of the vector `_Right`.  
  
## Example  
  
```  
// vector_swap.cpp  
// compile with: /EHsc  
#include <vector>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;     
   vector <int> v1, v2;  
  
   v1.push_back( 1 );  
   v1.push_back( 2 );  
   v1.push_back( 3 );  
  
   v2.push_back( 10 );  
   v2.push_back( 20 );  
  
   cout << "The number of elements in v1 = " << v1.size( ) << endl;  
   cout << "The number of elements in v2 = " << v2.size( ) << endl;  
   cout << endl;  
  
   v1.swap( v2 );  
  
   cout << "The number of elements in v1 = " << v1.size( ) << endl;  
   cout << "The number of elements in v2 = " << v2.size( ) << endl;  
}  
```  
  
 **The number of elements in v1 = 3**  
**The number of elements in v2 = 2**  
**The number of elements in v1 = 2**  
**The number of elements in v2 = 3**   
## Requirements  
 **Header:** <vector\>  
  
 **Namespace:** std  
  
## See Also  
 [vector Class](../vs140/vector-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)