---
title: "CMFCPropertySheet::OnDrawPageHeader"
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
  - "CMFCPropertySheet::OnDrawPageHeader"
  - "OnDrawPageHeader"
  - "CMFCPropertySheet.OnDrawPageHeader"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDrawPageHeader method"
ms.assetid: 66f793b6-6236-47e6-ac67-10e6edd1b23f
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCPropertySheet::OnDrawPageHeader
Called by the framework to draw the header for a custom property page.  
  
## Syntax  
  
```  
virtual void OnDrawPageHeader(  
   CDC* pDC,  
   int nPage,  
   CRect rectHeader   
);  
```  
  
#### Parameters  
 [in] `pDC`  
 Pointer to a device context.  
  
 [in] `nPage`  
 The zero-based property page number.  
  
 [in] `rectHeader`  
 A bounding rectangle that specifies where to draw the header.  
  
## Remarks  
 By default, this method does nothing. If you override this method, call the [CMFCPropertySheet::EnablePageHeader](../vs140/cmfcpropertysheet--enablepageheader.md) method before the framework calls this method.  
  
## Requirements  
 **Header:** afxpropertysheet.h  
  
## See Also  
 [CMFCPropertySheet Class](../vs140/cmfcpropertysheet-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCPropertySheet::EnablePageHeader](../vs140/cmfcpropertysheet--enablepageheader.md)