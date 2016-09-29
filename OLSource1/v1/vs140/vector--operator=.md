---
title: "vector::operator="
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
  - "="
  - "operator="
  - "vector.operator="
  - "vector::operator="
  - "std::vector::operator="
  - "std.vector.operator="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator=, with specific standard C++ objects"
  - "operator=, vector"
  - "operator =, vector"
ms.assetid: c529e30f-476d-499f-a33e-3d2b1c8c191b
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# vector::operator=
Replaces the elements of the vector with a copy of another vector.  
  
## Syntax  
  
```  
vector& operator=(  
   const vector& _Right  
);  
vector& operator=(  
   vector&& _Right  
);  
```  
  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|`_Right`|The [vector](../vs140/vector-class.md) being copied into the `vector`.|  
  
## Remarks  
 After erasing any existing elements in a `vector`, `operator=` either copies or moves the contents of `_Right` into the `vector`.  
  
## Example  
  
```  
// vector_operator_as.cpp  
// compile with: /EHsc  
#include <vector>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   vector<int> v1, v2, v3;  
   vector<int>::iterator iter;  
  
   v1.push_back(10);  
   v1.push_back(20);  
   v1.push_back(30);  
   v1.push_back(40);  
   v1.push_back(50);  
  
   cout << "v1 = " ;  
   for (iter = v1.begin(); iter != v1.end(); iter++)  
      cout << *iter << " ";  
   cout << endl;  
  
   v2 = v1;  
   cout << "v2 = ";  
   for (iter = v2.begin(); iter != v2.end(); iter++)  
      cout << *iter << " ";  
   cout << endl;  
  
// move v1 into v2  
   v2.clear();  
   v2 = move(v1);  
   cout << "v2 = ";  
   for (iter = v2.begin(); iter != v2.end(); iter++)  
      cout << *iter << " ";  
   cout << endl;  
}  
```  
  
## Output  
  
```  
v1 = 10 20 30 40 50   
v2 = 10 20 30 40 50   
v2 = 10 20 30 40 50   
```  
  
## Requirements  
 **Header:** <vector\>  
  
 **Namespace:** std  
  
## See Also  
 [vector Class](../vs140/vector-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)