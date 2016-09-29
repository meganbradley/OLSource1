---
title: "COM_INTERFACE_ENTRY_AUTOAGGREGATE"
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
  - "COM_INTERFACE_ENTRY_AUTOAGGREGATE"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COM_INTERFACE_ENTRY_AUTOAGGREGATE macro"
ms.assetid: c191a812-31ae-4667-bf67-109ba158e933
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COM_INTERFACE_ENTRY_AUTOAGGREGATE
Same as [COM_INTERFACE_ENTRY_AGGREGATE](../vs140/com_interface_entry_aggregate.md), except if `punk` is **NULL**, it automatically creates the aggregate described by the `clsid`.  
  
## Syntax  
  
```  
  
COM_INTERFACE_ENTRY_AUTOAGGREGATE(   
iid  
,   
punk  
,   
clsid  
 )  
  
```  
  
#### Parameters  
 `iid`  
 [in] The GUID of the interface queried for.  
  
 `punk`  
 [in] The name of an **IUnknown** pointer. Must be a member of the class containing the COM map.  
  
 `clsid`  
 [in] The identifier of the aggregate that will be created if `punk` is **NULL**.  
  
## Remarks  
 See [COM_INTERFACE_ENTRY Macros](../vs140/com_interface_entry-macros.md) for remarks about COM map entries.  
  
## Example  
 [!code[NVC_ATL_Windowing#114](../vs140/codesnippet/CPP/com_interface_entry_autoaggregate_1.h)]  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [COM Map Macros](../vs140/com-map-macros.md)   
 [Macros](../vs140/atl-macros.md)