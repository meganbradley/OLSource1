---
title: "CWnd::OnDrawIconicThumbnailOrLivePreview"
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
  - afxwin/CWnd::OnDrawIconicThumbnailOrLivePreview
  - OnDrawIconicThumbnailOrLivePreview
dev_langs: 
  - C++
helpviewer_keywords: 
  - OnDrawIconicThumbnailOrLivePreview
ms.assetid: 88781cfd-be52-41af-b48f-587befce7307
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CWnd::OnDrawIconicThumbnailOrLivePreview
Called by the framework when it needs to obtain a bitmap to be displayed on Windows 7 tab thumbnail, or on the client for application peek.  
  
## Syntax  
  
```  
virtual void OnDrawIconicThumbnailOrLivePreview(  
   CDC& dc,  
   CRect rect,  
   CSize szRequiredThumbnailSize,  
   BOOL bIsThumbnail,  
   BOOL& bAlphaChannelSet  
);  
```  
  
#### Parameters  
 `dc`  
 Specifies the device context.  
  
 `rect`  
 Specifies the bounding rectangle of the area to render.  
  
 `szRequiredThumbnailSize`  
 Specifies the size of the target thumbnail. Should be ignored if `bIsThumbnail` is `FALSE`.  
  
 `bIsThumbnail`  
 Specifies whether this method is called for iconic thumbnail or live preview (peek).  
  
 `bAlphaChannelSet`  
 [out] Set it to `TRUE` if your implementation initializes the alpha channel of a bitmap selected in `dc`.  
  
## Remarks  
 Override this method in a derived class and draw on the specified device context in order to customize thumbnail and peek. If `bThumbnail` is `TRUE`, `szRequiredThumbnailSize` can be ignored. In this case you should be aware that you draw full sized bitmap (that is, a bitmap that covers the whole client area). The device context (`dc`) comes with selected 32 bits bitmap. The default implementation sends WM_PRINT to this window with PRF_CLIENT, PRF_CHILDREN, and PRF_NONCLIENT flags.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)