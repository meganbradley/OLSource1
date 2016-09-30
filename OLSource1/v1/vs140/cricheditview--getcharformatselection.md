---
title: "CRichEditView::GetCharFormatSelection"
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
  - "CRichEditView.GetCharFormatSelection"
  - "GetCharFormatSelection"
  - "CRichEditView::GetCharFormatSelection"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CRichEditView class, attributes"
  - "GetCharFormatSelection method"
ms.assetid: bc9dbd03-105c-4062-860d-1b094c54bb6e
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRichEditView::GetCharFormatSelection
Call this function to get the character formatting attributes of the current selection.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A [CHARFORMAT2](http://msdn.microsoft.com/library/windows/desktop/bb787883) structure which contains the character formatting attributes of the current selection.  
  
## Remarks  
 For more information, see the [EM_GETCHARFORMAT](http://msdn.microsoft.com/library/windows/desktop/bb788026) message and the [CHARFORMAT2](http://msdn.microsoft.com/library/windows/desktop/bb787883) structure in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 [!code[NVC_MFCDocView#152](../vs140/codesnippet/CPP/cricheditview--getcharformatselection_1.cpp)]  
  
## Requirements  
 **Header:** afxrich.h  
  
## See Also  
 [CRichEditView Class](../vs140/cricheditview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRichEditView::SetCharFormat](../vs140/cricheditview--setcharformat.md)   
 [CRichEditView::GetParaFormatSelection](../vs140/cricheditview--getparaformatselection.md)   
 [CRichEditCtrl::GetSelectionCharFormat](../vs140/cricheditctrl--getselectioncharformat.md)