---
title: "CComSimpleThreadAllocator::GetThread"
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
  - "CComSimpleThreadAllocator.GetThread"
  - "GetThread"
  - "ATL::CComSimpleThreadAllocator::GetThread"
  - "ATL.CComSimpleThreadAllocator.GetThread"
  - "CComSimpleThreadAllocator::GetThread"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetThread method"
ms.assetid: 81aa8c8c-ea71-42f1-876f-0a5b6689bff9
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComSimpleThreadAllocator::GetThread
Selects a thread by specifying the next thread in the sequence.  
  
## Syntax  
  
```  
  
      int GetThread(  
   CComApartment* /* pApt */,  
   int nThreads   
);  
```  
  
#### Parameters  
 `pApt`  
 Not used in ATL's default implementation.  
  
 `nThreads`  
 The maximum number of threads in the EXE module.  
  
## Return Value  
 An integer between zero and (`nThreads` – 1). Identifies one of the threads in the EXE module.  
  
## Remarks  
 You can override `GetThread` to provide a different method of selection or to make use of the `pApt` parameter.  
  
 `GetThread` is called by [CComAutoThreadModule::CreateInstance](../vs140/ccomautothreadmodule--createinstance.md).  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CComSimpleThreadAllocator Class](../vs140/ccomsimplethreadallocator-class.md)   
 [CComApartment Class](../vs140/ccomapartment-class.md)