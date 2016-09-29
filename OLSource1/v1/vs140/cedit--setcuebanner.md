---
title: "CEdit::SetCueBanner"
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
  - "CEdit.SetCueBanner"
  - "CEdit::SetCueBanner"
  - "SetCueBanner"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CEdit class, general operations"
  - "SetCueBanner method"
ms.assetid: 71b939f7-7d9f-46e0-b2fb-061cf96dd296
caps.latest.revision: 24
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CEdit::SetCueBanner
Sets the text that is displayed as the text cue, or tip, in an edit control when the control is empty.  
  
## Syntax  
  
```  
BOOL SetCueBanner(  
     LPCWSTR lpszText  
);  
BOOL SetCueBanner(  
     LPCWSTR lpszText,   
     BOOL fDrawWhenFocused = FALSE  
);  
```  
  
#### Parameters  
 [in] `lpszText`  
 Pointer to a string that contains the cue to display in the edit control.  
  
 [in] `fDrawWhenFocused`  
 If `false`, the cue banner is not drawn when the user clicks in the edit control and gives the control the focus.  
  
 If `true`, the cue banner is drawn even when the control has focus. The cue banner disappears when the user starts to type in the control.  
  
 The default value is `false`.  
  
## Return Value  
 `true` if the method is successful; otherwise `false`.  
  
## Remarks  
 This method sends the [EM_SETCUEBANNER](http://msdn.microsoft.com/library/windows/desktop/bb761639) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. For more information, see the [Edit_SetCueBannerTextFocused](http://msdn.microsoft.com/library/windows/desktop/bb761703) macro.  
  
## Requirements  
 **Header:** afxwin.h  
  
 This control is supported in Windows XP and later.  
  
 Additional requirements for this method are described in [Build Requirements for Vista Common Controls](../vs140/build-requirements-for-windows-vista-common-controls.md).  
  
## Example  
 The following example demonstrates the [CEdit::SetCueBanner](../vs140/cedit--setcuebanner.md) method.  
  
 [!code[NVC_MFC_CEdit_s1#2](../vs140/codesnippet/CPP/cedit--setcuebanner_1.cpp)]  
  
## See Also  
 [CEdit Class](../vs140/cedit-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CEdit::GetCueBanner](../vs140/cedit--getcuebanner.md)   
 [EM_SETCUEBANNER](http://msdn.microsoft.com/library/windows/desktop/bb761639)   
 [Edit_SetCueBannerTextFocused](http://msdn.microsoft.com/library/windows/desktop/bb761703)