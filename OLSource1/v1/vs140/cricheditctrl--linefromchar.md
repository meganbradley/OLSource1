---
title: "CRichEditCtrl::LineFromChar"
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
  - CRichEditCtrl::LineFromChar
  - CRichEditCtrl.LineFromChar
dev_langs: 
  - C++
helpviewer_keywords: 
  - LineFromChar method
ms.assetid: 75c68013-fb59-43d3-a1d1-6f2216ec0289
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CRichEditCtrl::LineFromChar
Retrieves the line number of the line that contains the specified character index.  
  
## Syntax  
  
```  
  
      long LineFromChar(  
   long nIndex   
) const;  
```  
  
#### Parameters  
 `nIndex`  
 Contains the zero-based index value for the desired character in the text of the edit control, or contains –1. If `nIndex` is –1, it specifies the current line, that is, the line that contains the caret.  
  
## Return Value  
 The zero-based line number of the line containing the character index specified by `nIndex`. If `nIndex` is –1, the number of the line that contains the first character of the selection is returned. If there is no selection, the current line number is returned.  
  
## Remarks  
 A character index is the number of characters from the beginning of the rich edit control. For character counting, an OLE item is counted as a single character.  
  
 For more information, see [EM_EXLINEFROMCHAR](http://msdn.microsoft.com/library/windows/desktop/bb788005) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 [!code[NVC_MFC_CRichEditCtrl#20](../vs140/codesnippet/CPP/cricheditctrl--linefromchar_1.cpp)]
  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CRichEditCtrl Class](../vs140/cricheditctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRichEditCtrl::GetLineCount](../vs140/cricheditctrl--getlinecount.md)   
 [CRichEditCtrl::GetLine](../vs140/cricheditctrl--getline.md)   
 [CRichEditCtrl::LineIndex](../vs140/cricheditctrl--lineindex.md)