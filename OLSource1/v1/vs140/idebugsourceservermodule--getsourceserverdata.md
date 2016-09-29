---
title: "IDebugSourceServerModule::GetSourceServerData"
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
  - "IDebugSourceServerModule::GetSourceServerData"
ms.assetid: f15d86aa-1bd9-4b16-a64a-21b01c27db2e
caps.latest.revision: 13
author: ""
ms.author: "gregvanl"
manager: ""
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugSourceServerModule::GetSourceServerData
Retrieves an array of source server information.  
  
## Syntax  
  
```cpp#  
HRESULT GetSourceServerData(  
   ULONG* pDataByteCount,   
   BYTE** ppData  
);  
```  
  
```c#  
public int GetSourceServerData(  
   out uint  pDataByteCount,   
   out int[] ppData  
);  
```  
  
#### Parameters  
 `pDataByteCount`  
 [out] Number of bytes in the data array.  
  
 `ppData`  
 [out] Reference to the data array.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Example  
 The following example shows how to implement this method for a **CModule** object that exposes the [IDebugSourceServerModule](../vs140/idebugsourceservermodule.md) interface.  
  
```cpp#  
HRESULT CModule::GetSourceServerData(ULONG* pDataByteCount, BYTE** ppData)  
{  
    HRESULT hr = S_OK;  
    CComPtr<ISymUnmanagedReader> pSymReader;  
    CComPtr<ISymUnmanagedSourceServerModule> pSourceServerModule;  
  
    IfFalseGo( pDataByteCount && ppData, E_INVALIDARG );  
    *pDataByteCount = 0;  
    *ppData = NULL;  
  
    IfFailGo( this->GetUnmanagedSymReader( &pSymReader ) );  
    IfFailGo( pSymReader->QueryInterface( &pSourceServerModule ) );  
  
    IfFailGo( pSourceServerModule->GetSourceServerData( pDataByteCount, ppData ) );  
  
Error:  
  
    return hr;  
}  
```  
  
## See Also  
 [IDebugSourceServerModule](../vs140/idebugsourceservermodule.md)