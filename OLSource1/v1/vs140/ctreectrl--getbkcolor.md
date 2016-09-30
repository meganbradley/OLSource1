---
title: "CTreeCtrl::GetBkColor"
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
  - "CTreeCtrl.GetBkColor"
  - "CTreeCtrl::GetBkColor"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetBkColor method"
ms.assetid: e042b0b8-77a2-4d54-add4-48927c19b2ec
caps.latest.revision: 19
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTreeCtrl::GetBkColor
This member function implements the behavior of the Win32 message [TVM_GETBKCOLOR](http://msdn.microsoft.com/library/windows/desktop/bb773570), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A **COLORREF** value that represents the current window background color for the control. If this value is -1, the control is using the system window color. In this case, you can use <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> to get the current system color that the control is using.  
  
## Example  
 See the example for [CTreeCtrl::SetTextColor](../vs140/ctreectrl--settextcolor.md).  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CTreeCtrl Class](../vs140/ctreectrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CTreeCtrl::SetBkColor](../vs140/ctreectrl--setbkcolor.md)