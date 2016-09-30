---
title: "CComControlBase::OnDrawAdvanced"
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
  - "ATL.CComControlBase.OnDrawAdvanced"
  - "ATL::CComControlBase::OnDrawAdvanced"
  - "CComControlBase::OnDrawAdvanced"
  - "CComControlBase.OnDrawAdvanced"
  - "OnDrawAdvanced"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDrawAdvanced method"
ms.assetid: a8e59a81-50f7-4472-a341-dd5909fec133
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComControlBase::OnDrawAdvanced
The default <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> prepares a normalized device context for drawing, then calls your control class's <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> method.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A reference to the [ATL_DRAWINFO](../vs140/atl_drawinfo-structure.md) structure that contains drawing information such as the draw aspect, the control bounds, and whether the drawing is optimized or not.  
  
## Return Value  
 A standard <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> value.  
  
## Remarks  
 Override this method if you want to accept the device context passed by the container without normalizing it.  
  
 See [CComControlBase::OnDraw](../vs140/ccomcontrolbase--ondraw.md) for more details.  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [CComControlBase Class](../vs140/ccomcontrolbase-class.md)