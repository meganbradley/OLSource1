---
title: "CMDIFrameWndEx::m_bCanCovertControlBarToMDIChild"
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
  - "CMDIFrameWndEx::m_bCanCovertControlBarToMDIChild"
  - "CMDIFrameWndEx.m_bCanCovertControlBarToMDIChild"
  - "m_bCanCovertControlBarToMDIChild"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "m_bCanCovertControlBarToMDIChild"
  - "CMDIFrameWndEx class, data members"
ms.assetid: d78d757e-47e8-4eb7-a61e-24be379403bc
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMDIFrameWndEx::m_bCanCovertControlBarToMDIChild
Specifies whether docking panes can be converted to MDI child windows.  
  
## Syntax  
  
```  
BOOL m_bCanCovertControlBarToMDIChild;  
```  
  
## Remarks  
 Indicates whether docking control bars can be converted to MDI child windows. If this flag is `TRUE`, the framework handles the conversion automatically when the user selects the **Tabbed Document** command. The flag is protected and you must explicitly enable this option either by setting `m_bCanCovertControlBarToMDIChild` in a constructor of a `CMDIFrameWndEx`-derived class, or by overriding `CanConvertControlBarToMDIChild`.  
  
 The default value is `FALSE`.  
  
## Example  
 The following example shows how `m_bCanCovertControlBarToMDIChild` is used in the [VisualStudioDemo Sample: MFC Visual Studio Application](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_VisualStudioDemo#13](../vs140/codesnippet/CPP/cmdiframewndex--m_bcancovertcontrolbartomdichild_1.cpp)]  
  
## Requirements  
 **Header:** afxMDIFrameWndEx.h  
  
## See Also  
 [CMDIFrameWndEx Class](../vs140/cmdiframewndex-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)