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
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Elements  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Location information is unavailable.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Location is static.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Location is in thread local storage.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Location is register-relative.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Location is <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>-relative.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Location is in a register.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 Location is in a bit field.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 Location is a Microsoft Intermediate Language (MSIL) slot.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 Location is MSIL-relative.  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 Location is in metadata.  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 Location is in a constant value.  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 The number of location types in this enumeration.  
  
## Remarks  
 The properties available to the [IDiaSymbol](../vs140/idiasymbol.md) interface depend on the symbol's location within the image file. For more information, see [Symbol Locations](../vs140/symbol-locations.md).  
  
 The values in this enumeration are returned by a call to the [IDiaSymbol::get_locationType](../vs140/idiasymbol--get_locationtype.md) method.  
  
## Requirements  
 Header: cvconst.h  
  
## See Also  
 [Enumerations and Structures](../vs140/enumerations-and-structures.md)   
 [IDiaSymbol](../vs140/idiasymbol.md)   
 [IDiaSymbol::get_locationType](../vs140/idiasymbol--get_locationtype.md)   
 [Symbol Locations](../vs140/symbol-locations.md)