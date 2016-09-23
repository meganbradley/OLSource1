---
title: "IDebugPort2::GetPortName"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-sdk
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - IDebugPort2::GetPortName
helpviewer_keywords: 
  - IDebugPort2::GetPortName
ms.assetid: 4478b3d5-aa30-4105-8d05-e3bae2f8917a
caps.latest.revision: 14
translation.priority.mt: 
  - de-de
  - ja-jp
---
# IDebugPort2::GetPortName
Gets the port name.  
  
## Syntax  
  
```cpp#  
HRESULT GetPortName(   
   BSTR* pbstrName  
);  
```  
  
```c#  
int GetPortName(   
   out string pbstrName  
);  
```  
  
#### Parameters  
 `pbstrName`  
 [out] Returns the name of the port.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDebugPort2](../vs140/idebugport2.md)