---
title: "CPagerCtrl::GetBkColor"
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
  - CPagerCtrl::GetBkColor
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetBkColor method
ms.assetid: 51f1158c-4390-48d8-98cc-cd9bcbe97856
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CPagerCtrl::GetBkColor
Retrieves the background color of the current pager control.  
  
## Syntax  
  
```  
COLORREF GetBkColor() const;  
```  
  
## Requirements  
 **Header:** afxcmn.h  
  
## Return Value  
 A [COLORREF](http://msdn.microsoft.com/library/windows/desktop/dd183449) value that contains the current background color of the pager control.  
  
## Remarks  
 This method sends the [PGM_GETBKCOLOR](http://msdn.microsoft.com/library/windows/desktop/bb760868) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 The following example uses the [CPagerCtrl::SetBkColor](../vs140/cpagerctrl--setbkcolor.md) method to set the background color of the pager control to red, and the [CPagerCtrl::GetBkColor](../vs140/cpagerctrl--getbkcolor.md) method to confirm that the change was made.  
  
 [!code[NVC_MFC_CSplitButton_s2#4](../vs140/codesnippet/CPP/cpagerctrl--getbkcolor_1.cpp)]
  
  
## See Also  
 [CPagerCtrl Class](../vs140/cpagerctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [PGM_GETBKCOLOR](http://msdn.microsoft.com/library/windows/desktop/bb760868)   
 [CPagerCtrl::SetBkColor](../vs140/cpagerctrl--setbkcolor.md)