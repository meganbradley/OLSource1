---
title: "IDebugSymbolProvider::GetNextAddress"
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
  - "IDebugSymbolProvider::GetNextAddress"
helpviewer_keywords: 
  - "IDebugSymbolProvider::GetNextAddress method"
ms.assetid: 704eeb94-cb13-49d1-82b6-7d83ed0f19c0
caps.latest.revision: 12
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugSymbolProvider::GetNextAddress
Gets the debug address that follows a given debug address in a method.  
  
## Syntax  
  
```cpp#  
HRESULT GetNextAddress(   
   IDebugAddress*  pAddress,  
   BOOL            fStatementOnly,  
   IDebugAddress** ppAddress  
);  
```  
  
```c#  
int GetNextAddress(   
   IDebugAddress     pAddress,  
   bool              fStatementOnly,  
   out IDebugAddress ppAddress  
);  
```  
  
#### Parameters  
 `pAddress`  
 [in] Given debug address.  
  
 `fStatementOnly`  
 [in] If TRUE, limits the debug addresses to a single statement.  
  
 `ppAddress`  
 [out] Returns the next debug address.  
  
## Return Value  
 Returns a valid `HRESULT`, typically S_OK.  
  
## See Also  
 [IDebugSymbolProvider](../VS_csharp/idebugsymbolprovider.md)