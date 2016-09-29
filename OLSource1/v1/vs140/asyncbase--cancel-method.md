---
title: "AsyncBase::Cancel Method"
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
  - "async/Microsoft::WRL::AsyncBase::Cancel"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Cancel method"
ms.assetid: 8bfebc63-3848-4629-bc89-aa538ed7e7ad
caps.latest.revision: 7
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AsyncBase::Cancel Method
Cancels an asynchronous operation.  
  
## Syntax  
  
```  
STDMETHOD(  
   Cancel  
)(void);  
```  
  
## Return Value  
 By default, always returns S_OK.  
  
## Remarks  
 Cancel() is a default implementation of IAsyncInfo::Cancel, and does no actual work. To actually cancel an asynchronous operation, override the OnCancel() pure virtual method.  
  
## Requirements  
 **Header:** async.h  
  
 **Namespace:** Microsoft::WRL  
  
## See Also  
 [AsyncBase Class](../vs140/asyncbase-class.md)