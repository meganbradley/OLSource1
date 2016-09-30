---
title: "hash_map::operator="
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
  - "="
  - "operator="
  - "hash_map.operator="
  - "std::hash_map::operator="
  - "hash_map::operator="
  - "std.hash_map.operator="
  - "stdext.hash_map.operator="
  - "hash_map/stdext::hash_map::operator="
  - "stdext::hash_map::operator="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator =, hash_map objects"
  - "= operator, with specific standard C++ objects"
  - "operator=, hash_map objects"
ms.assetid: 942381f6-f801-49d0-ba82-0ef35a956ab2
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_map::operator=
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_map Class](../vs140/unordered_map-class.md).  
  
 Replaces the elements of the hash_map with a copy of another hash_map.  
  
## Syntax  
  
```  
hash_map& operator=(  
   const hash_map& _Right  
);  
hash_map& operator=(  
   hash_map&& _Right  
);  
```  
  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|`_Right`|The [hash_map Class](../vs140/hash_map-class.md) being copied into the `hash_map`.|  
  
## Remarks  
 After erasing any existing elements in a `hash_map`, `operator=` either copies or moves the contents of `_Right` into the `hash_map`.  
  
## Example  
  
```  
// hash_map_operator_as.cpp  
// compile with: /EHsc  
#include <hash_map>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   using namespace stdext;  
   hash_map<int, int> v1, v2, v3;  
   hash_map<int, int>::iterator iter;  
  
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
 **Header:** <hash_map>  
  
 **Namespace:** std  
  
## See Also  
 [hash_map Class](../vs140/hash_map-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)