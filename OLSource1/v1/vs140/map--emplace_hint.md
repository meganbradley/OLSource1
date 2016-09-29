---
title: "map::emplace_hint"
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
  - "map/std::map::emplace_hint"
  - "std.map.emplace_hint"
  - "std::map::emplace_hint"
  - "map.emplace_hint"
  - "map::emplace_hint"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "emplace_hint method"
ms.assetid: f4988068-3392-4ab8-980b-90f8d866a030
caps.latest.revision: 20
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# map::emplace_hint
Inserts an element constructed in place (no copy or move operations are performed), with a placement hint.  
  
## Syntax  
  
```  
template<class... Args>  
   iterator emplace_hint(  
      const_iterator where,  
      Args&&... args);  
```  
  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|`args`|The arguments forwarded to construct an element to be inserted into the map unless the map already contains that element or, more generally, unless it already contains an element whose key is equivalently ordered.|  
|`where`|The place to start searching for the correct point of insertion. (If that point immediately precedes `where`, insertion can occur in amortized constant time instead of logarithmic time.)|  
  
## Return Value  
 An iterator to the newly inserted element.  
  
 If the insertion failed because the element already exists, returns an iterator to the existing element with its key.  
  
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
    cout << m.size() << " elements: " << endl;  
  
    for (const auto& p : m) {  
        cout << "(" << p.first <<  "," << p.second << ") ";  
    }  
  
    cout << endl;  
}  
  
int main()  
{  
    map<string, string> m1;  
  
    // Emplace some test data  
    m1.emplace("Anna", "Accounting");  
    m1.emplace("Bob", "Accounting");  
    m1.emplace("Carmine", "Engineering");  
  
    cout << "map starting data: ";  
    print(m1);  
    cout << endl;  
  
    // Emplace with hint  
    // m1.end() should be the "next" element after this emplacement  
    m1.emplace_hint(m1.end(), "Doug", "Engineering");  
  
    cout << "map modified, now contains ";  
    print(m1);  
    cout << endl;  
}  
  
```  
  
## Output  
  
```  
  
map starting data: 3 elements:  
(Anna,Accounting) (Bob,Accounting) (Carmine,Engineering)  
  
map modified, now contains 4 elements:  
(Anna,Accounting) (Bob,Accounting) (Carmine,Engineering) (Doug,Engineering)  
```  
  
## Requirements  
 **Header:** <map\>  
  
 **Namespace:** std  
  
## See Also  
 [<map\>](../vs140/-map-.md)   
 [map Class](../vs140/map-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)