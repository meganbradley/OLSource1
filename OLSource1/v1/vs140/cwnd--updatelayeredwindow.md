---
title: "CWnd::UpdateLayeredWindow"
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
  - "CWnd.UpdateLayeredWindow"
  - "UpdateLayeredWindow"
  - "CWnd::UpdateLayeredWindow"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "UpdateLayeredWindow method"
ms.assetid: 9035dce1-8560-4ea4-94a8-f6e0ba2b2021
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::UpdateLayeredWindow
Updates the position, size, shape, content, and translucency of a layered window.  
  
## Syntax  
  
```  
  
      BOOL UpdateLayeredWindow(  
   CDC* pDCDst,  
   POINT *pptDst,  
   SIZE *psize,  
   CDC *pDCSrc,  
   POINT *pptSrc,  
   COLORREF crKey,  
   BLENDFUNCTION *pblend,  
   DWORD dwFlags  
);  
```  
  
#### Parameters  
 `pDCDst`  
 A pointer to a device context for the screen. It is used for palette color matching when the window contents are updated. If `pDCDst` is **NULL**, the default palette will be used.  
  
 If `pDCSrc` is **NULL**, `pDCDst` must be **NULL**.  
  
 `pptDst`  
 A pointer to a **POINT** structure specifying the new screen position of the layered window. If the current position is not changing, `pptDst` can be **NULL**.  
  
 *psize*  
 Pointer to a **SIZE** structure that specifies the new size of the layered window. If the size of the window is not changing, *psize* can be **NULL**.  
  
 If `pDCSrc` is **NULL**, *psize* must be **NULL**.  
  
 `pDCSrc`  
 A pointer to a DC for the surface that defines the layered window. If the shape and visual context of the window are not changing, `pDCSrc` can be **NULL**.  
  
 `pptSrc`  
 Pointer to a **POINT** structure that specifies the location of the layer in the device context.  
  
 If `pDCSrc` is **NULL**, `pptSrc` should be **NULL**.  
  
 `crKey`  
 Pointer to a **COLORREF** value that specifies the transparency color key to be used when composing the layered window. All pixels painted by the window in this color will be transparent. To generate a **COLORREF**, use the RGB macro.  
  
 *pblend*  
 Pointer to a [BLENDFUNCTION](http://msdn.microsoft.com/library/windows/desktop/dd183393) structure that specifies the transparency value to be used when composing the layered window.  
  
 `dwFlags`  
 Specifies an action to take. This parameter can be one or more of the following values. For a list of possible values, see[UpdateLayeredWindow](http://msdn.microsoft.com/library/windows/desktop/ms633556).  
  
## Return Value  
 Nonzero if the function succeeds; otherwise 0.  
  
## Remarks  
 This member function emulates the functionality of the function [UpdateLayeredWindow](http://msdn.microsoft.com/library/windows/desktop/ms633556), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::SetLayeredWindowAttributes](../vs140/cwnd--setlayeredwindowattributes.md)