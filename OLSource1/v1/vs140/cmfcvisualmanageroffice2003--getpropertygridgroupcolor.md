---
title: "CMFCVisualManagerOffice2003::GetPropertyGridGroupColor"
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
  - "CMFCVisualManagerOffice2003.GetPropertyGridGroupColor"
  - "GetPropertyGridGroupColor"
  - "CMFCVisualManagerOffice2003::GetPropertyGridGroupColor"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetPropertyGridGroupColor method"
ms.assetid: 62789e43-345c-4b9f-85a2-f58540bdd9ee
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCVisualManagerOffice2003::GetPropertyGridGroupColor
The framework calls this method to get the background color of a property list.  
  
## Syntax  
  
```  
virtual COLORREF GetPropertyGridGroupColor(  
   CMFCPropertyGridCtrl* pPropList  
);  
```  
  
#### Parameters  
 [in] `pPropList`  
 A pointer to the property list that the framework is drawing.  
  
## Return Value  
 Returns the background color of `pPropList`.  
  
## Remarks  
 Override this function to customize the background color of a property list in your application.  
  
## Requirements  
 **Header:** afxvisualmanageroffice2003.h  
  
## See Also  
 [CMFCVisualManagerOffice2003 Class](../vs140/cmfcvisualmanageroffice2003-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)