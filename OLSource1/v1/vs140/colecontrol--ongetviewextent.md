---
title: "COleControl::OnGetViewExtent"
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
  - "COleControl.OnGetViewExtent"
  - "OnGetViewExtent"
  - "COleControl::OnGetViewExtent"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnGetViewExtent method"
ms.assetid: 70414333-fb27-49a9-9473-08c41304e644
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControl::OnGetViewExtent
Called by the framework in response to a container's [IViewObject2::GetExtent](http://msdn.microsoft.com/library/windows/desktop/ms684032) request.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *dwDrawAspect*  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> describing which form, or aspect, of an object is to be displayed. Valid values are taken from the enumeration [DVASPECT](http://msdn.microsoft.com/library/windows/desktop/ms690318) or **DVASPECT2**.  
  
 *lindex*  
 The portion of the object that is of interest. Currently only –1 is valid.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Points to the [DVTARGETDEVICE](http://msdn.microsoft.com/library/windows/desktop/ms686613) structure defining the target device for which the object's size should be returned.  
  
 *lpsizel*  
 Points to the location where the object's size is returned.  
  
## Return Value  
 Nonzero if extent information is successfully returned; otherwise 0.  
  
## Remarks  
 Override this function if your control uses two-pass drawing, and its opaque and transparent parts have different dimensions.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [COleControl Class](../vs140/colecontrol-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleControl::OnGetViewRect](../vs140/colecontrol--ongetviewrect.md)