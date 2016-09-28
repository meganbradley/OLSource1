---
title: "multimap::find"
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
  - "std.multimap.find"
  - "find"
  - "multimap.find"
  - "std::multimap::find"
  - "multimap::find"
  - "map/std::multimap::find"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "find method"
ms.assetid: 1796b7c7-252e-40dd-a798-fb0e7ab25c78
caps.latest.revision: 18
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# multimap::find
Returns an iterator that refers to the first location of an element in a multimap that has a key equivalent to a specified key.  
  
## Syntax  
  
```  
iterator find(const Key& key);  
  
const_iterator find(const Key& key) const;  
  
```  
  
#### Parameters  
 `key`  
 The key value to be matched by the sort key of an element from the multimap being searched.  
  
## Return Value  
 An iterator that refers to the location of an element with a specified key, or the location succeeding the last element in the multimap (`multimap::end()`) if no match is found for the key.  
  
## Remarks  
 The member function returns an iterator that refers to an element in the multimap whose sort key is equivalent to the argument key under a binary predicate that induces an ordering based on a less than comparability relation.  
  
 If the return value of **find** is assigned to a **const_iterator**, the multimap object cannot be modified. If the return value of **find** is assigned to an **iterator**, the multimap object can be modified.  
  
## Example  
  
```cpp  
// compile with: /EHsc /W4 /MTd  
#include <map>  
#include <iostream>  
#include <vector>  
#include <string>  
#include <utility>  // make_pair()  
  
using namespace std;  
  
template <typename A, typename B> void print_elem(const pair<A, B>& p) {  
    cout << "(" << p.first << ", " << p.second << ") ";  
}  
  
template <typename T> void print_collection(const T& t) {  
    cout << t.size() << " elements: ";  
  
    for (const auto& p : t) {  
        print_elem(p);  
    }  
    cout << endl;  
}  
  
template <typename C, class T> void findit(const C& c, T val) {  
    cout << "Trying find() on value " << val << endl;  
    auto result = c.find(val);  
    if (result != c.end()) {  
        cout << "Element found: "; print_elem(*result); cout << endl;  
    } else {  
        cout << "Element not found." << endl;  
    }  
}  
  
int main()  
{  
    multimap<int, string> m1({ { 40, "Zr" }, { 45, "Rh" } });  
    cout << "The starting multimap m1 is (key, value):" << endl;  
    print_collection(m1);  
  
    vector<pair<int, string>> v;  
    v.push_back(make_pair(43, "Tc"));  
    v.push_back(make_pair(41, "Nb"));  
    v.push_back(make_pair(46, "Pd"));  
    v.push_back(make_pair(42, "Mo"));  
    v.push_back(make_pair(44, "Ru"));  
    v.push_back(make_pair(44, "Ru")); // attempt a duplicate  
  
    cout << "Inserting the following vector data into m1:" << endl;  
    print_collection(v);  
  
    m1.insert(v.begin(), v.end());  
  
    cout << "The modified multimap m1 is (key, value):" << endl;  
    print_collection(m1);  
    cout << endl;  
    findit(m1, 45);  
    findit(m1, 6);  
}  
  
```  
  
## Output  
 **The starting multimap m1 is (key, value):2 elements: (40, Zr) (45, Rh)Inserting the following vector data into m1:6 elements: (43, Tc) (41, Nb) (46, Pd) (42, Mo) (44, Ru) (44, Ru)The modified multimap m1 is (key, value):8 elements: (40, Zr) (41, Nb) (42, Mo) (43, Tc) (44, Ru) (44, Ru) (45, Rh) (46, Pd)Trying find() on value 45Element found: (45, Rh)Trying find() on value 6Element not found.**   
## Requirements  
 **Header:** <map\>  
  
 **Namespace:** std  
  
## See Also  
 [multimap Class](../vs140/multimap-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)