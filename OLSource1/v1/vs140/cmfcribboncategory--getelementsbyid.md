---
title: "CMFCRibbonCategory::GetElementsByID"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CMFCRibbonCategory::GetElementsByID
  - CMFCRibbonCategory.GetElementsByID
  - GetElementsByID
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetElementsByID method
ms.assetid: cb3711d2-55ff-49ff-a2a9-f043967ef9db
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCRibbonCategory::GetElementsByID
Retrieves all ribbon elements that are associated with the specified command ID.  
  
## Syntax  
  
```  
void GetElementsByID(  
   UINT uiCmdID,  
   CArray <CMFCRibbonBaseElement*, CMFCRibbonBaseElement*>& arElements  
);  
```  
  
#### Parameters  
 [in] `uiCmdID`  
 Command ID associated with a ribbon element.  
  
 [in, out] `arElements`  
 Reference to a [CArray](../vs140/carray-class.md) of ribbon elements.  
  
## Remarks  
 Ribbon elements that are designed for use on the quick access toolbar are included in the array.  
  
## Requirements  
 **Header:** afxribboncategory.h  
  
## See Also  
 [CMFCRibbonCategory Class](../vs140/cmfcribboncategory-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)