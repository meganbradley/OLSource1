---
title: "COM_INTERFACE_ENTRY_AGGREGATE"
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
  - "COM_INTERFACE_ENTRY_AGGREGATE"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COM_INTERFACE_ENTRY_AGGREGATE macro"
ms.assetid: c671fa40-a57b-4797-ae88-c9762dabd4dc
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COM_INTERFACE_ENTRY_AGGREGATE
When the interface identified by <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> is queried for, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> forwards to <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [in] The GUID of the interface queried for.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 [in] The name of an **IUnknown** pointer.  
  
## Remarks  
 The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> parameter is assumed to point to the inner unknown of an aggregate or to **NULL**, in which case the entry is ignored. Typically, you would **CoCreate** the aggregate in <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
 See [COM_INTERFACE_ENTRY Macros](../vs140/com_interface_entry-macros.md) for remarks about COM map entries.  
  
## Example  
 [!code[NVC_ATL_Windowing#112](../vs140/codesnippet/CPP/com_interface_entry_aggregate_1.h)]  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [COM Map Macros](../vs140/com-map-macros.md)   
 [Macros](../vs140/atl-macros.md)