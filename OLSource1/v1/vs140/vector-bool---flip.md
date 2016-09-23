---
title: "vector&lt;bool&gt;::flip"
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
  - std::vector<bool>::flip
  - vector<bool>::flip
dev_langs: 
  - C++
helpviewer_keywords: 
  - flip method
ms.assetid: 37c0413c-8053-42ee-b642-432e3f1eb5e7
caps.latest.revision: 21
translation.priority.ht: 
  - de-de
  - ja-jp
---
# vector&lt;bool&gt;::flip
Reverses all bits in a `vector<bool>`.  
  
## Syntax  
  
```  
  
void flip();  
  
```  
  
## Example  
  
```cpp  
// vector_bool_flip.cpp  
// compile with: /EHsc /W4  
#include <vector>  
#include <iostream>  
  
int main()  
{  
    using namespace std;  
    cout << boolalpha; // format output for subsequent code  
  
    vector<bool> vb = { true, false, false, true, true };  
    cout << "The vector is:" << endl << "    ";  
    for (const auto& b : vb) {  
        cout << b << " ";  
    }  
    cout << endl;  
  
    vb.flip();  
  
    cout << "The flipped vector is:" << endl << "    ";  
    for (const auto& b : vb) {  
        cout << b << " ";  
    }  
    cout << endl;  
}  
  
```  
  
## Output  
  
```  
The vector is:  
    true false false true true  
The flipped vector is:  
    false true true false false  
```  
  
## Requirements  
 **Header:** <vector\>  
  
 **Namespace:** std  
  
## See Also  
 [vector Class](../vs140/vector-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)