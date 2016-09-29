---
title: "CRichEditCtrl::GetTextLengthEx"
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
  - "CRichEditCtrl.GetTextLengthEx"
  - "GetTextLengthEx"
  - "CRichEditCtrl::GetTextLengthEx"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetTextLengthEx method"
ms.assetid: 248eae73-292f-401d-8d62-848ac5329410
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRichEditCtrl::GetTextLengthEx
Calculates the length of the text in the rich edit control.  
  
## Syntax  
  
```  
  
      long GetTextLengthEx(  
   DWORD dwFlags,  
   UINT uCodePage = -1   
) const;  
```  
  
#### Parameters  
 `dwFlags`  
 Value specifying the method to be used in determining the text length. This member can be one or more of the values listed in the flags member of [GETTEXTLENGTHEX](http://msdn.microsoft.com/library/windows/desktop/bb787915) described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 `uCodePage`  
 Code page for translation (CP_ACP for ANSI Code Page, 1200 for Unicode).  
  
## Return Value  
 The number of characters or bytes in the edit control. If incompatible flags were set in `dwFlags`, this member function returns `E_INVALIDARG`.  
  
## Remarks  
 `GetTextLengthEx` provides additional ways of determining the length of the text. It supports the Rich Edit 2.0 functionality. See [About Rich Edit Controls](http://msdn.microsoft.com/library/windows/desktop/bb787873) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]for more information.  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CRichEditCtrl Class](../vs140/cricheditctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRichEditCtrl::GetTextRange](../vs140/cricheditctrl--gettextrange.md)