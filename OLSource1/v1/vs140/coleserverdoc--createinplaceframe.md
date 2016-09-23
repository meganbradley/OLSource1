---
title: "COleServerDoc::CreateInPlaceFrame"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CreateInPlaceFrame
  - COleServerDoc::CreateInPlaceFrame
  - COleServerDoc.CreateInPlaceFrame
dev_langs: 
  - C++
helpviewer_keywords: 
  - COleServerDoc class, overridables
  - CreateInPlaceFrame method
ms.assetid: ef876054-109d-48c4-82de-b65d969b5f5d
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# COleServerDoc::CreateInPlaceFrame
The framework calls this function to create a frame window for in-place editing.  
  
## Syntax  
  
```  
  
      virtual COleIPFrameWnd* CreateInPlaceFrame(  
   CWnd* pParentWnd   
);  
```  
  
#### Parameters  
 `pParentWnd`  
 Pointer to the container application's parent window.  
  
## Return Value  
 A pointer to the in-place frame window, or **NULL** if unsuccessful.  
  
## Remarks  
 The default implementation uses information specified in the document template to create the frame. The view used is the first view created for the document. This view is temporarily detached from the original frame and attached to the newly created frame.  
  
 This is an advanced overridable.  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleServerDoc Class](../vs140/coleserverdoc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleServerDoc::DestroyInPlaceFrame](../vs140/coleserverdoc--destroyinplaceframe.md)