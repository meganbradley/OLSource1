---
title: "PROP_ENTRY_INTERFACE_EX"
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
  - "PROP_ENTRY_INTERFACE_EX"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "PROP_ENTRY_INTERFACE_EX macro"
ms.assetid: 5d6152b1-a935-4e41-b311-e5f759d0629b
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# PROP_ENTRY_INTERFACE_EX
Lets you specify a particular IID If your object supports multiple dispatch interfaces. Resembles [PROP_ENTRY_INTERFACE](../vs140/prop_entry_interface.md).  
  
## Syntax  
  
```  
PROP_ENTRY_INTERFACE_EX(  
   szDesc,  
   dispid,  
   clsid,  
   iidDispatch,  
   rgclsidAllowed,  
   cclsidAllowed,  
   vt  
)  
```  
  
#### Parameters  
 [in] `szDesc`  
 The property description.  
  
 [in] `dispid`  
 The DISPID of the property.  
  
 [in] `clsid`  
 The CLSID of the associated property page. Use the special value `CLSID_NULL` for a property that does not have an associated property page.  
  
 [in] `iidDispatch`  
 The IID of the dispatch interface that defines the property.  
  
 [in] `rgclsidAllowed`  
 An array of CLSIDs that can be loaded. For stability, use a `const` array.  
  
 [in] `cclsidAllowed`  
 The number of elements in `rgclsidAllowed`.  
  
 [in] `vt`  
 The type for the property.  
  
## Remarks  
 Include this macro to give an application more control over the [IPersistStreamInitImpl::Load](../vs140/ipersiststreaminitimpl--load.md) process. This macro only applies if `IPersistStreamInitImpl` is a base class and the class is advertised as safe for initializing. Otherwise, you should not use this macro.  
  
 In most cases, `cclsidAllowed` can be determined by `_countof(rgclsidAllowed)`.  
  
 This macro is only valid if `vt` is `VT_DISPATCH` or `VT_UNKNOWN`. Passing in a different value for `vt` to this macro will cause a compilation error. For any other value of `vt`, use [PROP_ENTRY_TYPE_EX](../vs140/prop_entry_type_ex.md).  
  
 The [BEGIN_PROP_MAP](../vs140/begin_prop_map.md) macro marks the beginning of the property map; the [END_PROP_MAP](../vs140/end_prop_map.md) macro marks the end.  
  
 If you are creating a web control that needs to be initialized, you should use the [IPersistPropertyBagImpl Class](../vs140/ipersistpropertybagimpl-class.md) instead of `IPersistStreamInitImpl` to initialize properties. `IPersistStreamInitImpl` possess a greater risk in binary format than `IPersistPropertyBagImpl`.  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [ATL Macros Alphabetical Reference](../vs140/atl-macros-alphabetical-reference.md)   
 [PROP_ENTRY_INTERFACE](../vs140/prop_entry_interface.md)   
 [PROP_ENTRY_INTERFACE_CALLBACK](../vs140/prop_entry_interface_callback.md)   
 [PROP_ENTRY_INTERFACE_CALLBACK_EX](../vs140/prop_entry_interface_callback_ex.md)   
 [PROP_ENTRY_TYPE](../vs140/prop_entry_type.md)   
 [PROP_ENTRY_TYPE_EX](../vs140/prop_entry_type_ex.md)