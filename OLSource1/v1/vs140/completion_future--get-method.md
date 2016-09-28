---
title: "completion_future::get Method"
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
  - "amprt/Concurrency::completion_future::get"
dev_langs: 
  - "C++"
ms.assetid: edfee0c5-cfdc-45fc-b115-e15057b1bb74
caps.latest.revision: 8
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# completion_future::get Method
Waits until the associated asynchronous operation completes. Throws the stored exception if one was encountered during the asynchronous operation.  
  
## Syntax  
  
```  
void get() const;  
```  
  
## Requirements  
 **Header:** amprt.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [completion_future Class](../vs140/completion_future-class.md)