---
title: "COM_INTERFACE_ENTRY_AUTOAGGREGATE_BLIND"
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
  - "COM_INTERFACE_ENTRY_AUTOAGGREGATE_BLIND"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COM_INTERFACE_ENTRY_AUTOAGGREGATE_BLIND macro"
ms.assetid: 4e867f24-0a4f-465e-ad17-06939fcf9c1c
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COM_INTERFACE_ENTRY_AUTOAGGREGATE_BLIND
Same as [COM_INTERFACE_ENTRY_AUTOAGGREGATE](../VS_csharp/com_interface_entry_autoaggregate.md), except that querying for any IID results in forwarding the query to `punk`, and if `punk` is **NULL**, automatically creating the aggregate described by the `clsid`.  
  
## Syntax  
  
```  
  
COM_INTERFACE_ENTRY_AUTOAGGREGATE_BLIND(   
punk  
,   
clsid  
 )  
  
```  
  
#### Parameters  
 `punk`  
 [in] The name of an **IUnknown** pointer. Must be a member of the class containing the COM map.  
  
 `clsid`  
 [in] The identifier of the aggregate that will be created if `punk` is **NULL**.  
  
## Remarks  
 If the interface query fails, processing of the COM map continues.  
  
 See [COM_INTERFACE_ENTRY Macros](../VS_csharp/com_interface_entry-macros.md) for remarks about COM map entries.  
  
## Example  
 [!code[NVC_ATL_Windowing#115](../VS_csharp/codesnippet/CPP/com_interface_entry_autoaggregate_blind_1.h)]  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [COM Map Macros](../VS_csharp/com-map-macros.md)   
 [Macros](../VS_csharp/atl-macros.md)