---
title: "CFrameWndEx::OnClosePopupMenu"
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
  - "CFrameWndEx.OnClosePopupMenu"
  - "CFrameWndEx::OnClosePopupMenu"
  - "OnClosePopupMenu"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnClosePopupMenu method"
ms.assetid: 07ffc236-db46-4d6b-b5ff-a1dd6a173841
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFrameWndEx::OnClosePopupMenu
Called by the framework when an active pop-up menu processes a WM_DESTROY message.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to a pop-up menu.  
  
## Remarks  
 The framework sends a WM_DESTROY message when it is about to close the window. Override this method if you want to handle notifications from <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> objects that belong to the frame window when a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object is processing a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> message sent by the framework when the window is being closed.  
  
## Requirements  
 **Header:** afxframewndex.h  
  
## See Also  
 [CFrameWndEx Class](../vs140/cframewndex-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)