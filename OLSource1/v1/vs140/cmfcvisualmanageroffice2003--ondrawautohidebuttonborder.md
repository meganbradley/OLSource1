---
title: "CMFCVisualManagerOffice2003::OnDrawAutoHideButtonBorder"
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
  - "CMFCVisualManagerOffice2003.OnDrawAutoHideButtonBorder"
  - "CMFCVisualManagerOffice2003::OnDrawAutoHideButtonBorder"
  - "OnDrawAutoHideButtonBorder"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDrawAutoHideButtonBorder method"
ms.assetid: 8a7a05fe-9726-41c1-98b2-76aacfffd387
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCVisualManagerOffice2003::OnDrawAutoHideButtonBorder
The framework calls this method when it draws the border of an auto-hide button.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The size and location of the auto-hide button.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The sizes of the borders.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A pointer to the auto-hide button. The framework is drawing the border for this button.  
  
## Remarks  
 Override this method in a derived class if you want to customize the appearance of the border of an auto-hide button. By default, this method fills a flat border with the default shadow color for your application.  
  
 The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> parameter does not contain the coordinates of the border. It contains the size of the border in the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> data members. A value less than or equal to 0 indicates no border on that side of the auto-hide button.  
  
## Requirements  
 **Header:** afxvisualmanageroffice2003.h  
  
## See Also  
 [CMFCVisualManagerOffice2003 Class](../vs140/cmfcvisualmanageroffice2003-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)