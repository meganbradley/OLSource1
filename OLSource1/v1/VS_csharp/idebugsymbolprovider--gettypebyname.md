---
title: "IDebugSymbolProvider::GetTypeByName"
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
  - "IDebugSymbolProvider::GetTypeByName"
helpviewer_keywords: 
  - "IDebugSymbolProvider::GetTypeByName method"
ms.assetid: b9d88d3b-8b75-484a-b9cc-dc8c0fbb4bc8
caps.latest.revision: 15
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugSymbolProvider::GetTypeByName
This method maps a symbol name to a symbol type.  
  
## Syntax  
  
```cpp#  
HRESULT GetTypeByName(   
   LPCOLESTR     pszClassName,  
   NAME_MATCH    nameMatch,  
   IDebugField** ppField  
);  
```  
  
```c#  
int GetTypeByName(  
   string          pszClassName,   
   NAME_MATCH      nameMatch,   
   out IDebugField ppField  
);  
```  
  
#### Parameters  
 `pszClassName`  
 [in] The symbol name.  
  
 `nameMatch`  
 [in] Selects the type of match, for example, case-sensitive. A value from the [NAME_MATCH](../VS_csharp/name_match.md) enumeration.  
  
 `ppField`  
 [out] Returns the symbol type as an [IDebugField](../VS_csharp/idebugfield.md) object.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 This method is a generic version of [IDebugSymbolProvider::GetClassTypeByName](../VS_csharp/idebugsymbolprovider--getclasstypebyname.md).  
  
## See Also  
 [IDebugSymbolProvider](../VS_csharp/idebugsymbolprovider.md)   
 [IDebugField](../VS_csharp/idebugfield.md)   
 [NAME_MATCH](../VS_csharp/name_match.md)   
 [IDebugSymbolProvider::GetClassTypeByName](../VS_csharp/idebugsymbolprovider--getclasstypebyname.md)