---
title: "CRichEditCtrl::CharFromPos"
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
  - "CRichEditCtrl.CharFromPos"
  - "CRichEditCtrl::CharFromPos"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CharFromPos method"
ms.assetid: 57686d42-fdd7-46d2-b76d-f66cdfd29111
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRichEditCtrl::CharFromPos
Retrieves information about the character at the point specified by the parameter <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A [CPoint](../vs140/cpoint-class.md) object containing the coordinates of the specified point.  
  
## Return Value  
 The zero-based character index of the character nearest the specified point. If the specified point is beyond the last character in the control, the return value indicates the last character in the control.  
  
## Remarks  
 This member function works with a rich edit control. To get the information for an edit control, call [CEdit::CharFromPos](../vs140/cedit--charfrompos.md).  
  
 For more information, see [EM_CHARFROMPOS](http://msdn.microsoft.com/library/windows/desktop/bb761566) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CRichEditCtrl Class](../vs140/cricheditctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRichEditCtrl::PosFromChar](../vs140/cricheditctrl--posfromchar.md)