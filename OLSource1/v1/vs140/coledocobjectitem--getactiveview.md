---
title: "COleDocObjectItem::GetActiveView"
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
  - "COleDocObjectItem.GetActiveView"
  - "COleDocObjectItem::GetActiveView"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetActiveView method"
ms.assetid: 5257d290-66e6-4f91-8d8f-db3c8c53e1f6
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleDocObjectItem::GetActiveView
Call this member function to get a pointer to the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> interface of the currently active view.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A pointer to the [IOleDocumentView](http://msdn.microsoft.com/library/windows/desktop/ms678455) interface of the currently active view. If there is no current view, it returns **NULL**.  
  
## Remarks  
 The reference count on the returned <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> pointer is not incremented before it is returned by this function.  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleDocObjectItem Class](../vs140/coledocobjectitem-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)