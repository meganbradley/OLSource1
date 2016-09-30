---
title: "COleClientItem::OnUpdateFrameTitle"
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
  - "COleClientItem.OnUpdateFrameTitle"
  - "COleClientItem::OnUpdateFrameTitle"
  - "OnUpdateFrameTitle"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleClientItem class, overridables"
  - "OnUpdateFrameTitle method"
ms.assetid: d0a64a9e-f9e4-44fd-b659-c826b3fbb856
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleClientItem::OnUpdateFrameTitle
Called by the framework during in-place activation to update the frame window's title bar.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Nonzero if this function successfully updated the frame title, otherwise zero.  
  
## Remarks  
 The default implementation does not change the frame window title. Override this function if you want a different frame title for your application, for example "*server app* - *item* in *docname*" (as in, "Microsoft Excel - spreadsheet in REPORT.DOC"). This is an advanced overridable.  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleClientItem Class](../vs140/coleclientitem-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)