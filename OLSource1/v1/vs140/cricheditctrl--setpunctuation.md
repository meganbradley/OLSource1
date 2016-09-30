---
title: "CRichEditCtrl::SetPunctuation"
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
  - "CRichEditCtrl::SetPunctuation"
  - "CRichEditCtrl.SetPunctuation"
  - "SetPunctuation"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetPunctuation method"
ms.assetid: f8ff1547-06e0-452a-8a9c-49f030f73548
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRichEditCtrl::SetPunctuation
Sets the punctuation in a rich edit control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The punctuation flag. For a list of possible values, see the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> parameter for [EM_SETPUNCTUATION](http://msdn.microsoft.com/library/windows/desktop/bb774278) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A pointer to a [PUNCTUATION](http://msdn.microsoft.com/library/windows/desktop/bb787944) structure, as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Return Value  
 Nonzero if successful, otherwise 0.  
  
## Remarks  
 This member function is available for only Asian-language versions of the operating system.  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CRichEditCtrl Class](../vs140/cricheditctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRichEditCtrl::GetPunctuation](../vs140/cricheditctrl--getpunctuation.md)