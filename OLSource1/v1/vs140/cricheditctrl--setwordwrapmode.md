---
title: "CRichEditCtrl::SetWordWrapMode"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - SetWordWrapMode
  - CRichEditCtrl.SetWordWrapMode
  - CRichEditCtrl::SetWordWrapMode
dev_langs: 
  - C++
helpviewer_keywords: 
  - SetWordWrapMode method
ms.assetid: 3eeae80e-dbcd-493b-b33f-4fb872526cb5
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CRichEditCtrl::SetWordWrapMode
Sets the word-wrapping and word-breaking options for the rich edit control.  
  
## Syntax  
  
```  
  
      UINT SetWordWrapMode(  
   UINT uFlags   
) const;  
```  
  
#### Parameters  
 `uFlags`  
 The options to set for word wrapping and word breaking. For a list of possible options, see [EM_SETWORDWRAPMODE](http://msdn.microsoft.com/library/windows/desktop/bb774294) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Return Value  
 The current word-wrapping and word-breaking options.  
  
## Remarks  
 This message is available only in Asian-language versions of the operating system.  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CRichEditCtrl Class](../vs140/cricheditctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRichEditCtrl::GetWordWrapMode](../vs140/cricheditctrl--getwordwrapmode.md)