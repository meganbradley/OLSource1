---
title: "IDebugSymbolProvider::GetClassTypeByName"
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
  - "IDebugSymbolProvider::GetClassTypeByName"
helpviewer_keywords: 
  - "IDebugSymbolProvider::GetClassTypeByName method"
ms.assetid: 2c748909-51dc-49b7-b193-19f96fca1138
caps.latest.revision: 15
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugSymbolProvider::GetClassTypeByName
This method gets the class field type representing a fully qualified class name.  
  
## Syntax  
  
```cpp#  
HRESULT GetClassTypeByName(   
   LPCOLESTR          pszClassName,  
   NAME_MATCH         nameMatch,  
   IDebugClassField** ppField  
);  
```  
  
```c#  
int GetClassTypeByName(  
   string               pszClassName,   
   NAME_MATCH           nameMatch,   
   out IDebugClassField ppField  
);  
```  
  
#### Parameters  
 `pszClassName`  
 [in] The class name.  
  
 `nameMatch`  
 [in] Selects the type of match, for example, case-sensitive. A value from the [NAME_MATCH](../vs140/name_match.md) enumeration.  
  
 `ppField`  
 [out] Returns the class type as represented by the [IDebugClassField](../vs140/idebugclassfield.md) interface.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDebugSymbolProvider](../vs140/idebugsymbolprovider.md)   
 [NAME_MATCH](../vs140/name_match.md)   
 [IDebugClassField](../vs140/idebugclassfield.md)