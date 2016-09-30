---
title: "CWnd::OnDrawIconicThumbnailOrLivePreview"
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
  - "afxwin/CWnd::OnDrawIconicThumbnailOrLivePreview"
  - "OnDrawIconicThumbnailOrLivePreview"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDrawIconicThumbnailOrLivePreview"
ms.assetid: 88781cfd-be52-41af-b48f-587befce7307
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::OnDrawIconicThumbnailOrLivePreview
Called by the framework when it needs to obtain a bitmap to be displayed on Windows 7 tab thumbnail, or on the client for application peek.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the device context.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the bounding rectangle of the area to render.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Specifies the size of the target thumbnail. Should be ignored if <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Specifies whether this method is called for iconic thumbnail or live preview (peek).  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 [out] Set it to <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> if your implementation initializes the alpha channel of a bitmap selected in <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
## Remarks  
 Override this method in a derived class and draw on the specified device context in order to customize thumbnail and peek. If <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> can be ignored. In this case you should be aware that you draw full sized bitmap (that is, a bitmap that covers the whole client area). The device context (<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>) comes with selected 32 bits bitmap. The default implementation sends WM_PRINT to this window with PRF_CLIENT, PRF_CHILDREN, and PRF_NONCLIENT flags.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)