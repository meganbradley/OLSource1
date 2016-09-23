---
title: "multiset::count"
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
  - multiset::count
  - std.multiset.count
  - set/std::multiset::count
  - multiset.count
  - count
  - std::multiset::count
dev_langs: 
  - C++
helpviewer_keywords: 
  - count method
ms.assetid: 044b1ea9-ce3a-4fd9-8c78-8249eaf824e0
caps.latest.revision: 21
translation.priority.ht: 
  - de-de
  - ja-jp
---
# multiset::count
Returns the number of elements in a multiset whose key matches a parameter-specified key.  
  
## Syntax  
  
```  
  
      size_type count(  
   const Key& _Key  
) const;  
```  
  
#### Parameters  
 `_Key`  
 The key of the elements to be matched from the multiset.  
  
## Return Value  
 The number of elements in the multiset whose sort key matches the parameter key.  
  
## Remarks  
 The member function returns the number of elements *x* in the range  
  
 [`lower_bound` (_*Key* ), `upper_bound` (\_*Key* ) ).  
  
## Example  
 The following example demonstrates the use of the multiset::count member function.  
  
```  
// multiset_count.cpp  
// compile with: /EHsc  
#include <set>  
#include <iostream>  
  
int main()  
{  
    using namespace std;  
    multiset<int> ms1;  
    multiset<int>::size_type i;  
  
    ms1.insert(1);  
    ms1.insert(1);  
    ms1.insert(2);  
  
    // Elements do not need to be unique in multiset,  
    // so duplicates are allowed and counted.  
    i = ms1.count(1);  
    cout << "The number of elements in ms1 with a sort key of 1 is: "  
         << i << "." << endl;  
  
    i = ms1.count(2);  
    cout << "The number of elements in ms1 with a sort key of 2 is: "  
         << i << "." << endl;  
  
    i = ms1.count(3);  
    cout << "The number of elements in ms1 with a sort key of 3 is: "  
         << i << "." << endl;  
}  
```  
  
 **The number of elements in ms1 with a sort key of 1 is: 2.**  
**The number of elements in ms1 with a sort key of 2 is: 1.**  
**The number of elements in ms1 with a sort key of 3 is: 0.**   
## Requirements  
 **Header:** <set\>  
  
 **Namespace:** std  
  
## See Also  
 [multiset Class](../vs140/multiset-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)