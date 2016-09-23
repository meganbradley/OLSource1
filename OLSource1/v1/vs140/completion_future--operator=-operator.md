---
title: "completion_future::operator= Operator"
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
  - amprt/Concurrency::completion_future::operator=
dev_langs: 
  - C++
ms.assetid: ecaf56c3-b0f6-4432-a782-f3e71fc68f58
caps.latest.revision: 8
translation.priority.ht: 
  - de-de
  - ja-jp
---
# completion_future::operator= Operator
Copies the contents of the specified `completion_future` object into this one.  
  
## Syntax  
  
```  
completion_future& operator=(  
   const completion_future& _Other  
);  
  
completion_future& operator=(  
   completion_future&& _Other  
);  
```  
  
#### Parameters  
 `_Other`  
 The object to copy from.  
  
## Return Value  
 A reference to this `completion_future` object.  
  
## Overloads List  
  
|Name|Description|  
|----------|-----------------|  
|`completion_future& operator=(const completion_future& _Other);`|Copies the contents of the specified `completion_future` object into this one, using a deep copy.|  
|`completion_future& operator=(completion_future&& _Other);`|Copies the contents of the specified `completion_future` object into this one, using a move assignment.|  
  
## Requirements  
 **Header:** amprt.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [completion_future Class](../vs140/completion_future-class.md)