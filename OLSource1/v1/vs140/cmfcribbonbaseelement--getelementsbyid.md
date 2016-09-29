---
title: "CMFCRibbonBaseElement::GetElementsByID"
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
  - "CMFCRibbonBaseElement.GetElementsByID"
  - "GetElementsByID"
  - "CMFCRibbonBaseElement::GetElementsByID"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetElementsByID method"
ms.assetid: 55a2fb87-e13f-4efd-a593-fcaaa8cf32e3
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonBaseElement::GetElementsByID
Adds the current ribbon element to the specified array if the current ribbon element contains the specified command ID.  
  
## Syntax  
  
```  
virtual void GetElementsByID(  
   UINT uiCmdID,  
   CArray<CMFCRibbonBaseElement*, CMFCRibbonBaseElement*>& arElements  
);  
```  
  
#### Parameters  
 [in] `uiCmdID`  
 Command ID of a ribbon element.  
  
 [in] `arElements`  
 An array of ribbon elements.  
  
## Remarks  
  
## Requirements  
 **Header:** afxbaseribbonelement.h  
  
## See Also  
 [CMFCRibbonBaseElement Class](../vs140/cmfcribbonbaseelement-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)