---
title: "map::count"
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
  - "map.count"
  - "count"
  - "map::count"
  - "std.map.count"
  - "map/std::map::count"
  - "std::map::count"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "count method"
ms.assetid: 0d93c45f-78b6-4022-b6f9-6338844740fc
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# map::count
Returns the number of elements in a map whose key matches a parameter-specified key.  
  
## Syntax  
  
```  
  
      size_type count(  
   const Key& _Key  
) const;  
```  
  
#### Parameters  
 `_Key`  
 The key value of the elements to be matched from the map.  
  
## Return Value  
 1 if the map contains an element whose sort key matches the parameter key; 0 if the map does not contain an element with a matching key.  
  
## Remarks  
 The member function returns the number of elements *x* in the range  
  
 [`lower_bound` (_*Key* ), `upper_bound` (\_*Key* ) )  
  
 which is 0 or 1 in the case of map, which is a unique associative container.  
  
## Example  
 The following example demonstrates the use of the map::count member function.  
  
```  
// map_count.cpp  
// compile with: /EHsc  
#include <map>  
#include <iostream>  
  
int main()  
{  
    using namespace std;  
    map<int, int> m1;  
    map<int, int>::size_type i;  
    typedef pair<int, int> Int_Pair;  
  
    m1.insert(Int_Pair(1, 1));  
    m1.insert(Int_Pair(2, 1));  
    m1.insert(Int_Pair(1, 4));  
    m1.insert(Int_Pair(2, 1));  
  
    // Keys must be unique in map, so duplicates are ignored  
    i = m1.count(1);  
    cout << "The number of elements in m1 with a sort key of 1 is: "  
         << i << "." << endl;  
  
    i = m1.count(2);  
    cout << "The number of elements in m1 with a sort key of 2 is: "  
         << i << "." << endl;  
  
    i = m1.count(3);  
    cout << "The number of elements in m1 with a sort key of 3 is: "  
         << i << "." << endl;  
}  
```  
  
 **The number of elements in m1 with a sort key of 1 is: 1.**  
**The number of elements in m1 with a sort key of 2 is: 1.**  
**The number of elements in m1 with a sort key of 3 is: 0.**   
## Requirements  
 **Header:** <map\>  
  
 **Namespace:** std  
  
## See Also  
 [map Class](../vs140/map-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)