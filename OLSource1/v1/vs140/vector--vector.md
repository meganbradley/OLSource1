---
title: "vector::vector"
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
  - "std::vector::vector"
  - "std.vector.vector"
  - "vector::vector"
  - "vector.vector"
  - "vector"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "vector method"
  - "vector class, constructor"
ms.assetid: 24b14024-3af3-4f4b-89a5-0291744a9f83
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# vector::vector
Constructs a vector of a specific size or with elements of a specific value or with a specific allocator or as a copy of all or part of some other vector.  
  
## Syntax  
  
```  
vector( );   
explicit vector(  
    const Allocator& Al  
);  
explicit vector(  
    size_type Count  
);  
vector(  
    size_type Count,  
    const Type& Val  
);  
vector(  
    size_type Count,  
    const Type& Val,  
    const Allocator& Al  
);  
vector(  
    const vector& Right  
);   
vector(  
    vector&& Right  
);  
vector(  
    initializer_list<Type> IList,  
    const _Allocator& Al  
);  
template<class InputIterator>  
    vector(  
        InputIterator First,  
        InputIterator Last  
    );  
template<class InputIterator>  
    vector(  
        InputIterator First,  
        InputIterator Last,  
        const Allocator& Al  
    );  
  
```  
  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|`Al`|The allocator class to use with this object. [get_allocator](../vs140/vector--get_allocator.md) returns the allocator class for the object.|  
|`Count`|The number of elements in the constructed vector.|  
|`Val`|The value of the elements in the constructed vector.|  
|`Right`|The vector of which the constructed vector is to be a copy.|  
|`First`|Position of the first element in the range of elements to be copied.|  
|`Last`|Position of the first element beyond the range of elements to be copied.|  
|`IList`|The initializer_list containing the elmeents to copy.|  
  
## Remarks  
 All constructors store an allocator object (`Al`) and initialize the vector.  
  
 The first two constructors specify an empty initial vector. The second explicitly specifies the allocator type (`Al`) to be used.  
  
 The third constructor specifies a repetition of a specified number (`Count`) of elements of the default value for class `Type`.  
  
 The fourth and fifth constructors specify a repetition of (`Count`) elements of value `Val`.  
  
 The sixth constructor specifies a copy of the vector `Right`.  
  
 The seventh constructor moves the vector `Right`.  
  
 The eighth constructor uses an initializer_list to specify the elements.  
  
 The ninth and tenth constructors copy the range [`First`, `Last`) of a vector.  
  
## Example  
  
```cpp  
// vector_ctor.cpp  
// compile with: /EHsc  
#include <vector>  
#include <iostream>  
  
int main()  
{  
    using namespace std;  
    vector <int>::iterator v1_Iter, v2_Iter, v3_Iter, v4_Iter, v5_Iter, v6_Iter;  
  
    // Create an empty vector v0  
    vector <int> v0;  
  
    // Create a vector v1 with 3 elements of default value 0  
    vector <int> v1(3);  
  
    // Create a vector v2 with 5 elements of value 2  
    vector <int> v2(5, 2);  
  
    // Create a vector v3 with 3 elements of value 1 and with the allocator   
    // of vector v2  
    vector <int> v3(3, 1, v2.get_allocator());  
  
    // Create a copy, vector v4, of vector v2  
    vector <int> v4(v2);  
  
    // Create a new temporary vector for demonstrating copying ranges  
    vector <int> v5(5);  
    for (auto i : v5) {  
        v5[i] = i;  
    }  
  
    // Create a vector v6 by copying the range v5[_First, _Last)  
    vector <int> v6(v5.begin() + 1, v5.begin() + 3);  
  
    cout << "v1 =";  
    for (auto& v : v1){  
        cout << " " << v;  
    }  
    cout << endl;  
  
    cout << "v2 =";  
    for (auto& v : v2){  
        cout << " " << v;  
    }  
    cout << endl;  
  
    cout << "v3 =";  
    for (auto& v : v3){  
        cout << " " << v;  
    }  
    cout << endl;  
    cout << "v4 =";  
    for (auto& v : v4){  
        cout << " " << v;  
    }  
    cout << endl;  
  
    cout << "v5 =";  
    for (auto& v : v5){  
        cout << " " << v;  
    }  
    cout << endl;  
  
    cout << "v6 =";  
    for (auto& v : v6){  
        cout << " " << v;  
    }  
    cout << endl;  
  
    // Move vector v2 to vector v7  
    vector <int> v7(move(v2));  
    vector <int>::iterator v7_Iter;  
  
    cout << "v7 =";  
    for (auto& v : v7){  
        cout << " " << v;  
    }  
    cout << endl;  
  
    vector<int> v8{ { 1, 2, 3, 4 } };  
    for (auto& v : v8){  
        cout << " " << v ;  
    }  
    cout << endl;  
}  
  
```  
  
 **v1 = 0 0 0v2 = 2 2 2 2 2v3 = 1 1 1v4 = 2 2 2 2 2v5 = 0 1 2 3 4v6 = 1 2v7 = 2 2 2 2 21 2 3 4**   
## Requirements  
 **Header:** <vector\>  
  
 **Namespace:** std  
  
## See Also  
 [vector Class](../vs140/vector-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)