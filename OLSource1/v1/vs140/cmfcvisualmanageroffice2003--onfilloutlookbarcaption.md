---
title: "CMFCVisualManagerOffice2003::OnFillOutlookBarCaption"
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
  - "OnFillOutlookBarCaption"
  - "CMFCVisualManagerOffice2003::OnFillOutlookBarCaption"
  - "CMFCVisualManagerOffice2003.OnFillOutlookBarCaption"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnFillOutlookBarCaption method"
ms.assetid: eccc038f-eeee-413a-8a7f-b18578c705c7
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCVisualManagerOffice2003::OnFillOutlookBarCaption
The framework calls this method when it fills the background of an Outlook caption bar.  
  
## Syntax  
  
```  
virtual void OnFillOutlookBarCaption(  
   CDC* pDC,  
   CRect rectCaption,  
   COLORREF& clrText  
);  
```  
  
#### Parameters  
 [in] `pDC`  
 A pointer to a device context.  
  
 [in] `rectCaption`  
 A rectangle that specifies the boundaries of the caption bar.  
  
 [out] `clrText`  
 A reference to a `COLORREF` object to which this method writes the color of text on the caption bar.  
  
## Remarks  
 The default implementation of this method fills the caption bar with the color for shadows based on the current skin.  
  
 Override this method in a derived visual manager to customize the color of the Outlook caption bar.  
  
## Requirements  
 **Header:** afxvisualmanageroffice2003.h  
  
## See Also  
 [CMFCVisualManagerOffice2003 Class](../vs140/cmfcvisualmanageroffice2003-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)