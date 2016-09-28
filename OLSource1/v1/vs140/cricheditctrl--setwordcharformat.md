---
title: "CRichEditCtrl::SetWordCharFormat"
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
  - "CRichEditCtrl.SetWordCharFormat"
  - "SetWordCharFormat"
  - "CRichEditCtrl::SetWordCharFormat"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetWordCharFormat method"
ms.assetid: 5e996e21-3bab-49be-84ba-8e67acca7298
caps.latest.revision: 19
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRichEditCtrl::SetWordCharFormat
Sets the character formatting attributes for the currently selected word in this `CRichEditCtrl` object.  
  
## Syntax  
  
```  
  
      BOOL SetWordCharFormat(  
   CHARFORMAT& cf   
);  
BOOL SetWordCharFormat(  
   CHARFORMAT2& cf   
);  
```  
  
#### Parameters  
 `cf`  
 In the first version, a pointer to a [CHARFORMAT](http://msdn.microsoft.com/library/windows/desktop/bb787881) structure containing the new character formatting attributes for the currently selected word.  
  
 In the second version, a pointer to a [CHARFORMAT2](http://msdn.microsoft.com/library/windows/desktop/bb787883) structure, which is a Rich Edit 2.0 extension to the **CHARFORMAT** structure, containing the new character formatting attributes for the currently selected word.  
  
## Return Value  
 Nonzero if successful; otherwise, 0.  
  
## Remarks  
 Only the attributes specified by the **dwMask** member of `cf` are changed by this function.  
  
 For more information, see the [EM_SETCHARFORMAT](http://msdn.microsoft.com/library/windows/desktop/bb774230) message and the **CHARFORMAT** and **CHARFORMAT2** structures in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 [!code[NVC_MFC_CRichEditCtrl#33](../vs140/codesnippet/CPP/cricheditctrl--setwordcharformat_1.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CRichEditCtrl Class](../vs140/cricheditctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRichEditCtrl::SetSelectionCharFormat](../vs140/cricheditctrl--setselectioncharformat.md)