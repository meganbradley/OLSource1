---
title: "CPagerCtrl::RecalcSize"
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
  - "CPagerCtrl::RecalcSize"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "RecalcSize method"
ms.assetid: 5875647e-e2ca-43d3-b27a-7dba3b0d3011
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPagerCtrl::RecalcSize
Causes the current pager control to recalculate the size of the contained window.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** afxcmn.h  
  
## Remarks  
 This method sends the [PGM_RECALCSIZE](http://msdn.microsoft.com/library/windows/desktop/bb760876) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. Consequently, the pager control sends the [PGN_CALCSIZE](http://msdn.microsoft.com/library/windows/desktop/bb760864) notification to obtain the scrollable dimensions of the contained window.  
  
## Example  
 The following example uses the [CPagerCtrl::RecalcSize](../vs140/cpagerctrl--recalcsize.md) method to request the current pager control to recalculate its size.  
  
 [!code[NVC_MFC_CSplitButton_s2#3](../vs140/codesnippet/CPP/cpagerctrl--recalcsize_1.cpp)]  
  
## Example  
 The following example uses [message reflection](../vs140/tn062--message-reflection-for-windows-controls.md) to enable the pager control to recalculate its own size instead of requiring the control's parent dialog to perform the calculation. The example derives the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> class from the [CPagerCtrl class](../vs140/cpagerctrl-class.md), then uses a message map to associate the [PGN_CALCSIZE](http://msdn.microsoft.com/library/windows/desktop/bb760864) notification with the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> notification handler. In this example, the notification handler sets the width and height of the pager control to fixed values.  
  
 [!code[NVC_MFC_CSplitButton_s2#8](../vs140/codesnippet/CPP/cpagerctrl--recalcsize_2.cpp)]  
  
## See Also  
 [CPagerCtrl Class](../vs140/cpagerctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [PGM_RECALCSIZE](http://msdn.microsoft.com/library/windows/desktop/bb760876)   
 [PGN_CALCSIZE](http://msdn.microsoft.com/library/windows/desktop/bb760864)