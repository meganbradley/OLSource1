---
title: "completion_future::completion_future Constructor"
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
  - "amprt/Concurrency::completion_future::completion_future"
dev_langs: 
  - "C++"
ms.assetid: 472755a4-baa2-4892-836b-9ff4b80747dc
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# completion_future::completion_future Constructor
Initializes a new instance of the `completion_future` class.  
  
## Syntax  
  
```  
completion_future();  
  
completion_future(  
   const completion_future& _Other  
);  
  
completion_future(  
   completion_future&& _Other  
);  
```  
  
#### Parameters  
 `_Other`  
 The `completion_future` object to copy or move.  
  
## Overloads List  
  
|Name|Description|  
|----------|-----------------|  
|`completion_future();`|Initializes a new instance of the `completion_future` Class|  
|`completion_future(const completion_future& _Other);`|Initializes a new instance of the `completion_future` class by copying a constructor.|  
|`completion_future(completion_future&& _Other);`|Initializes a new instance of the `completion_future` class by moving a constructor.|  
  
## Requirements  
 **Header:** amprt.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [completion_future Class](../vs140/completion_future-class.md)