---
title: "IDiaSession::put_loadAddress"
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
  - "IDiaSession::put_loadAddress method"
ms.assetid: b157b245-1ea0-4b80-8962-d8b278dbc742
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaSession::put_loadAddress
Sets the load address for the executable file that corresponds to the symbols in this symbol store.  
  
## Syntax  
  
```cpp#  
HRESULT put_loadAddress (   
   ULONGLONG NewVal  
);  
```  
  
#### Parameters  
 `NewVal`  
 [in] Load address for the executable file.  
  
## Remarks  
 Symbol virtual address (VA) properties are computed using the value of this method. Virtual addresses are not calculated unless this property is set to non-zero.  
  
> [!NOTE]
>  You must call this method when you get the [IDiaSession](../vs140/idiasession.md) object and before you start using the object if you need to use any virtual properties on symbols.  
  
## See Also  
 [IDiaSession](../vs140/idiasession.md)