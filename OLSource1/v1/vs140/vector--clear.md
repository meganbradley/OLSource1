---
title: "vector::clear"
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
  - "vector.clear"
  - "std::vector::clear"
  - "std.vector.clear"
  - "Clear"
  - "vector::clear"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "clear method"
ms.assetid: 8257c33c-893a-41a7-87dc-ad9c7c93c5c9
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# vector::clear
Erases the elements of the vector.  
  
## Syntax  
  
```  
  
void clear( );  
  
```  
  
## Example  
  
```  
// vector_clear.cpp  
// compile with: /EHsc  
#include <vector>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;     
   vector <int> v1;  
  
   v1.push_back( 10 );  
   v1.push_back( 20 );  
   v1.push_back( 30 );  
  
   cout << "The size of v1 is " << v1.size( ) << endl;  
   v1.clear( );  
   cout << "The size of v1 after clearing is " << v1.size( ) << endl;  
}  
```  
  
 **The size of v1 is 3**  
**The size of v1 after clearing is 0**   
## Requirements  
 **Header:** <vector\>  
  
 **Namespace:** std  
  
## See Also  
 [vector Class](../vs140/vector-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)