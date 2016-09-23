---
title: "AsyncBase::PutOnProgress Method"
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
  - async/Microsoft::WRL::AsyncBase::PutOnProgress
dev_langs: 
  - C++
helpviewer_keywords: 
  - PutOnProgress method
ms.assetid: 1f5f180e-eb5a-4afe-ac16-69dbf36f0383
caps.latest.revision: 7
translation.priority.ht: 
  - de-de
  - ja-jp
---
# AsyncBase::PutOnProgress Method
Sets the address of the progress event handler to the specified value.  
  
## Syntax  
  
```  
STDMETHOD(  
   PutOnProgress  
)(TProgress* progressHandler);  
```  
  
#### Parameters  
 `progressHandler`  
 The address to which the progress event handler is set.  
  
## Return Value  
 S_OK if successful; otherwise, E_ILLEGAL_METHOD_CALL.  
  
## Requirements  
 **Header:** async.h  
  
 **Namespace:** Microsoft::WRL  
  
## See Also  
 [AsyncBase Class](../vs140/asyncbase-class.md)