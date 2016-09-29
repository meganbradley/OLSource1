---
title: "IDebugCoreServer3::GetServerName"
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
  - "IDebugCoreServer3::GetServerName"
helpviewer_keywords: 
  - "IDebugCoreServer3::GetServerName"
ms.assetid: 0fc3fcf5-d6a3-4a00-bf14-458b8645714e
caps.latest.revision: 12
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugCoreServer3::GetServerName
Retrieves the name of the server.  
  
## Syntax  
  
```cpp#  
HRESULT GetServerName(  
   BSTR* pbstrName  
);  
```  
  
```c#  
int GetServerName(  
   out string pbstrName  
);  
```  
  
#### Parameters  
 `pbstrName`  
 [out] Returns the name of the server.  
  
> [!NOTE]
>  The caller is responsible for freeing the string.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns error code.  
  
## Remarks  
 For a friendly server name, call the [IDebugCoreServer3::GetServerFriendlyName](../VS_csharp/idebugcoreserver3--getserverfriendlyname.md) method.  
  
## See Also  
 [IDebugCoreServer3](../VS_csharp/idebugcoreserver3.md)   
 [IDebugCoreServer3::GetServerFriendlyName](../VS_csharp/idebugcoreserver3--getserverfriendlyname.md)