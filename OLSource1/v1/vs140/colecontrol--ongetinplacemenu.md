---
title: "COleControl::OnGetInPlaceMenu"
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
  - "COleControl.OnGetInPlaceMenu"
  - "OnGetInPlaceMenu"
  - "COleControl::OnGetInPlaceMenu"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnGetInPlaceMenu method"
ms.assetid: 2eae9775-5a52-4dc5-a8d6-99b320fae9ec
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControl::OnGetInPlaceMenu
Called by the framework when the control is UI activated to obtain the menu to be merged into the container's existing menu.  
  
## Syntax  
  
```  
  
virtual HMENU OnGetInPlaceMenu( );  
```  
  
## Return Value  
 The handle of the control's menu, or **NULL** if the control has none. The default implementation returns **NULL**.  
  
## Remarks  
 For more information on merging OLE resources, see the article [Menus and Resources (OLE)](../vs140/menus-and-resources--ole-.md).  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [COleControl Class](../vs140/colecontrol-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)