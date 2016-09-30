---
title: "CMFCRibbonPanel::SetElementMenu"
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
  - "CMFCRibbonPanel::SetElementMenu"
  - "CMFCRibbonPanel.SetElementMenu"
  - "SetElementMenu"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetElementMenu method"
ms.assetid: 0d72d54e-c5f5-4e0f-bf18-dc5cbf4a9aac
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonPanel::SetElementMenu
Assigns a popup menu to the element that has the given command ID.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the command ID of the ribbon element where the menu is added.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the handle to the Windows menu to add to the ribbon panel.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> to specify that the command associated with the ribbon element should be executed if the ribbon element is clicked. In this case, the menu is only opened when the user clicks the arrow next to the ribbon element. <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> to specify that the command associated with the ribbon element should not be executed if the ribbon element is clicked. In this case, the popup menu appears regardless of where the user clicks on the element.  
  
 [in] <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> to specify that the popup menu is right-aligned; otherwise, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 Specifies the resource ID of the menu to add to the ribbon panel.  
  
## Return Value  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> if the menu has been assigned to the ribbon element; otherwise, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
## Remarks  
 Call this method to assign a popup menu to the ribbon element that has the given command ID.  
  
## Requirements  
 **Header:** afxRibbonPanel.h  
  
## See Also  
 [CMFCRibbonPanel Class](../vs140/cmfcribbonpanel-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)