---
title: "map::map"
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
  - map::map
  - map/std::map::map
  - map.map
  - std.map.map
  - map
  - std::map::map
dev_langs: 
  - C++
helpviewer_keywords: 
  - map class, constructor
  - map method
ms.assetid: b35c0055-889c-463d-9015-cfd127fb71be
caps.latest.revision: 20
translation.priority.ht: 
  - de-de
  - ja-jp
---
# map::map
Constructs a map that is empty or that is a copy of all or part of some other map.  
  
## Syntax  
  
```  
map( );  
explicit map(  
    const Traits& Comp  
);  
map(  
    const Traits& Comp,  
    const Allocator& Al  
);  
map(  
    const map& Right  
);   
map(  
    map&& Right  
);  
map(  
    initializer_list<value_type> IList  
);  
map(  
    initializer_list<value_type> IList,  
    const Traits& Comp  
);  
map(  
    initializer_list<value_type> IList,  
    const Traits& Comp,   
    const Allocator& Allocator  
);  
template<class InputIterator>  
    map(  
        InputIterator First,  
        InputIterator Last  
    );  
template<class InputIterator>  
    map(  
        InputIterator First,  
        InputIterator Last,  
        const Traits& Comp  
    );  
template<class InputIterator>  
    map(  
        InputIterator First,  
        InputIterator Last,  
        const Traits& Comp,  
        const Allocator& Al  
    );  
  
```  
  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|`Al`|The storage allocator class to be used for this map object, which defaults to `Allocator`.|  
|`Comp`|The comparison function of type `const Traits` used to order the elements in the map, which defaults to `hash_compare`.|  
|`Right`|The map of which the constructed set is to be a copy.|  
|`First`|The position of the first element in the range of elements to be copied.|  
|`Last`|The position of the first element beyond the range of elements to be copied.|  
|`IList`|The initializer_list from which the elements are to be copied.|  
  
## Remarks  
 All constructors store a type of allocator object that manages memory storage for the map and that can later be returned by calling [get_allocator](../vs140/map--get_allocator.md). The allocator parameter is often omitted in the class declarations and preprocessing macros used to substitute alternative allocators.  
  
 All constructors initialize their map.  
  
 All constructors store a function object of type Traits that is used to establish an order among the keys of the map and that can later be returned by calling [key_comp](../vs140/map--key_comp.md).  
  
 The first three constructors specify an empty initial map, the second specifying the type of comparison function (`Comp`) to be used in establishing the order of the elements and the third explicitly specifying the allocator type (`Al`) to be used. The key word `explicit` suppresses certain kinds of automatic type conversion.  
  
 The fourth constructor specifies a copy of the map `Right`.  
  
 The fifth constructor specifies a copy of the map by moving `Right`.  
  
 The sixth, seventh, and eighth constructors use an initializer_list from which to copy the members.  
  
 The next three constructors copy the range `[First, Last)` of a map with increasing explicitness in specifying the type of comparison function of class `Traits` and allocator.  
  
## Example  
  
