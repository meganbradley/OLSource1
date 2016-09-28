---
title: "IDiaSession::findSymbolsByRVAForAcceleratorPointerTag"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
ms.assetid: a073cc45-0c7b-417e-b5fc-a3b08beccdbc
caps.latest.revision: 7
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaSession::findSymbolsByRVAForAcceleratorPointerTag
Given a corresponding tag value, this method returns an enumeration of symbols that are contained in a specified parent Accelerator stub function at a specified relative virtual address.  
  
## Syntax  
  
```cpp#  
HRESULT findSymbolsByRVAForAcceleratorPointerTag (   
   IDiaSymbol*           parent,  
   DWORD                 tagValue,  
   DWORD                 rva,  
   IDiaEnumSymbols**     ppResult  
);  
```  
  
#### Parameters  
 `parent`  
 [in] An `IDiaSymbol` that corresponds to the Accelerator stub function to be searched.  
  
 `tagValue`  
 [in] The pointer tag value.  
  
 `rva`  
 [in] The relative virtual address.  
  
 `ppResult`  
 [out] A pointer to an `IDiaEnumSymbols` interface pointer that is initialized with the result.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 Call this method only on an `IDiaSymbol` interface that corresponds to an Accelerator stub function.  
  
## See Also  
 [IDiaSession](../vs140/idiasession.md)   
 [IDiaEnumSymbols](../vs140/idiaenumsymbols.md)   
 [IDiaSymbol](../vs140/idiasymbol.md)