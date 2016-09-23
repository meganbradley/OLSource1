---
title: "CMFCToolBarButton::OnToolHitTest"
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
  - CMFCToolBarButton.OnToolHitTest
  - OnToolHitTest
  - CMFCToolBarButton::OnToolHitTest
dev_langs: 
  - C++
helpviewer_keywords: 
  - OnToolHitTest method
ms.assetid: e5053787-8bde-4094-b572-ff5226c8e2b5
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCToolBarButton::OnToolHitTest
Called by the framework when the parent toolbar must determine whether a point is in the bounding rectangle of the button.  
  
## Syntax  
  
```  
virtual BOOL OnToolHitTest(  
   const CWnd* pWnd,  
   TOOLINFO* pTI   
);  
```  
  
#### Parameters  
 [in] `pWnd`  
 The parent window of the button. Can be `NULL`.  
  
 [in] `pTI`  
 A `TOOLINFO` structure that contains information about a tool in a tooltip control.  
  
## Return Value  
 The result of `OnMenuButtonToolHitTest` if the button can retrieve a pointer to the parent frame window; otherwise `FALSE`.  
  
## Remarks  
 This method calls one of the following methods if it can convert the parent window to a valid frame object:  
  
-   [CMDIFrameWndEx::OnMenuButtonToolHitTest](../vs140/cmdiframewndex--onmenubuttontoolhittest.md)  
  
-   [CFrameWndEx::OnMenuButtonToolHitTest](../vs140/cframewndex--onmenubuttontoolhittest.md)  
  
-   [COleIPFrameWndEx::OnMenuButtonToolHitTest](../vs140/coleipframewndex--onmenubuttontoolhittest.md)  
  
## Requirements  
 **Header:** afxtoolbarbutton.h  
  
## See Also  
 [CMFCToolBarButton Class](../vs140/cmfctoolbarbutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMDIFrameWndEx::OnMenuButtonToolHitTest](../vs140/cmdiframewndex--onmenubuttontoolhittest.md)   
 [CFrameWndEx::OnMenuButtonToolHitTest](../vs140/cframewndex--onmenubuttontoolhittest.md)   
 [COleIPFrameWndEx::OnMenuButtonToolHitTest](../vs140/coleipframewndex--onmenubuttontoolhittest.md)