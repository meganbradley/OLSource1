---
title: "CRichEditCtrl::HideSelection"
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
  - "CRichEditCtrl::HideSelection"
  - "HideSelection"
  - "CRichEditCtrl.HideSelection"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ECO_NOHIDESEL"
  - "HideSelection method"
ms.assetid: 1713a378-b7a1-4b14-9551-0ed0c9a2cd5e
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRichEditCtrl::HideSelection
Changes the visibility of the selection.  
  
## Syntax  
  
```  
  
      void HideSelection(  
   BOOL bHide,  
   BOOL bPerm   
);  
```  
  
#### Parameters  
 `bHide`  
 Indicates if the selection should be shown or hidden, **TRUE** to hide the selection.  
  
 `bPerm`  
 Indicates if this change in visibility for the selection should be permanent.  
  
## Remarks  
 When `bPerm` is **TRUE**, it changes the `ECO_NOHIDESEL` option for this `CRichEditCtrl` object. For a brief description of this option, see [SetOptions](../vs140/cricheditctrl--setoptions.md). You can use this function to set all the options for this `CRichEditCtrl` object.  
  
 For more information, see [EM_HIDESELECTION](http://msdn.microsoft.com/library/windows/desktop/bb774210) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 [!code[NVC_MFC_CRichEditCtrl#18](../vs140/codesnippet/CPP/cricheditctrl--hideselection_1.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CRichEditCtrl Class](../vs140/cricheditctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRichEditCtrl::SetSel](../vs140/cricheditctrl--setsel.md)   
 [CRichEditCtrl::GetSelectionType](../vs140/cricheditctrl--getselectiontype.md)