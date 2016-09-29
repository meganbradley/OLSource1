---
title: "CEdit::CharFromPos"
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
  - "CEdit::CharFromPos"
  - "CEdit.CharFromPos"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CharFromPos method"
ms.assetid: 5353152b-c154-430e-814d-56f5d92d510f
caps.latest.revision: 17
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CEdit::CharFromPos
Call this function to retrieve the zero-based line and character indices of the character nearest the specified point in this `CEdit` control  
  
## Syntax  
  
```  
  
      int CharFromPos(  
   CPoint pt   
) const;  
```  
  
#### Parameters  
 `pt`  
 The coordinates of a point in the client area of this `CEdit` object.  
  
## Return Value  
 The character index in the low-order **WORD**, and the line index in the high-order **WORD**.  
  
## Remarks  
  
> [!NOTE]
>  This member function is available beginning with Windows 95 and Windows NT 4.0.  
  
 For more information, see [EM_CHARFROMPOS](http://msdn.microsoft.com/library/windows/desktop/bb761566) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 [!code[NVC_MFC_CEdit#3](../vs140/codesnippet/CPP/cedit--charfrompos_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CEdit Class](../vs140/cedit-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CEdit::PosFromChar](../vs140/cedit--posfromchar.md)