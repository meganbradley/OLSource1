---
title: "BEGIN_PROP_MAP"
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
  - "BEGIN_PROP_MAP"
  - "ATL::BEGIN_PROP_MAP"
  - "ATL.BEGIN_PROP_MAP"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "BEGIN_PROP_MAP macro"
  - "property maps"
ms.assetid: bfe30be6-62c3-4dc2-bd49-21ef96f15427
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# BEGIN_PROP_MAP
Marks the beginning of the object's property map.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 [in] Specifies the class containing the property map.  
  
## Remarks  
 The property map stores property descriptions, property DISPIDs, property page CLSIDs, and <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> IIDs. Classes [IPerPropertyBrowsingImpl](../vs140/iperpropertybrowsingimpl-class.md), [IPersistPropertyBagImpl](../vs140/ipersistpropertybagimpl-class.md), [IPersistStreamInitImpl](../vs140/ipersiststreaminitimpl-class.md), and [ISpecifyPropertyPagesImpl](../vs140/ispecifypropertypagesimpl-class.md) use the property map to retrieve and set this information.  
  
 When you create an object with the ATL Project Wizard, the wizard will create an empty property map by specifying <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> followed by [END_PROP_MAP](../vs140/end_prop_map.md).  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> does not save out the extent (that is, the dimensions) of a property map, because an object using a property map may not have a user interface, so it would have no extent. If the object is an ActiveX control with a user interface, it has an extent. In this case, you must specify [PROP_DATA_ENTRY](../vs140/prop_data_entry.md) in your property map to supply the extent.  
  
## Example  
 [!code[NVC_ATL_Windowing#103](../vs140/codesnippet/CPP/begin_prop_map_1.h)]  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [Property Map Macros](../vs140/property-map-macros.md)   
 [Macros](../vs140/atl-macros.md)