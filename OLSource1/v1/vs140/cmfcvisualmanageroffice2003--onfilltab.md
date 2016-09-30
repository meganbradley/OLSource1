---
title: "CMFCVisualManagerOffice2003::OnFillTab"
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
  - "CMFCVisualManagerOffice2003.OnFillTab"
  - "CMFCVisualManagerOffice2003::OnFillTab"
  - "OnFillTab"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnFillTab method"
ms.assetid: e734822f-be3f-444a-828e-ab9193c4b943
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCVisualManagerOffice2003::OnFillTab
The framework calls this method when it fills the background of a tab window.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A rectangle that specifies the boundaries for the tab window.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A pointer to the brush that the framework is using to fill the tab window.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The zero-based tab index of a tab for which the framework fills the background.  
  
 [in] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> if the tab is active or <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> if not.  
  
 [in] <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 A pointer to the parent tab control.  
  
## Remarks  
 Override this method in a derived visual manager to customize the appearance of tabs.  
  
## Requirements  
 **Header:** afxvisualmanageroffice2003.h  
  
## See Also  
 [CMFCVisualManagerOffice2003 Class](../vs140/cmfcvisualmanageroffice2003-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)