---
title: "CToolTipCtrl::GetCurrentTool"
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
  - "CToolTipCtrl::GetCurrentTool"
  - "CToolTipCtrl.GetCurrentTool"
  - "GetCurrentTool method"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetCurrentTool method"
ms.assetid: fb14e47b-4167-4e82-a4ae-a59ca78e1aea
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CToolTipCtrl::GetCurrentTool
Retrieves information, such as the size, position, and text, of the tooltip window displayed by the current tooltip control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[out] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|Pointer to a [TOOLINFO](http://msdn.microsoft.com/library/windows/desktop/bb760256) structure that receives information about the current tooltip window.|  
  
## Return Value  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> if the information is retrieved successfully; otherwise, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
  
## Remarks  
 This method sends the [TTM_GETCURRENTTOOL](http://msdn.microsoft.com/library/windows/desktop/bb760389) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxcmn.h  
  
## Example  
 The following code example retrieves information about the current tooltip window.  
  
 [!code[NVC_MFC_CToolBarCtrl_s1#6](../vs140/codesnippet/CPP/ctooltipctrl--getcurrenttool_1.cpp)]  
  
## See Also  
 [CToolTipCtrl Class](../vs140/ctooltipctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [TTM_GETCURRENTTOOL](http://msdn.microsoft.com/library/windows/desktop/bb760389)   
 [TOOLINFO](http://msdn.microsoft.com/library/windows/desktop/bb760256)