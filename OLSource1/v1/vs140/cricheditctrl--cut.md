---
title: "CRichEditCtrl::Cut"
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
  - Cut
  - CRichEditCtrl.Cut
  - CRichEditCtrl::Cut
dev_langs: 
  - C++
helpviewer_keywords: 
  - Cut method
ms.assetid: ac84099b-dcdb-42ff-aff6-4e688d6807b7
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CRichEditCtrl::Cut
Delete (cuts) the current selection (if any) in the rich edit control and copies the deleted text to the Clipboard.  
  
## Syntax  
  
```  
  
void Cut( );  
  
```  
  
## Remarks  
 The deletion performed by **Cut** can be undone by calling the [Undo](../vs140/cricheditctrl--undo.md) member function.  
  
 To delete the current selection without placing the deleted text into the Clipboard, call the [Clear](../vs140/cricheditctrl--clear.md) member function.  
  
 For more information, see [WM_CUT](http://msdn.microsoft.com/library/windows/desktop/ms649023) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 [!code[NVC_MFC_CRichEditCtrl#7](../vs140/codesnippet/CPP/cricheditctrl--cut_1.cpp)]
  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CRichEditCtrl Class](../vs140/cricheditctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRichEditCtrl::Copy](../vs140/cricheditctrl--copy.md)   
 [CRichEditCtrl::Undo](../vs140/cricheditctrl--undo.md)   
 [CRichEditCtrl::Clear](../vs140/cricheditctrl--clear.md)