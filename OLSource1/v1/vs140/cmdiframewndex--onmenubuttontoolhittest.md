---
title: "CMDIFrameWndEx::OnMenuButtonToolHitTest"
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
  - OnMenuButtonToolHitTest
  - CMDIFrameWndEx.OnMenuButtonToolHitTest
  - CMDIFrameWndEx::OnMenuButtonToolHitTest
dev_langs: 
  - C++
helpviewer_keywords: 
  - OnMenuButtonToolHitTest method
ms.assetid: 4e491860-7331-4bf9-8bd4-2f4b3043f4a7
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMDIFrameWndEx::OnMenuButtonToolHitTest
Called by the framework when a [CMFCToolBarButton](../vs140/cmfctoolbarbutton-class.md)object processes a `WM_NCHITTEST` message.  
  
## Syntax  
  
```  
virtual BOOL OnMenuButtonToolHitTest(  
   CMFCToolBarButton* pButton,  
   TOOLINFO* pTI  
);  
```  
  
#### Parameters  
 [in] `pButton`  
 The toolbar button.  
  
 [out] `pTI`  
 Pointer to a [TOOLINFO](http://msdn.microsoft.com/library/windows/desktop/bb760256) structure.  
  
## Return Value  
 `TRUE` if the application fills the `pTI` parameter. The default implementation returns `FALSE`.  
  
## Remarks  
 Override this method if you want to provide information about specific menu items to a tooltip. The default implementation does nothing.  
  
## Requirements  
 **Header:** afxMDIFrameWndEx.h  
  
## See Also  
 [CMDIFrameWndEx Class](../vs140/cmdiframewndex-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)