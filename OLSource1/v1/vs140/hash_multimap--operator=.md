---
title: "hash_multimap::operator="
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
  - hash_multimap.operator=
  - hash_map/stdext::hash_multimap::operator=
  - stdext::hash_multimap::operator=
  - =
  - operator=
  - stdext.hash_multimap.operator=
  - hash_multimap::operator=
  - std.hash_multimap.operator=
  - std::hash_multimap::operator=
dev_langs: 
  - C++
helpviewer_keywords: 
  - operator=
  - = operator, with specific standard C++ objects
ms.assetid: 0f1d365d-1e19-48e7-89a5-6370e781da39
caps.latest.revision: 13
translation.priority.ht: 
  - de-de
  - ja-jp
---
# hash_multimap::operator=
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multimap Class](../vs140/unordered_multimap-class.md).  
  
 Replaces the elements of the hash_multimap with a copy of another hash_multimap.  
  
## Syntax  
  
```  
hash_multimap& operator=(  
   const hash_multimap& _Right  
);  
hash_multimap& operator=(  
   hash_multimap&& _Right  
);  
```  
  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|`_Right`|The [hash_multimap](../vs140/hash_multimap-class.md) being copied into the `hash_multimap`.|  
  
## Remarks  
 After erasing any existing elements in a `hash_multimap`, `operator=` either copies or moves the contents of `_Right` into the `hash_multimap`.  
  
## Example  
  
```  
// hash_multimap_operator_as.cpp  
// compile with: /EHsc  
#include <hash_multimap>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   using namespace stdext;  
   hash_multimap<int, int> v1, v2, v3;  
   hash_multimap<int, int>::iterator iter;  
  
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
 [hash_multimap Class](../vs140/hash_multimap-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)