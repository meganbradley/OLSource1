---
title: "CRichEditCtrl::LimitText"
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
  - CRichEditCtrl.LimitText
  - CRichEditCtrl::LimitText
dev_langs: 
  - C++
helpviewer_keywords: 
  - LimitText method
ms.assetid: c43d0522-484e-4474-b707-f04f63939488
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CRichEditCtrl::LimitText
Limits the length of the text that the user can enter into an edit control.  
  
## Syntax  
  
```  
  
      void LimitText(  
   long nChars = 0   
);  
```  
  
#### Parameters  
 `nChars`  
 Specifies the length (in bytes) of the text that the user can enter. If this parameter is 0 (the default value), the text length is set to 64K bytes.  
  
## Remarks  
 Changing the text limit restricts only the text the user can enter. It has no effect on any text already in the edit control, nor does it affect the length of the text copied to the edit control by the [SetWindowText](../vs140/cwnd--setwindowtext.md) member function in `CWnd`. If an application uses the `SetWindowText` function to place more text into an edit control than is specified in the call to `LimitText`, the user can delete any of the text within the edit control. However, the text limit will prevent the user from replacing the existing text with new text, unless deleting the current selection causes the text to fall below the text limit.  
  
> [!NOTE]
>  For the text limit, each OLE item counts as a single character.  
  
 For more information, see [EM_EXLIMITTEXT](http://msdn.microsoft.com/library/windows/desktop/bb788003) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 [!code[NVC_MFC_CRichEditCtrl#19](../vs140/codesnippet/CPP/cricheditctrl--limittext_1.cpp)]
  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CRichEditCtrl Class](../vs140/cricheditctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRichEditCtrl::GetLimitText](../vs140/cricheditctrl--getlimittext.md)