---
title: "multimap::insert"
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
  - "std::multimap::insert"
  - "multimap.insert"
  - "Insert"
  - "insert"
  - "map/std::multimap::insert"
  - "multimap::insert"
  - "std.multimap.insert"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "insert method"
ms.assetid: 7864b6fa-f4eb-4017-9842-f9810006fb45
caps.latest.revision: 26
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# multimap::insert
Inserts an element or a range of elements into a multimap.  
  
## Syntax  
  
```  
// (1) single element  
pair<iterator, bool> insert(  
    const value_type& Val  
);   
  
// (2) single element, perfect forwarded  
template<class ValTy>  
pair<iterator, bool> insert(  
    ValTy&& Val  
);  
  
// (3) single element with hint  
iterator insert(  
    const_iterator Where,  
    const value_type& Val  
);   
  
// (4) single element, perfect forwarded, with hint  
template<class ValTy>  
iterator insert(  
    const_iterator Where,  
    ValTy&& Val  
);  
  
// (5) range   
template<class InputIterator>   
void insert(  
    InputIterator First,  
    InputIterator Last  
);   
  
// (6) initializer list  
void insert(  
    initializer_list<value_type> IList  
);  
  
```  
  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|`Val`|The value of an element to be inserted into the multimap.|  
|`Where`|The place to start searching for the correct point of insertion. (If that point immediately precedes `Where`, insertion can occur in amortized constant time instead of logarithmic time.)|  
|`ValTy`|Template parameter that specifies the argument type that the map can use to construct an element of [value_type](../vs140/map--value_type.md), and perfect-forwards `Val` as an argument.|  
|`First`|The position of the first element to be copied.|  
|`Last`|The position just beyond the last element to be copied.|  
|`InputIterator`|Template function argument that meets the requirements of an [input iterator](../vs140/input_iterator_tag-struct.md) that points to elements of a type that can be used to construct [value_type](../vs140/map--value_type.md) objects.|  
|`IList`|The [initializer_list](../vs140/-initializer_list-.md) from which to copy the elements.|  
  
## Return Value  
 The single-element-insert member functions, (1) and (2), return an iterator to the position where the new element was inserted into the multimap.  
  
 The single-element-with-hint member functions, (3) and (4), return an iterator that points to the position where the new element was inserted into the multimap.  
  
## Remarks  
 No pointers or references are invalidated by this function, but it may invalidate all iterators to the container.  
  
 During the insertion of just one element, if an exception is thrown, the container's state is not modified. During the insertion of multiple elements, if an exception is thrown, the container is left in an unspecified but valid state.  
  
 The [value_type](../vs140/map--value_type.md) of a container is a typedef that belongs to the container, and for map, `multimap<K, V>::value_type` is `pair<const K, V>`. The value of an element is an ordered pair in which the first component is equal to the key value and the second component is equal to the data value of the element.  
  
 The range member function (5) inserts the sequence of element values into a multimap that corresponds to each element addressed by an iterator in the range `[First, Last)`; therefore, `Last` does not get inserted. The container member function `end()` refers to the position just after the last element in the container—for example, the statement `m.insert(v.begin(), v.end());` inserts all elements of `v` into `m`.  
  
 The initializer list member function (6) uses an [initializer_list](../vs140/-initializer_list-.md) to copy elements into the map.  
  
 For insertion of an element constructed in place—that is, no copy or move operations are performed—see [multimap::emplace](../vs140/multimap--emplace.md) and [multimap::emplace_hint](../vs140/multimap--emplace_hint.md).  
  
## Example  
  
```cpp  
  
// multimap_insert.cpp  
// compile with: /EHsc  
#include <map>  
#include <iostream>  
#include <string>  
#include <vector>  
#include <utility>  // make_pair()  
  
using namespace std;  
  
template <typename M> void print(const M& m) {  
    cout << m.size() << " elements: ";  
  
    for (const auto& p : m) {  
        cout << "(" << p.first << ", " << p.second << ") ";  
    }  
  
    cout << endl;  
}  
  
int main()  
{  
  
    // insert single values   
    multimap<int, int> m1;  
    // call insert(const value_type&) version  
    m1.insert({ 1, 10 });  
    // call insert(ValTy&&) version   
    m1.insert(make_pair(2, 20));  
  
    cout << "The original key and mapped values of m1 are:" << endl;  
    print(m1);  
  
    // intentionally attempt a duplicate, single element  
    m1.insert(make_pair(1, 111));  
  
    cout << "The modified key and mapped values of m1 are:" << endl;  
    print(m1);  
  
    // single element, with hint  
    m1.insert(m1.end(), make_pair(3, 30));  
    cout << "The modified key and mapped values of m1 are:" << endl;  
    print(m1);  
    cout << endl;  
  
    // The templatized version inserting a jumbled range  
    multimap<int, int> m2;  
    vector<pair<int, int>> v;  
    v.push_back(make_pair(43, 294));  
    v.push_back(make_pair(41, 262));  
    v.push_back(make_pair(45, 330));  
    v.push_back(make_pair(42, 277));  
    v.push_back(make_pair(44, 311));  
  
    cout << "Inserting the following vector data into m2:" << endl;  
    print(v);  
  
    m2.insert(v.begin(), v.end());  
  
    cout << "The modified key and mapped values of m2 are:" << endl;  
    print(m2);  
    cout << endl;  
  
    // The templatized versions move-constructing elements  
    multimap<int, string>  m3;  
    pair<int, string> ip1(475, "blue"), ip2(510, "green");  
  
    // single element  
    m3.insert(move(ip1));  
    cout << "After the first move insertion, m3 contains:" << endl;  
    print(m3);  
  
    // single element with hint  
    m3.insert(m3.end(), move(ip2));  
    cout << "After the second move insertion, m3 contains:" << endl;  
    print(m3);  
    cout << endl;  
  
    multimap<int, int> m4;  
    // Insert the elements from an initializer_list  
    m4.insert({ { 4, 44 }, { 2, 22 }, { 3, 33 }, { 1, 11 }, { 5, 55 } });  
    cout << "After initializer_list insertion, m4 contains:" << endl;  
    print(m4);  
    cout << endl;  
}  
  
```  
  
## Output  
  
```  
  
The original key and mapped values of m1 are:  
2 elements: (1, 10) (2, 20)  
The modified key and mapped values of m1 are:  
3 elements: (1, 10) (1, 111) (2, 20)  
The modified key and mapped values of m1 are:  
4 elements: (1, 10) (1, 111) (2, 20) (3, 30)  
  
Inserting the following vector data into m2:  
5 elements: (43, 294) (41, 262) (45, 330) (42, 277) (44, 311)  
The modified key and mapped values of m2 are:  
5 elements: (41, 262) (42, 277) (43, 294) (44, 311) (45, 330)  
  
After the first move insertion, m3 contains:  
1 elements: (475, blue)  
After the second move insertion, m3 contains:  
2 elements: (475, blue) (510, green)  
  
After initializer_list insertion, m4 contains:  
5 elements: (1, 11) (2, 22) (3, 33) (4, 44) (5, 55)  
```  
  
## Requirements  
 **Header:** \<map>  
  
 **Namespace:** std  
  
## See Also  
 [map::insert](../vs140/map--insert.md)   
 [multimap Class](../vs140/multimap-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)