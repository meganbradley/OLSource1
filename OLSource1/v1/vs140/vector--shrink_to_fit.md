---
title: "vector::shrink_to_fit"
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
  - shrink_to_fit
  - std.vector.shrink_to_fit
  - vector::shrink_to_fit
  - vector.shrink_to_fit
  - std::vector::shrink_to_fit
dev_langs: 
  - C++
helpviewer_keywords: 
  - shrink_to_fit method
ms.assetid: bef7342b-48f2-4979-b85d-63e6ae7b44ba
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# vector::shrink_to_fit
Discards excess capacity.  
  
## Syntax  
  
```  
void shrink_to_fit(  
);  
```  
  
## Example  
  
```  
// vector_shrink_to_fit.cpp  
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
   v1.shrink_to_fit();  
   cout << "Current capacity of v1 = "   
      << v1.capacity( ) << endl;  
}  
```  
  
 **Current capacity of v1 = 1**  
**Current capacity of v1 = 20**  
**Current capacity of v1 = 1**   
## Requirements  
 **Header:** <vector\>  
  
 **Namespace:** std  
  
## See Also  
 [vector Class](../vs140/vector-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)