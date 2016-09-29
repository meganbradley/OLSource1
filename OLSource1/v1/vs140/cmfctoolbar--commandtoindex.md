---
title: "CMFCToolBar::CommandToIndex"
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
  - "CMFCToolBar.CommandToIndex"
  - "CommandToIndex"
  - "CMFCToolBar::CommandToIndex"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CommandToIndex method"
ms.assetid: 3fa452c8-6af3-4992-bc08-6296de5e9b16
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBar::CommandToIndex
Returns the index of the button in the toolbar with a specified command ID.  
  
## Syntax  
  
```  
int CommandToIndex(  
   UINT nIDFind,  
   int iIndexFirst=0   
) const;  
```  
  
#### Parameters  
 [in] `nIDFind`  
 Specifies the command ID.  
  
 [in] `iIndexFirst`  
 Specifies the initial index to start from.  
  
## Return Value  
 Zero-based index of the toolbar button if the method was successful; -1 if there is no button with the specified ID.  
  
## Remarks  
 A [CMFCToolBar](../vs140/cmfctoolbar-class.md) object maintains an internal list of the buttons on the toolbar. Call this function to retrieve the index of a button in the list given the command ID of the button.  
  
 If `iIndex` is greater than 0, this method ignores any button on the toolbar that has an index less than `iIndex`.  
  
## Requirements  
 **Header:** afxtoolbar.h  
  
## See Also  
 [CMFCToolBar Class](../vs140/cmfctoolbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)