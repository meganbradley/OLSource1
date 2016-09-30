---
title: "CMFCRibbonPanel::SetElementRTCByID"
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
  - "CMFCRibbonPanel::SetElementRTCByID"
  - "CMFCRibbonPanel.SetElementRTCByID"
  - "SetElementRTCByID"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetElementRTCByID method"
ms.assetid: 8653fdab-4c99-4480-98f7-f85c2a9bc547
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonPanel::SetElementRTCByID
Adds a ribbon element that is specified by the provided runtime class information to the ribbon panel.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the command ID of the ribbon element to add.  
  
 [in] [out] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A pointer to the runtime class information associated with the ribbon element that is added to the ribbon panel.  
  
## Return Value  
 The ribbon element that was created by using the specified runtime class information.  
  
## Remarks  
 If you want to add a custom element (for example, a color button) to the ribbon panel, you must specify the custom element's runtime class information. The ribbon stores this information, creates the custom element, and replaces an existing element located by the specified command ID. It then returns a pointer to the newly created element.  
  
## Example  
 The following example shows how to use the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> method:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** afxRibbonPanel.h  
  
## See Also  
 [CMFCRibbonPanel Class](../vs140/cmfcribbonpanel-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)