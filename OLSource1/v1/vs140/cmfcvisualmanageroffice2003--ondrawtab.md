---
title: "CMFCVisualManagerOffice2003::OnDrawTab"
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
  - "CMFCVisualManagerOffice2003::OnDrawTab"
  - "CMFCVisualManagerOffice2003.OnDrawTab"
  - "OnDrawTab"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDrawTab method"
ms.assetid: d5590dbf-bbae-495e-b5fa-4f7f3248f2cd
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCVisualManagerOffice2003::OnDrawTab
The framework calls this method when it draws the tabs for a [CMFCBaseTabCtrl](../vs140/cmfcbasetabctrl-class.md) object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A rectangle that specifies the boundaries of the tab control.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The index of the tab that the framework draws.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A Boolean parameter that specifies whether the tab is active.  
  
 [in] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 A pointer to a [CMFCBaseTabCtrl](../vs140/cmfcbasetabctrl-class.md) object. The framework draws this tab control.  
  
## Remarks  
 A <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object calls this method when it processes the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> message.Override this method in a derived class to customize the look of tabs.  
  
## Requirements  
 **Header:** afxvisualmanageroffice2003.h  
  
## See Also  
 [CMFCVisualManagerOffice2003 Class](../vs140/cmfcvisualmanageroffice2003-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)