---
title: "CRichEditCtrl::SetParaFormat"
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
  - "CRichEditCtrl.SetParaFormat"
  - "CRichEditCtrl::SetParaFormat"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetParaFormat method"
ms.assetid: a5b4725c-5b2c-43ee-89cd-7bc41f352d9d
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRichEditCtrl::SetParaFormat
Sets the paragraph formatting attributes for the current selection in this <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 In the first version, a pointer to a [PARAFORMAT](http://msdn.microsoft.com/library/windows/desktop/bb787940) structure containing the new default paragraph formatting attributes.  
  
 In the second version, a pointer to a [PARAFORMAT2](http://msdn.microsoft.com/library/windows/desktop/bb787942) structure, which is a Rich Edit 2.0 extension to the **PARAFORMAT** structure, holding the default character formatting attributes.  
  
## Return Value  
 Nonzero if successful; otherwise, 0.  
  
## Remarks  
 Only the attributes specified by the **dwMask** member of <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> are changed by this function.  
  
 For more information, see the [EM_SETPARAFORMAT](http://msdn.microsoft.com/library/windows/desktop/bb774276) message and the **PARAFORMAT** and **PARAFORMAT2** structures in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 [!code[NVC_MFC_CRichEditCtrl#28](../vs140/codesnippet/CPP/cricheditctrl--setparaformat_1.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CRichEditCtrl Class](../vs140/cricheditctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRichEditCtrl::GetParaFormat](../vs140/cricheditctrl--getparaformat.md)   
 [CRichEditCtrl::SetSelectionCharFormat](../vs140/cricheditctrl--setselectioncharformat.md)