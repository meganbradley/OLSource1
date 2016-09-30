---
title: "CRichEditView::GetParaFormatSelection"
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
  - "GetParaFormatSelection"
  - "CRichEditView.GetParaFormatSelection"
  - "CRichEditView::GetParaFormatSelection"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CRichEditView class, attributes"
  - "GetParaFormatSelection method"
ms.assetid: af54f34b-b645-4fc1-a580-a517d2b11e04
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRichEditView::GetParaFormatSelection
Call this function to get the paragraph formatting attributes of the current selection.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A [PARAFORMAT2](http://msdn.microsoft.com/library/windows/desktop/bb787942) structure which contains the paragraph formatting attributes of the current selection.  
  
## Remarks  
 For more information, see [EM_GETPARAFORMAT](http://msdn.microsoft.com/library/windows/desktop/bb774182) message and [PARAFORMAT2](http://msdn.microsoft.com/library/windows/desktop/bb787942) structure in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxrich.h  
  
## See Also  
 [CRichEditView Class](../vs140/cricheditview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRichEditView::GetCharFormatSelection](../vs140/cricheditview--getcharformatselection.md)   
 [CRichEditView::SetParaFormat](../vs140/cricheditview--setparaformat.md)   
 [CRichEditCtrl::GetParaFormat](../vs140/cricheditctrl--getparaformat.md)