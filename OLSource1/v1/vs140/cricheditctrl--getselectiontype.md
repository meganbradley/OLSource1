---
title: "CRichEditCtrl::GetSelectionType"
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
  - "SEL_MULTIOBJECT"
  - "GetSelectionType"
  - "SEL_OBJECT"
  - "CRichEditCtrl.GetSelectionType"
  - "SEL_EMPTY"
  - "SEL_MULTICHAR"
  - "SEL_TEXT"
  - "CRichEditCtrl::GetSelectionType"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetSelectionType method"
  - "SEL_MULTIOBJECT"
  - "SEL_OBJECT"
  - "SEL_EMPTY"
  - "SEL_TEXT"
  - "SEL_MULTICHAR"
ms.assetid: 527e2f24-4b82-4b61-ae98-616a48aeec87
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRichEditCtrl::GetSelectionType
Determines the selection type in this `CRichEditCtrl` object.  
  
## Syntax  
  
```  
  
WORD GetSelectionType( ) const;  
  
```  
  
## Return Value  
 Flags indicating the contents of the current selection. A combination of the following flags:  
  
-   `SEL_EMPTY` Indicates that there is no current selection.  
  
-   `SEL_TEXT` Indicates that the current selection contains text.  
  
-   `SEL_OBJECT` Indicates that the current selection contains at least one OLE item.  
  
-   `SEL_MULTICHAR` Indicates that the current selection contains more than one character of text.  
  
-   `SEL_MULTIOBJECT` Indicates that the current selection contains more than one OLE object.  
  
## Remarks  
 For more information, see [EM_SELECTIONTYPE](http://msdn.microsoft.com/library/windows/desktop/bb774223) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 [!code[NVC_MFC_CRichEditCtrl#16](../vs140/codesnippet/CPP/cricheditctrl--getselectiontype_1.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CRichEditCtrl Class](../vs140/cricheditctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRichEditCtrl::GetSel](../vs140/cricheditctrl--getsel.md)   
 [CRichEditCtrl::GetSelText](../vs140/cricheditctrl--getseltext.md)