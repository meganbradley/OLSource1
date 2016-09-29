---
title: "IDiaSession::symbolById"
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
helpviewer_keywords: 
  - "IDiaSession::symbolById method"
ms.assetid: 062e4b5a-9c4d-4703-88da-ec13102c2b66
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaSession::symbolById
Retrieves a symbol by its unique identifier.  
  
## Syntax  
  
```cpp#  
HRESULT symbolById (   
   DWORD        id,  
   IDiaSymbol** ppSymbol  
);  
```  
  
#### Parameters  
 `id`  
 [in] Unique identifier.  
  
 `ppSymbol`  
 [out] Returns an [IDiaSymbol](../vs140/idiasymbol.md) object that represents the symbol retrieved.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 The specified identifier is a unique value used internally by the DIA SDK to make all symbols unique.  
  
 This method can be used, for example, to retrieve the symbol representing the type of another symbol (see the example).  
  
## Example  
 This example retrieves an [IDiaSymbol](../vs140/idiasymbol.md) representing the type of another symbol. This example shows how to use the `symbolById` method in the session. A simpler approach is to call the [IDiaSymbol::get_type](../vs140/idiasymbol--get_type.md) method to retrieve the type symbol directly.  
  
```cpp#  
IDiaSymbol *GetSymbolType(IDiaSymbol *pSymbol, IDiaSession *pSession)  
{  
    IDiaSymbol *pTypeSymbol = NULL;  
    if (pSymbol != NULL && pSession != NULL)  
    {  
        DWORD symbolTypeId;  
        pSymbol->get_typeId(&symbolTypeId);  
        pSession->symbolById(symbolTypeId, &pTypeSymbol);  
    }  
    return(pTypeSymbol);  
}  
```  
  
## See Also  
 [IDiaSession](../vs140/idiasession.md)   
 [IDiaSymbol](../vs140/idiasymbol.md)   
 [IDiaSymbol::get_type](../vs140/idiasymbol--get_type.md)