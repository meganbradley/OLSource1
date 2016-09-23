---
title: "IDiaSymbol::findInlineFramesByRVA"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-debug
ms.tgt_pltfrm: na
ms.topic: article
dev_langs: 
  - C++
ms.assetid: e7a6d9cb-2726-4ac7-9f38-415ad215bf9c
caps.latest.revision: 7
translation.priority.ht: 
  - de-de
  - ja-jp
---
# IDiaSymbol::findInlineFramesByRVA
Retrieves an enumeration that allows a client to iterate through all of the inline frames on a specified relative virtual address (RVA).  
  
## Syntax  
  
```cpp#  
HRESULT findInlineFramesByRVA (    DWORD             rva,  
   IDiaEnumSymbols** ppResult  
);  
```  
  
#### Parameters  
 `rva`  
 [in] Specifies the address as an RVA.  
  
 `ppResult`  
 [out] Holds an `IDiaEnumSymbols` object that contains the list of frames that are retrieved.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDiaSession](../vs140/idiasession.md)   
 [IDiaSymbol](../vs140/idiasymbol.md)   
 [SymTagEnum Enumeration](../vs140/symtagenum.md)   
 [IDiaEnumSymbols](../vs140/idiaenumsymbols.md)