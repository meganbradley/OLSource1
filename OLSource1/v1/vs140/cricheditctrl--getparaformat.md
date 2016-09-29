---
title: "CRichEditCtrl::GetParaFormat"
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
  - "CRichEditCtrl::GetParaFormat"
  - "CRichEditCtrl.GetParaFormat"
  - "GetParaFormat"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetParaFormat method"
ms.assetid: 4006c6e5-0637-4586-89b9-35c3f19cd8a5
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRichEditCtrl::GetParaFormat
Gets the paragraph formatting attributes of the current selection.  
  
## Syntax  
  
```  
  
      DWORD GetParaFormat(  
   PARAFORMAT& pf   
) const;  
DWORD GetParaFormat(  
   PARAFORMAT2& pf   
) const;  
```  
  
#### Parameters  
 `pf`  
 In the first version, a pointer to a [PARAFORMAT](http://msdn.microsoft.com/library/windows/desktop/bb787940) structure to hold the paragraph formatting attributes of the current selection.  
  
 In the second version, a pointer to a [PARAFORMAT2](http://msdn.microsoft.com/library/windows/desktop/bb787942) structure, which is a Rich Edit 2.0 extension to the **PARAFORMAT** structure, holding the default character formatting attributes.  
  
## Return Value  
 The **dwMask** data member of `pf`. It specifies the paragraph formatting attributes that are consistent throughout the current selection.  
  
## Remarks  
 If more than one paragraph is selected, `pf` receives the attributes of the first selected paragraph. The return value specifies which attributes are consistent throughout the selection.  
  
 For more information, see the [EM_GETPARAFORMAT](http://msdn.microsoft.com/library/windows/desktop/bb774182) message and the **PARAFORMAT** and **PARAFORMAT2** structures in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 See the example for [CRichEditCtrl::SetParaFormat](../vs140/cricheditctrl--setparaformat.md).  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CRichEditCtrl Class](../vs140/cricheditctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRichEditCtrl::SetParaFormat](../vs140/cricheditctrl--setparaformat.md)   
 [CRichEditCtrl::GetSelectionCharFormat](../vs140/cricheditctrl--getselectioncharformat.md)