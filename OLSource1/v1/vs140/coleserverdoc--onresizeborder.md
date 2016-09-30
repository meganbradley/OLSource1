---
title: "COleServerDoc::OnResizeBorder"
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
  - "OnResizeBorder"
  - "COleServerDoc::OnResizeBorder"
  - "COleServerDoc.OnResizeBorder"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnResizeBorder method"
  - "COleServerDoc class, overridables"
ms.assetid: bff4224f-d74d-4e69-a673-d8fcc005fe21
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleServerDoc::OnResizeBorder
The framework calls this function when the container application's frame windows change size.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Pointer to a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> structure or a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object that specifies the coordinates of the border.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Pointer to an object of class **IOleInPlaceUIWindow** that owns the current in-place editing session.  
  
 *bFrame*  
 **TRUE** if <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> points to the container application's top-level frame window, or **FALSE** if <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> points to the container application's document-level frame window.  
  
## Remarks  
 This function resizes and adjusts toolbars and other user-interface elements in accordance with the new window size.  
  
 For more information, see [IOleInPlaceUIWindow](http://msdn.microsoft.com/library/windows/desktop/ms680716) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 This is an advanced overridable.  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleServerDoc Class](../vs140/coleserverdoc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleServerDoc::OnShowControlBars](../vs140/coleserverdoc--onshowcontrolbars.md)