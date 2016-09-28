---
title: "PROP_DATA_ENTRY"
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
  - "PROP_DATA_ENTRY"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "PROP_DATA_ENTRY macro"
ms.assetid: 9488b68a-4744-42c0-bf56-c21846f84d55
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# PROP_DATA_ENTRY
Indicates the extent, or dimensions, of an ActiveX control.  
  
## Syntax  
  
```  
  
      PROP_DATA_ENTRY(   
   szDesc,   
   member,   
   vt    
)  
```  
  
#### Parameters  
 `szDesc`  
 [in] The property description.  
  
 `member`  
 [in] The data member containing the extent; for example, `m_sizeExtent`.  
  
 *vt*  
 [in] Specifies the VARIANT type of the property.  
  
## Remarks  
 This macro causes the specified data member to be persisted.  
  
 When you create an ActiveX control, the wizard inserts this macro after the property map macro [BEGIN_PROP_MAP](../vs140/begin_prop_map.md) and before the property map macro [END_PROP_MAP](../vs140/end_prop_map.md).  
  
## Example  
 In the following example, the extent of the object (`m_sizeExtent`) is being persisted.  
  
 [!code[NVC_ATL_Windowing#131](../vs140/codesnippet/CPP/prop_data_entry_1.h)]  
  
 [!code[NVC_ATL_Windowing#132](../vs140/codesnippet/CPP/prop_data_entry_2.h)]  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [Property Map Macros](../vs140/property-map-macros.md)   
 [Macros](../vs140/atl-macros.md)