---
title: "AsyncBase::get_Status Method"
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
  - "async/Microsoft::WRL::AsyncBase::get_Status"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "get_Status method"
ms.assetid: 9823ecb9-212e-471d-b76f-7b8f21208905
caps.latest.revision: 7
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AsyncBase::get_Status Method
Retrieves a value that indicates the status of the asynchronous operation.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The location where the status is to be stored. For more information, see Windows::Foundation::AsyncStatus enumeration.  
  
## Return Value  
 S_OK if successful; otherwise, E_ILLEGAL_METHOD_CALL.  
  
## Remarks  
 This method implements IAsyncInfo::get_Status.  
  
## Requirements  
 **Header:** async.h  
  
 **Namespace:** Microsoft::WRL  
  
## See Also  
 [AsyncBase Class](../vs140/asyncbase-class.md)