---
title: "COM_INTERFACE_ENTRY (ATL)"
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
  - "COM_INTERFACE_ENTRY"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COM_INTERFACE_ENTRY macro"
ms.assetid: c5363b8b-a1a2-471e-ad3a-d472f6c356c5
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COM_INTERFACE_ENTRY (ATL)
Enters interfaces into the COM interface map.  
  
## Syntax  
  
```  
  
COM_INTERFACE_ENTRY(   
x  
 )  
  
```  
  
#### Parameters  
 *x*  
 [in] The name of an interface your class object derives from directly.  
  
## Remarks  
 Typically, this is the entry type you use most often.  
  
 See [COM_INTERFACE_ENTRY Macros](../VS_csharp/com_interface_entry-macros.md) for remarks about COM map entries.  
  
## Example  
 [!code[NVC_ATL_Windowing#109](../VS_csharp/codesnippet/CPP/com_interface_entry--atl-_1.h)]  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [COM Map Macros](../VS_csharp/com-map-macros.md)   
 [Macros](../VS_csharp/atl-macros.md)