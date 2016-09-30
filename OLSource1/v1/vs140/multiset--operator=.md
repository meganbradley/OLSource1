---
title: "multiset::operator="
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
  - "set/std::multiset::operator="
  - "operator="
  - "multiset::operator="
  - "multiset.operator="
  - "std.multiset.operator="
  - "std::multiset::operator="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator="
ms.assetid: 59be0f0d-fd1d-4bf0-838b-b21307e247c0
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# multiset::operator=
Replaces the elements of this `multiset` using elements from another `multiset`.  
  
## Syntax  
  
```  
multiset& operator=(  
   const multiset& _Right  
);  
multiset& operator=(  
   multiset&& _Right  
);  
```  
  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|`_Right`|The `multiset` from which elements are copied or moved.|  
  
## Remarks  
 `operator=` copies or moves the elements in `_Right` into this `multiset`, depending on the reference type (lvalue or rvalue) used. Elements that are in this `multiset` before `operator=` executes are discarded.  
  
## Example  
  
```  
// multiset_operator_as.cpp  
// compile with: /EHsc  
#include <multiset>  
#include <iostream>  
  
int main( )  
   {  
   using namespace std;  
   multiset<int> v1, v2, v3;  
   multiset<int>::iterator iter;  
  
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
 **Header:** \<multiset>  
  
 **Namespace:** std  
  
## See Also  
 [multiset Class](../vs140/multiset-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)