---
title: "multimap::operator="
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
  - "multimap::operator="
  - "operator="
  - "std::multimap::operator="
  - "std.multimap.operator="
  - "map/std::multimap::operator="
  - "multimap.operator="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator="
ms.assetid: f670a97a-ef3c-4629-b4df-e6395227259f
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# multimap::operator=
Replaces the elements of a multimap with a copy of another multimap.  
  
## Syntax  
  
```  
multimap& operator=(  
   const multimap& _Right  
);  
multimap& operator=(  
   multimap&& _Right  
);  
```  
  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|`_Right`|The [multimap](../vs140/multimap-class.md) being copied into the `multimap`.|  
  
## Remarks  
 After erasing any existing elements in a `multimap`, `operator=` either copies or moves the contents of `_Right` into the `multimap`.  
  
## Example  
  
```  
// multimap_operator_as.cpp  
// compile with: /EHsc  
#include <map>  
#include <iostream>  
  
int main( )  
   {  
   using namespace std;  
   multimap<int, int> v1, v2, v3;  
   multimap<int, int>::iterator iter;  
  
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
 **Header:** \<map>  
  
 **Namespace:** std  
  
## See Also  
 [multimap Class](../vs140/multimap-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)