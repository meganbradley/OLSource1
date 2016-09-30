---
title: "CRichEditCtrl::Clear"
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
  - "CRichEditCtrl::Clear"
  - "CRichEditCtrl.Clear"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Clear method"
ms.assetid: 4fe696b7-d67b-4838-88de-1f678a415901
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRichEditCtrl::Clear
Deletes (clears) the current selection (if any) in the rich edit control.  
  
## Syntax  
  
```  
  
void Clear( );  
  
```  
  
## Remarks  
 The deletion performed by **Clear** can be undone by calling the [Undo](../vs140/cricheditctrl--undo.md) member function.  
  
 To delete the current selection and place the deleted contents onto the Clipboard, call the [Cut](../vs140/cricheditctrl--cut.md) member function.  
  
 For more information, see [WM_CLEAR](http://msdn.microsoft.com/library/windows/desktop/ms649020) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 [!code[NVC_MFC_CRichEditCtrl#3](../vs140/codesnippet/CPP/cricheditctrl--clear_1.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CRichEditCtrl Class](../vs140/cricheditctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRichEditCtrl::Undo](../vs140/cricheditctrl--undo.md)   
 [CRichEditCtrl::Cut](../vs140/cricheditctrl--cut.md)   
 [CRichEditCtrl::Copy](../vs140/cricheditctrl--copy.md)   
 [CRichEditCtrl::Paste](../vs140/cricheditctrl--paste.md)