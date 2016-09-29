---
title: "CMFCVisualManagerOffice2003::GetPropertyGridGroupTextColor"
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
  - "GetPropertyGridGroupTextColor"
  - "CMFCVisualManagerOffice2003::GetPropertyGridGroupTextColor"
  - "CMFCVisualManagerOffice2003.GetPropertyGridGroupTextColor"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetPropertyGridGroupTextColor method"
ms.assetid: f5068e11-81d5-4f02-b9d0-184b39a51a13
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCVisualManagerOffice2003::GetPropertyGridGroupTextColor
The framework calls this method to retrieve the text color of a property list.  
  
## Syntax  
  
```  
virtual COLORREF GetPropertyGridGroupTextColor(  
   CMFCPropertyGridCtrl* pPropList  
);  
```  
  
#### Parameters  
 [in] `pPropList`  
 A pointer to the property list.  
  
## Return Value  
 Returns the text color of the specified property list.  
  
## Remarks  
 Override this function to customize the text color of a property list in your application.  
  
## Requirements  
 **Header:** afxvisualmanageroffice2003.h  
  
## See Also  
 [CMFCVisualManagerOffice2003 Class](../vs140/cmfcvisualmanageroffice2003-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)