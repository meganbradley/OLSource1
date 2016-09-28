---
title: "COleClientItem::SetDrawAspect"
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
  - "COleClientItem.SetDrawAspect"
  - "DVASPECT"
  - "DVASPECT_CONTENT"
  - "COleClientItem::SetDrawAspect"
  - "DVASPECT_DOCPRINT"
  - "DVASPECT_ICON"
  - "SetDrawAspect"
  - "DVASPECT_THUMBNAIL"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DVASPECT_DOCPRINT"
  - "SetDrawAspect method"
  - "DVASPECT_THUMBNAIL"
  - "COleClientItem class, status"
  - "DVASPECT_CONTENT"
  - "DVASPECT"
  - "DVASPECT_ICON"
ms.assetid: af1b0989-ce8b-4f69-8080-a280159b5e0d
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleClientItem::SetDrawAspect
Call the `SetDrawAspect` member function to set the "aspect," or view, of the item.  
  
## Syntax  
  
```  
  
      virtual void SetDrawAspect(  
   DVASPECT nDrawAspect   
);  
```  
  
#### Parameters  
 `nDrawAspect`  
 A value from the `DVASPECT` enumeration. This parameter can have one of the following values:  
  
-   `DVASPECT_CONTENT` Item is represented in such a way that it can be displayed as an embedded object inside its container.  
  
-   `DVASPECT_THUMBNAIL` Item is rendered in a "thumbnail" representation so that it can be displayed in a browsing tool.  
  
-   `DVASPECT_ICON` Item is represented by an icon.  
  
-   `DVASPECT_DOCPRINT` Item is represented as if it were printed using the Print command from the File menu.  
  
## Remarks  
 The aspect specifies how the item is to be rendered by [Draw](../vs140/coleclientitem--draw.md) when the default value for that function's `nDrawAspect` argument is used.  
  
 This function is called automatically by the Change Icon (and other dialogs that call the Change Icon dialog directly) to enable the iconic display aspect when requested by the user.  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleClientItem Class](../vs140/coleclientitem-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleClientItem::GetDrawAspect](../vs140/coleclientitem--getdrawaspect.md)   
 [COleClientItem::Draw](../vs140/coleclientitem--draw.md)