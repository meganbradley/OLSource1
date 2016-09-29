---
title: "CEdit::SetRectNP"
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
  - "SetRectNP"
  - "CEdit.SetRectNP"
  - "CEdit::SetRectNP"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetRectNP method"
  - "CEdit class, multiple-line operations"
ms.assetid: 680d9e4e-3d32-44b5-a862-313ac8f5565f
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CEdit::SetRectNP
Call this function to set the formatting rectangle of a multiple-line edit control.  
  
## Syntax  
  
```  
  
      void SetRectNP(  
   LPCRECT lpRect   
);  
```  
  
#### Parameters  
 `lpRect`  
 Points to a `RECT` structure or `CRect` object that specifies the new dimensions of the rectangle.  
  
## Remarks  
 The formatting rectangle is the limiting rectangle of the text, which is independent of the size of the edit-control window.  
  
 `SetRectNP` is identical to the `SetRect` member function except that the edit-control window is not redrawn.  
  
 When the edit control is first created, the formatting rectangle is the same as the client area of the edit-control window. By calling the `SetRectNP` member function, an application can make the formatting rectangle larger or smaller than the edit-control window.  
  
 If the edit control has no scroll bar, text will be clipped, not wrapped, if the formatting rectangle is made larger than the window.  
  
 This member is processed only by multiple-line edit controls.  
  
 For more information, see [EM_SETRECTNP](http://msdn.microsoft.com/library/windows/desktop/bb761659) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 See the example for [CEdit::SetRect](../vs140/cedit--setrect.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CEdit Class](../vs140/cedit-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRect::CRect](../vs140/crect--crect.md)   
 [CRect::CopyRect](../vs140/crect--copyrect.md)   
 [CRect::operator =](../vs140/crect--operator-=.md)   
 [CRect::SetRectEmpty](../vs140/crect--setrectempty.md)   
 [CEdit::GetRect](../vs140/cedit--getrect.md)   
 [CEdit::SetRect](../vs140/cedit--setrect.md)