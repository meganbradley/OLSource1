---
title: "AtlInternalQueryInterface"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "AtlInternalQueryInterface"
  - "ATL.AtlInternalQueryInterface"
  - "ATL::AtlInternalQueryInterface"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AtlInternalQueryInterface function"
ms.assetid: 3d55c16c-c55e-4c70-9340-4500ceabca37
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AtlInternalQueryInterface
Retrieves a pointer to the requested interface.  
  
## Syntax  
  
```  
  
      HRESULT AtlInternalQueryInterface(  
   void* pThis,  
   const _ATL_INTMAP_ENTRY* pEntries,  
   REFIID iid,  
   void** ppvObject   
);  
```  
  
#### Parameters  
 `pThis`  
 [in] A pointer to the object that contains the COM map of interfaces exposed to `QueryInterface`.  
  
 `pEntries`  
 [in] An array of **_ATL_INTMAP_ENTRY** structures that access a map of available interfaces.  
  
 `iid`  
 [in] The GUID of the interface being requested.  
  
 `ppvObject`  
 [out] A pointer to the interface pointer specified in `iid`, or **NULL** if the interface is not found.  
  
## Return Value  
 One of the standard HRESULT values.  
  
## Remarks  
 `AtlInternalQueryInterface` only handles interfaces in the COM map table. If your object is aggregated, `AtlInternalQueryInterface` does not delegate to the outer unknown. You can enter interfaces into the COM map table with the macro [COM_INTERFACE_ENTRY](../vs140/com_interface_entry-macros.md) or one of its variants.  
  
## Example  
 [!code[NVC_ATL_Windowing#94](../vs140/codesnippet/CPP/atlinternalqueryinterface_1.cpp)]  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CComObjectRootEx::InternalAddRef](../vs140/ccomobjectrootex--internaladdref.md)   
 [CComObjectRootEx::InternalRelease](../vs140/ccomobjectrootex--internalrelease.md)   
 [COM Map Global Functions](../vs140/com-map-global-functions.md)