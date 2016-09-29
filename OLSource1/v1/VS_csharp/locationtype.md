---
title: "LocationType"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "LocationType enumeration"
ms.assetid: d3e1eedc-bfd3-4c91-881b-d69565138d0f
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# LocationType
Indicates the kind of location information contained in a symbol.  
  
## Syntax  
  
```cpp#  
enum LocationType {   
   LocIsNull,  
   LocIsStatic,  
   LocIsTLS,  
   LocIsRegRel,  
   LocIsThisRel,  
   LocIsEnregistered,  
   LocIsBitField,  
   LocIsSlot,  
   LocIsIlRel,  
   LocInMetaData,  
   LocIsConstant,  
   LocTypeMax  
};  
```  
  
## Elements  
 `LocIsNull`  
 Location information is unavailable.  
  
 `LocIsStatic`  
 Location is static.  
  
 `LocIsTLS`  
 Location is in thread local storage.  
  
 `LocIsRegRel`  
 Location is register-relative.  
  
 `LocIsThisRel`  
 Location is `this`-relative.  
  
 `LocIsEnregistered`  
 Location is in a register.  
  
 `LocIsBitField`  
 Location is in a bit field.  
  
 `LocIsSlot`  
 Location is a Microsoft Intermediate Language (MSIL) slot.  
  
 `LocIsIlRel`  
 Location is MSIL-relative.  
  
 `LocInMetaData`  
 Location is in metadata.  
  
 `LocIsConstant`  
 Location is in a constant value.  
  
 `LocTypeMax`  
 The number of location types in this enumeration.  
  
## Remarks  
 The properties available to the [IDiaSymbol](../VS_csharp/idiasymbol.md) interface depend on the symbol's location within the image file. For more information, see [Symbol Locations](../VS_csharp/symbol-locations.md).  
  
 The values in this enumeration are returned by a call to the [IDiaSymbol::get_locationType](../VS_csharp/idiasymbol--get_locationtype.md) method.  
  
## Requirements  
 Header: cvconst.h  
  
## See Also  
 [Enumerations and Structures](../VS_csharp/enumerations-and-structures.md)   
 [IDiaSymbol](../VS_csharp/idiasymbol.md)   
 [IDiaSymbol::get_locationType](../VS_csharp/idiasymbol--get_locationtype.md)   
 [Symbol Locations](../VS_csharp/symbol-locations.md)