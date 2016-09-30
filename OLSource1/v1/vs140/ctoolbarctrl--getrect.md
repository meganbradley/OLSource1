---
title: "CToolBarCtrl::GetRect"
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
  - "CToolBarCtrl.GetRect"
  - "CToolBarCtrl::GetRect"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetRect method"
ms.assetid: 2f142772-a524-4bf2-9269-0ce3e6e5d356
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CToolBarCtrl::GetRect
Retrieves the bounding rectangle for a specified toolbar button.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The button identifier.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to a [RECT](http://msdn.microsoft.com/library/windows/desktop/dd162897) structure to receive the bounding rectangle information.  
  
## Return Value  
 **TRUE** if successful; otherwise **FALSE**.  
  
## Remarks  
 This member function implements the behavior of the Win32 message [TB_GETRECT](http://msdn.microsoft.com/library/windows/desktop/bb787346), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CToolBarCtrl Class](../vs140/ctoolbarctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)