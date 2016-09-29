---
title: "PROP_ENTRY_TYPE_EX"
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
  - "PROP_ENTRY_TYPE_EX"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "PROP_ENTRY_TYPE_EX macro"
ms.assetid: 61df460c-854e-4d42-87dc-5fc3894b58aa
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# PROP_ENTRY_TYPE_EX
Similar to [PROP_ENTRY_TYPE](../vs140/prop_entry_type.md), but allows you specify a particular IID if your object supports multiple dual interfaces.  
  
## Syntax  
  
```  
PROP_ENTRY_TYPE_EX(   
   szDesc,   
   dispid,   
   clsid,   
   iidDispatch,   
   vt   
)  
```  
  
#### Parameters  
 `szDesc`  
 [in] The property description.  
  
 `dispid`  
 [in] The property's DISPID.  
  
 `clsid`  
 [in] The CLSID of the associated property page. Use the special value `CLSID_NULL` for a property that does not have an associated property page.  
  
 `iidDispatch`  
 [in] The IID of the dual interface defining the property.  
  
 `vt`  
 [in] The property's type.  
  
## Remarks  
 The `PROP_ENTRY_EX` macro was insecure and deprecated. It has been replaced with `PROP_ENTRY_TYPE_EX`.  
  
 The [BEGIN_PROP_MAP](../vs140/begin_prop_map.md) macro marks the beginning of the property map; the [END_PROP_MAP](../vs140/end_prop_map.md) macro marks the end.  
  
## Example  
 The following example groups entries for `IMyDual1` followed by an entry for `IMyDual2`. Grouping by dual interface will improve performance.  
  
 [!code[NVC_ATL_Windowing#133](../vs140/codesnippet/CPP/prop_entry_type_ex_1.h)]  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [Property Map Macros](../vs140/property-map-macros.md)   
 [Macros](../vs140/atl-macros.md)   
 [PROP_PAGE](../vs140/prop_page.md)   
 [PROP_ENTRY_INTERFACE](../vs140/prop_entry_interface.md)   
 [PROP_ENTRY_INTERFACE_EX](../vs140/prop_entry_interface_ex.md)   
 [PROP_ENTRY_INTERFACE_CALLBACK](../vs140/prop_entry_interface_callback.md)   
 [PROP_ENTRY_INTERFACE_CALLBACK_EX](../vs140/prop_entry_interface_callback_ex.md)   
 [PROP_ENTRY_TYPE](../vs140/prop_entry_type.md)