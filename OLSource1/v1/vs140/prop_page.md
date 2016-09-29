---
title: "PROP_PAGE"
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
  - "PROP_PAGE"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "PROP_PAGE macro"
ms.assetid: 2155973e-b96c-4385-bf85-5d6112c969b8
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# PROP_PAGE
Use this macro to enter a property page CLSID into the object's property map.  
  
## Syntax  
  
```  
  
      PROP_PAGE(   
   clsid    
)  
```  
  
#### Parameters  
 `clsid`  
 [in] The CLSID of a property page.  
  
## Remarks  
 `PROP_PAGE` is similar to [PROP_ENTRY_TYPE](../vs140/prop_entry_type.md), but does not require a property description or DISPID.  
  
> [!NOTE]
>  If you have already entered a CLSID with `PROP_ENTRY_TYPE` or [PROP_ENTRY_TYPE_EX](../vs140/prop_entry_type_ex.md), you do not need to make an additional entry with `PROP_PAGE`.  
  
 The [BEGIN_PROP_MAP](../vs140/begin_prop_map.md) macro marks the beginning of the property map; the [END_PROP_MAP](../vs140/end_prop_map.md) macro marks the end.  
  
## Example  
 [!code[NVC_ATL_Windowing#134](../vs140/codesnippet/CPP/prop_page_1.h)]  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [Property Map Macros](../vs140/property-map-macros.md)   
 [Macros](../vs140/atl-macros.md)