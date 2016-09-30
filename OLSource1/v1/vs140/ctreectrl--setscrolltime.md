---
title: "CTreeCtrl::SetScrollTime"
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
  - "SetScrollTime"
  - "CTreeCtrl.SetScrollTime"
  - "CTreeCtrl::SetScrollTime"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetScrollTime method"
ms.assetid: fafa894a-b2d9-4f72-8047-5592c34b33de
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTreeCtrl::SetScrollTime
Call this member function to set the maximum scroll time for the tree view control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *uScrollTime*  
 The new maximum scroll time, in milliseconds. If this value is less than 100, it will be rounded up to 100.  
  
## Return Value  
 The previous maximum scroll time, in milliseconds.  
  
## Remarks  
 This member function implements the behavior of the win32 message [TVM_SETSCROLLTIME](http://msdn.microsoft.com/library/windows/desktop/bb773767), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CTreeCtrl Class](../vs140/ctreectrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CTreeCtrl::GetScrollTime](../vs140/ctreectrl--getscrolltime.md)