---
title: "map::operator="
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
  - operator=
  - map/std::map::operator=
  - map::operator=
  - map.operator=
  - std.map.operator=
  - std::map::operator=
dev_langs: 
  - C++
helpviewer_keywords: 
  - operator=
ms.assetid: 2188f9e8-fe24-47d8-a24b-620618952b8b
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# map::operator=
Replaces the elements of a map with a copy of another map.  
  
## Syntax  
  
```  
map& operator=(  
   const map& _Right  
);  
map& operator=(  
   map&& _Right  
);  
```  
  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|`_Right`|The [map](../vs140/map-class.md) being copied into the `map`.|  
  
## Remarks  
 After erasing any existing elements in a `map`, `operator=` either copies or moves the contents of `_Right` into the map.  
  
## Example  
  
```  
// map_operator_as.cpp  
// compile with: /EHsc  
#include <map>  
#include <iostream>  
  
int main( )  
   {  
   using namespace std;  
   map<int, int> v1, v2, v3;  
   map<int, int>::iterator iter;  
  
   v1.insert(pair<int, int>(1, 10));  
  
   cout << "v1 = " ;  
   for (iter = v1.begin(); iter != v1.end(); iter++)  
      cout << iter->second << " ";  
   cout << endl;  
  
   v2 = v1;  
   cout << "v2 = ";  
   for (iter = v2.begin(); iter != v2.end(); iter++)  
      cout << iter->second << " ";  
   cout << endl;  
  
// move v1 into v2  
   v2.clear();  
   v2 = move(v1);  
   cout << "v2 = ";  
   for (iter = v2.begin(); iter != v2.end(); iter++)  
      cout << iter->second << " ";  
   cout << endl;  
   }  
```  
  
## Output  
  
```  
v1 = 10   
v2 = 10   
v2 = 10   
```  
  
## Requirements  
 **Header:** <map\>  
  
 **Namespace:** std  
  
## See Also  
 [map Class](../vs140/map-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)