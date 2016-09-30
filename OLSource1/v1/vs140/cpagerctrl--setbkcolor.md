---
title: "CPagerCtrl::SetBkColor"
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
  - "CPagerCtrl::SetBkColor"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetBkColor method"
ms.assetid: 97350564-049d-4cf2-a882-7f8a5b92ec2e
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPagerCtrl::SetBkColor
Sets the background color of the current pager control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|A [COLORREF](http://msdn.microsoft.com/library/windows/desktop/dd183449) value that contains the new background color of the pager control.|  
  
## Requirements  
 **Header:** afxcmn.h  
  
## Return Value  
 A [COLORREF](http://msdn.microsoft.com/library/windows/desktop/dd183449) value that contains the previous background color of the pager control.  
  
## Remarks  
 This method sends the [PGM_SETBKCOLOR](http://msdn.microsoft.com/library/windows/desktop/bb760878) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 The following example uses the [CPagerCtrl::SetBkColor](../vs140/cpagerctrl--setbkcolor.md) method to set the background color of the pager control to red, and the [CPagerCtrl::GetBkColor](../vs140/cpagerctrl--getbkcolor.md) method to confirm that the change was made.  
  
 [!code[NVC_MFC_CSplitButton_s2#4](../vs140/codesnippet/CPP/cpagerctrl--setbkcolor_1.cpp)]  
  
## See Also  
 [CPagerCtrl Class](../vs140/cpagerctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [PGM_SETBKCOLOR](http://msdn.microsoft.com/library/windows/desktop/bb760878)   
 [CPagerCtrl::GetBkColor](../vs140/cpagerctrl--getbkcolor.md)