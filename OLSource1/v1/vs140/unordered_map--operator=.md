---
title: "unordered_map::operator="
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
  - "std.tr1.unordered_map.operator="
  - "unordered_map/std::tr1::unordered_map::operator="
  - "operator="
  - "unordered_map::operator="
  - "unordered_map.operator="
  - "std::tr1::unordered_map::operator="
  - "tr1.unordered_map.operator="
  - "tr1::unordered_map::operator="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator="
ms.assetid: 13422034-b578-468c-9324-bcd4deb52882
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# unordered_map::operator=
Replaces the elements of this unordered_map using the elements from another unordered_map.  
  
## Syntax  
  
```  
unordered_map& operator=(  
   const unordered_map& _Right  
);  
unordered_map& operator=(  
   unordered_map&& _Right  
);  
```  
  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|`_Right`|The unordered_map that the operator function assigns content from.|  
  
## Remarks  
 The first version copies all of the elements from `_Right` to this unordered_map.  
  
 The second version moves all of the elements from `_Right` to this unordered_map.  
  
 Any elements that are in this unordered_map before `operator`= executes are discarded.  
  
## Example  
  
```  
// unordered_map_operator_as.cpp  
// compile with: /EHsc  
#include <unordered_map>  
#include <iostream>  
  
int main( )  
   {  
   using namespace std;  
   unordered_map<int, int> v1, v2, v3;  
   unordered_map<int, int>::iterator iter;  
  
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
 **Header:** <unordered_map>  
  
 **Namespace:** std  
  
## See Also  
 [<unordered_map>](../vs140/-unordered_map-.md)   
 [unordered_map](../vs140/unordered_map-class.md)