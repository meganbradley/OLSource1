---
title: "CRichEditCtrl::SetOptions"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - ECO_VERTICAL
  - ECO_READONLY
  - ECO_AUTOHSCROLL
  - ECOOP_XOR
  - ECO_AUTOVSCROLL
  - ECO_NOHIDESEL
  - ECOOP_OR
  - ECO_WANTRETURN
  - CRichEditCtrl::SetOptions
  - ECO_SAVESEL
  - ECO_AUTOWORDSELECTION
  - ECOOP_AND
  - ECOOP_SET
  - CRichEditCtrl.SetOptions
dev_langs: 
  - C++
helpviewer_keywords: 
  - ECOOP_AND
  - ECO_NOHIDESEL
  - ECO_READONLY
  - ECO_SAVESEL
  - ECO_WANTRETURN
  - ECO_VERTICAL
  - ECOOP_SET
  - ECOOP_OR
  - ECO_AUTOHSCROLL
  - ECO_AUTOWORDSELECTION
  - ECO_AUTOVSCROLL
  - ECOOP_XOR
  - SetOptions method
ms.assetid: fbe281fb-2b82-472c-ab31-e184f2fd1eb4
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CRichEditCtrl::SetOptions
Sets the options for this `CRichEditCtrl` object.  
  
## Syntax  
  
```  
  
      void SetOptions(  
   WORD wOp,  
   DWORD dwFlags   
);  
```  
  
#### Parameters  
 *wOp*  
 Indicates the type of operation. One of the following values:  
  
-   `ECOOP_SET` Set the options to those specified by `dwFlags`.  
  
-   `ECOOP_OR` Combine the current options with those specified by `dwFlags`.  
  
-   `ECOOP_AND` Retain only those current options that are also specified by `dwFlags`.  
  
-   `ECOOP_XOR` Retain only those current options that are *not* specified by `dwFlags`.  
  
 `dwFlags`  
 Rich edit options. The flag values are listed in the Remarks section.  
  
## Remarks  
 The options can be a combination of the following values:  
  
-   `ECO_AUTOWORDSELECTION` Automatic word selection on double-click.  
  
-   `ECO_AUTOVSCROLL` Automatically scrolls text to the right by 10 characters when the user types a character at the end of the line. When the user presses the ENTER key, the control scrolls all text back to position zero.  
  
-   `ECO_AUTOHSCROLL` Automatically scrolls text up one page when the user presses the ENTER key on the last line.  
  
-   `ECO_NOHIDESEL` Negates the default behavior for an edit control. The default behavior hides the selection when the control loses the input focus and shows the selection when the control receives the input focus. If you specify `ECO_NOHIDESEL`, the selected text is inverted, even if the control does not have the focus.  
  
-   `ECO_READONLY` Prevents the user from typing or editing text in the edit control.  
  
-   `ECO_WANTRETURN` Specifies that a carriage return be inserted when the user presses the ENTER key while entering text into a multiple-line rich edit control in a dialog box. If you do not specify this style, pressing the ENTER key sends a command to the rich edit control's parent window, which mimics clicking the parent window's default button (for example, the OK button in a dialog box). This style has no effect on a single-line edit control.  
  
-   `ECO_SAVESEL` Preserves the selection when the control loses the focus. By default, the entire contents of the control are selected when it regains the focus.  
  
-   `ECO_VERTICAL` Draws text and objects in a vertical direction. Available for Asian languages only.  
  
 For more information, see [EM_SETOPTIONS](http://msdn.microsoft.com/library/windows/desktop/bb774254) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 [!code[NVC_MFC_CRichEditCtrl#27](../vs140/codesnippet/CPP/cricheditctrl--setoptions_1.cpp)]
  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CRichEditCtrl Class](../vs140/cricheditctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRichEditCtrl::HideSelection](../vs140/cricheditctrl--hideselection.md)   
 [CRichEditCtrl::SetReadOnly](../vs140/cricheditctrl--setreadonly.md)