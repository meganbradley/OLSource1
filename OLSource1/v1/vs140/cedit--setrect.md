---
title: "CEdit::SetRect"
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
  - "CEdit.SetRect"
  - "CEdit::SetRect"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetRect method"
  - "CEdit class, multiple-line operations"
ms.assetid: 74374aef-2793-4c1a-8530-f5f7778682a3
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CEdit::SetRect
Call this function to set the dimensions of a rectangle using the specified coordinates.  
  
## Syntax  
  
```  
  
      void SetRect(  
   LPCRECT lpRect   
);  
```  
  
#### Parameters  
 `lpRect`  
 Points to the `RECT` structure or `CRect` object that specifies the new dimensions of the formatting rectangle.  
  
## Remarks  
 This member is processed only by multiple-line edit controls.  
  
 Use `SetRect` to set the formatting rectangle of a multiple-line edit control. The formatting rectangle is the limiting rectangle of the text, which is independent of the size of the edit-control window. When the edit control is first created, the formatting rectangle is the same as the client area of the edit-control window. By using the `SetRect` member function, an application can make the formatting rectangle larger or smaller than the edit-control window.  
  
 If the edit control has no scroll bar, text will be clipped, not wrapped, if the formatting rectangle is made larger than the window. If the edit control contains a border, the formatting rectangle is reduced by the size of the border. If you adjust the rectangle returned by the `GetRect` member function, you must remove the size of the border before you pass the rectangle to `SetRect`.  
  
 When `SetRect` is called, the edit control's text is also reformatted and redisplayed.  
  
 For more information, see [EM_SETRECT](http://msdn.microsoft.com/library/windows/desktop/bb761657) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 [!code[NVC_MFC_CEdit#24](../vs140/codesnippet/CPP/cedit--setrect_1.cpp)]  
  
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
 [CEdit::SetRectNP](../vs140/cedit--setrectnp.md)