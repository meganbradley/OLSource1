---
title: "CRichEditCtrl::LineScroll"
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
  - "CRichEditCtrl::LineScroll"
  - "CRichEditCtrl.LineScroll"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "LineScroll method"
ms.assetid: fc117523-fd02-439e-8c96-a3452bf7071e
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRichEditCtrl::LineScroll
Scrolls the text of a multiple-line edit control.  
  
## Syntax  
  
```  
  
      void LineScroll(  
   int nLines,  
   int nChars = 0   
);  
```  
  
#### Parameters  
 `nLines`  
 Specifies the number of lines to scroll vertically.  
  
 `nChars`  
 Specifies the number of character positions to scroll horizontally. This value is ignored if the rich edit control has either the **ES_RIGHT** or **ES_CENTER** style. [Edit styles](../vs140/edit-styles.md) are specified in [Create](../vs140/cricheditctrl--create.md).  
  
## Remarks  
 The edit control does not scroll vertically past the last line of text in the edit control. If the current line plus the number of lines specified by `nLines` exceeds the total number of lines in the edit control, the value is adjusted so that the last line of the edit control is scrolled to the top of the edit-control window.  
  
 `LineScroll` can be used to scroll horizontally past the last character of any line.  
  
 For more information, see [EM_LINESCROLL](http://msdn.microsoft.com/library/windows/desktop/bb761615) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 See the example for [GetFirstVisibleLine](../vs140/cricheditctrl--getfirstvisibleline.md).  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CRichEditCtrl Class](../vs140/cricheditctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRichEditCtrl::LineIndex](../vs140/cricheditctrl--lineindex.md)