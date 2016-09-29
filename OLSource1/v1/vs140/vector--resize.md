---
title: "vector::resize"
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
  - "Resize"
  - "std.vector.resize"
  - "std::vector::resize"
  - "vector.resize"
  - "vector::resize"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "resize method"
ms.assetid: c1cb7b49-74bc-4044-aab6-d3d0628a535f
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# vector::resize
Specifies a new size for a vector.  
  
## Syntax  
  
```  
void resize( size_type Newsize );  
void resize( size_type Newsize, Type Val );  
```  
  
#### Parameters  
 `Newsize`  
 The new size of the vector.  
  
 `Val`  
 The initialization value of new elements added to the vector if the new size is larger that the original size. If the value is omitted, the new objects use their default constructor.  
  
## Remarks  
 If the container's size is less than the requested size, `Newsize`, elements are added to the vector until it reaches the requested size. If the container's size is larger than the requested size, the elements closest to the end of the container are deleted until the container reaches the size `Newsize`. If the present size of the container is the same as the requested size, no action is taken.  
  
 [size](../vs140/vector--size.md) reflects the current size of the vector.  
  
## Example  
  
```cpp  
// vectorsizing.cpp  
// compile with: /EHsc /W4  
// Illustrates vector::reserve, vector::max_size,  
// vector::resize, vector::resize, and vector::capacity.  
//  
// Functions:  
//  
//    vector::max_size - Returns maximum number of elements vector could  
//                       hold.  
//  
//    vector::capacity - Returns number of elements for which memory has  
//                       been allocated.  
//  
//    vector::size - Returns number of elements in the vector.  
//  
//    vector::resize - Reallocates memory for vector, preserves its  
//                     contents if new size is larger than existing size.  
//  
//    vector::reserve - Allocates elements for vector to ensure a minimum  
//                      size, preserving its contents if the new size is  
//                      larger than existing size.  
//  
//    vector::push_back - Appends (inserts) an element to the end of a  
//                        vector, allocating memory for it if necessary.  
//  
//////////////////////////////////////////////////////////////////////  
  
// The debugger cannot handle symbols more than 255 characters long.  
// STL often creates symbols longer than that.  
// The warning can be disabled:  
//#pragma warning(disable:4786)  
  
#include <iostream>  
#include <vector>  
#include <string>  
  
using namespace std;  
  
template <typename C> void print(const string& s, const C& c) {  
    cout << s;  
  
    for (const auto& e : c) {  
        cout << e << " ";  
    }  
    cout << endl;  
}  
  
void printvstats(const vector<int>& v) {  
    cout << "   the vector's size is: " << v.size() << endl;  
    cout << "   the vector's capacity is: " << v.capacity() << endl;  
    cout << "   the vector's maximum size is: " << v.max_size() << endl;  
}  
  
int main()  
{  
    // declare a vector that begins with 0 elements.  
    vector<int> v;  
  
    // Show statistics about vector.  
    cout << endl << "After declaring an empty vector:" << endl;  
    printvstats(v);  
    print("   the vector's contents: ", v);  
  
    // Add one element to the end of the vector.  
    v.push_back(-1);  
    cout << endl << "After adding an element:" << endl;  
    printvstats(v);  
    print("   the vector's contents: ", v);  
  
    for (int i = 1; i < 10; ++i) {  
        v.push_back(i);  
    }  
    cout << endl << "After adding 10 elements:" << endl;  
    printvstats(v);  
    print("   the vector's contents: ", v);  
  
    v.resize(6);  
    cout << endl << "After resizing to 6 elements without an initialization value:" << endl;  
    printvstats(v);  
    print("   the vector's contents: ", v);  
  
    v.resize(9, 999);  
    cout << endl << "After resizing to 9 elements with an initialization value of 999:" << endl;  
    printvstats(v);  
    print("   the vector's contents: ", v);  
  
    v.resize(12);  
    cout << endl << "After resizing to 12 elements without an initialization value:" << endl;  
    printvstats(v);  
    print("   the vector's contents: ", v);  
  
    // Ensure there's room for at least 1000 elements.  
    v.reserve(1000);  
    cout << endl << "After vector::reserve(1000):" << endl;  
    printvstats(v);  
  
    // Ensure there's room for at least 2000 elements.  
    v.resize(2000);  
    cout << endl << "After vector::resize(2000):" << endl;  
    printvstats(v);  
}  
```  
  
## Output  
  
```  
After declaring an empty vector:  
   the vector's size is: 0  
   the vector's capacity is: 0  
   the vector's maximum size is: 1073741823  
   the vector's contents:  
  
After adding an element:  
   the vector's size is: 1  
   the vector's capacity is: 1  
   the vector's maximum size is: 1073741823  
   the vector's contents: -1  
  
After adding 10 elements:  
   the vector's size is: 10  
   the vector's capacity is: 13  
   the vector's maximum size is: 1073741823  
   the vector's contents: -1 1 2 3 4 5 6 7 8 9  
  
After resizing to 6 elements without an initialization value:  
   the vector's size is: 6  
   the vector's capacity is: 13  
   the vector's maximum size is: 1073741823  
   the vector's contents: -1 1 2 3 4 5  
  
After resizing to 9 elements with an initialization value of 999:  
   the vector's size is: 9  
   the vector's capacity is: 13  
   the vector's maximum size is: 1073741823  
   the vector's contents: -1 1 2 3 4 5 999 999 999  
  
After resizing to 12 elements without an initialization value:  
   the vector's size is: 12  
   the vector's capacity is: 13  
   the vector's maximum size is: 1073741823  
   the vector's contents: -1 1 2 3 4 5 999 999 999 0 0 0  
  
After vector::reserve(1000):  
   the vector's size is: 12  
   the vector's capacity is: 1000  
   the vector's maximum size is: 1073741823  
  
After vector::resize(2000):  
   the vector's size is: 2000  
   the vector's capacity is: 2000  
   the vector's maximum size is: 1073741823  
```  
  
## Requirements  
 **Header:** \<vector>  
  
 **Namespace:** std  
  
## See Also  
 [vector Class](../vs140/vector-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)