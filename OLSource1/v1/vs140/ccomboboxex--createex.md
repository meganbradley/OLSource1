---
title: "CComboBoxEx::CreateEx"
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
  - "CComboBoxEx::CreateEx"
  - "CComboBoxEx.CreateEx"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CreateEx method"
ms.assetid: d6112a8f-4cf6-4031-9fd6-e4e26833aa27
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComboBoxEx::CreateEx
Call this function to create an extended combo box control (a child window) and associate it with the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the extended style of the control being created. For a list of extended Windows styles, see the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> parameter for [CreateWindowEx](http://msdn.microsoft.com/library/windows/desktop/ms632680) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The combo box control's style. See [Create](../vs140/ccomboboxex--create.md) for a list of styles.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 A reference to a [RECT](http://msdn.microsoft.com/library/windows/desktop/dd162897) structure describing the size and position of the window to be created, in client coordinates of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 A pointer to the window that is the control's parent.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 The control's child-window ID.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 Use <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> instead of **Create** to apply extended Windows styles, specified by the Windows extended style preface **WS_EX_**.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> creates the control with the extended Windows styles specified by <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>. You must set extended styles specific to an extended combo box control using [SetExtendedStyle](../vs140/ccomboboxex--setextendedstyle.md). For example, use <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> to set such styles as **WS_EX_CONTEXTHELP**, but use <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> to set such styles as **CBES_EX_CASESENSITIVE**. For more information, see the styles described in the topic [ComboBoxEx Control Extended Styles](http://msdn.microsoft.com/library/windows/desktop/bb775742) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CComboBoxEx Class](../vs140/ccomboboxex-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CComboBoxEx::CComboBoxEx](../vs140/ccomboboxex--ccomboboxex.md)   
 [CComboBox Class](../vs140/ccombobox-class.md)