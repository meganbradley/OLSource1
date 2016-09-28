---
title: "CRichEditCtrl::Paste"
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
  - "CRichEditCtrl.Paste"
  - "CRichEditCtrl::Paste"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Paste method"
ms.assetid: 5b6c189a-fc3c-41e6-a648-807e6324b37a
caps.latest.revision: 18
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRichEditCtrl::Paste
Inserts the data from the Clipboard into the `CRichEditCtrl` at the insertion point, the location of the caret.  
  
## Syntax  
  
```  
  
void Paste( );  
  
```  
  
## Remarks  
 Data is inserted only if the Clipboard contains data in a recognized format.  
  
 For more information, see [WM_PASTE](http://msdn.microsoft.com/library/windows/desktop/ms649028) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 [!code[NVC_MFC_CRichEditCtrl#22](../vs140/codesnippet/CPP/cricheditctrl--paste_1.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CRichEditCtrl Class](../vs140/cricheditctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRichEditCtrl::Copy](../vs140/cricheditctrl--copy.md)   
 [CRichEditCtrl::Cut](../vs140/cricheditctrl--cut.md)   
 [CRichEditCtrl::PasteSpecial](../vs140/cricheditctrl--pastespecial.md)