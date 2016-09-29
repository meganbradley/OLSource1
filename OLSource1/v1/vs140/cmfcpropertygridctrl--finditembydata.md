---
title: "CMFCPropertyGridCtrl::FindItemByData"
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
  - "CMFCPropertyGridCtrl.FindItemByData"
  - "CMFCPropertyGridCtrl::FindItemByData"
  - "FindItemByData"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "FindItemByData method"
ms.assetid: 73760d55-7d34-40d0-a0f4-d51c1cac1513
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCPropertyGridCtrl::FindItemByData
Retrieves the property that is associated with a user-defined `DWORD` value.  
  
## Syntax  
  
```  
CMFCPropertyGridProperty* FindItemByData(  
   DWORD_PTR dwData,  
   BOOL bSearchSubItems=TRUE   
) const;  
```  
  
#### Parameters  
 [in] `dwData`  
 A `DWORD` value.  
  
 [in] `bSearchSubItems`  
 `TRUE` to search property sub-items; otherwise, `FALSE`. The default value is `TRUE`.  
  
## Return Value  
 A pointer to the associated property object if this method succeeds; otherwise, `NULL`.  
  
## Remarks  
 Use the [CMFCPropertyGridCtrl::CMFCPropertyGridCtrl](../vs140/cmfcpropertygridctrl--cmfcpropertygridctrl.md) constructor or [CMFCPropertyGridProperty::SetData](../vs140/cmfcpropertygridproperty--setdata.md) method to associate a `DWORD` with a property.  
  
## Requirements  
 **Header:** afxpropertygridctrl.h  
  
## See Also  
 [CMFCPropertyGridCtrl Class](../vs140/cmfcpropertygridctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)