---
title: "CComControlBase::OnDraw"
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
  - "CComControlBase::OnDraw"
  - "ATL::CComControlBase::OnDraw"
  - "ATL.CComControlBase.OnDraw"
  - "CComControlBase.OnDraw"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDraw method"
ms.assetid: 26ad62f4-1ee6-4c24-aeac-fb64f77bdafb
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComControlBase::OnDraw
Override this method to draw your control.  
  
## Syntax  
  
```  
  
      virtual HRESULT OnDraw(  
   ATL_DRAWINFO& di   
);  
```  
  
#### Parameters  
 `di`  
 A reference to the [ATL_DRAWINFO](../vs140/atl_drawinfo-structure.md) structure that contains drawing information such as the draw aspect, the control bounds, and whether the drawing is optimized or not.  
  
## Return Value  
 A standard `HRESULT` value.  
  
## Remarks  
 The default `OnDraw` deletes or restores the device context or does nothing, depending on flags set in [CComControlBase::OnDrawAdvanced](../vs140/ccomcontrolbase--ondrawadvanced.md).  
  
 An `OnDraw` method is automatically added to your control class when you create your control with the ATL Control Wizard. The wizard's default `OnDraw` draws a rectangle with the label "ATL 8.0".  
  
## Example  
 See the example for [CComControlBase::GetAmbientAppearance](../vs140/ccomcontrolbase--getambientappearance.md).  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [CComControlBase Class](../vs140/ccomcontrolbase-class.md)