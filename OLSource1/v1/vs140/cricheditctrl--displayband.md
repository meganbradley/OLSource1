---
title: "CRichEditCtrl::DisplayBand"
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
  - "CRichEditCtrl.DisplayBand"
  - "DisplayBand"
  - "CRichEditCtrl::DisplayBand"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DisplayBand method"
ms.assetid: 07d92086-5145-4002-9642-869147f1a3a2
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRichEditCtrl::DisplayBand
Displays a portion of the contents of the rich edit control (text and OLE items), as previously formatted by [FormatRange](../vs140/cricheditctrl--formatrange.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Pointer to a [RECT](../vs140/rect-structure.md) or [CRect](../vs140/crect-class.md) object specifying the area of the device to display the text.  
  
## Return Value  
 Nonzero if the display of the formatted text succeeds, otherwise, 0.  
  
## Remarks  
 The text and OLE items are clipped to the area specified by the pointer <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
 For more information, see [EM_DISPLAYBAND](http://msdn.microsoft.com/library/windows/desktop/bb787997) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 See the example for [CRichEditCtrl::FormatRange](../vs140/cricheditctrl--formatrange.md).  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CRichEditCtrl Class](../vs140/cricheditctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRichEditCtrl::FormatRange](../vs140/cricheditctrl--formatrange.md)