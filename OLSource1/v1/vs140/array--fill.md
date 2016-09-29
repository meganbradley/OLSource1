---
title: "array::fill"
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
  - "std::tr1::array::fill"
  - "array/std::tr1::array::fill"
  - "tr1::array::fill"
  - "tr1.array.fill"
  - "array.fill"
  - "std.tr1.array.fill"
  - "array::fill"
  - "std::array::fill"
  - "std.array.fill"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "fill method"
ms.assetid: 5ecd5de1-eb48-4fb5-836d-2893618d68f8
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# array::fill
Erases a array and copies the specified elements to the empty array.  
  
## Syntax  
  
```  
void fill(  
   const Type& _Val  
);  
```  
  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|`_Val`|The value of the element being inserted into the array.|  
  
## Remarks  
 `fill` replaces each element of the array with the specified value.  
  
## Example  
  
```  
// array_fill.cpp  
// compile with: /EHsc  
#include <array>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   array<int, 2> v1 = {1, 2};  
   array<int, 2>::iterator iter;  
  
   cout << "v1 = " ;  
   for (iter = v1.begin(); iter != v1.end(); iter++)  
      cout << *iter << " ";  
   cout << endl;  
  
   v1.fill(3);  
   cout << "v1 = " ;  
   for (iter = v1.begin(); iter != v1.end(); iter++)  
      cout << *iter << " ";  
   cout << endl;  
}  
```  
  
## Output  
  
```  
v1 = 1 2  
v1 = 3 3  
```  
  
## Requirements  
 **Header:** <array\>  
  
 **Namespace:** std  
  
## See Also  
 [<array\>](../vs140/-array-.md)   
 [array Class](../vs140/array-class--stl-.md)   
 [Standard Template Library](../vs140/standard-template-library.md)