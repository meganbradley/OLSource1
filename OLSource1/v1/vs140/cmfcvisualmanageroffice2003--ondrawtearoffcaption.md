---
title: "CMFCVisualManagerOffice2003::OnDrawTearOffCaption"
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
  - "CMFCVisualManagerOffice2003.OnDrawTearOffCaption"
  - "CMFCVisualManagerOffice2003::OnDrawTearOffCaption"
  - "OnDrawTearOffCaption"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDrawTearOffCaption method"
ms.assetid: 56a17082-6893-43c5-8fc2-f1e1b21843f0
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCVisualManagerOffice2003::OnDrawTearOffCaption
The framework calls this method when it draws the caption for a [CMFCPopupMenu](../vs140/cmfcpopupmenu-class.md) object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A rectangle that specifies the boundaries of the caption.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> if the caption is active; <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> otherwise.  
  
## Remarks  
 This function is called by the framework when a [CMFCPopupMenu](../vs140/cmfcpopupmenu-class.md) object processes a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> message and must draw a tear-off caption.  
  
 Override this method in a derived class to customize the look of captions for tear-off bars.  
  
## Requirements  
 **Header:** afxvisualmanageroffice2003.h  
  
## See Also  
 [CMFCVisualManagerOffice2003 Class](../vs140/cmfcvisualmanageroffice2003-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)