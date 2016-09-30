---
title: "list::operator="
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
  - "operator="
  - "std::list::operator="
  - "list/std::list::operator="
  - "list.operator="
  - "list::operator="
  - "std.list.operator="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator="
ms.assetid: c4e4f312-8a93-4366-8df6-fc78a499d250
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# list::operator=
Replaces the elements of the list with a copy of another list.  
  
## Syntax  
  
```  
list& operator=(  
   const list& _Right  
);  
list& operator=(  
   list&& _Right  
);  
```  
  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|`_Right`|The [list](../vs140/list-class.md) being copied into the `list`.|  
  
## Remarks  
 After erasing any existing elements in a `list`, the operator either copies or moves the contents of `_Right` into the `list`.  
  
## Example  
  
```  
// list_operator_as.cpp  
// compile with: /EHsc  
#include <list>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   list<int> v1, v2, v3;  
   list<int>::iterator iter;  
  
   v1.push_back(10);  
   v1.push_back(20);  
   v1.push_back(30);  
   v1.push_back(40);  
   v1.push_back(50);  
  
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
   v2 = forward< list<int> >(v1);  
   cout << "v2 = ";  
   for (iter = v2.begin(); iter != v2.end(); iter++)  
      cout << *iter << " ";  
   cout << endl;  
}  
```  
  
## Output  
  
```  
v1 = 10 20 30 40 50   
v2 = 10 20 30 40 50   
v2 = 10 20 30 40 50   
```  
  
## Requirements  
 **Header:** \<list>  
  
 **Namespace:** std  
  
## See Also  
 [list Class](../vs140/list-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)