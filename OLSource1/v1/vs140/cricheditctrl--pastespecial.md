---
title: "CRichEditCtrl::PasteSpecial"
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
  - "CRichEditCtrl::PasteSpecial"
  - "PasteSpecial"
  - "CRichEditCtrl.PasteSpecial"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "PasteSpecial method"
ms.assetid: 758f5360-2f2a-4ebc-93c4-450e9f268181
caps.latest.revision: 18
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRichEditCtrl::PasteSpecial
Pastes data in a specific Clipboard format into this `CRichEditCtrl` object.  
  
## Syntax  
  
```  
  
      void PasteSpecial(  
   UINT nClipFormat,  
   DWORD dvAspect = 0,  
   HMETAFILE hMF = 0   
);  
```  
  
#### Parameters  
 *nClipFormat*  
 Clipboard format to paste into this `CRichEditCtrl` object.  
  
 *dvAspect*  
 Device aspect for the data to be retrieved from the Clipboard.  
  
 *hMF*  
 Handle to the metafile containing the iconic view of the object to be pasted.  
  
## Remarks  
 The new material is inserted at the insertion point, the location of the caret.  
  
 For more information, see [EM_PASTESPECIAL](http://msdn.microsoft.com/library/windows/desktop/bb774214) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 [!code[NVC_MFC_CRichEditCtrl#23](../vs140/codesnippet/CPP/cricheditctrl--pastespecial_1.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CRichEditCtrl Class](../vs140/cricheditctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRichEditCtrl::Paste](../vs140/cricheditctrl--paste.md)   
 [CRichEditCtrl::Copy](../vs140/cricheditctrl--copy.md)   
 [CRichEditCtrl::Cut](../vs140/cricheditctrl--cut.md)