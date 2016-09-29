---
title: "IDiaSymbol::findInlineeLines"
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
ms.assetid: 56ba4bc0-8f96-47c2-8b18-332b4e7c2d91
caps.latest.revision: 7
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaSymbol::findInlineeLines
Retrieves an enumeration that allows a client to iterate through the line number information of all functions that are inlined, directly or indirectly, in this symbol.  
  
## Syntax  
  
```cpp#  
HRESULT findInlineeLines (   
   IDiaEnumLineNumbers** ppResult  
);  
```  
  
#### Parameters  
 `ppResult`  
 [out] Holds an `IDiaEnumLineNumbers` object that contains the list of line numbers that are retrieved.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDiaSession](../VS_csharp/idiasession.md)   
 [IDiaSymbol](../VS_csharp/idiasymbol.md)   
 [SymTagEnum Enumeration](../VS_csharp/symtagenum.md)   
 [IDiaEnumLineNumbers](../VS_csharp/idiaenumlinenumbers.md)   
 [IDiaSession::findInlineeLines](../VS_csharp/idiasession--findinlineelines.md)