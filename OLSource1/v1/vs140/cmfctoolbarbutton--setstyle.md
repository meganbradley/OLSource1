---
title: "CMFCToolBarButton::SetStyle"
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
  - "SetStyle"
  - "CMFCToolBarButton::SetStyle"
  - "CMFCToolBarButton.SetStyle"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetStyle method"
ms.assetid: 5d10ec23-d12a-4aa5-9a23-28bfbc1e48e8
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBarButton::SetStyle
Sets the style of the button.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The new style of the button.  
  
## Remarks  
 The default implementation sets the [CMFCToolBarButton::m_nStyle](../vs140/cmfctoolbarbutton--m_nstyle.md) data member to <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>. Override this method if you want to perform additional processing to handle the change in style. See [ToolBar Control Styles](../vs140/toolbar-control-styles.md) for a list of valid style flags.  
  
## Requirements  
 **Header:** afxtoolbarbutton.h  
  
## See Also  
 [CMFCToolBarButton Class](../vs140/cmfctoolbarbutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCToolBarButton::m_nStyle](../vs140/cmfctoolbarbutton--m_nstyle.md)   
 [ToolBar Control Styles](../vs140/toolbar-control-styles.md)