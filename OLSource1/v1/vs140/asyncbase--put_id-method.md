---
title: "AsyncBase::put_Id Method"
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
  - "async/Microsoft::WRL::AsyncBase::put_Id"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "put_Id method"
ms.assetid: aebad85f-4774-42de-b625-a9cf5f65cb4e
caps.latest.revision: 7
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AsyncBase::put_Id Method
Sets the handle of the asynchronous operation.  
  
## Syntax  
  
```  
STDMETHOD(  
   put_Id  
)(const unsigned int id);  
```  
  
#### Parameters  
 `id`  
 A nonzero handle.  
  
## Return Value  
 S_OK if successful; otherwise, E_INVALIDARG or E_ILLEGAL_METHOD_CALL.  
  
## Requirements  
 **Header:** async.h  
  
 **Namespace:** Microsoft::WRL  
  
## See Also  
 [AsyncBase Class](../vs140/asyncbase-class.md)