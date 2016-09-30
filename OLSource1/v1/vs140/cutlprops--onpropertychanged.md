---
title: "CUtlProps::OnPropertyChanged"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "OnPropertyChanged"
  - "CUtlProps.OnPropertyChanged"
  - "CUtlProps::OnPropertyChanged"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnPropertyChanged method"
ms.assetid: c5924210-b685-46c4-87f8-1b81e5bd3378
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CUtlProps::OnPropertyChanged
Called after setting a property to handle chained properties.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The index into the property-set array; zero if there is only one property set.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The property ID and new value in a [DBPROP](https://msdn.microsoft.com/en-us/library/ms717970.aspx) structure.  
  
## Return Value  
 A standard <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. The default return value is <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## Remarks  
 If you want to handle chained properties, such as bookmarks or updates whose values are dependent on another property's value, you should override this function.  
  
## Example  
 In this function, the user gets the property ID from the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> parameter. Now, it is possible to compare the ID against a property to chain. When the property is found, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is called with the property that will now be set in conjunction with the other property. In this case, if one gets the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> property, one can set the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> property.  
  
 [!code[NVC_OLEDB_Provider#2](../vs140/codesnippet/CPP/cutlprops--onpropertychanged_1.h)]  
  
## Requirements  
 **Header:** atldb.h  
  
## See Also  
 [CUtlProps Class](../vs140/cutlprops-class.md)