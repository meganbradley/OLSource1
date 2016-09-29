---
title: "unordered_multimap::operator="
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
  - "std::tr1::unordered_multimap::operator="
  - "operator="
  - "tr1.unordered_multimap.operator="
  - "unordered_multimap::operator="
  - "tr1::unordered_multimap::operator="
  - "std.tr1.unordered_multimap.operator="
  - "unordered_map/std::tr1::unordered_multimap::operator="
  - "unordered_multimap.operator="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator="
ms.assetid: c9919b59-3378-4373-80bd-13ca25cf258b
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# unordered_multimap::operator=
Copies a hash table.  
  
## Syntax  
  
```  
unordered_multimap& operator=(  
   const unordered_multimap& _Right  
);  
unordered_multimap& operator=(  
   unordered_multimap&& _Right  
);  
```  
  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|`_Right`|The unordered_multimap being copied into the unordered_multimap.|  
  
## Remarks  
 After erasing any existing elements in a unordered_multimap, `operator=` either copies or moves the contents of `_Right` into the unordered_multimap.  
  
## Example  
  
```  
// unordered_multimap_operator_as.cpp  
// compile with: /EHsc  
#include <unordered_multimap>  
#include <iostream>  
  
int main( )  
   {  
   using namespace std;  
   unordered_multimap<int, int> v1, v2, v3;  
   unordered_multimap<int, int>::iterator iter;  
  
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
 **Header:** <unordered_multimap>  
  
 **Namespace:** std  
  
## See Also  
 [<unordered_map>](../vs140/-unordered_map-.md)   
 [unordered_multimap Class](../vs140/unordered_multimap-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)