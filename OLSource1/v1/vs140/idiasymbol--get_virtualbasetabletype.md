---
title: "IDiaSymbol::get_virtualBaseTableType"
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
  - "IDiaSymbol::get_virtualBaseTableType method"
ms.assetid: e0581c4f-0343-49b5-9754-a48477460e9f
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaSymbol::get_virtualBaseTableType
Retrieves the type of a virtual base table pointer.  
  
## Syntax  
  
```cpp#  
HRESULT get_virtualBaseTableType(  
   IDiaSymbol *pRetVal  
};  
```  
  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|`pRetVal`|[out] Returns an [IDiaSymbol](../vs140/idiasymbol.md) object that specifies the type of base table.|  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.  
  
> [!NOTE]
>  A return value of `S_FALSE` means the property is not available for the symbol.  
  
## Remarks  
 A virtual base table pointer (`vbtptr`) is a hidden pointer in a [!INCLUDE[vcprvc](../vs140/includes/vcprvc_md.md)] vtable that handles inheritance from virtual base classes. A `vbtptr` can have different sizes depending on the inherited classes.  
  
 This method returns an [IDiaSymbol](../vs140/idiasymbol.md) object that can be used to determine the size of the vbtptr.  
  
## Requirements  
  
|Requirement|Description|  
|-----------------|-----------------|  
|Header:|dia2.h|  
|Version:|DIA SDK v8.0|  
  
## See Also  
 [IDiaSymbol](../vs140/idiasymbol.md)