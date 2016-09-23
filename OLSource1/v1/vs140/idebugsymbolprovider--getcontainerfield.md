---
title: "IDebugSymbolProvider::GetContainerField"
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
  - IDebugSymbolProvider::GetContainerField
helpviewer_keywords: 
  - IDebugSymbolProvider::GetContainerField method
ms.assetid: d6b56b4f-a96b-4fa7-87c1-bac4e58fa766
caps.latest.revision: 15
translation.priority.mt: 
  - de-de
  - ja-jp
---
# IDebugSymbolProvider::GetContainerField
This method gets the field that contains the debug address.  
  
## Syntax  
  
```cpp#  
HRESULT GetContainerField(   
   IDebugAddress*         pAddress,  
   IDebugContainerField** ppContainerField  
);  
```  
  
```c#  
int GetContainerField(  
   IDebugAddress            pAddress,   
   out IDebugContainerField ppContainerField  
);  
```  
  
#### Parameters  
 `pAddress`  
 [in] The address as represented by an [IDebugAddress](../vs140/idebugaddress.md) interface.  
  
 `ppContainerField`  
 [out] Returns a container field represented by an [IDebugContainerField](../vs140/idebugcontainerfield.md) interface.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDebugSymbolProvider](../vs140/idebugsymbolprovider.md)   
 [IDebugAddress](../vs140/idebugaddress.md)   
 [IDebugContainerField](../vs140/idebugcontainerfield.md)