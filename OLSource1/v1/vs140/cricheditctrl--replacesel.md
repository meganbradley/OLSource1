---
title: "CRichEditCtrl::ReplaceSel"
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
  - "CRichEditCtrl.ReplaceSel"
  - "CRichEditCtrl::ReplaceSel"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ReplaceSel method"
ms.assetid: 9e27db0d-a46f-4479-8328-36f7ea1bbf18
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRichEditCtrl::ReplaceSel
Replaces the current selection in this `CRichEditCtrl` object with the specified text.  
  
## Syntax  
  
```  
  
      void ReplaceSel(  
   LPCTSTR lpszNewText,  
   BOOL bCanUndo = FALSE   
);  
```  
  
#### Parameters  
 `lpszNewText`  
 Pointer to a null-terminated string containing the replacement text.  
  
 `bCanUndo`  
 To specify that this function can be undone, set the value of this parameter to **TRUE**. The default value is **FALSE**.  
  
## Remarks  
 To replace all the text in this `CRichEditCtrl` object, use [CWnd::SetWindowText](../vs140/cwnd--setwindowtext.md).  
  
 If there is no current selection, the replacement text is inserted at the insertion point, that is, the current caret location.  
  
 This function will format the inserted text with the existing character formatting. When replacing the entire range of text (by calling `SetSel`(0,-1) before calling `ReplaceSel`), there is an end of paragraph character that retains the previous paragraph's formatting, which in inherited by the newly inserted text.  
  
 For more information, see [EM_REPLACESEL](http://msdn.microsoft.com/library/windows/desktop/bb761633) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 See the example for [LineIndex](../vs140/cricheditctrl--lineindex.md).  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CRichEditCtrl Class](../vs140/cricheditctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRichEditCtrl::CanUndo](../vs140/cricheditctrl--canundo.md)   
 [CRichEditCtrl::Undo](../vs140/cricheditctrl--undo.md)   
 [CWnd::SetWindowText](../vs140/cwnd--setwindowtext.md)