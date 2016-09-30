---
title: "COleClientItem::OnGetItemPosition"
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
  - "COleClientItem.OnGetItemPosition"
  - "OnGetItemPosition"
  - "COleClientItem::OnGetItemPosition"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnGetItemPosition method"
  - "COleClientItem class, overridables"
ms.assetid: 484d6ec2-6050-4aac-8ccc-1a01d5909c4b
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleClientItem::OnGetItemPosition
The framework calls the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> member function to get the coordinates of the item that is being edited in place.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Reference to the [CRect](../vs140/crect-class.md) object that will contain the item's position coordinates.  
  
## Remarks  
 Coordinates are in pixels relative to the container application window's client area.  
  
 The default implementation of this function does nothing. Applications that support in-place editing require its implementation.  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleClientItem Class](../vs140/coleclientitem-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleClientItem::OnActivate](../vs140/coleclientitem--onactivate.md)   
 [COleClientItem::OnActivateUI](../vs140/coleclientitem--onactivateui.md)