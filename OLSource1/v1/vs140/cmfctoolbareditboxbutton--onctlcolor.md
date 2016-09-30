---
title: "CMFCToolBarEditBoxButton::OnCtlColor"
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
  - "CMFCToolBarEditBoxButton.OnCtlColor"
  - "OnCtlColor"
  - "CMFCToolBarEditBoxButton::OnCtlColor"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnCtlColor method"
ms.assetid: 1486c128-f22c-4b1b-8008-24cc2217f3b8
caps.latest.revision: 11
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBarEditBoxButton::OnCtlColor
Called by the framework when the parent toolbar handles a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> message.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The device context that displays the button.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Unused.  
  
## Return Value  
 A handle to the global window brush.  
  
## Remarks  
 This method overrides the base class implementation ([CMFCToolBarButton::OnCtlColor](../vs140/cmfctoolbarbutton--onctlcolor.md)) by setting the text and background colors of the provided device context to the global text and background colors, respectively.  
  
 For more information about global options that are available to your application, see [AFX_GLOBAL_DATA Structure](../vs140/afx_global_data-structure.md).  
  
## Requirements  
 **Header:** afxtoolbareditboxbutton.h  
  
## See Also  
 [CMFCToolBarEditBoxButton Class](../vs140/cmfctoolbareditboxbutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCToolBarButton::OnCtlColor](../vs140/cmfctoolbarbutton--onctlcolor.md)   
 [AFX_GLOBAL_DATA Structure](../vs140/afx_global_data-structure.md)