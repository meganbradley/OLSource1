---
title: "COleControl::IsConvertingVBX"
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
  - "COleControl::IsConvertingVBX"
  - "IsConvertingVBX"
  - "COleControl.IsConvertingVBX"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsConvertingVBX method"
ms.assetid: f2db71e6-be85-467d-8d00-622a9c9118b5
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControl::IsConvertingVBX
Allows specialized loading of an OLE control.  
  
## Syntax  
  
```  
  
BOOL IsConvertingVBX( );  
```  
  
## Return Value  
 Nonzero if the control is being converted; otherwise 0.  
  
## Remarks  
 When converting a form that uses VBX controls to one that uses OLE controls, special loading code for the OLE controls may be required. For example, if you are loading an instance of your OLE control, you might have a call to [PX_Font](../vs140/px_font.md) in your `DoPropExchange`:  
  
 [!code[NVC_MFCAxCtl#3](../vs140/codesnippet/CPP/colecontrol--isconvertingvbx_1.cpp)]  
  
 However, VBX controls did not have a Font object; each font property was saved individually. In this case, you would use `IsConvertingVBX` to distinguish between these two cases:  
  
 [!code[NVC_MFCAxCtl#4](../vs140/codesnippet/CPP/colecontrol--isconvertingvbx_2.cpp)]  
  
 Another case would be if your VBX control saved proprietary binary data (in its **VBM_SAVEPROPERTY** message handler), and your OLE control saves its binary data in a different format. If you want your OLE control to be backward-compatible with the VBX control, you could read both the old and new formats using the `IsConvertingVBX` function by distinguishing whether the VBX control or the OLE control was being loaded.  
  
 In your control's `DoPropExchange` function, you can check for this condition and if true, execute load code specific to this conversion (such as the previous examples). If the control is not being converted, you can execute normal load code. This ability is only applicable to controls being converted from VBX counterparts.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [COleControl Class](../vs140/colecontrol-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleControl::DoPropExchange](../vs140/colecontrol--dopropexchange.md)