---
title: "CMFCPropertyGridCtrl::ValidateItemData"
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
  - "CMFCPropertyGridCtrl.ValidateItemData"
  - "ValidateItemData"
  - "CMFCPropertyGridCtrl::ValidateItemData"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ValidateItemData method"
ms.assetid: 5e696742-7019-43ae-9bdb-313fc28cd601
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCPropertyGridCtrl::ValidateItemData
Called by the framework to validate property data.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|Pointer to a property. This parameter is not used.|  
  
## Return Value  
 Always <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Remarks  
 The [CMFCPropertyGridCtrl::EndEditItem](../vs140/cmfcpropertygridctrl--endedititem.md) method calls this method to validate data. By default, this method does not use its <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> parameter and its return value is always <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
 If you override this method, return <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> if the specified property data is valid. Otherwise, return <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, in which case the framework does not update the property.  
  
## Requirements  
 **Header:** afxpropertygridctrl.h  
  
## See Also  
 [CMFCPropertyGridCtrl Class](../vs140/cmfcpropertygridctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCPropertyGridCtrl::EndEditItem](../vs140/cmfcpropertygridctrl--endedititem.md)