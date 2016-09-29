---
title: "CEdit::FmtLines"
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
  - "CEdit.FmtLines"
  - "CEdit::FmtLines"
  - "FmtLines"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "FmtLines method"
  - "CEdit class, multiple-line operations"
ms.assetid: 0b7a2c23-5770-46ae-ae4a-8af18e00a7f9
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CEdit::FmtLines
Call this function to set the inclusion of soft line-break characters on or off within a multiple-line edit control.  
  
## Syntax  
  
```  
  
      BOOL FmtLines(  
   BOOL bAddEOL   
);  
```  
  
#### Parameters  
 *bAddEOL*  
 Specifies whether soft line-break characters are to be inserted. A value of **TRUE** inserts the characters; a value of **FALSE** removes them.  
  
## Return Value  
 Nonzero if any formatting occurs; otherwise 0.  
  
## Remarks  
 A soft line break consists of two carriage returns and a linefeed inserted at the end of a line that is broken because of word wrapping. A hard line break consists of one carriage return and a linefeed. Lines that end with a hard line break are not affected by `FmtLines`.  
  
 Windows will only respond if the `CEdit` object is a multiple-line edit control.  
  
 `FmtLines` only affects the buffer returned by [GetHandle](../vs140/cedit--gethandle.md) and the text returned by [WM_GETTEXT](http://msdn.microsoft.com/library/windows/desktop/ms632627). It has no impact on the display of the text within the edit control.  
  
 For more information, see [EM_FMTLINES](http://msdn.microsoft.com/library/windows/desktop/bb761570) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 [!code[NVC_MFC_CEdit#8](../vs140/codesnippet/CPP/cedit--fmtlines_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CEdit Class](../vs140/cedit-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CEdit::GetHandle](../vs140/cedit--gethandle.md)   
 [CWnd::GetWindowText](../vs140/cwnd--getwindowtext.md)