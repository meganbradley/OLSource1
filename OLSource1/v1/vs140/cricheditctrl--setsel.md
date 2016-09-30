---
title: "CRichEditCtrl::SetSel"
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
  - "CRichEditCtrl.SetSel"
  - "CRichEditCtrl::SetSel"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetSel method"
ms.assetid: cd42a64b-aa18-44a0-ad1e-2375dc207f47
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRichEditCtrl::SetSel
Sets the selection within this <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Zero-based index of the first character for the selection.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Zero-based index of the last character for the selection.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [CHARRANGE](http://msdn.microsoft.com/library/windows/desktop/bb787885) structure which holds the bounds of the current selection.  
  
## Remarks  
 The two forms of this function provide alternate ways to set the bounds for the selection. Brief descriptions of these forms follow:  
  
-   **SetSel(**  <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  **)** This form uses the **CHARRANGE** structure with its **cpMin** and **cpMax** members to set the bounds.  
  
-   **SetSel(**  <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> **,**  <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  **)** This form use the parameters <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> to set the bounds.  
  
 The caret is placed at the end of the selection indicated by the greater of the start (**cpMin** or <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>) and end (**cpMax** or <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>) indices. This function scrolls the contents of the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> so that the caret is visible.  
  
 To select all the text in this <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> object, call <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> with a start index of 0 and an end index of – 1.  
  
 For more information, see [EM_EXSETSEL](http://msdn.microsoft.com/library/windows/desktop/bb788007) message and [CHARRANGE](http://msdn.microsoft.com/library/windows/desktop/bb787885) structure in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 See the example for [GetSel](../vs140/cricheditctrl--getsel.md).  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CRichEditCtrl Class](../vs140/cricheditctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRichEditCtrl::GetSel](../vs140/cricheditctrl--getsel.md)   
 [CRichEditCtrl::GetSelectionType](../vs140/cricheditctrl--getselectiontype.md)