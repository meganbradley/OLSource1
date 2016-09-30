---
title: "vector::reserve"
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
  - "std.vector.reserve"
  - "vector.reserve"
  - "vector::reserve"
  - "std::vector::reserve"
  - "reserve"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "reserve method"
ms.assetid: 895d78f5-ad8a-4cbb-b386-4beea4bd1688
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# vector::reserve
Reserves a minimum length of storage for a vector object, allocating space if necessary.  
  
## Syntax  
  
```  
  
      void reserve(  
   size_type _Count  
);  
```  
  
#### Parameters  
 `_Count`  
 The minimum length of storage to be allocated for the vector.  
  
## Example  
  
```  
// vector_reserve.cpp  
// compile with: /EHsc  
#include <vector>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;     
   vector <int> v1;  
   //vector <int>::iterator Iter;  
  
   v1.push_back( 1 );  
   cout << "Current capacity of v1 = "   
      << v1.capacity( ) << endl;  
   v1.reserve( 20 );  
   cout << "Current capacity of v1 = "   
      << v1.capacity( ) << endl;  
}  
```  
  
 **Current capacity of v1 = 1**  
**Current capacity of v1 = 20**   
## Requirements  
 **Header:** \<vector>  
  
 **Namespace:** std  
  
## See Also  
 [vector Class](../vs140/vector-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)