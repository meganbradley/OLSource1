---
title: "CMFCToolBarComboBoxButton::Compare"
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
  - Compare
  - CMFCToolBarComboBoxButton::Compare
  - CMFCToolBarComboBoxButton.Compare
dev_langs: 
  - C++
helpviewer_keywords: 
  - Compare method
ms.assetid: 636357ee-2a4c-4cae-962f-5d4644046285
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCToolBarComboBoxButton::Compare
Compares two strings.  
  
## Syntax  
  
```  
virtual int Compare(  
   LPCTSTR lpszItem1,  
   LPCTSTR lpszItem2   
);  
```  
  
#### Parameters  
 [in] `lpszItem1`  
 The first string to compare.  
  
 [in] `lpszItem2`  
 The second string to compare.  
  
## Return Value  
 A value that indicates the case-sensitive lexicographic relationship between the strings. The following table lists the possible values:  
  
|Value|Description|  
|-----------|-----------------|  
|<0|The first string is less than the second.|  
|0|The first string equals the second.|  
|>0|The first string is greater than the second.|  
  
## Remarks  
 Override this method to change how items are sorted in the list box.  
  
 The comparison is case-sensitive.  
  
 This method is called only from the [AddSortedItem](../vs140/cmfctoolbarcomboboxbutton--addsorteditem.md) method.  
  
## Requirements  
 **Header:** afxtoolbarcomboboxbutton.h  
  
## See Also  
 [CMFCToolBarComboBoxButton Class](../vs140/cmfctoolbarcomboboxbutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCToolBarComboBoxButton::AddSortedItem](../vs140/cmfctoolbarcomboboxbutton--addsorteditem.md)