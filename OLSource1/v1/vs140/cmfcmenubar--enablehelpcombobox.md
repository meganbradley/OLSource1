---
title: "CMFCMenuBar::EnableHelpCombobox"
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
  - "CMFCMenuBar.EnableHelpCombobox"
  - "CMFCMenuBar::EnableHelpCombobox"
  - "EnableHelpCombobox"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "EnableHelpCombobox method"
ms.assetid: 9d940546-a07b-4b28-8641-a98b30f8adea
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCMenuBar::EnableHelpCombobox
Enables a **Help** combo box that is located on the right side of the menu bar.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The command ID for the button of the **Help** combo box.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A string that contains the text that the framework displays in the combo box if it is empty and not active. For example, "Enter the text here".  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The width of the button for the combo box in pixels.  
  
## Remarks  
 The **Help** combo box resembles the **Help** combo box in the menu bar of [!INCLUDE[ofprword](../vs140/includes/ofprword_md.md)].  
  
 When you call this method with <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> set to 0, this method hides the combo box. Otherwise, this method displays the combo box automatically on the right side of your menu bar. After you call this method, call [CMFCMenuBar::GetHelpCombobox](../vs140/cmfcmenubar--gethelpcombobox.md) to obtain a pointer to the inserted [CMFCToolBarComboBoxButton](../vs140/cmfctoolbarcomboboxbutton-class.md) object.  
  
## Requirements  
 **Header:** afxmenubar.h  
  
## See Also  
 [CMFCMenuBar Class](../vs140/cmfcmenubar-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)