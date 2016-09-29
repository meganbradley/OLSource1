---
title: "SYNC_DEFAULT (&lt;allocators&gt;)"
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
  - "allocators/stdext::SYNC_DEFAULT"
  - "SYNC_DEFAULT"
  - "stdext.SYNC_DEFAULT"
  - "stdext::SYNC_DEFAULT"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SYNC_DEFAULT macro"
ms.assetid: 6a29d144-7cb0-4c28-adfc-8451676ccffc
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# SYNC_DEFAULT (&lt;allocators&gt;)
Yields a synchronization filter.  
  
## Syntax  
  
```  
#define SYNC_DEFAULT <sync_template>  
```  
  
## Remarks  
 If a compiler supports compiling both single-threaded and multi-threaded applications, for single-threaded applications the macro yields `stdext::allocators::sync_none`; in all other cases it yields `stdext::allocators::sync_shared`.  
  
## Requirements  
 **Header:** \<allocators>  
  
 **Namespace:** stdext  
  
## See Also  
 [\<allocators>](../vs140/-allocators-.md)