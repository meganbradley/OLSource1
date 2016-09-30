---
title: "RaiseException Function"
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
  - "internal/Microsoft::WRL::Details::RaiseException"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "RaiseException function"
ms.assetid: f9c74f6d-112a-4d2e-900f-622f795d5dbf
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# RaiseException Function
Supports the WRL infrastructure and is not intended to be used directly from your code.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The exception code of the exception being raised; that is, the HRESULT of a failed operation.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A flag that indicates a continuable exception (the flag value is zero), or noncontinuable exception (flag value is nonzero). By default, the exception is noncontinuable.  
  
## Remarks  
 Raises an exception in the calling thread.  
  
 For more information, see the Windows **RaiseException** function.  
  
## Requirements  
 **Header:** internal.h  
  
 **Namespace:** Microsoft::WRL::Details  
  
## See Also  
 [Microsoft::WRL::Details Namespace](../vs140/microsoft--wrl--details-namespace.md)