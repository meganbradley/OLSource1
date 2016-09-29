---
title: "vector::const_reference"
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
  - "const_reference"
  - "vector.const_reference"
  - "std::vector::const_reference"
  - "vector::const_reference"
  - "std.vector.const_reference"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "const_reference method"
ms.assetid: 89f80d68-3dcb-4c2f-8860-7a30a9a49352
caps.latest.revision: 18
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# vector::const_reference
A type that provides a reference to a **const** element stored in a vector for reading and performing **const** operations.  
  
## Syntax  
  
```  
typedef typename Allocator::const_reference const_reference;  
```  
  
## Remarks  
 A type `const_reference` cannot be used to modify the value of an element.  
  
## Example  
  
```  
// vector_const_ref.cpp  
// compile with: /EHsc  
#include <vector>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   vector <int> v1;  
  
   v1.push_back( 10 );  
   v1.push_back( 20 );  
  
   const vector <int> v2 = v1;  
   const int &i = v2.front( );  
   const int &j = v2.back( );  
   cout << "The first element is " << i << endl;  
   cout << "The second element is " << j << endl;  
  
   // The following line would cause an error as v2 is const  
   // v2.push_back( 30 );  
}  
```  
  
 **The first element is 10**  
**The second element is 20**   
## Requirements  
 **Header:** <vector\>  
  
 **Namespace:** std  
  
## See Also  
 [vector Class](../vs140/vector-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)