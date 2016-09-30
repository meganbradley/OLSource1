---
title: "COM_INTERFACE_ENTRY_AGGREGATE_BLIND"
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
  - "COM_INTERFACE_ENTRY_AGGREGATE_BLIND"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COM_INTERFACE_ENTRY_AGGREGATE_BLIND macro"
ms.assetid: c44e4d89-0f33-4eca-9ded-18a35311f94f
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COM_INTERFACE_ENTRY_AGGREGATE_BLIND
Same as [COM_INTERFACE_ENTRY_AGGREGATE](../vs140/com_interface_entry_aggregate.md), except that querying for any IID results in forwarding the query to <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] The name of an **IUnknown** pointer.  
  
## Remarks  
 If the interface query fails, processing of the COM map continues.  
  
 See [COM_INTERFACE_ENTRY Macros](../vs140/com_interface_entry-macros.md) for remarks about COM map entries.  
  
## Example  
 [!code[NVC_ATL_Windowing#113](../vs140/codesnippet/CPP/com_interface_entry_aggregate_blind_1.h)]  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [COM Map Macros](../vs140/com-map-macros.md)   
 [Macros](../vs140/atl-macros.md)