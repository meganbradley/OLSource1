---
title: "unordered_set::operator="
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
  - unordered_set.operator=
  - tr1.unordered_set.operator=
  - unordered_set::operator=
  - unordered_set/std::tr1::unordered_set::operator=
  - std.tr1.unordered_set.operator=
  - tr1::unordered_set::operator=
  - std::tr1::unordered_set::operator=
dev_langs: 
  - C++
helpviewer_keywords: 
  - operator=
ms.assetid: 1998bf3e-bd37-4430-aed3-0265488777fc
caps.latest.revision: 13
translation.priority.mt: 
  - de-de
  - ja-jp
---
# unordered_set::operator=
Copies a hash table.  
  
## Syntax  
  
```  
unordered_set& operator=(  
   const unordered_set& _Right  
);  
unordered_set& operator=(  
   unordered_set&& _Right  
);  
```  
  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|`_Right`|The [unordered_set](../vs140/unordered_set-class.md) being copied into the `unordered_set`.|  
  
## Remarks  
 After erasing any existing elements in an `unordered_set`, `operator=` either copies or moves the contents of `_Right` into the `unordered_set`.  
  
## Example  
  
```  
// unordered_set_operator_as.cpp  
// compile with: /EHsc  
#include <unordered_set>  
#include <iostream>  
  
int main( )  
   {  
   using namespace std;  
   unordered_set<int> v1, v2, v3;  
   unordered_set<int>::iterator iter;  
  
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
 [unordered_set](../vs140/unordered_set-class.md)