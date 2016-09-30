---
title: "CRichEditCtrl::Undo"
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
  - "CRichEditCtrl::Undo"
  - "CRichEditCtrl.Undo"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Undo method"
ms.assetid: 66e8832b-b48d-4c3d-a1fb-3933b842f3fb
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRichEditCtrl::Undo
Undoes the last operation in the rich edit control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Nonzero if the undo operation is successful; otherwise, 0.  
  
## Remarks  
 An undo operation can also be undone. For example, you can restore deleted text with the first call to **Undo**. As long as there is no intervening edit operation, you can remove the text again with a second call to **Undo**.  
  
 For more information, see [EM_UNDO](http://msdn.microsoft.com/library/windows/desktop/bb761670) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 See the example for [CanUndo](../vs140/cricheditctrl--canundo.md).  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CRichEditCtrl Class](../vs140/cricheditctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRichEditCtrl::CanUndo](../vs140/cricheditctrl--canundo.md)   
 [CRichEditCtrl::EmptyUndoBuffer](../vs140/cricheditctrl--emptyundobuffer.md)