---
title: "COleControl::GetControlFlags"
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
  - "GetControlFlags"
  - "COleControl.GetControlFlags"
  - "COleControl::GetControlFlags"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetControlFlags method"
ms.assetid: 4a469282-7229-47ac-b9ca-66f921c92490
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControl::GetControlFlags
Retrieves the control flag settings.  
  
## Syntax  
  
```  
  
virtual DWORD GetControlFlags( );  
```  
  
## Return Value  
 An ORed combination of the flags in the ControlFlags enumeration:  
  
 `enum ControlFlags {`  
  
 `fastBeginPaint = 0x0001,`  
  
 `clipPaintDC = 0x0002,`  
  
 `pointerInactive = 0x0004,`  
  
 `noFlickerActivate = 0x0008,`  
  
 `windowlessActivate = 0x0010,`  
  
 `canOptimizeDraw = 0x0020,`  
  
 `};`  
  
## Remarks  
 By default, `GetControlFlags` returns `fastBeginPaint | clipPaintDC`.  
  
 `fastBeginPaint`  
 If set, uses a begin-paint function tailored for OLE controls instead of the [BeginPaint](http://msdn.microsoft.com/library/windows/desktop/dd183362) API (set by default).  
  
 `clipPaintDC`  
 If not set, disables the call to `IntersectClipRect` made by `COleControl` and gains a small speed advantage. If you are using windowless activation, the flag has no effect.  
  
 `pointerInactive`  
 If set, provides mouse interaction while your control is inactive by enabling `COleControl`'s implementation of the `IPointerInactive` interface, which is disabled by default.  
  
 `noFlickerActivate`  
 If set, eliminates extra drawing operations and the accompanying visual flicker. Use when your control draws itself identically in the inactive and active states. If you are using windowless activation, the flag has no effect.  
  
 `windowlessActivate`  
 If set, indicates your control uses windowless activation.  
  
 `canOptimizeDraw`  
 If set, indicates that the control will perform optimized drawing, if the container supports it.  
  
 For more information about `GetControlFlags` and other optimizations of OLE controls, see [ActiveX Controls: Optimization](../vs140/mfc-activex-controls--optimization.md).  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [COleControl Class](../vs140/colecontrol-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::IntersectClipRect](../vs140/cdc--intersectcliprect.md)   
 [COleControl::SetControlSize](../vs140/colecontrol--setcontrolsize.md)