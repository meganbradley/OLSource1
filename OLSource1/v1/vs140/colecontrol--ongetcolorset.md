---
title: "COleControl::OnGetColorSet"
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
  - "COleControl::OnGetColorSet"
  - "OnGetColorSet"
  - "COleControl.OnGetColorSet"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnGetColorSet method"
ms.assetid: 28de0465-e5a7-4898-acbb-e070895ede31
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControl::OnGetColorSet
Called by the framework when the container calls the **IViewObject::GetColorSet** member function.  
  
## Syntax  
  
```  
  
      virtual BOOL OnGetColorSet(  
   DVTARGETDEVICE* ptd,  
   HDC hicTargetDev,  
   LPLOGPALETTE* ppColorSet   
);  
```  
  
#### Parameters  
 `ptd`  
 Points to the target device for which the picture should be rendered. If this value is **NULL**, the picture should be rendered for a default target device, usually a display device.  
  
 `hicTargetDev`  
 Specifies the information context on the target device indicated by `ptd`. This parameter can be a device context, but is not one necessarily. If `ptd` is **NULL**, `hicTargetDev` should also be **NULL**.  
  
 *ppColorSet*  
 A pointer to the location into which the set of colors that would be used should be copied. If the function does not return the color set, **NULL** is returned.  
  
## Return Value  
 Nonzero if a valid color set is returned; otherwise 0.  
  
## Remarks  
 The container calls this function to obtain all the colors needed to draw the OLE control. The container can use the color sets obtained in conjunction with the colors it needs to set the overall color palette. The default implementation returns **FALSE**.  
  
 Override this function to do any special processing of this request.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [COleControl Class](../vs140/colecontrol-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)