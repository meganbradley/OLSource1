---
title: "PROP_ENTRY_INTERFACE_CALLBACK_EX"
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
  - PROP_ENTRY_INTERFACE_CALLBACK_EX
dev_langs: 
  - C++
helpviewer_keywords: 
  - PROP_ENTRY_INTERFACE_CALLBACK_EX macro
ms.assetid: af9f61a1-6a69-4d9f-bebd-8e638a6ab99d
caps.latest.revision: 15
translation.priority.ht: 
  - de-de
  - ja-jp
---
# PROP_ENTRY_INTERFACE_CALLBACK_EX
Lets you specify a particular IID if your object supports multiple dispatch interfaces. Resembles [PROP_ENTRY_INTERFACE_CALLBACK](../vs140/prop_entry_interface_callback.md).  
  
## Syntax  
  
```  
PROP_ENTRY_INTERFACE_CALLBACK_EX(  
   szDesc,  
   dispid,  
   clsid,  
   iidDispatch,  
   pfnFunc,  
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
  
 [in]`pfnFunc`  
 The callback function that controls data during the loading process.  
  
 [in] `vt`  
 The type of the property.  
  
## Remarks  
 Include this macro to give an application more control over the [IPersistStreamInitImpl::Load](../vs140/ipersiststreaminitimpl--load.md) process. The callback function `pfnFunc` is called when `IPersistStreamInitImpl::Load` is retrieving data from a non-trusted stream. The callback function filters the data and controls which objects are loaded.  
  
 This macro only applies if `IPersistStreamInitImpl` is a base class and the class is advertised as safe for initialization. Otherwise, you should not use this macro.  
  
 This macro is only valid if `vt` is `VT_DISPATCH` or `VT_UNKNOWN`. Passing in a different value for `vt` to this macro will cause a compilation error. For any other value of `vt`, use [PROP_ENTRY_TYPE_EX](../vs140/prop_entry_type_ex.md).  
  
 The [BEGIN_PROP_MAP](../vs140/begin_prop_map.md) macro marks the beginning of the property map; the [END_PROP_MAP](../vs140/end_prop_map.md) macro marks the end.  
  
 If you are creating a web control that needs to be initialized, you should use the [IPersistPropertyBagImpl Class](../vs140/ipersistpropertybagimpl-class.md) instead of `IPersistStreamInitImpl` to initialize properties. `IPersistStreamInitImpl` possess a greater risk in binary format than `IPersistPropertyBagImpl`.  
  
## Example  
 See the example for [BEGIN_PROP_MAP](../vs140/begin_prop_map.md).  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [ATL Macros Alphabetical Reference](../vs140/atl-macros-alphabetical-reference.md)   
 [PROP_ENTRY_INTERFACE](../vs140/prop_entry_interface.md)   
 [PROP_ENTRY_INTERFACE_EX](../vs140/prop_entry_interface_ex.md)   
 [PROP_ENTRY_INTERFACE_CALLBACK](../vs140/prop_entry_interface_callback.md)   
 [PROP_ENTRY_TYPE](../vs140/prop_entry_type.md)   
 [PROP_ENTRY_TYPE_EX](../vs140/prop_entry_type_ex.md)