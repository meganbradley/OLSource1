---
title: "COM_INTERFACE_ENTRY_CACHED_TEAR_OFF"
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
  - "COM_INTERFACE_ENTRY_CACHED_TEAR_OFF"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COM_INTERFACE_ENTRY_CACHED_TEAR_OFF macro"
ms.assetid: 195d37df-1ae1-4ac5-b5f1-294ad652189a
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COM_INTERFACE_ENTRY_CACHED_TEAR_OFF
Saves the interface-specific data for every instance.  
  
## Syntax  
  
```  
  
COM_INTERFACE_ENTRY_CACHED_TEAR_OFF(   
iid  
,   
x  
,   
punk  
 )  
  
```  
  
#### Parameters  
 `iid`  
 [in] The GUID of the tear-off interface.  
  
 *x*  
 [in] The name of the class implementing the interface.  
  
 `punk`  
 [in] The name of an **IUnknown** pointer. Must be a member of the class containing the COM map. Should be initialized to **NULL** in the class object's constructor.  
  
## Remarks  
 If the interface is not used, this lowers the overall instance size of your object.  
  
 See [COM_INTERFACE_ENTRY Macros](../vs140/com_interface_entry-macros.md) for remarks about COM map entries.  
  
## Example  
 [!code[NVC_ATL_COM#54](../vs140/codesnippet/CPP/com_interface_entry_cached_tear_off_1.h)]  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [COM Map Macros](../vs140/com-map-macros.md)   
 [Macros](../vs140/atl-macros.md)