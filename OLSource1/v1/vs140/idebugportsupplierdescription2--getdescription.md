---
title: "IDebugPortSupplierDescription2::GetDescription"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "IDebugPortSupplierDescription2::GetDescription"
ms.assetid: bff5f536-1cd1-4313-8856-db7b05818305
caps.latest.revision: 12
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugPortSupplierDescription2::GetDescription
Retrieves the description and description metadata for the port supplier.  
  
## Syntax  
  
```cpp#  
HRESULT GetDescription(  
   PORT_SUPPLIER_DESCRIPTION_FLAGS *pdwFlags,  
   BSTR *pbstrText  
);  
```  
  
```c#  
public int GetDescription(  
   out enum_PORT_SUPPLIER_DESCRIPTION_FLAGS pdwFlags,  
   out string pbstrText  
);  
```  
  
#### Parameters  
 `pdwFlags`  
 [out] Metadata flags for the description.  
  
 `pbstrText`  
 [out] Description of the port supplier.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDebugPortSupplierDescription2](../vs140/idebugportsupplierdescription2.md)