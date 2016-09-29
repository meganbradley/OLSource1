---
title: "CRichEditCtrl::GetModify"
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
  - "CRichEditCtrl.GetModify"
  - "CRichEditCtrl::GetModify"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetModify method"
ms.assetid: d69e305f-ac4b-4333-a6ca-ac330d6e19dc
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRichEditCtrl::GetModify
Determines if the contents of this `CRichEditCtrl` object have been modified.  
  
## Syntax  
  
```  
  
BOOL GetModify( ) const;  
  
```  
  
## Return Value  
 Nonzero if the text in this `CRichEditCtrl` object has been modified; otherwise 0.  
  
## Remarks  
 Windows maintains an internal flag indicating whether the contents of the rich edit control have been changed. This flag is cleared when the edit control is first created and can also be cleared by calling the [SetModify](../vs140/cricheditctrl--setmodify.md) member function.  
  
 For more information, see [EM_GETMODIFY](http://msdn.microsoft.com/library/windows/desktop/bb761592) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 [!code[NVC_MFC_CRichEditCtrl#14](../vs140/codesnippet/CPP/cricheditctrl--getmodify_1.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CRichEditCtrl Class](../vs140/cricheditctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRichEditCtrl::SetModify](../vs140/cricheditctrl--setmodify.md)