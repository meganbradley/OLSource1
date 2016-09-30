---
title: "CMFCToolBarButton::HasFocus"
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
  - "CMFCToolBarButton.HasFocus"
  - "HasFocus"
  - "CMFCToolBarButton::HasFocus"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "HasFocus method"
ms.assetid: ba5a6a73-7dd3-401b-a94e-c66811d84964
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBarButton::HasFocus
Determines whether the button has the current input focus.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Nonzero if the button has the input focus; otherwise 0.  
  
## Remarks  
 The default implementation of this method returns nonzero if the button has the input focus or is a child or descendant window of the window that has the input focus. You can override this function to customize this behavior.  
  
## Requirements  
 **Header:** afxtoolbarbutton.h  
  
## See Also  
 [CMFCToolBarButton Class](../vs140/cmfctoolbarbutton-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)