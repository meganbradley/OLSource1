---
title: "CRichEditCtrl::SetSelectionCharFormat"
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
  - "CRichEditCtrl.SetSelectionCharFormat"
  - "SetSelectionCharFormat"
  - "CRichEditCtrl::SetSelectionCharFormat"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetSelectionCharFormat method"
ms.assetid: 9e3cfd5d-86f6-4a04-9bfc-740572df997d
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRichEditCtrl::SetSelectionCharFormat
Sets the character formatting attributes for the text in the current selection in this <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 In the first version, a pointer to a [CHARFORMAT](http://msdn.microsoft.com/library/windows/desktop/bb787881) structure containing the new character formatting attributes for the current selection.  
  
 In the second version, a pointer to a [CHARFORMAT2](http://msdn.microsoft.com/library/windows/desktop/bb787883) structure, which is a Rich Edit 2.0 extension to the **CHARFORMAT** structure, containing the new character formatting attributes for the current selection.  
  
## Return Value  
 Nonzero if successful; otherwise, 0.  
  
## Remarks  
 Only the attributes specified by the **dwMask** member of <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> are changed by this function.  
  
 For more information, see the [EM_SETCHARFORMAT](http://msdn.microsoft.com/library/windows/desktop/bb774230) and the **CHARFORMAT** and **CHARFORMAT2** structures in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 [!code[NVC_MFC_CRichEditCtrl#31](../vs140/codesnippet/CPP/cricheditctrl--setselectioncharformat_1.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CRichEditCtrl Class](../vs140/cricheditctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRichEditCtrl::GetSelectionCharFormat](../vs140/cricheditctrl--getselectioncharformat.md)   
 [CRichEditCtrl::SetDefaultCharFormat](../vs140/cricheditctrl--setdefaultcharformat.md)