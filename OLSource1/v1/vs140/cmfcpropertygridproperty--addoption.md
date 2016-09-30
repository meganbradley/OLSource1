---
title: "CMFCPropertyGridProperty::AddOption"
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
  - "AddOption"
  - "CMFCPropertyGridProperty.AddOption"
  - "CMFCPropertyGridProperty::AddOption"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AddOption method"
ms.assetid: 434be473-52f8-4ed5-bc4d-209316ac57d8
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCPropertyGridProperty::AddOption
Adds a new list item to a property list control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The list item (option) to add.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> to add the list item only if it does not already exist; otherwise, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. The default value is <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Return Value  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, which means that the list item is added. Otherwise, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, which means that the list item is not added because the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> parameter is <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> and the list item specified by the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> parameter already exists.  
  
## Remarks  
  
## Requirements  
 **Header:** afxpropertygridctrl.h  
  
## See Also  
 [CMFCPropertyGridProperty Class](../vs140/cmfcpropertygridproperty-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)