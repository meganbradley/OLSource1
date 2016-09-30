---
title: "CRichEditCtrl::PosFromChar"
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
  - "PosFromChar"
  - "CRichEditCtrl.PosFromChar"
  - "CRichEditCtrl::PosFromChar"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "PosFromChar method"
ms.assetid: 24e32ab7-fafd-4299-a035-daf279a437e9
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRichEditCtrl::PosFromChar
Retrieves the client area coordinates of a specified character in an edit control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The zero-based index of the character.  
  
## Return Value  
 The position of the character, (x, y). For a single-line edit control, the y-coordinate is always zero.  
  
## Remarks  
 For more information, see [EM_POSFROMCHAR](http://msdn.microsoft.com/library/windows/desktop/bb761631) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CRichEditCtrl Class](../vs140/cricheditctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRichEditCtrl::GetCharPos](../vs140/cricheditctrl--getcharpos.md)