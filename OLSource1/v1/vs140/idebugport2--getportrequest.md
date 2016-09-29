---
title: "IDebugPort2::GetPortRequest"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "IDebugPort2::GetPortRequest"
helpviewer_keywords: 
  - "IDebugPort2::GetPortRequest"
ms.assetid: 14abf847-0675-4fa8-872e-971e00c84224
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugPort2::GetPortRequest
Gets the description of a port that was previously used to create the port (if available).  
  
## Syntax  
  
```cpp#  
HRESULT GetPortRequest(   
   IDebugPortRequest2** ppRequest  
);  
```  
  
```c#  
int GetPortRequest(   
   out IDebugPortRequest2 ppRequest  
);  
```  
  
#### Parameters  
 `ppRequest`  
 [out] Returns an [IDebugPortRequest2](../vs140/idebugportrequest2.md) object representing the request that was used to create the port.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  Returns `E_PORT_NO_REQUEST` if a port was not created using an [IDebugPortRequest2](../vs140/idebugportrequest2.md) port request.  
  
## See Also  
 [IDebugPort2](../vs140/idebugport2.md)   
 [IDebugPortRequest2](../vs140/idebugportrequest2.md)   
 [AddPort](../vs140/idebugportsupplier2--addport.md)