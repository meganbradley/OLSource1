---
title: "vector::operator"
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
  - "vector::operator[]"
  - "[]"
  - "std.vector.operator[]"
  - "operator[]"
  - "std::vector::operator[]"
  - "vector.operator[]"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "[] operator, with specific standard C++ objects"
  - "operator[], vector"
  - "operator [], vector"
ms.assetid: 9f19d479-152d-40c6-aab8-d7e5b62a41ed
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# vector::operator
Returns a reference to the vector element at a specified position.  
  
## Syntax  
  
```  
reference operator[](size_type Pos);  
const_reference operator[](size_typePos) const;  
```  
  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|`Pos`|The position of the vector element.|  
  
## Return Value  
 If the position specified is greater than or equal to the size of the container, the result is undefined.  
  
## Remarks  
 If the return value of `operator[]` is assigned to a `const_reference`, the vector object cannot be modified. If the return value of `operator[]` is assigned to a reference, the vector object can be modified.  
  
 When compiling with _SECURE_SCL 1 (controlled with [_ITERATOR_DEBUG_LEVEL](../vs140/_iterator_debug_level.md)), a runtime error will occur if you attempt to access an element outside the bounds of the vector.  See [Checked Iterators](../vs140/checked-iterators.md) for more information.  
  
## Example  
  
```cpp  
// vector_op_ref.cpp  
// compile with: /EHsc  
#include <vector>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;     
   vector <int> v1;  
  
   v1.push_back( 10 );  
   v1.push_back( 20 );  
  
   int& i = v1[1];  
   cout << "The second integer of v1 is " << i << endl;  
}  
```  
  
## Output  
  
```  
The second integer of v1 is 20  
```  
  
## Requirements  
 **Header:** \<vector>  
  
 **Namespace:** std  
  
## See Also  
 [vector Class](../vs140/vector-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)