---
title: "CMFCRibbonEdit::SetACCData"
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
  - CMFCRibbonEdit.SetACCData
  - SetACCData
  - CMFCRibbonEdit::SetACCData
dev_langs: 
  - C++
helpviewer_keywords: 
  - SetACCData method
ms.assetid: f57786d2-fb74-46dd-8683-8c00289681b6
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCRibbonEdit::SetACCData
Sets the accessibility data for the [CMFCRibbonEdit](../vs140/cmfcribbonedit-class.md) object.  
  
## Syntax  
  
```  
 virtual BOOL SetACCData(  
   CWnd* pParent,  
   CAccessibilityData& data  
);  
```  
  
#### Parameters  
 `pParent`  
 Pointer to the parent window for the [CMFCRibbonEdit](../vs140/cmfcribbonedit-class.md) object.  
  
 `data`  
 The accessibility data for the [CMFCRibbonEdit](../vs140/cmfcribbonedit-class.md) object.  
  
## Return Value  
 Always returns `TRUE`.  
  
## Remarks  
  
## Requirements  
 **Header:** afxribbonedit.h  
  
## See Also  
 [CMFCRibbonEdit Class](../vs140/cmfcribbonedit-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)