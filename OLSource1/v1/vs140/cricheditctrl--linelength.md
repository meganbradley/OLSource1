---
title: "CRichEditCtrl::LineLength"
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
  - "CRichEditCtrl::LineLength"
  - "CRichEditCtrl.LineLength"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "LineLength method"
ms.assetid: 05d222fa-9be2-4bb6-b079-06e0335c2e31
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRichEditCtrl::LineLength
Retrieves the length of a line in a rich edit control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the character index of a character in the line whose length is to be retrieved. If this parameter is –1, the length of the current line (the line that contains the caret) is returned, not including the length of any selected text within the line. When <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is called for a single-line edit control, this parameter is ignored.  
  
## Return Value  
 When <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is called for a multiple-line edit control, the return value is the length (in bytes) of the line specified by <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. When <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is called for a single-line edit control, the return value is the length (in bytes) of the text in the edit control.  
  
## Remarks  
 Use the [LineIndex](../vs140/cricheditctrl--lineindex.md) member function to retrieve a character index for a given line number within this <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object.  
  
 For more information, see [EM_LINELENGTH](http://msdn.microsoft.com/library/windows/desktop/bb761613) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 See the example for [LineIndex](../vs140/cricheditctrl--lineindex.md).  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CRichEditCtrl Class](../vs140/cricheditctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRichEditCtrl::LineIndex](../vs140/cricheditctrl--lineindex.md)