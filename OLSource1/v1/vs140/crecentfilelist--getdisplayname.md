---
title: "CRecentFileList::GetDisplayName"
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
  - "CRecentFileList::GetDisplayName"
  - "GetDisplayName"
  - "CRecentFileList.GetDisplayName"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetDisplayName method"
ms.assetid: e56833ce-1200-4da6-ad1b-48c33be65276
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRecentFileList::GetDisplayName
Obtains a display name for a file in the MRU file list, for use in the menu display of the MRU list.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Full path of the file whose name is to be displayed in the menu list of MRU files.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Zero-based index of the file in the MRU file list.  
  
 *lpszCurDir*  
 String holding the current directory.  
  
 *nCurDir*  
 Length of the current directory string.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 If nonzero, indicates that the base name of the file should be returned, even if it exceeds the maximum display length (passed as the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> parameter to the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> constructor).  
  
## Return Value  
 **FALSE** if there is no filename at the specified index in the most recently used (MRU) file list.  
  
## Remarks  
 If the file is in the current directory, the function leaves the directory off the display. If the filename is too long, the directory and extension are stripped. If the filename is still too long, the display name is set to an empty string unless <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is nonzero.  
  
## Requirements  
 **Header:** afxadv.h  
  
## See Also  
 [CRecentFileList Class](../vs140/crecentfilelist-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRecentFileList::ReadList](../vs140/crecentfilelist--readlist.md)   
 [CRecentFileList::WriteList](../vs140/crecentfilelist--writelist.md)