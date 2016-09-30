---
title: "CMFCOutlookBarPane::Create"
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
  - "CMFCOutlookBarPane.Create"
  - "CMFCOutlookBarPane::Create"
  - "Create"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Create method"
ms.assetid: 1469b19b-e19d-4640-85fa-dedb372b2a3c
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCOutlookBarPane::Create
Creates the Outlook bar pane.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the parent window of the Outlook bar pane control. Must not be <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The window style.  For a list of window styles, see [Window Styles](../vs140/window-styles.md).  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The control ID. Must be unique to enable saving of the control's state.  
  
 [in] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Specifies special styles that define the behavior of the Outlook bar pane control when it is detached from the Outlook bar.  
  
## Return Value  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> if the method was successful; otherwise <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
## Remarks  
 To construct a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object, first call the constructor, and then call <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, which creates the Outlook bar pane control and attaches it to the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> object.  
  
 For more information about <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> see [CBasePane::CreateEx](../vs140/cbasepane--createex.md).  
  
## Requirements  
 **Header:** afxoutlookbarpane.h  
  
## See Also  
 [CMFCOutlookBarPane Class](../vs140/cmfcoutlookbarpane-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)