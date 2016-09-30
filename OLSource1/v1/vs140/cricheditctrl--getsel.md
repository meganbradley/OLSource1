---
title: "CRichEditCtrl::GetSel"
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
  - "CRichEditCtrl.GetSel"
  - "CRichEditCtrl::GetSel"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetSel method"
ms.assetid: 9d487125-c79d-4ff3-bcff-d93d14715a0a
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRichEditCtrl::GetSel
Retrieves the bounds of the current selection in this <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Reference to a [CHARRANGE](http://msdn.microsoft.com/library/windows/desktop/bb787885) structure to receive the bounds of the current selection.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Zero-based index of the first character in the current selection.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Zero-based index of the last character in the current selection.  
  
## Remarks  
 The two forms of this function provide alternate ways to get the bounds for the selection. Brief descriptions of these forms follow:  
  
-   **GetSel(**  <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  **)** This form uses the **CHARRANGE** structure with its **cpMin** and **cpMax** members to return the bounds.  
  
-   **GetSel(**  <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> **,**  <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  **)** This form returns the bounds in the parameters <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
 The selection includes everything if the beginning (**cpMin** or <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>) is 0 and the end (**cpMax** or <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>) is – 1.  
  
 For more information, see [EM_EXGETSEL](http://msdn.microsoft.com/library/windows/desktop/bb788001) message and [CHARRANGE](http://msdn.microsoft.com/library/windows/desktop/bb787885) structure in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 [!code[NVC_MFC_CRichEditCtrl#15](../vs140/codesnippet/CPP/cricheditctrl--getsel_1.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CRichEditCtrl Class](../vs140/cricheditctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRichEditCtrl::SetSel](../vs140/cricheditctrl--setsel.md)   
 [CRichEditCtrl::GetSelText](../vs140/cricheditctrl--getseltext.md)   
 [CRichEditCtrl::GetParaFormat](../vs140/cricheditctrl--getparaformat.md)   
 [CRichEditCtrl::GetSelectionCharFormat](../vs140/cricheditctrl--getselectioncharformat.md)