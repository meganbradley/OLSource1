---
title: "CWnd::DlgDirSelect"
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
  - "DlgDirSelect"
  - "CWnd::DlgDirSelect"
  - "CWnd.DlgDirSelect"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DlgDirSelect method"
ms.assetid: a72d7b0d-74f9-41ef-a101-9709755a3b5f
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::DlgDirSelect
Retrieves the current selection from a list box.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Points to a buffer that is to receive the current selection in the list box.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the integer ID of a list box in the dialog box.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 It assumes that the list box has been filled by the [DlgDirList](../vs140/cwnd--dlgdirlist.md) member function and that the selection is a drive letter, a file, or a directory name.  
  
 The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> member function copies the selection to the buffer given by <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. If there is no selection, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> does not change.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> sends [LB_GETCURSEL](http://msdn.microsoft.com/library/windows/desktop/bb775197) and [LB_GETTEXT](http://msdn.microsoft.com/library/windows/desktop/bb761313) messages to the list box.  
  
 It does not allow more than one filename to be returned from a list box. The list box must not be a multiple-selection list box.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::DlgDirList](../vs140/cwnd--dlgdirlist.md)   
 [CWnd::DlgDirListComboBox](../vs140/cwnd--dlgdirlistcombobox.md)   
 [CWnd::DlgDirSelectComboBox](../vs140/cwnd--dlgdirselectcombobox.md)   
 [DlgDirSelectEx](http://msdn.microsoft.com/library/windows/desktop/bb761368)