```  
// map_map.cpp  
// compile with: /EHsc  
#include <map>  
#include <iostream>  
  
int main()  
{  
    using namespace std;  
    typedef pair <int, int> Int_Pair;  
    map <int, int>::iterator m1_Iter, m3_Iter, m4_Iter, m5_Iter, m6_Iter, m7_Iter;  
    map <int, int, less<int> >::iterator m2_Iter;  
  
    // Create an empty map m0 of key type integer  
    map <int, int> m0;  
  
    // Create an empty map m1 with the key comparison  
    // function of less than, then insert 4 elements  
    map <int, int, less<int> > m1;  
    m1.insert(Int_Pair(1, 10));  
    m1.insert(Int_Pair(2, 20));  
    m1.insert(Int_Pair(3, 30));  
    m1.insert(Int_Pair(4, 40));  
  
    // Create an empty map m2 with the key comparison  
    // function of geater than, then insert 2 elements  
    map <int, int, less<int> > m2;  
    m2.insert(Int_Pair(1, 10));  
    m2.insert(Int_Pair(2, 20));  
  
    // Create a map m3 with the   
    // allocator of map m1  
    map <int, int>::allocator_type m1_Alloc;  
    m1_Alloc = m1.get_allocator();  
    map <int, int> m3(less<int>(), m1_Alloc);  
    m3.insert(Int_Pair(3, 30));  
  
    // Create a copy, map m4, of map m1  
    map <int, int> m4(m1);  
  
    // Create a map m5 by copying the range m1[_First, _Last)  
    map <int, int>::const_iterator m1_bcIter, m1_ecIter;  
    m1_bcIter = m1.begin();  
    m1_ecIter = m1.begin();  
    m1_ecIter++;  
    m1_ecIter++;  
    map <int, int> m5(m1_bcIter, m1_ecIter);  
  
    // Create a map m6 by copying the range m4[_First, _Last)  
    // and with the allocator of map m2  
    map <int, int>::allocator_type m2_Alloc;  
    m2_Alloc = m2.get_allocator();  
    map <int, int> m6(m4.begin(), ++m4.begin(), less<int>(), m2_Alloc);  
  
    cout << "m1 =";  
    for (auto i : m1)  
        cout << i.first << " " << i.second << ", ";  
    cout << endl;  
  
    cout << "m2 =";  
    for(auto i : m2)  
        cout << i.first << " " << i.second << ", ";  
    cout << endl;  
  
    cout << "m3 =";  
    for (auto i : m3)  
        cout << i.first << " " << i.second << ", ";  
    cout << endl;  
  
    cout << "m4 =";  
    for (auto i : m4)  
        cout << i.first << " " << i.second << ", ";  
    cout << endl;  
  
    cout << "m5 =";  
    for (auto i : m5)  
        cout << i.first << " " << i.second << ", ";  
    cout << endl;  
  
    cout << "m6 =";  
    for (auto i : m6)  
        cout << i.first << " " << i.second << ", ";  
    cout << endl;  
  
    // Create a map m7 by moving m5  
    cout << "m7 =";  
    map<int, int> m7(move(m5));  
    for (auto i : m7)  
        cout << i.first << " " << i.second << ", ";  
    cout << endl;  
  
    // Create a map m8 by copying in an initializer_list  
    map<int, int> m8{ { { 1, 1 }, { 2, 2 }, { 3, 3 }, { 4, 4 } } };  
    cout << "m8: = ";  
    for (auto i : m8)  
        cout << i.first << " " << i.second << ", ";  
    cout << endl;  
  
    // Create a map m9 with an initializer_list and a comparator  
    map<int, int> m9({ { 5, 5 }, { 6, 6 }, { 7, 7 }, { 8, 8 } }, less<int>());  
    cout << "m9: = ";  
    for (auto i : m9)  
        cout << i.first << " " << i.second << ", ";  
    cout << endl;  
  
    // Create a map m10 with an initializer_list, a comparator, and an allocator  
    map<int, int> m10({ { 9, 9 }, { 10, 10 }, { 11, 11 }, { 12, 12 } }, less<int>(), m9.get_allocator());  
    cout << "m10: = ";  
    for (auto i : m10)  
        cout << i.first << " " << i.second << ", ";  
    cout << endl;  
}  
  
```  
  
## Output  
  
```  
m1 = 10 20 30 40  
m2 = 10 20  
m3 = 30  
m4 = 10 20 30 40  
m5 = 10 20  
m6 = 10  
m7 = 10 20  
m8: = 1 1, 2 2, 3 3, 4 4,  
m9: = 5 5, 6 6, 7 7, 8 8,  
m10: = 9 9, 10 10, 11 11, 12 12,  
```  
  
## Requirements  
 **Header:** <map\>  
  
 **Namespace:** std  
  
## See Also  
 [map Class](../vs140/map-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)