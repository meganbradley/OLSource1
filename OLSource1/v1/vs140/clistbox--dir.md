---
title: "CListBox::Dir"
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
  - "CListBox::Dir"
  - "CListBox.Dir"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CListBox class, string operations"
  - "Dir method"
ms.assetid: b345bc4d-6b2a-45f2-a795-5b6380d6e860
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CListBox::Dir
Adds a list of filenames, drives, or both to a list box.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Can be any combination of the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> values described in **CFile::GetStatu**[s](../vs140/cfile--getstatus.md), or any combination of the following values:  
  
|Value|Meaning|  
|-----------|-------------|  
|0x0000|File can be read from or written to.|  
|0x0001|File can be read from but not written to.|  
|0x0002|File is hidden and does not appear in a directory listing.|  
|0x0004|File is a system file.|  
|0x0010|The name specified by <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> specifies a directory.|  
|0x0020|File has been archived.|  
|0x4000|Include all drives that match the name specified by <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.|  
|0x8000|Exclusive flag. If the exclusive flag is set, only files of the specified type are listed. Otherwise, files of the specified type are listed in addition to "normal" files.|  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Points to a file-specification string. The string can contain wildcards (for example, *.\*).  
  
## Return Value  
 The zero-based index of the last filename added to the list. The return value is **LB_ERR** if an error occurs; the return value is **LB_ERRSPACE** if insufficient space is available to store the new strings.  
  
## Example  
 [!code[NVC_MFC_CListBox#8](../vs140/codesnippet/CPP/clistbox--dir_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CListBox Class](../vs140/clistbox-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::DlgDirList](../vs140/cwnd--dlgdirlist.md)   
 [LB_DIR](http://msdn.microsoft.com/library/windows/desktop/bb775185)   
 [CFile::GetStatus](../vs140/cfile--getstatus.md)