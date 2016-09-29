---
title: "IDiaSymbol::getSrcLineOnTypeDefn"
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
ms.assetid: ad554d18-9988-4b64-ad71-e7594c266e94
caps.latest.revision: 7
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaSymbol::getSrcLineOnTypeDefn
Retrieves the source file and line number that indicate where a specified user-defined type is defined.  
  
## Syntax  
  
```cpp  
HRESULT getSrcLineOnTypeDefn(  
   IDiaLineNumber **ppResult);  
```  
  
#### Parameters  
 `ppResult`  
 [out] A `IDiaLineNumber` object that contains the source file and line number where the user-defined.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.  
  
## See Also  
 [IDiaSymbol](../vs140/idiasymbol.md)   
 [IDiaLineNumber](../vs140/idialinenumber.md)