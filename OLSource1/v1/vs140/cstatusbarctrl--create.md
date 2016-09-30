---
title: "CStatusBarCtrl::Create"
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
  - "CStatusBarCtrl::Create"
  - "CStatusBarCtrl.Create"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CCS_NORESIZE constant"
  - "CCS_NOMOVEY constant"
  - "CCS_TOP constant"
  - "Create method [C++]"
  - "CStatusBarCtrl class, constructors"
  - "CCS_NOPARENTALIGN constant"
  - "CCS_BOTTOM constant"
  - "CCS_NOHILITE constant"
  - "CCS_NODIVIDER constant"
  - "status bar controls, constructing"
ms.assetid: 0f879c8c-225d-4038-8241-1e027e7ad318
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CStatusBarCtrl::Create
Creates a status bar control and attaches it to a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the status bar control's style. Apply any combination of status bar control styles listed in [Common Control Styles](http://msdn.microsoft.com/library/windows/desktop/bb775498) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. This parameter must include the **WS_CHILD** style. It should also include the **WS_VISIBLE** style.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Specifies the status bar control's size and position. It can be either a [CRect](../vs140/crect-class.md) object or a [RECT](http://msdn.microsoft.com/library/windows/desktop/dd162897) structure.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Specifies the status bar control's parent window, usually a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. It must not be **NULL.**  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Specifies the status bar control's ID.  
  
## Return Value  
 Nonzero if successful; otherwise zero.  
  
## Remarks  
 You construct a <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> in two steps. First, call the constructor, and then call **Create**, which creates the status bar control and attaches it to the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object.  
  
 The default position of a status window is along the bottom of the parent window, but you can specify the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> style to have it appear at the top of the parent window's client area. You can specify the **SBARS_SIZEGRIP** style to include a sizing grip at the right end of the status window. Combining the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> and **SBARS_SIZEGRIP** styles is not recommended, because the resulting sizing grip is not functional even though the system draws it in the status window.  
  
 To create a status bar with extended window styles, call [CStatusBarCtrl::CreateEx](../vs140/cstatusbarctrl--createex.md) instead of **Create**.  
  
## Example  
 [!code[NVC_MFC_CStatusBarCtrl#1](../vs140/codesnippet/CPP/cstatusbarctrl--create_1.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CStatusBarCtrl Class](../vs140/cstatusbarctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CStatusBarCtrl::CStatusBarCtrl](../vs140/cstatusbarctrl--cstatusbarctrl.md)