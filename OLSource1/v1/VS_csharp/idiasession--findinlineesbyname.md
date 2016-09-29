---
title: "IDiaSession::findInlineesByName"
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
ms.assetid: 9860336d-f703-4ecb-bfc4-3f5beb175a76
caps.latest.revision: 7
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaSession::findInlineesByName
Retrieves an enumeration that allows a client to iterate through the line number information of all inlined functions that match a specified name.  
  
## Syntax  
  
```cpp#  
HRESULT findInlineesByName (   
   LPCOLESTR             name,  
   DWORD                 option,  
   IDiaEnumLineNumbers** ppResult  
);  
```  
  
#### Parameters  
 `name`  
 [in] Specifies the name to use for comparison.  
  
 `option`  
 [in] Specifies the comparison options applied to name searching. Values from the [NameSearchOptions Enumeration](../VS_csharp/namesearchoptions.md) enumeration can be used alone or in combination.  
  
 `ppResult`  
 [out] Returns an [IDiaEnumLineNumbers](../VS_csharp/idiaenumlinenumbers.md) object that contains a list of the line numbers that were retrieved.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDiaSession](../VS_csharp/idiasession.md)   
 [IDiaSourceFile](../VS_csharp/idiasourcefile.md)   
 [IDiaSymbol](../VS_csharp/idiasymbol.md)   
 [SymTagEnum Enumeration](../VS_csharp/symtagenum.md)   
 [IDiaEnumLineNumbers](../VS_csharp/idiaenumlinenumbers.md)