---
title: "vector::capacity"
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
  - "vector.capacity"
  - "capacity"
  - "std.vector.capacity"
  - "vector::capacity"
  - "std::vector::capacity"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "capacity method"
ms.assetid: e7c9a9e1-7fcd-43eb-b93e-27ee80064739
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# vector::capacity
Returns the number of elements that the vector could contain without allocating more storage.  
  
## Syntax  
  
```  
  
size_type capacity( ) const;  
  
```  
  
## Return Value  
 The current length of storage allocated for the vector.  
  
## Remarks  
 The member function [resize](../vs140/vector--resize.md) will be more efficient if sufficient memory is allocated to accommodate it. Use the member function [reserve](../vs140/vector--reserve.md) to specify the amount of memory allocated.  
  
## Example  
  
```  
// vector_capacity.cpp  
// compile with: /EHsc  
#include <vector>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   vector <int> v1;  
  
   v1.push_back( 1 );  
   cout << "The length of storage allocated is "  
        << v1.capacity( ) << "." << endl;  
  
   v1.push_back( 2 );  
   cout << "The length of storage allocated is now "  
        << v1.capacity( ) << "." << endl;  
}  
```  
  
 **The length of storage allocated is 1.**  
**The length of storage allocated is now 2.**   
## Requirements  
 **Header:** \<vector>  
  
 **Namespace:** std  
  
## See Also  
 [vector Class](../vs140/vector-class.md)   
 [vector::size and vector::capacity](../vs140/vector--size-and-vector--capacity.md)   
 [Standard Template Library](../vs140/standard-template-library.md)