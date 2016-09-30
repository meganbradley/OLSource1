---
title: "CMFCMenuBar::OnSetDefaultButtonText"
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
  - "CMFCMenuBar.OnSetDefaultButtonText"
  - "OnSetDefaultButtonText"
  - "CMFCMenuBar::OnSetDefaultButtonText"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnSetDefaultButtonText method"
ms.assetid: 9010a1f3-ee53-4d24-bb39-8ec2b81a0259
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCMenuBar::OnSetDefaultButtonText
The framework calls this method when the user changes the text of an item on the menu bar.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to the [CMFCToolBarButton](../vs140/cmfctoolbarbutton-class.md) object that the user wants to customize.  
  
## Return Value  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> if the framework applies the user changes to the menu bar; otherwise <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Remarks  
 The default implementation for this method changes the text of the button to the text that the user provides.  
  
## Requirements  
 **Header:** afxmenubar.h  
  
## See Also  
 [CMFCMenuBar Class](../vs140/cmfcmenubar-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)