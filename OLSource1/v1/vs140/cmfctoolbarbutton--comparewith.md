---
title: "CMFCToolBarButton::CompareWith"
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
  - "CMFCToolBarButton::CompareWith"
  - "CompareWith"
  - "CMFCToolBarButton.CompareWith"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CompareWith method"
ms.assetid: d0f9464c-0f5d-4408-b3e1-0205e92b41db
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBarButton::CompareWith
Compares this instance with the provided <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Reference to the object to compare with this instance.  
  
## Return Value  
 Nonzero if the provided object equals the value of this instance; otherwise, 0.  
  
## Remarks  
 The default implementation determines whether the command ID of the provided object equals the command ID of this instance. Override this method if you must perform additional processing to determine whether two <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> objects are equal.  
  
## Requirements  
 **Header:** afxtoolbarbutton.h  
  
## See Also  
 [CMFCToolBarButton Class](../vs140/cmfctoolbarbutton-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)