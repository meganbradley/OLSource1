---
title: "AsyncBase::Close Method"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - async/Microsoft::WRL::AsyncBase::Close
dev_langs: 
  - C++
helpviewer_keywords: 
  - Close method
ms.assetid: a52b1124-754b-4393-b491-64aae0c22f1c
caps.latest.revision: 7
translation.priority.ht: 
  - de-de
  - ja-jp
---
# AsyncBase::Close Method
Closes the asynchronous operation.  
  
## Syntax  
  
```  
STDMETHOD(  
   Close  
)(void) override;  
```  
  
## Return Value  
 S_OK if the operation closes or is already closed; otherwise, E_ILLEGAL_STATE_CHANGE.  
  
## Remarks  
 Close() is a default implementation of IAsyncInfo::Close, and does no actual work. To actually close an asynchronous operation, override the OnClose() pure virtual method.  
  
## Requirements  
 **Header:** async.h  
  
 **Namespace:** Microsoft::WRL  
  
## See Also  
 [AsyncBase Class](../vs140/asyncbase-class.md)