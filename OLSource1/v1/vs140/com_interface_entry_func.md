---
title: "COM_INTERFACE_ENTRY_FUNC"
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
  - "COM_INTERFACE_ENTRY_FUNC"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COM_INTERFACE_ENTRY_FUNC macro"
ms.assetid: e4c9936b-0957-4172-a3ca-b715d6909966
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COM_INTERFACE_ENTRY_FUNC
A general mechanism for hooking into ATL's `QueryInterface` logic.  
  
## Syntax  
  
```  
  
COM_INTERFACE_ENTRY_FUNC(   
iid  
,   
dw  
,   
func  
 )  
  
```  
  
#### Parameters  
 `iid`  
 [in] The GUID of the interface exposed.  
  
 `dw`  
 [in] A parameter passed through to the `func`.  
  
 `func`  
 [in] The function pointer that will return `iid`.  
  
## Remarks  
 If *iid* matches the IID of the interface queried for, then the function specified by `func` is called. The declaration for the function should be:  
  
 `HRESULT WINAPI func(void* pv, REFIID riid, LPVOID* ppv, DWORD_PTR dw);`  
  
 When your function is called, `pv` points to your class object. The `riid` parameter refers to the interface being queried for, `ppv` is the pointer to the location where the function should store the pointer to the interface, and `dw` is the parameter you specified in the entry. The function should set \*`ppv` to **NULL** and return **E_NOINTERFACE** or **S_FALSE** if it chooses not to return an interface. With **E_NOINTERFACE**, COM map processing terminates. With **S_FALSE**, COM map processing continues, even though no interface pointer was returned. If the function returns an interface pointer, it should return `S_OK`.  
  
 See [COM_INTERFACE_ENTRY Macros](../vs140/com_interface_entry-macros.md) for remarks about COM map entries.  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [COM Map Macros](../vs140/com-map-macros.md)   
 [Macros](../vs140/atl-macros.md)