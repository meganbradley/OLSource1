---
title: "CView::OnUpdate"
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
  - "OnUpdate"
  - "CView.OnUpdate"
  - "CView::OnUpdate"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "document views, updating"
  - "OnUpdate method"
  - "updating views"
  - "CView class, overridables"
ms.assetid: 8f580b26-be61-4ec9-9730-33c53caff22f
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CView::OnUpdate
Called by the framework after the view's document has been modified; this function is called by [CDocument::UpdateAllViews](../vs140/cdocument--updateallviews.md) and allows the view to update its display to reflect those modifications.  
  
## Syntax  
  
```  
  
      virtual void OnUpdate(  
   CView* pSender,  
   LPARAM lHint,  
   CObject* pHint   
);  
```  
  
#### Parameters  
 `pSender`  
 Points to the view that modified the document, or **NULL** if all views are to be updated.  
  
 `lHint`  
 Contains information about the modifications.  
  
 `pHint`  
 Points to an object storing information about the modifications.  
  
## Remarks  
 It is also called by the default implementation of [OnInitialUpdate](../vs140/cview--oninitialupdate.md). The default implementation invalidates the entire client area, marking it for painting when the next `WM_PAINT` message is received. Override this function if you want to update only those regions that map to the modified portions of the document. To do this you must pass information about the modifications using the hint parameters.  
  
 To use `lHint`, define special hint values, typically a bitmask or an enumerated type, and have the document pass one of these values. To use `pHint`, derive a hint class from [CObject](../vs140/cobject-class.md) and have the document pass a pointer to a hint object; when overriding `OnUpdate`, use the [CObject::IsKindOf](../vs140/cobject--iskindof.md) member function to determine the run-time type of the hint object.  
  
 Typically you should not perform any drawing directly from `OnUpdate`. Instead, determine the rectangle describing, in device coordinates, the area that requires updating; pass this rectangle to [CWnd::InvalidateRect](../vs140/cwnd--invalidaterect.md). This causes painting to occur the next time a [WM_PAINT](http://msdn.microsoft.com/library/windows/desktop/dd145213) message is received.  
  
 If `lHint` is 0 and `pHint` is **NULL**, the document has sent a generic update notification. If a view receives a generic update notification, or if it cannot decode the hints, it should invalidate its entire client area.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CView Class](../vs140/cview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDocument::UpdateAllViews](../vs140/cdocument--updateallviews.md)   
 [CView::OnInitialUpdate](../vs140/cview--oninitialupdate.md)   
 [CWnd::Invalidate](../vs140/cwnd--invalidate.md)   
 [CWnd::InvalidateRect](../vs140/cwnd--invalidaterect.md)