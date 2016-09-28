---
title: "AsyncBase::PutOnComplete Method"
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
  - "async/Microsoft::WRL::AsyncBase::PutOnComplete"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "PutOnComplete method"
ms.assetid: 1c469ff9-b2df-4637-bf05-01a617043149
caps.latest.revision: 7
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AsyncBase::PutOnComplete Method
Sets the address of the completion event handler to the specified value.  
  
## Syntax  
  
```  
STDMETHOD(  
   PutOnComplete  
)(TComplete* completeHandler);  
```  
  
#### Parameters  
 `completeHandler`  
 The address to which the completion event handler is set.  
  
## Return Value  
 S_OK if successful; otherwise, E_ILLEGAL_METHOD_CALL.  
  
## Requirements  
 **Header:** async.h  
  
 **Namespace:** Microsoft::WRL  
  
## See Also  
 [AsyncBase Class](../vs140/asyncbase-class.md)