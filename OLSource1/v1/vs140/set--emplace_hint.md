---
title: "set::emplace_hint"
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
  - "std.set.emplace_hint"
  - "std::set::emplace_hint"
  - "set.emplace_hint"
  - "set/std::set::emplace_hint"
  - "set::emplace_hint"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "emplace_hint method"
ms.assetid: f62c715a-4087-4bcf-a3fb-8945fc2d0d5e
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# set::emplace_hint
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
|`args`|The arguments forwarded to construct an element to be inserted into the set unless the set already contains that element or, more generally, unless it already contains an element whose value is equivalently ordered.|  
|`where`|The place to start searching for the correct point of insertion. (If that point immediately precedes `where`, insertion can occur in amortized constant time instead of logarithmic time.)|  
  
## Return Value  
 An iterator to the newly inserted element.  
  
 If the insertion failed because the element already exists, returns an iterator to the existing element.  
  
## Remarks  
 No iterators or references are invalidated by this function.  
  
 During emplacement, if an exception is thrown, the container's state is not modified.  
  
## Example  
  
```cpp  
  
// set_emplace.cpp  
// compile with: /EHsc  
#include <set>  
#include <string>  
#include <iostream>  
  
using namespace std;  
  
template <typename S> void print(const S& s) {  
    cout << s.size() << " elements: " << endl;  
  
    for (const auto& p : s) {  
        cout << "(" << p <<  ") ";  
    }  
  
    cout << endl;  
}  
  
int main()  
{  
    set<string> s1;  
  
    // Emplace some test data  
    s1.emplace("Anna");  
    s1.emplace("Bob");  
    s1.emplace("Carmine");  
  
    cout << "set starting data: ";  
    print(s1);  
    cout << endl;  
  
    // Emplace with hint  
    // s1.end() should be the "next" element after this emplacement  
    s1.emplace_hint(s1.end(), "Doug");  
  
    cout << "set modified, now contains ";  
    print(s1);  
    cout << endl;  
}  
  
```  
  
## Output  
  
```  
  
set starting data: 3 elements:  
(Anna) (Bob) (Carmine)  
  
set modified, now contains 4 elements:  
(Anna) (Bob) (Carmine) (Doug)  
```  
  
## Requirements  
 **Header:** \<set>  
  
 **Namespace:** std  
  
## See Also  
 [\<set>](../vs140/-set-.md)   
 [set Class](../vs140/set-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)