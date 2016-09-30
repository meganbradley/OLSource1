---
title: "CRichEditView::SetParaFormat"
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
  - "CRichEditView::SetParaFormat"
  - "CRichEditView.SetParaFormat"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetParaFormat method"
  - "CRichEditView class, attributes"
ms.assetid: 2fd8ca4c-79e6-4d00-8b2a-a422fb2242ce
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRichEditView::SetParaFormat
Call this function to set the paragraph formatting attributes for the current selection in this <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [PARAFORMAT2](http://msdn.microsoft.com/library/windows/desktop/bb787942) structure containing the new default paragraph formatting attributes.  
  
## Return Value  
 Nonzero if successful; otherwise, 0.  
  
## Remarks  
 Only the attributes specified by the **dwMask** member of <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> are changed by this function.  
  
 For more information, see [EM_SETPARAFORMAT](http://msdn.microsoft.com/library/windows/desktop/bb774276) message and [PARAFORMAT2](http://msdn.microsoft.com/library/windows/desktop/bb787942) structure in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 [!code[NVC_MFCDocView#162](../vs140/codesnippet/CPP/cricheditview--setparaformat_1.cpp)]  
  
## Requirements  
 **Header:** afxrich.h  
  
## See Also  
 [CRichEditView Class](../vs140/cricheditview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRichEditView::GetParaFormatSelection](../vs140/cricheditview--getparaformatselection.md)   
 [CRichEditView::SetCharFormat](../vs140/cricheditview--setcharformat.md)