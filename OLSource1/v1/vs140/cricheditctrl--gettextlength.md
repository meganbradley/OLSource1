---
title: "CRichEditCtrl::GetTextLength"
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
  - "GetTextLength"
  - "CRichEditCtrl::GetTextLength"
  - "CRichEditCtrl.GetTextLength"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetTextLength method"
ms.assetid: 453d3943-13df-4bc6-b52d-1d1168a726a3
caps.latest.revision: 18
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRichEditCtrl::GetTextLength
Retrieves the length of the text, in characters, in this `CRichEditCtrl` object, not including the terminating null character.  
  
## Syntax  
  
```  
  
long GetTextLength( ) const;  
  
```  
  
## Return Value  
 The length of the text in this `CRichEditCtrl` object.  
  
## Remarks  
 For more information, see [WM_GETTEXTLENGTH](http://msdn.microsoft.com/library/windows/desktop/ms632628) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 [!code[NVC_MFC_CRichEditCtrl#17](../vs140/codesnippet/CPP/cricheditctrl--gettextlength_1.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CRichEditCtrl Class](../vs140/cricheditctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRichEditCtrl::LimitText](../vs140/cricheditctrl--limittext.md)   
 [CRichEditCtrl::GetLimitText](../vs140/cricheditctrl--getlimittext.md)