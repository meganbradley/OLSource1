---
title: "Persistence of OLE Controls"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vc.mfc.macros.ole"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OLE controls, persistence"
  - "persistence, OLE controls"
ms.assetid: 64f8dc80-f110-41af-b3ea-14948f6bfdf7
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Persistence of OLE Controls
One capability of OLE controls is property persistence (or serialization), which allows the OLE control to read or write property values to and from a file or stream. A container application can use serialization to store a control's property values even after the application has destroyed the control. The property values of the OLE control can then be read from the file or stream when a new instance of the control is created at a later time.  
  
### Persistence of OLE Controls  
  
|||  
|-|-|  
|[PX_Blob](../vs140/px_blob.md)|Exchanges a control property that stores binary large object (BLOB) data.|  
|[PX_Bool](../vs140/px_bool.md)|Exchanges a control property of type **BOOL**.|  
|[PX_Color](../vs140/px_color.md)|Exchanges a color property of a control.|  
|[PX_Currency](../vs140/px_currency.md)|Exchanges a control property of type **CY**.|  
|[PX_DataPath](../vs140/px_datapath.md)|Exchanges a control property of type <CodeContentPlaceHolder>0\</CodeContentPlaceHolder>.|  
|[PX_Double](../vs140/px_double.md)|Exchanges a control property of type **double**.|  
|[PX_Font](../vs140/px_font.md)|Exchanges a font property of a control.|  
|[PX_Float](../vs140/px_float.md)|Exchanges a control property of type **float**.|  
|[PX_IUnknown](../vs140/px_iunknown.md)|Exchanges a control property of undefined type.|  
|[PX_Long](../vs140/px_long.md)|Exchanges a control property of type **long**.|  
|[PX_Picture](../vs140/px_picture.md)|Exchanges a picture property of a control.|  
|[PX_Short](../vs140/px_short.md)|Exchanges a control property of type **short**.|  
|[PX_ULong](../vs140/px_ulong.md)|Exchanges a control property of type **ULONG**.|  
|[PX_UShort](../vs140/px_ushort.md)|Exchanges a control property of type **USHORT**.|  
|[PX_String](../vs140/px_string.md)|Exchanges a character string control property.|  
|[PX_VBXFontConvert](../vs140/px_vbxfontconvert.md)|Exchanges a VBX control's font-related properties into an OLE control font property.|  
  
 In addition, the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> global function is provided to test for a match between a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> and a given GUID.  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)