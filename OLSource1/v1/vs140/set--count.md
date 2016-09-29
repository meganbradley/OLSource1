---
title: "set::count"
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
  - "set::count"
  - "std.set.count"
  - "set/std::set::count"
  - "set.count"
  - "count"
  - "std::set::count"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "count method"
ms.assetid: 6688fb52-0774-4b0d-9171-3e8bab24bd15
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# set::count
Returns the number of elements in a set whose key matches a parameter-specified key.  
  
## Syntax  
  
```  
  
      size_type count(  
   const Key& _Key  
) const;  
```  
  
#### Parameters  
 `_Key`  
 The key of the elements to be matched from the set.  
  
## Return Value  
 1 if the set contains an element whose sort key matches the parameter key. 0 if the set does not contain an element with a matching key.  
  
## Remarks  
 The member function returns the number of elements in the following range:  
  
 [`lower_bound` (_*Key* ), `upper_bound` (\_*Key* ) ).  
  
## Example  
 The following example demonstrates the use of the set::count member function.  
  
```  
// set_count.cpp  
// compile with: /EHsc  
#include <set>  
#include <iostream>  
  
int main()  
{  
    using namespace std;  
    set<int> s1;  
    set<int>::size_type i;  
  
    s1.insert(1);  
    s1.insert(1);  
  
    // Keys must be unique in set, so duplicates are ignored  
    i = s1.count(1);  
    cout << "The number of elements in s1 with a sort key of 1 is: "  
         << i << "." << endl;  
  
    i = s1.count(2);  
    cout << "The number of elements in s1 with a sort key of 2 is: "  
         << i << "." << endl;  
}  
```  
  
 **The number of elements in s1 with a sort key of 1 is: 1.**  
**The number of elements in s1 with a sort key of 2 is: 0.**   
## Requirements  
 **Header:** \<set>  
  
 **Namespace:** std  
  
## See Also  
 [set Class](../vs140/set-class.md)   
 [set::count](../vs140/set--count--stl-samples-.md)   
 [Standard Template Library](../vs140/standard-template-library.md)