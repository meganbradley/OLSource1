---
title: "PX_VBXFontConvert"
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
  - "PX_VBXFontConvert"
  - "AFXCTL/PX_VBXFontConvert"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "PX_VBXFontConvert function"
ms.assetid: 92a0bcb0-f882-4fac-97d9-16699f83f6ba
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# PX_VBXFontConvert
Call this function within your control's `DoPropExchange` member function to initialize a font property by converting a VBX control's font-related properties.  
  
## Syntax  
  
```  
  
      BOOL PX_VBXFontConvert(  
   CPropExchange* pPX,  
   CFontHolder& font   
);  
```  
  
#### Parameters  
 `pPX`  
 Pointer to the [CPropExchange](../vs140/cpropexchange-class.md) object (typically passed as a parameter to `DoPropExchange`).  
  
 `font`  
 The font property of the OLE control that will contain the converted VBX font-related properties.  
  
## Return Value  
 Nonzero if the exchange was successful; 0 if unsuccessful.  
  
## Remarks  
 This function should be used only by an OLE control that is designed as a direct replacement for a VBX control. When the Visual Basic development environment converts a form containing a VBX control to use the corresponding replacement OLE control, it will call the control's **IDataObject::SetData** function, passing in a property set that contains the VBX control's property data. This operation, in turn, causes the control's `DoPropExchange` function to be invoked. `DoPropExchange` can call `PX_VBXFontConvert` to convert the VBX control's font-related properties (for example, "FontName," "FontSize," and so on) into the corresponding components of the OLE control's font property.  
  
 `PX_VBXFontConvert` should only be called when the control is actually being converted from a VBX form application. For example:  
  
 [!code[NVC_MFCActiveXControl#14](../vs140/codesnippet/CPP/px_vbxfontconvert_1.cpp)]  
[!code[NVC_MFCActiveXControl#15](../vs140/codesnippet/CPP/px_vbxfontconvert_2.cpp)]  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [COleControl::DoPropExchange](../vs140/colecontrol--dopropexchange.md)   
 [COleControl::AmbientFont](../vs140/colecontrol--ambientfont.md)   
 [PX_Font](../vs140/px_font.md)