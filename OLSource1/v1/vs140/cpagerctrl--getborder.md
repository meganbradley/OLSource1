---
title: "CPagerCtrl::GetBorder"
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
  - "CPagerCtrl::GetBorder"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetBorder method"
ms.assetid: 60e1e989-4bc5-4687-80d2-53c0758d8ff3
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPagerCtrl::GetBorder
Retrieves the border size of the current pager control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** afxcmn.h  
  
## Return Value  
 The current border size, measured in pixels.  
  
## Remarks  
 This method sends the [PGM_GETBORDER](http://msdn.microsoft.com/library/windows/desktop/bb760869) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 The following example uses the [CPagerCtrl::GetBorder](../vs140/cpagerctrl--getborder.md) method to retrieve the thickness of the pager control's border.  
  
 [!code[NVC_MFC_CSplitButton_s2#5](../vs140/codesnippet/CPP/cpagerctrl--getborder_1.cpp)]  
  
## See Also  
 [CPagerCtrl Class](../vs140/cpagerctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [PGM_GETBORDER](http://msdn.microsoft.com/library/windows/desktop/bb760869)   
 [CPagerCtrl::SetBorder](../vs140/cpagerctrl--setborder.md)