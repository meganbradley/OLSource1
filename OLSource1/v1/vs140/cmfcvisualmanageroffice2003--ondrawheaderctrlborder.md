---
title: "CMFCVisualManagerOffice2003::OnDrawHeaderCtrlBorder"
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
  - "CMFCVisualManagerOffice2003::OnDrawHeaderCtrlBorder"
  - "OnDrawHeaderCtrlBorder"
  - "CMFCVisualManagerOffice2003.OnDrawHeaderCtrlBorder"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDrawHeaderCtrlBorder method"
ms.assetid: 543112ab-2689-46e7-8341-94a989a2d42b
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCVisualManagerOffice2003::OnDrawHeaderCtrlBorder
The framework calls this method when it draws the border around an instance of the [CMFCHeaderCtrl Class](../vs140/cmfcheaderctrl-class.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to a [CMFCHeaderCtrl](../vs140/cmfcheaderctrl-class.md) object. The framework draws the border of this header control.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A rectangle that specifies the boundaries of the header control.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 A Boolean parameter that indicates whether the header control is pressed.  
  
## Remarks  
 Override this method in a derived visual manager to customize the border of the header control.  
  
## Requirements  
 **Header:** afxvisualmanageroffice2003.h  
  
## See Also  
 [CMFCVisualManagerOffice2003 Class](../vs140/cmfcvisualmanageroffice2003-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)