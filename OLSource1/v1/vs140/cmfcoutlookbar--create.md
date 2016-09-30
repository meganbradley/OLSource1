---
title: "CMFCOutlookBar::Create"
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
  - "CMFCOutlookBar.Create"
  - "Create"
  - "CMFCOutlookBar::Create"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Create method"
ms.assetid: 7dbce5a5-bc78-456f-aebb-2fafa4ffc890
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCOutlookBar::Create
Creates the Outlook bar control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the window caption.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies a pointer to a parent window. It must not be NULL.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Specifies the outlook bar size and position in pixels.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Specifies the control ID. Must be distinct from other control IDs used in the application.  
  
 [in] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Specifies the desired control bar style. For possible values, see [Window Styles](../vs140/window-styles.md).  
  
 [in] <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Specifies the special library-defined styles.  
  
 [in] <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Create context.  
  
## Return Value  
 Nonzero if the method is successful; otherwise 0.  
  
## Remarks  
 You construct a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object in two steps. First call the constructor, and then call <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, which creates the outlook bar control and attaches it to the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> object.  
  
 See [CBasePane::CreateEx](../vs140/cbasepane--createex.md) for the list of the available library-defined styles to be specified by <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
## Example  
 The following example demonstrates how to use the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> method of the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> class. This code snippet is part of the [Outlook Multi Views sample](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_OutlookMultiViews#1](../vs140/codesnippet/CPP/cmfcoutlookbar--create_1.h)]  
[!code[NVC_MFC_OutlookMultiViews#2](../vs140/codesnippet/CPP/cmfcoutlookbar--create_2.cpp)]  
  
## Requirements  
 **Header:** afxoutlookbar.h  
  
## See Also  
 [CMFCOutlookBar Class](../vs140/cmfcoutlookbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)