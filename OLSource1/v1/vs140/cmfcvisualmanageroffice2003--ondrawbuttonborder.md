---
title: "CMFCVisualManagerOffice2003::OnDrawButtonBorder"
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
  - "OnDrawButtonBorder"
  - "CMFCVisualManagerOffice2003::OnDrawButtonBorder"
  - "CMFCVisualManagerOffice2003.OnDrawButtonBorder"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDrawButtonBorder method"
ms.assetid: e5d479e0-249d-4d2d-9304-34f0a06742a1
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCVisualManagerOffice2003::OnDrawButtonBorder
The framework calls this method when it draws the border of a toolbar button.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to the device context of a toolbar button.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to a toolbar button. The framework draws the border of this button.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A rectangle that specifies the boundaries of the toolbar button.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 An enumerated data type that specifies the current state of the toolbar button.  
  
## Remarks  
 The default implementation of this method displays the standard border. Override this method in a derived visual manager to customize the appearance of the border of a toolbar button.  
  
 The possible states of a toolbar button are <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** afxvisualmanageroffice2003.h  
  
## See Also  
 [CMFCVisualManagerOffice2003 Class](../vs140/cmfcvisualmanageroffice2003-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)