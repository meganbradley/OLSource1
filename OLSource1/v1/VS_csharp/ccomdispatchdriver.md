---
title: "CComDispatchDriver"
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
  - "CComDispatchDriver"
  - "ATLCOMCLI/CComDispatchDriver"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CComDispatchDriver typedef"
ms.assetid: 3c1171f6-0f5b-439d-bd5f-30e8ac5a7245
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComDispatchDriver
This class manages COM interface pointers.  
  
## Syntax  
  
```  
  
typedef CComQIPtr<IDispatch, &__uuidof(IDispatch)> CComDispatchDriver;  
  
```  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [Typedefs](../VS_csharp/atl-typedefs.md)   
 [CComQIPtr Class](../VS_csharp/ccomqiptr-class.md)