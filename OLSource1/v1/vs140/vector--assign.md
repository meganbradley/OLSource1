---
title: "vector::assign"
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
  - "vector.assign"
  - "Assign"
  - "std.vector.assign"
  - "std::vector::assign"
  - "vector::assign"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "assign function"
ms.assetid: ab241740-3ea8-4c77-98da-ef4dc0a2c00b
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# vector::assign
Erases a vector and copies the specified elements to the empty vector.  
  
## Syntax  
  
```  
void assign(  
   size_type Count,  
   const Type& Val  
);  
void assign(  
    initializer_list<Type> IList  
);  
template<class InputIterator>  
   void assign(  
      InputIterator First,  
      InputIterator Last  
   );  
```  
  
#### Parameters  
 `First`  
 Position of the first element in the range of elements to be copied.  
  
 `Last`  
 Position of the first element beyond the range of elements to be copied.  
  
 `Count`  
 The number of copies of an element being inserted into the vector.  
  
 `Val`  
 The value of the element being inserted into the vector.  
  
 `IList`  
 The initializer_list containing the elements to insert.  
  
## Remarks  
 After erasing any existing elements in a vector, assign either inserts a specified range of elements from the original vector into a vector or inserts copies of a new element of a specified value into a vector.  
  
## Example  
  
```  
/ vector_assign.cpp  
// compile with: /EHsc  
#include <vector>  
#include <iostream>  
  
int main()  
{  
    using namespace std;  
    vector<int> v1, v2, v3;  
  
    v1.push_back(10);  
    v1.push_back(20);  
    v1.push_back(30);  
    v1.push_back(40);  
    v1.push_back(50);  
  
    cout << "v1 = ";  
    for (auto& v : v1){  
        cout << v << " ";  
    }  
    cout << endl;  
  
    v2.assign(v1.begin(), v1.end());  
    cout << "v2 = ";  
    for (auto& v : v2){  
        cout << v << " ";  
    }  
    cout << endl;  
  
    v3.assign(7, 4);  
    cout << "v3 = ";  
    for (auto& v : v3){  
        cout << v << " ";  
    }  
    cout << endl;  
  
    v3.assign({ 5, 6, 7 });  
    for (auto& v : v3){  
        cout << v << " ";  
    }  
    cout << endl;  
}  
  
```  
  
## Output  
  
```  
v1 = 10 20 30 40 50  
v2 = 10 20 30 40 50  
v3 = 4 4 4 4 4 4 4  
5 6 7  
```  
  
## Requirements  
 **Header:** \<vector>  
  
 **Namespace:** std  
  
## See Also  
 [vector Class](../vs140/vector-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)