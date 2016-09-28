---
title: "ATLS_DEFAULT_THREADPOOLSHUTDOWNTIMEOUT"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "ATLUTIL/ATLS_DEFAULT_THREADPOOLSHUTDOWNTIMEOUT"
  - "ATLS_DEFAULT_THREADPOOLSHUTDOWNTIMEOUT"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ATLS_DEFAULT_THREADPOOLSHUTDOWNTIMEOUT macro"
ms.assetid: c1e660a7-d490-42af-bbe1-ded76e80cc10
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ATLS_DEFAULT_THREADPOOLSHUTDOWNTIMEOUT
This macro defines the default time in milliseconds that [CThreadPool](../vs140/cthreadpool-class.md) will wait for a thread to shut down.  
  
## Syntax  
  
```  
  
#define ATLS_DEFAULT_THREADPOOLSHUTDOWNTIMEOUT  
  
```  
  
## Remarks  
 The default time is 36 seconds. If necessary, you can define your own positive integer value for this symbol before including atlutil.h.  
  
 To set the timeout at run time or for a particular object, call [CThreadPool::SetTimeout](../vs140/cthreadpool--settimeout.md).  
  
## Requirements  
 **Header:** atlutil.h  
  
## See Also  
 [ATL Concepts](../vs140/active-template-library--atl--concepts.md)   
 [ATL Reference](../vs140/atl-com-desktop-components.md)   
 [ATL Macros Alphabetical Reference](../vs140/atl-macros-alphabetical-reference.md)