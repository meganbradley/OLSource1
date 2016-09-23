---
title: "CMDIFrameWndEx::NegotiateBorderSpace"
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
  - CMDIFrameWndEx::NegotiateBorderSpace
  - NegotiateBorderSpace
  - CMDIFrameWndEx.NegotiateBorderSpace
dev_langs: 
  - C++
helpviewer_keywords: 
  - NegotiateBorderSpace method
ms.assetid: edd72620-46cb-4a4c-a998-e65fba4cd194
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMDIFrameWndEx::NegotiateBorderSpace
Negotiates border space in a frame window during OLE in-place activation.  
  
## Syntax  
  
```  
virtual BOOL NegotiateBorderSpace(  
   UINT nBorderCmd,  
   LPRECT lpRectBorder  
);  
```  
  
#### Parameters  
 [in] `nBorderCmd`  
 Contains one of the following values from the enum `CFrameWnd::BorderCmd`:  
  
-   `borderGet` = 1  
  
-   `borderRequest` = 2  
  
-   `borderSet` = 3  
  
 [in, out] `lpRectBorder`  
 Pointer to a [RECT Structure](../vs140/rect-structure.md) or a [CRect Class](../vs140/crect-class.md) object that specifies the coordinates of the border.  
  
## Return Value  
 Nonzero if the method was successful; otherwise 0.  
  
## Remarks  
 This method is an implementation of OLE border space negotiation.  
  
## Requirements  
 **Header:** afxmdiframewndex.h  
  
## See Also  
 [CMDIFrameWndEx Class](../vs140/cmdiframewndex-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)