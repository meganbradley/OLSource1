---
title: "CRichEditCtrl::SetModify"
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
  - "CRichEditCtrl::SetModify"
  - "CRichEditCtrl.SetModify"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetModify method"
ms.assetid: c206730e-d761-4938-ac8c-a3293e4606cc
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRichEditCtrl::SetModify
Sets or clears the modified flag for an edit control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A value of **TRUE** indicates that the text has been modified, and a value of **FALSE** indicates it is unmodified. By default, the modified flag is set.  
  
## Remarks  
 The modified flag indicates whether or not the text within the edit control has been modified. It is automatically set whenever the user changes the text. Its value can be retrieved with the [GetModify](../vs140/cricheditctrl--getmodify.md) member function.  
  
 For more information, see [EM_SETMODIFY](http://msdn.microsoft.com/library/windows/desktop/bb761651) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 See the example for [GetModify](../vs140/cricheditctrl--getmodify.md).  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CRichEditCtrl Class](../vs140/cricheditctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRichEditCtrl::GetModify](../vs140/cricheditctrl--getmodify.md)