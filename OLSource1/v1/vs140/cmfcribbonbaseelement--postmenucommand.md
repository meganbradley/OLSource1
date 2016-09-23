---
title: "CMFCRibbonBaseElement::PostMenuCommand"
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
  - CMFCRibbonBaseElement::PostMenuCommand
  - PostMenuCommand
  - CMFCRibbonBaseElement.PostMenuCommand
dev_langs: 
  - C++
helpviewer_keywords: 
  - PostMenuCommand method
ms.assetid: 18cc763c-a373-4c8b-9acd-cdf46524af09
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCRibbonBaseElement::PostMenuCommand
Closes the pop-up menu for the ribbon element and sends a close message to the parent menu.  
  
## Syntax  
  
```  
void PostMenuCommand(  
   UINT uiCmdId  
);  
```  
  
#### Parameters  
 [in] `uiCmdId`  
 The parameter is not used.  
  
## Remarks  
 The close message is only sent if the ribbon element is located on a pop-up menu.  
  
## Requirements  
 **Header:** afxbaseribbonelement.h  
  
## See Also  
 [CMFCRibbonBaseElement Class](../vs140/cmfcribbonbaseelement-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)