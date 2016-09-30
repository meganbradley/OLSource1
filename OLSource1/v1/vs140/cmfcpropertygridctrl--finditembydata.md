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
Retrieves the property that is associated with a user-defined <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> value.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> value.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> to search property sub-items; otherwise, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. The default value is <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
## Return Value  
 A pointer to the associated property object if this method succeeds; otherwise, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
## Remarks  
 Use the [CMFCPropertyGridCtrl::CMFCPropertyGridCtrl](../vs140/cmfcpropertygridctrl--cmfcpropertygridctrl.md) constructor or [CMFCPropertyGridProperty::SetData](../vs140/cmfcpropertygridproperty--setdata.md) method to associate a <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> with a property.  
  
## Requirements  
 **Header:** afxpropertygridctrl.h  
  
## See Also  
 [CMFCPropertyGridCtrl Class](../vs140/cmfcpropertygridctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)