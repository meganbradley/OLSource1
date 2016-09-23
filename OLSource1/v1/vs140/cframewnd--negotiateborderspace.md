---
title: "CFrameWnd::NegotiateBorderSpace"
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
  - BorderCmd
  - CFrameWnd::NegotiateBorderSpace
  - NegotiateBorderSpace
  - CFrameWnd.NegotiateBorderSpace
dev_langs: 
  - C++
helpviewer_keywords: 
  - BorderCmd
  - NegotiateBorderSpace method
  - CFrameWnd class, overridables
ms.assetid: 2be37aff-ecd8-4998-ad8e-4ba418c64f5d
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CFrameWnd::NegotiateBorderSpace
Call this member function to negotiate border space in a frame window during OLE inplace activation.  
  
## Syntax  
  
```  
  
      virtual BOOL NegotiateBorderSpace(  
   UINT nBorderCmd,  
   LPRECT lpRectBorder   
);  
```  
  
#### Parameters  
 *nBorderCmd*  
 Contains one of the following values from the **enum BorderCmd**:  
  
-   **borderGet** = 1  
  
-   **borderRequest** = 2  
  
-   **borderSet** = 3  
  
 `lpRectBorder`  
 Pointer to a [RECT](../vs140/rect-structure.md) structure or a [CRect](../vs140/crect-class.md) object that specifies the coordinates of the border.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 This member function is the **CFrameWnd** implementation of OLE border space negotiation.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CFrameWnd Class](../vs140/cframewnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [IOleInPlaceUIWindow](http://msdn.microsoft.com/library/windows/desktop/ms680716)