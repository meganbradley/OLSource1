---
title: "map::emplace"
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
  - "std::map::emplace"
  - "map::emplace"
  - "map/std::map::emplace"
  - "std.map.emplace"
  - "map.emplace"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "emplace method"
ms.assetid: ca98a183-6cf4-49db-82ae-92fac94c0407
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# map::emplace
Inserts an element constructed in place (no copy or move operations are performed) into a map.  
  
## Syntax  
  
```  
template<class... Args>  
   pair<iterator, bool> emplace(  
      Args&&... args);  
```  
  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|`args`|The arguments forwarded to construct an element to be inserted into the map unless it already contains an element whose value is equivalently ordered.|  
  
## Return Value  
 A [pair](../vs140/pair-structure.md) whose `bool` component is true if an insertion was made, and false if the map already contained an element of equivalent value in the ordering. The iterator component of the return-value pair points to the newly inserted element if the `bool` component is true, or to the existing element if the `bool` component is false.  
  
 To access the iterator component of a `pair``pr`, use `pr.first`; to dereference it, use `*pr.first`. To access the `bool` component, use `pr.second`. For an example, see the sample code later in this article.  
  
## Remarks  
 No iterators or references are invalidated by this function.  
  
 During emplacement, if an exception is thrown, the container's state is not modified.  
  
 The [value_type](../vs140/map--value_type.md) of an element is a pair, so that the value of an element will be an ordered pair with the first component equal to the key value and the second component equal to the data value of the element.  
  
## Example  
  
```cpp  
  
// map_emplace.cpp  
// compile with: /EHsc  
#include <map>  
#include <string>  
#include <iostream>  
  
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
    map<int, string> m1;  
  
    auto ret = m1.emplace(10, "ten");  
  
    if (!ret.second){  
        auto pr = *ret.first;  
        cout << "Emplace failed, element with key 10 already exists."  
            << endl << "  The existing element is (" << pr.first << ", " << pr.second << ")"  
            << endl;  
        cout << "map not modified" << endl;  
    }  
    else{  
        cout << "map modified, now contains ";  
        print(m1);  
    }  
    cout << endl;  
  
    ret = m1.emplace(10, "one zero");  
  
    if (!ret.second){  
        auto pr = *ret.first;  
        cout << "Emplace failed, element with key 10 already exists."  
            << endl << "  The existing element is (" << pr.first << ", " << pr.second << ")"  
            << endl;  
    }  
    else{  
        cout << "map modified, now contains ";  
        print(m1);  
    }  
    cout << endl;  
}  
  
```  
  
## Output  
  
```  
  
map modified, now contains 1 elements: (10, ten)  
  
Emplace failed, element with key 10 already exists.  
  The existing element is (10, ten)  
```  
  
## Requirements  
 **Header:** \<map>  
  
 **Namespace:** std  
  
## See Also  
 [\<map>](../vs140/-map-.md)   
 [map Class](../vs140/map-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)