---
title: "set::insert"
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
  - "std.set.insert"
  - "insert"
  - "set/std::set::insert"
  - "std::set::insert"
  - "set.insert"
  - "set::insert"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "insert method"
ms.assetid: fd0c3edf-ab58-4d29-98f0-de036d2c55d5
caps.latest.revision: 27
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# set::insert
Inserts an element or a range of elements into a set.  
  
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
|`Val`|The value of an element to be inserted into the set unless it already contains an element whose value is equivalently ordered.|  
|`Where`|The place to start searching for the correct point of insertion. (If that point immediately precedes `Where`, insertion can occur in amortized constant time instead of logarithmic time.)|  
|`ValTy`|Template parameter that specifies the argument type that the set can use to construct an element of [value_type](../vs140/map--value_type.md), and perfect-forwards `Val` as an argument.|  
|`First`|The position of the first element to be copied.|  
|`Last`|The position just beyond the last element to be copied.|  
|`InputIterator`|Template function argument that meets the requirements of an [input iterator](../vs140/input_iterator_tag-struct.md) that points to elements of a type that can be used to construct [value_type](../vs140/map--value_type.md) objects.|  
|`IList`|The [initializer_list](../vs140/-initializer_list-.md) from which to copy the elements.|  
  
## Return Value  
 The single-element member functions, (1) and (2), return a [pair](../vs140/pair-structure.md) whose `bool` component is true if an insertion was made, and false if the set already contained an element of equivalent value in the ordering. The iterator component of the return-value pair points to the newly inserted element if the `bool` component is true, or to the existing element if the `bool` component is false.  
  
 The single-element-with-hint member functions, (3) and (4), return an iterator that points to the position where the new element was inserted into the set or, if an element with an equivalent key already exists, to the existing element.  
  
## Remarks  
 No iterators, pointers, or references are invalidated by this function.  
  
 During the insertion of just one element, if an exception is thrown, the container's state is not modified. During the insertion of multiple elements, if an exception is thrown, the container is left in an unspecified but valid state.  
  
 To access the iterator component of a `pair``pr` that's returned by the single-element member functions, use `pr.first`; to dereference the iterator within the returned pair, use `*pr.first`, giving you an element. To access the `bool` component, use `pr.second`. For an example, see the sample code later in this article.  
  
 The [value_type](../vs140/map--value_type.md) of a container is a typedef that belongs to the container, and, for set, `set<V>::value_type` is type `const V`.  
  
 The range member function (5) inserts the sequence of element values into a set that corresponds to each element addressed by an iterator in the range `[First, Last)`; therefore, `Last` does not get inserted. The container member function `end()` refers to the position just after the last element in the container—for example, the statement `s.insert(v.begin(), v.end());` attempts to insert all elements of `v` into `s`. Only elements that have unique values in the range are inserted; duplicates are ignored. To observe which elements are rejected, use the single-element versions of `insert`.  
  
 The initializer list member function (6) uses an [initializer_list](../vs140/-initializer_list-.md) to copy elements into the set.  
  
 For insertion of an element constructed in place—that is, no copy or move operations are performed—see [set::emplace](../vs140/set--emplace.md) and [set::emplace_hint](../vs140/set--emplace_hint.md).  
  
## Example  
  
```cpp  
  
// set_insert.cpp  
// compile with: /EHsc  
#include <set>  
#include <iostream>  
#include <string>  
#include <vector>  
  
using namespace std;  
  
template <typename S> void print(const S& s) {  
    cout << s.size() << " elements: ";  
  
    for (const auto& p : s) {  
        cout << "(" << p << ") ";  
    }  
  
    cout << endl;  
}  
  
int main()  
{  
  
    // insert single values   
    set<int> s1;  
    // call insert(const value_type&) version  
    s1.insert({ 1, 10 });  
    // call insert(ValTy&&) version   
    s1.insert(20);  
  
    cout << "The original set values of s1 are:" << endl;  
    print(s1);  
  
    // intentionally attempt a duplicate, single element  
    auto ret = s1.insert(1);  
    if (!ret.second){  
        auto elem = *ret.first;  
        cout << "Insert failed, element with value 1 already exists."  
            << endl << "  The existing element is (" << elem << ")"  
            << endl;  
    }  
    else{  
        cout << "The modified set values of s1 are:" << endl;  
        print(s1);  
    }  
    cout << endl;  
  
    // single element, with hint  
    s1.insert(s1.end(), 30);  
    cout << "The modified set values of s1 are:" << endl;  
    print(s1);  
    cout << endl;  
  
    // The templatized version inserting a jumbled range  
    set<int> s2;  
    vector<int> v;  
    v.push_back(43);  
    v.push_back(294);  
    v.push_back(41);  
    v.push_back(330);  
    v.push_back(42);  
    v.push_back(45);  
  
    cout << "Inserting the following vector data into s2:" << endl;  
    print(v);  
  
    s2.insert(v.begin(), v.end());  
  
    cout << "The modified set values of s2 are:" << endl;  
    print(s2);  
    cout << endl;  
  
    // The templatized versions move-constructing elements  
    set<string>  s3;  
    string str1("blue"), str2("green");  
  
    // single element  
    s3.insert(move(str1));  
    cout << "After the first move insertion, s3 contains:" << endl;  
    print(s3);  
  
    // single element with hint  
    s3.insert(s3.end(), move(str2));  
    cout << "After the second move insertion, s3 contains:" << endl;  
    print(s3);  
    cout << endl;  
  
    set<int> s4;  
    // Insert the elements from an initializer_list  
    s4.insert({ 4, 44, 2, 22, 3, 33, 1, 11, 5, 55 });  
    cout << "After initializer_list insertion, s4 contains:" << endl;  
    print(s4);  
    cout << endl;  
}  
  
```  
  
## Output  
  
```  
  
The original set values of s1 are:  
3 elements: (1) (10) (20)  
Insert failed, element with value 1 already exists.  
  The existing element is (1)  
  
The modified set values of s1 are:  
4 elements: (1) (10) (20) (30)  
  
Inserting the following vector data into s2:  
6 elements: (43) (294) (41) (330) (42) (45)  
The modified set values of s2 are:  
6 elements: (41) (42) (43) (45) (294) (330)  
  
After the first move insertion, s3 contains:  
1 elements: (blue)  
After the second move insertion, s3 contains:  
2 elements: (blue) (green)  
  
After initializer_list insertion, s4 contains:  
10 elements: (1) (2) (3) (4) (5) (11) (22) (33) (44) (55)  
```  
  
## Requirements  
 **Header:** \<set>  
  
 **Namespace:** std  
  
## See Also  
 [\<set>](../vs140/-set-.md)   
 [set Class](../vs140/set-class.md)   
 [multiset::insert](../vs140/multiset--insert.md)   
 [Standard Template Library](../vs140/standard-template-library.md)