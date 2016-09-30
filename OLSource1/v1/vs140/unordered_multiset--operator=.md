---
title: "unordered_multiset::operator="
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
  - "unordered_multiset.operator="
  - "std.tr1.unordered_multiset.operator="
  - "operator="
  - "tr1::unordered_multiset::operator="
  - "unordered_multiset::operator="
  - "std::tr1::unordered_multiset::operator="
  - "tr1.unordered_multiset.operator="
  - "unordered_set/std::tr1::unordered_multiset::operator="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator="
ms.assetid: 20632e0f-a4bc-48c1-966b-adf2bc8cf643
caps.latest.revision: 14
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# unordered_multiset::operator=
Copies a hash table.  
  
## Syntax  
  
```  
unordered_multiset& operator=(  
   const unordered_multiset& _Right  
);  
unordered_multiset& operator=(  
   unordered_multiset&& _Right  
);  
```  
  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|`_Right`|The [unordered_multiset](../vs140/unordered_multiset-class.md) being copied into the `unordered_multiset`.|  
  
## Remarks  
 After erasing any existing elements in an `unordered_multiset`, `operator=` either copies or moves the contents of `_Right` into the `unordered_multiset`.  
  
## Example  
  
```  
// unordered_multiset_operator_as.cpp  
// compile with: /EHsc  
#include <unordered_set>  
#include <iostream>  
  
int main( )  
   {  
   using namespace std;  
   unordered_multiset<int> v1, v2, v3;  
   unordered_multiset<int>::iterator iter;  
  
   v1.insert(10);  
  
   cout << "v1 = " ;  
   for (iter = v1.begin(); iter != v1.end(); iter++)  
      cout << *iter << " ";  
   cout << endl;  
  
   v2 = v1;  
   cout << "v2 = ";  
   for (iter = v2.begin(); iter != v2.end(); iter++)  
      cout << *iter << " ";  
   cout << endl;  
  
// move v1 into v2  
   v2.clear();  
   v2 = move(v1);  
   cout << "v2 = ";  
   for (iter = v2.begin(); iter != v2.end(); iter++)  
      cout << *iter << " ";  
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
 **Header:** <unordered_set>  
  
 **Namespace:** std  
  
## See Also  
 [<unordered_set>](../vs140/-unordered_set-.md)   
 [unordered_multiset](../vs140/unordered_multiset-class.md)