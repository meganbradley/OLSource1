---
title: "CRichEditCtrl::GetLimitText"
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
  - "CRichEditCtrl.GetLimitText"
  - "CRichEditCtrl::GetLimitText"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetLimitText method"
ms.assetid: f2b960a1-60b2-48b5-aa5b-cfb919aaccf8
caps.latest.revision: 18
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRichEditCtrl::GetLimitText
Gets the text limit for this `CRichEditCtrl` object.  
  
## Syntax  
  
```  
  
long GetLimitText( ) const;  
  
```  
  
## Return Value  
 The current text limit, in bytes, for this `CRichEditCtrl` object.  
  
## Remarks  
 The text limit is the maximum amount of text, in bytes, the rich edit control can accept.  
  
 For more information, see [EM_GETLIMITTEXT](http://msdn.microsoft.com/library/windows/desktop/bb761582) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 [!code[NVC_MFC_CRichEditCtrl#12](../vs140/codesnippet/CPP/cricheditctrl--getlimittext_1.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CRichEditCtrl Class](../vs140/cricheditctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRichEditCtrl::LimitText](../vs140/cricheditctrl--limittext.md)