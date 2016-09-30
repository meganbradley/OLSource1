---
title: "CWnd::DlgDirSelectComboBox"
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
  - "CWnd.DlgDirSelectComboBox"
  - "DlgDirSelectComboBox"
  - "CWnd::DlgDirSelectComboBox"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DlgDirSelectComboBox method"
ms.assetid: 7a422a19-88eb-4d8d-87af-ba5eb58ca77b
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::DlgDirSelectComboBox
Retrieves the current selection from the list box of a combo box.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Points to a buffer that is to receive the selected path.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the integer ID of the combo box in the dialog box.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 It assumes that the list box has been filled by the [DlgDirListComboBox](../vs140/cwnd--dlgdirlistcombobox.md) member function and that the selection is a drive letter, a file, or a directory name.  
  
 The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> member function copies the selection to the specified buffer. If there is no selection, the contents of the buffer are not changed.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> sends [CB_GETCURSEL](http://msdn.microsoft.com/library/windows/desktop/bb775845) and [CB_GETLBTEXT](http://msdn.microsoft.com/library/windows/desktop/bb775862) messages to the combo box.  
  
 It does not allow more than one filename to be returned from a combo box.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::DlgDirListComboBox](../vs140/cwnd--dlgdirlistcombobox.md)   
 [DlgDirSelectComboBoxEx](http://msdn.microsoft.com/library/windows/desktop/bb775937)