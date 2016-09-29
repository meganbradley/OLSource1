---
title: "CMFCToolBarFontComboBox::GetFontDesc"
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
  - "CMFCToolBarFontComboBox.GetFontDesc"
  - "CMFCToolBarFontComboBox::GetFontDesc"
  - "GetFontDesc"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetFontDesc method"
ms.assetid: 59d53d3f-f599-43a9-9e7b-778e2a235982
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBarFontComboBox::GetFontDesc
Returns a pointer to the `CMFCFontInfo` object for a specified index in the combo box.  
  
## Syntax  
  
```  
const CMFCFontInfo* GetFontDesc(  
   int iIndex=-1   
) const;  
```  
  
#### Parameters  
 [in] `iIndex`  
 Specifies the zero-based index of a combo box item.  
  
## Return Value  
 A pointer to a `CMFCFontInfo` object. If `iIndex` does not specify a valid item index, the return value is `NULL`.  
  
## Requirements  
 **Header:** afxtoolbarfontcombobox.h  
  
## See Also  
 [CMFCToolBarFontComboBox Class](../vs140/cmfctoolbarfontcombobox-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCFontInfo Class](../vs140/cmfcfontinfo-class.md)