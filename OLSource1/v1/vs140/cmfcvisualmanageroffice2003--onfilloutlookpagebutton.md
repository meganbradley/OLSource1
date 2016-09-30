---
title: "CMFCVisualManagerOffice2003::OnFillOutlookPageButton"
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
  - "OnFillOutlookPageButton"
  - "CMFCVisualManagerOffice2003.OnFillOutlookPageButton"
  - "CMFCVisualManagerOffice2003::OnFillOutlookPageButton"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnFillOutlookPageButton method"
ms.assetid: daf1de7b-5408-4f40-bd1d-60a619d1fdbb
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCVisualManagerOffice2003::OnFillOutlookPageButton
The framework calls this method when it fills the interior of an Outlook page button.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A rectangle that specifies the boundaries of the Outlook page button.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A Boolean parameter that specifies whether the button is highlighted.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A Boolean parameter that specifies whether the button is pressed.  
  
 [out] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 A reference to a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object where this method stores the text color of the outlook page button.  
  
## Remarks  
 Override this function in a derived visual manager to customize the appearance of Outlook page buttons.  
  
## Requirements  
 **Header:** afxvisualmanageroffice2003.h  
  
## See Also  
 [CMFCVisualManagerOffice2003 Class](../vs140/cmfcvisualmanageroffice2003-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)