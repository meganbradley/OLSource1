---
title: "list::list"
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
  - "std::list::list"
  - "list"
  - "std.list.list"
  - "list.list"
  - "list/std::list::list"
  - "list::list"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "list class, constructor"
  - "list method"
ms.assetid: 415ff234-ff4e-4236-a7fe-0aa1ec7300a2
caps.latest.revision: 22
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# list::list
Constructs a list of a specific size or with elements of a specific value or with a specific allocator or as a copy of all or part of some other list.  
  
## Syntax  
  
```  
list( );  
explicit list(  
    const Allocator& Al  
);  
explicit list(  
    size_type Count  
);  
list(  
    size_type Count,  
    const Type& Val  
);  
list(  
    size_type Count,  
    const Type& Val,  
    const Allocator& Al  
);  
list(  
    const list& Right  
);  
list(  
    list&& Right  
);  
list(  
    initializer_list<Type> IList,  
    const Allocator& Al  
);  
template<class InputIterator>  
    list(  
        InputIterator First,  
        InputIterator Last  
    );  
template<class InputIterator >  
    list(  
        InputIterator First,  
        InputIterator Last,  
        const Allocator& Al  
    );  
  
```  
  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|`Al`|The allocator class to use with this object.|  
|`Count`|The number of elements in the list constructed.|  
|`Val`|The value of the elements in the list.|  
|`Right`|The list of which the constructed list is to be a copy.|  
|`First`|The position of the first element in the range of elements to be copied.|  
|`Last`|The position of the first element beyond the range of elements to be copied.|  
|`IList`|The initializer_list that contains the elements to be copied.|  
  
## Remarks  
 All constructors store an allocator object (`Al`) and initialize the list.  
  
 [get_allocator](../vs140/list--get_allocator.md) returns a copy of the allocator object used to construct a list.  
  
 The first two constructors specify an empty initial list, the second specifying the allocator type (`Al`) to be used.  
  
 The third constructor specifies a repetition of a specified number (`Count`) of elements of the default value for class **Type**.  
  
 The fourth and fifth constructors specify a repetition of (`Count`) elements of value `Val`.  
  
 The sixth constructor specifies a copy of the list `Right`.  
  
 The seventh constructor moves the list `Right`.  
  
 The eighth constructor uses an initializer_list to specify the elements.  
  
 The next two constructors copy the range `[First, Last)` of a list.  
  
 None of the constructors perform any interim reallocations.  
  
## Example  
  
```cpp  
// list_class_list.cpp  
// compile with: /EHsc  
#include <list>  
#include <iostream>  
  
int main()  
{  
    using namespace std;  
    // Create an empty list c0  
    list <int> c0;  
  
    // Create a list c1 with 3 elements of default value 0  
    list <int> c1(3);  
  
    // Create a list c2 with 5 elements of value 2  
    list <int> c2(5, 2);  
  
    // Create a list c3 with 3 elements of value 1 and with the   
    // allocator of list c2  
    list <int> c3(3, 1, c2.get_allocator());  
  
    // Create a copy, list c4, of list c2  
    list <int> c4(c2);  
  
    // Create a list c5 by copying the range c4[_First, _Last)  
    list <int>::iterator c4_Iter = c4.begin();  
    c4_Iter++;  
    c4_Iter++;  
    list <int> c5(c4.begin(), c4_Iter);  
  
    // Create a list c6 by copying the range c4[_First, _Last) and with   
    // the allocator of list c2  
    c4_Iter = c4.begin();  
    c4_Iter++;  
    c4_Iter++;  
    c4_Iter++;  
    list <int> c6(c4.begin(), c4_Iter, c2.get_allocator());  
  
    cout << "c1 =";  
    for (auto c : c1)  
        cout << " " << c;  
    cout << endl;  
  
    cout << "c2 =";  
    for (auto c : c2)  
        cout << " " << c;  
    cout << endl;  
  
    cout << "c3 =";  
    for (auto c : c3)  
        cout << " " << c;  
    cout << endl;  
  
    cout << "c4 =";  
    for (auto c : c4)  
        cout << " " << c;  
    cout << endl;  
  
    cout << "c5 =";  
    for (auto c : c5)  
        cout << " " << c;  
    cout << endl;  
  
    cout << "c6 =";  
    for (auto c : c6)  
        cout << " " << c;  
    cout << endl;  
  
    // Move list c6 to list c7  
    list <int> c7(move(c6));  
    cout << "c7 =";  
    for (auto c : c7)  
        cout << " " << c;  
    cout << endl;  
  
    // Construct with initializer_list  
    list<int> c8({ 1, 2, 3, 4 });  
    cout << "c8 =";  
    for (auto c : c8)  
        cout << " " << c;  
    cout << endl;  
}  
```  
  
 **c1 = 0 0 0c2 = 2 2 2 2 2c3 = 1 1 1c4 = 2 2 2 2 2c5 = 2 2c6 = 2 2 2c7 = 2 2 2c8 = 1 2 3 4**   
## Requirements  
 **Header:** \<list>  
  
 **Namespace:** std  
  
## See Also  
 [list Class](../vs140/list-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)