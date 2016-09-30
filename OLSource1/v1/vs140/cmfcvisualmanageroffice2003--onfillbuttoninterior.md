---
title: "CMFCVisualManagerOffice2003::OnFillButtonInterior"
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
  - "CMFCVisualManagerOffice2003.OnFillButtonInterior"
  - "CMFCVisualManagerOffice2003::OnFillButtonInterior"
  - "OnFillButtonInterior"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnFillButtonInterior method"
ms.assetid: 34d344e0-098c-4d5f-9bcf-68e37ae6c829
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCVisualManagerOffice2003::OnFillButtonInterior
The framework calls this method when it fills the background of a toolbar button.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to the device context of a toolbar button.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to the button for which the framework is filling the background.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A rectangle that specifies the boundaries of the toolbar button.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The state of the toolbar button (the possible states of a toolbar button are <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>).  
  
## Remarks  
 The default implementation of this method uses the default color to fill the background. Override this method in a derived visual manager to customize the background of a toolbar button.  
  
## Requirements  
 **Header:** afxvisualmanageroffice2003.h  
  
## See Also  
 [CMFCVisualManagerOffice2003 Class](../vs140/cmfcvisualmanageroffice2003-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)