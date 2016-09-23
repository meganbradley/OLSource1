---
title: "PROP_ENTRY_TYPE"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - PROP_ENTRY_TYPE
dev_langs: 
  - C++
helpviewer_keywords: 
  - PROP_ENTRY_TYPE macro
ms.assetid: 172466f3-a512-41dd-9289-841f29ab150d
caps.latest.revision: 16
translation.priority.ht: 
  - de-de
  - ja-jp
---
# PROP_ENTRY_TYPE
Use this macro to enter a property description, property DISPID, and property page CLSID into the object's property map.  
  
## Syntax  
  
```  
PROP_ENTRY_TYPE(   
   szDesc,   
   dispid,   
   clsid,   
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
  
 `vt`  
 [in] The property's type.  
  
## Remarks  
 The `PROP_ENTRY` macro was insecure and deprecated. It has been replaced with `PROP_ENTRY_TYPE`.  
  
 The [BEGIN_PROP_MAP](../vs140/begin_prop_map.md) macro marks the beginning of the property map; the [END_PROP_MAP](../vs140/end_prop_map.md) macro marks the end.  
  
## Example  
 See the example for [BEGIN_PROP_MAP](../vs140/begin_prop_map.md).  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [Property Map Macros](../vs140/property-map-macros.md)   
 [Macros](../vs140/atl-macros.md)   
 [PROP_ENTRY_TYPE_EX](../vs140/prop_entry_type_ex.md)   
 [PROP_PAGE](../vs140/prop_page.md)   
 [PROP_ENTRY_INTERFACE](../vs140/prop_entry_interface.md)   
 [PROP_ENTRY_INTERFACE_EX](../vs140/prop_entry_interface_ex.md)   
 [PROP_ENTRY_INTERFACE_CALLBACK](../vs140/prop_entry_interface_callback.md)   
 [PROP_ENTRY_INTERFACE_CALLBACK_EX](../vs140/prop_entry_interface_callback_ex.md)