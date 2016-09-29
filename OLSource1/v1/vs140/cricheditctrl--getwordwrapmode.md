---
title: "CRichEditCtrl::GetWordWrapMode"
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
  - "CRichEditCtrl.GetWordWrapMode"
  - "GetWordWrapMode"
  - "CRichEditCtrl::GetWordWrapMode"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetWordWrapMode method"
ms.assetid: 6e356a29-010f-44c0-97ca-3c42ff7cd900
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRichEditCtrl::GetWordWrapMode
Retrieves the current word wrapping and word breaking options for the rich edit control.  
  
## Syntax  
  
```  
  
UINT GetWordWrapMode( ) const;  
  
```  
  
## Return Value  
 The current word wrapping and word breaking options. These options are described in [EM_SETWORDWRAPMODE](http://msdn.microsoft.com/library/windows/desktop/bb774294) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Remarks  
 This member function is available only for Asian-language versions of the operating system.  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CRichEditCtrl Class](../vs140/cricheditctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)