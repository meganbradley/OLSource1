---
title: "CEdit::GetMargins"
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
  - "GetMargins"
  - "CEdit::GetMargins"
  - "CEdit.GetMargins"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetMargins method"
ms.assetid: d68bea3a-198f-4df6-98e5-bea6de00c13e
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CEdit::GetMargins
Call this member function to retrieve the left and right margins of this edit control.  
  
## Syntax  
  
```  
  
DWORD GetMargins( ) const;  
  
```  
  
## Return Value  
 The width of the left margin in the low-order **WORD** and the width of the right margin in the high-order **WORD**.  
  
## Remarks  
 Margins are measured in pixels.  
  
> [!NOTE]
>  This member function is available beginning with Windows 95 and Windows NT 4.0.  
  
 For more information, see [EM_GETMARGINS](http://msdn.microsoft.com/library/windows/desktop/bb761590) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 See the example for [CEditView::GetEditCtrl](../vs140/ceditview--geteditctrl.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CEdit Class](../vs140/cedit-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CEdit::SetMargins](../vs140/cedit--setmargins.md)