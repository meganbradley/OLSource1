---
title: "CMFCToolBar::ReplaceButton"
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
  - "ReplaceButton"
  - "CMFCToolBar.ReplaceButton"
  - "CMFCToolBar::ReplaceButton"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ReplaceButton method"
ms.assetid: 830335e8-88fb-4800-913a-8b24a05a4380
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBar::ReplaceButton
Replaces a toolbar button with another toolbar button.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The command ID of the button to replace.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A reference to the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> to insert.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A Boolean value that specifies whether to replace all buttons that have the command ID specified by <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. If this parameter is <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, all buttons that have the specified command ID are replaced. Otherwise, the first button is replaced.  
  
## Return Value  
 The number of buttons that are replaced. This method returns 0 if a button with the specified command ID does not exist on the toolbar.  
  
## Remarks  
 Call this method when you want to add toolbar buttons that cannot be loaded from resources. You can create a placeholder button at design-time and replace that button with a custom button when you initialize the toolbar. See the VisualStudioDemo sample for an example that uses this method.  
  
## Example  
 The following example demonstrates how to use the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> method in the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> class. This code snippet is part of the [IE Demo sample](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_IEDemo#6](../vs140/codesnippet/CPP/cmfctoolbar--replacebutton_1.h)]  
[!code[NVC_MFC_IEDemo#10](../vs140/codesnippet/CPP/cmfctoolbar--replacebutton_2.cpp)]  
  
## Requirements  
 **Header:** afxtoolbar.h  
  
## See Also  
 [CMFCToolBar Class](../vs140/cmfctoolbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCToolBarButton Class](../vs140/cmfctoolbarbutton-class.md)