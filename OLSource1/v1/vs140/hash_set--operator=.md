---
title: "hash_set::operator="
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
  - "stdext::hash_set::operator="
  - "="
  - "operator="
  - "hash_set::operator="
  - "hash_set/stdext::hash_set::operator="
  - "hash_set.operator="
  - "std.hash_set.operator="
  - "stdext.hash_set.operator="
  - "std::hash_set::operator="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "= operator, with specific standard C++ objects"
  - "operator =, hash_set objects"
  - "operator=, hash_set objects"
ms.assetid: e1bfe53e-37f4-499f-8dce-cd16ff537504
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_set::operator=
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_set Class](../vs140/unordered_set-class.md).  
  
 Replaces the elements of the hash_set with a copy of another hash_set.  
  
## Syntax  
  
```  
hash_set& operator=(  
   const hash_set& _Right  
);  
hash_set& operator=(  
   hash_set&& _Right  
);  
```  
  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|`_Right`|The [hash_set](../vs140/hash_set-class.md) being copied into the `hash_set`.|  
  
## Remarks  
 After erasing any existing elements in a `hash_set`, `operator=` either copies or moves the contents of `_Right` into the `hash_set`.  
  
## Example  
  
```  
// hash_set_operator_as.cpp  
// compile with: /EHsc  
#include <hash_set>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   using namespace stdext;  
   hash_set<int> v1, v2, v3;  
   hash_set<int>::iterator iter;  
  
   v1.insert(10);  
  
   cout << "v1 = " ;  
   for (iter = v1.begin(); iter != v1.end(); iter++)  
      cout << iter << " ";  
   cout << endl;  
  
   v2 = v1;  
   cout << "v2 = ";  
   for (iter = v2.begin(); iter != v2.end(); iter++)  
      cout << iter << " ";  
   cout << endl;  
  
// move v1 into v2  
   v2.clear();  
   v2 = move(v1);  
   cout << "v2 = ";  
   for (iter = v2.begin(); iter != v2.end(); iter++)  
      cout << iter << " ";  
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
 **Header:** <hash_set>  
  
 **Namespace:** std  
  
## See Also  
 [hash_set Class](../vs140/hash_set-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)