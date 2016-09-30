---
title: "CMFCVisualManagerOffice2003::OnFillBarBackground"
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
  - "OnFillBarBackground"
  - "CMFCVisualManagerOffice2003::OnFillBarBackground"
  - "CMFCVisualManagerOffice2003.OnFillBarBackground"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnFillBarBackground method"
ms.assetid: c9b3c3e9-e6f1-4e14-84e7-6e1079d32519
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCVisualManagerOffice2003::OnFillBarBackground
The framework calls this method when it fills the background of a [CBasePane](../vs140/cbasepane-class.md) object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to the device context for a control bar.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to a [CBasePane](../vs140/cbasepane-class.md) object. The framework fills the background of this pane.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A rectangle that specifies the boundaries of the pane.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A rectangle that specifies the clipping area of the pane.  
  
 [in] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 A reserved value.  
  
## Remarks  
 The default implementation of this method fills the background of the bar with the 3d background color from the global variable <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
 Override this method in a derived visual manager to customize the background of a pane.  
  
## Requirements  
 **Header:** afxvisualmanageroffice2003.h  
  
## See Also  
 [CMFCVisualManagerOffice2003 Class](../vs140/cmfcvisualmanageroffice2003-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)