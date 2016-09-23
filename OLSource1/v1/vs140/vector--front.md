---
title: "vector::front"
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
  - vector.front
  - vector::front
  - std::vector::front
  - std.vector.front
  - front
dev_langs: 
  - C++
helpviewer_keywords: 
  - front method, vector class
ms.assetid: 469e5cda-cbaa-4492-98a0-5562f0c06970
caps.latest.revision: 18
translation.priority.ht: 
  - de-de
  - ja-jp
---
# vector::front
Returns a reference to the first element in a vector.  
  
## Syntax  
  
```  
  
      reference front( );   
const_reference front( ) const;  
```  
  
## Return Value  
 A reference to the first element in the vector object. If the vector is empty, the return is undefined.  
  
## Remarks  
 If the return value of `front` is assigned to a `const_reference`, the vector object cannot be modified. If the return value of `front` is assigned to a **reference**, the vector object can be modified.  
  
 When compiling with _SECURE_SCL 1, a runtime error will occur if you attempt to access an element in an empty vector.  See [Checked Iterators](../vs140/checked-iterators.md) for more information.  
  
## Example  
  
```  
// vector_front.cpp  
// compile with: /EHsc  
#include <vector>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;     
   vector <int> v1;  
  
   v1.push_back( 10 );  
   v1.push_back( 11 );  
  
   int& i = v1.front( );  
   const int& ii = v1.front( );  
  
   cout << "The first integer of v1 is "<< i << endl;  
   // by incrementing i, we move the the front reference to the second element  
   i++;  
   cout << "Now, the first integer of v1 is "<< i << endl;  
}  
```  
  
## Output  
  
```  
The first integer of v1 is 10  
Now, the first integer of v1 is 11  
```  
  
## Requirements  
 **Header:** <vector\>  
  
 **Namespace:** std  
  
## See Also  
 [vector Class](../vs140/vector-class.md)   
 [vector::front and vector::back](../vs140/vector--front-and-vector--back.md)   
 [Standard Template Library](../vs140/standard-template-library.md)