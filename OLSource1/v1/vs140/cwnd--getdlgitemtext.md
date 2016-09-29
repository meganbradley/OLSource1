---
title: "CWnd::GetDlgItemText"
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
  - "CWnd.GetDlgItemText"
  - "CWnd::GetDlgItemText"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetDlgItemText method"
ms.assetid: c75ce07e-de4c-4d61-b458-69cac4a1af9b
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::GetDlgItemText
Call this member function to retrieve the title or text associated with a control in a dialog box.  
  
## Syntax  
  
```  
  
      int GetDlgItemText(  
   int nID,  
   LPTSTR lpStr,  
   int nMaxCount   
) const;  
int GetDlgItemText(  
   int nID,  
   CString& rString   
) const;  
```  
  
#### Parameters  
 `nID`  
 Specifies the integer identifier of the control whose title is to be retrieved.  
  
 `lpStr`  
 Points to the buffer to receive the control's title or text.  
  
 `nMaxCount`  
 Specifies the maximum length (in characters) of the string to be copied to `lpStr`. If the string is longer than `nMaxCount`, it is truncated.  
  
 `rString`  
 A reference to a [CString](../vs140/cstringt-class.md).  
  
## Return Value  
 Specifies the actual number of characters copied to the buffer, not including the terminating null character. The value is 0 if no text is copied.  
  
## Remarks  
 The `GetDlgItemText` member function copies the text to the location pointed to by `lpStr` and returns a count of the number of bytes it copies.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::GetDlgItem](../vs140/cwnd--getdlgitem.md)   
 [CWnd::GetDlgItemInt](../vs140/cwnd--getdlgitemint.md)   
 [GetDlgItemText](http://msdn.microsoft.com/library/windows/desktop/ms645489)   
 [WM_GETTEXT](http://msdn.microsoft.com/library/windows/desktop/ms632627)