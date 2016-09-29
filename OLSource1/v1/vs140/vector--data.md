---
title: "vector::data"
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
  - "std::vector::data"
  - "data"
  - "vector.data"
  - "std.vector.data"
  - "vector::data"
  - "vector/std::vector::data"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "data method"
ms.assetid: 6526d864-a5c8-4dbe-957b-4ca0d2768511
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# vector::data
Returns a pointer to the first element in the vector.  
  
## Syntax  
  
```  
const_pointer data() const;  
pointer data();  
```  
  
## Return Value  
 A pointer to the first element in the [vector](../vs140/vector-class.md) or to the location succeeding an empty `vector`.  
  
## Example  
  
```  
// vector_data.cpp  
// compile with: /EHsc  
#include <vector>  
#include <iostream>  
  
int main()  
{  
    using namespace std;  
    vector<int> c1;  
    vector<int>::pointer c1_Ptr;  
    vector<int>::const_pointer c1_cPtr;  
  
    c1.push_back(1);  
    c1.push_back(2);  
  
    cout << "The vector c1 contains elements:";  
    c1_cPtr = c1.data();  
    for (size_t n = c1.size(); 0 < n; --n, c1_cPtr++)  
    {  
        cout << " " << *c1_cPtr;  
    }  
    cout << endl;  
  
    cout << "The vector c1 now contains elements:";  
    c1_Ptr = c1.data();  
    *c1_Ptr = 20;  
    for (size_t n = c1.size(); 0 < n; --n, c1_Ptr++)  
    {  
        cout << " " << *c1_Ptr;  
    }  
    cout << endl;  
}  
```  
  
 **The vector c1 contains elements: 1 2**  
**The vector c1 now contains elements: 20 2**   
## Requirements  
 **Header:** <vector\>  
  
 **Namespace:** std  
  
## See Also  
 [vector Class](../vs140/vector-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)