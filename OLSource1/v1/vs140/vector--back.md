---
title: "vector::back"
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
  - "vector.back"
  - "std.vector.back"
  - "vector::back"
  - "std::vector::back"
  - "Back"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "back method"
  - "back method, vector class"
ms.assetid: 755299c4-8696-4f09-ade1-d01756eafcf1
caps.latest.revision: 17
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# vector::back
Returns a reference to the last element of the vector.  
  
## Syntax  
  
```  
  
      reference back( );   
const_reference back( ) const;  
```  
  
## Return Value  
 The last element of the vector. If the vector is empty, the return value is undefined.  
  
## Remarks  
 If the return value of **back** is assigned to a `const_reference`, the vector object cannot be modified. If the return value of **back** is assigned to a **reference**, the vector object can be modified.  
  
 When compiling with _SECURE_SCL 1, a runtime error will occur if you attempt to access an element in an empty vector.  See [Checked Iterators](../vs140/checked-iterators.md) for more information.  
  
## Example  
  
```  
// vector_back.cpp  
// compile with: /EHsc  
#include <vector>  
#include <iostream>  
  
int main() {  
   using namespace std;     
   vector <int> v1;  
  
   v1.push_back( 10 );  
   v1.push_back( 11 );  
  
   int& i = v1.back( );  
   const int& ii = v1.front( );  
  
   cout << "The last integer of v1 is " << i << endl;  
   i--;  
   cout << "The next-to-last integer of v1 is "<< ii << endl;  
}  
```  
  
## Output  
  
```  
The last integer of v1 is 11  
The next-to-last integer of v1 is 10  
```  
  
## Requirements  
 **Header:** \<vector>  
  
 **Namespace:** std  
  
## See Also  
 [vector Class](../vs140/vector-class.md)   
 [vector::front and vector::back](../vs140/vector--front-and-vector--back.md)   
 [Standard Template Library](../vs140/standard-template-library.md)