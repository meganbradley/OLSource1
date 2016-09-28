---
title: "multimap::emplace"
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
  - "multimap.emplace"
  - "map/std::multimap::emplace"
  - "multimap::emplace"
  - "std::multimap::emplace"
  - "std.multimap.emplace"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "emplace method"
ms.assetid: 2e60cee0-1cec-482d-aa1f-caf3e58cb2f2
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# multimap::emplace
Inserts an element constructed in place (no copy or move operations are performed).  
  
## Syntax  
  
```  
template<class... Args>  
   iterator emplace(  
      Args&&... args);  
```  
  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|`args`|The arguments forwarded to construct an element to be inserted into the multimap.|  
  
## Return Value  
 An iterator to the newly inserted element.  
  
## Remarks  
 No references to container elements are invalidated by this function, but it may invalidate all iterators to the container.  
  
 If an exception is thrown during the insertion, the container is left unaltered and the exception is rethrown.  
  
 The [value_type](../vs140/map--value_type.md) of an element is a pair, so that the value of an element will be an ordered pair with the first component equal to the key value and the second component equal to the data value of the element.  
  
## Example  
  
```cpp  
// multimap_emplace.cpp  
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
    multimap<string, string> m1;  
  
    m1.emplace("Anna", "Accounting");  
    m1.emplace("Bob", "Accounting");  
    m1.emplace("Carmine", "Engineering");  
  
    cout << "multimap modified, now contains ";  
    print(m1);  
    cout << endl;  
  
    m1.emplace("Bob", "Engineering");  
  
    cout << "multimap modified, now contains ";  
    print(m1);  
    cout << endl;  
}  
  
```  
  
## Output  
  
```  
  
multimap modified, now contains 3 elements:  
(Anna,Accounting) (Bob,Accounting) (Carmine,Engineering)  
  
multimap modified, now contains 4 elements:  
(Anna,Accounting) (Bob,Accounting) (Bob,Engineering) (Carmine,Engineering)  
```  
  
## Requirements  
 **Header:** <map\>  
  
 **Namespace:** std  
  
## See Also  
 [<map\>](../vs140/-map-.md)   
 [multimap Class](../vs140/multimap-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)