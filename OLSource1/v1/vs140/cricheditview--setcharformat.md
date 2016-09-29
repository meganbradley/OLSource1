---
title: "CRichEditView::SetCharFormat"
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
  - "CRichEditView::SetCharFormat"
  - "SetCharFormat"
  - "CRichEditView.SetCharFormat"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetCharFormat method"
  - "CRichEditView class, attributes"
ms.assetid: cc3fd397-012d-4c45-8be3-13982aa2a762
caps.latest.revision: 17
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRichEditView::SetCharFormat
Call this function to set the character formatting attributes for new text in this `CRichEditView` object.  
  
## Syntax  
  
```  
  
      void SetCharFormat(  
   CHARFORMAT2 cf   
);  
```  
  
#### Parameters  
 `cf`  
 [CHARFORMAT2](http://msdn.microsoft.com/library/windows/desktop/bb787883) structure containing the new default character formatting attributes.  
  
## Remarks  
 Only the attributes specified by the **dwMask** member of `cf` are changed by this function.  
  
 For more information, see [EM_SETCHARFORMAT](http://msdn.microsoft.com/library/windows/desktop/bb774230) message and [CHARFORMAT2](http://msdn.microsoft.com/library/windows/desktop/bb787883) structure in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 [!code[NVC_MFCDocView#152](../vs140/codesnippet/CPP/cricheditview--setcharformat_1.cpp)]  
  
## Requirements  
 **Header:** afxrich.h  
  
## See Also  
 [CRichEditView Class](../vs140/cricheditview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRichEditView::GetCharFormatSelection](../vs140/cricheditview--getcharformatselection.md)   
 [CRichEditView::SetParaFormat](../vs140/cricheditview--setparaformat.md)