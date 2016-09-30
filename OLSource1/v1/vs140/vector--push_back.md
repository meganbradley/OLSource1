---
title: "vector::push_back"
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
  - "vector.push_back"
  - "vector::push_back"
  - "std.vector.push_back"
  - "std::vector::push_back"
  - "push_back"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "push_back method"
ms.assetid: d63f0648-25f2-4272-b3a3-466e2cf7e570
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# vector::push_back
Adds an element to the end of the vector.  
  
## Syntax  
  
```  
void push_back(const T& Val);  
  
void push_back(T&& Val);  
```  
  
#### Parameters  
 `Val`  
 The value to assign to the element added to the end of the vector.  
  
## Example  
  
```cpp  
// compile with: /EHsc /W4  
#include <vector>  
#include <iostream>  
  
using namespace std;  
  
template <typename T> void print_elem(const T& t) {  
    cout << "(" << t << ") ";  
}  
  
template <typename T> void print_collection(const T& t) {  
    cout << "  " << t.size() << " elements: ";  
  
    for (const auto& p : t) {  
        print_elem(p);  
    }  
    cout << endl;  
}  
  
int main()  
{  
    vector<int> v;  
    for (int i = 0; i < 10; ++i) {  
        v.push_back(10 + i);  
    }  
  
    cout << "vector data: " << endl;  
    print_collection(v);  
  
    // pop_back() until it's empty, printing the last element as we go  
    while (v.begin() != v.end()) {   
        cout << "v.back(): "; print_elem(v.back()); cout << endl;  
        v.pop_back();  
    }  
}  
```  
  
## Output  
 **vector data:  10 elements: (10) (11) (12) (13) (14) (15) (16) (17) (18) (19)v.back(): (19)v.back(): (18)v.back(): (17)v.back(): (16)v.back(): (15)v.back(): (14)v.back(): (13)v.back(): (12)v.back(): (11)v.back(): (10)**   
## Requirements  
 **Header:** \<vector>  
  
 **Namespace:** std  
  
## See Also  
 [vector Class](../vs140/vector-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)