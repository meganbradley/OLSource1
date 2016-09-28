---
title: "allocator::value_type"
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
  - "memory/std::allocator::value_type"
  - "allocator.value_type"
  - "std.allocator.value_type"
  - "allocator::value_type"
  - "std::allocator::value_type"
  - "value_type"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "value_type typedef"
ms.assetid: c8a0e55a-10b0-4e59-aea4-f771b9db2d88
caps.latest.revision: 17
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# allocator::value_type
A type that is managed by the allocator.  
  
## Syntax  
  
```  
typedef Type value_type;  
```  
  
## Remarks  
 The type is a synonym for the template parameter **Type**.  
  
## Example  
  
```  
// allocator_value_type.cpp  
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
   allocator<double>::value_type vecVal = 150.0;  
   *vfIter = vecVal;  
   cout << "The value of the element addressed by vfIter is: "  
        << *vfIter << ",\n the first element in the vector." << endl;  
  
   cout << "The modified vector v is:\n ( " ;  
   for ( vIter = v.begin( ) ; vIter != v.end( ) ; vIter++ )  
      cout << *vIter << " ";  
   cout << ")." << endl;  
}  
```  
  
 **The original vector v is:**  
 **( 100 200 300 400 500 600 700 ).**  
**The value of the element addressed by vfIter is: 150,**  
 **the first element in the vector.**  
**The modified vector v is:**  
 **( 150 200 300 400 500 600 700 ).**   
## Requirements  
 **Header:** <memory\>  
  
 **Namespace:** std  
  
## See Also  
 [allocator Class](../vs140/allocator-class.md)