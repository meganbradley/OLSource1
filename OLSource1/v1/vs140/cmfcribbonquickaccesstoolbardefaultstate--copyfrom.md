---
title: "CMFCRibbonQuickAccessToolBarDefaultState::CopyFrom"
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
  - "CopyFrom"
  - "CMFCRibbonQuickAccessToolBarDefaultState::CopyFrom"
  - "CMFCRibbonQuickAccessToolBarDefaultState.CopyFrom"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CopyFrom method"
ms.assetid: f3baf6a2-04a2-4965-ae4f-d6dca5330e7a
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonQuickAccessToolBarDefaultState::CopyFrom
Copies the properties of one Quick Access Toolbar to another.  
  
## Syntax  
  
```  
void CopyFrom(  
   const CMFCRibbonQuickAccessToolBarDefaultState& src  
);  
```  
  
#### Parameters  
 [in] `src`  
 A reference to the source `CMFCRibbonQuickAccessToolBarDefaultState` object to copy from.  
  
## Remarks  
 This method copies each command from the source `CMFCRibbonQuickAccessToolBarDefaultState` object to this object by using the [CMFCRibbonQuickAccessToolBarDefaultState::AddCommand](../vs140/cmfcribbonquickaccesstoolbardefaultstate--addcommand.md) method.  
  
## Requirements  
 **Header:** afxribbonquickaccesstoolbar.h  
  
## See Also  
 [CMFCRibbonQuickAccessToolBarDefaultState Class](../vs140/cmfcribbonquickaccesstoolbardefaultstate-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CMFCRibbonQuickAccessToolBarDefaultState::AddCommand](../vs140/cmfcribbonquickaccesstoolbardefaultstate--addcommand.md)