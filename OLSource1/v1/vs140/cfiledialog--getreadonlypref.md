---
title: "CFileDialog::GetReadOnlyPref"
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
  - "CFileDialog::GetReadOnlyPref"
  - "CFileDialog.GetReadOnlyPref"
  - "GetReadOnlyPref"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CFileDialog class, operations"
  - "GetReadOnlyPref method"
ms.assetid: 4611071d-b24f-4c0d-bd93-bdde30200ee4
caps.latest.revision: 23
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFileDialog::GetReadOnlyPref
Call this function to determine whether the Read Only check box has been selected in the Windows standard File Open and File Save As dialog boxes.  
  
## Syntax  
  
```  
BOOL GetReadOnlyPref( ) const;  
```  
  
## Return Value  
 Non-zero if the Read Only check box in the dialog box is selected; otherwise 0.  
  
## Remarks  
 You can hide the Read Only check box by setting the `OFN_HIDEREADONLY` style in the [CFileDialog](../vs140/cfiledialog-class.md) constructor.  
  
> [!NOTE]
>  [!INCLUDE[wiprlhext](../vs140/includes/wiprlhext_md.md)] style `CFileDialog` objects do not support this function. Attempting to use this function on a [!INCLUDE[wiprlhext](../vs140/includes/wiprlhext_md.md)] style `CFileDialog` will throw [CNotSupportedException](../vs140/cnotsupportedexception-class.md). See [CFileDialog Class](../vs140/cfiledialog-class.md) for more information.  
  
## Requirements  
 **Header:** afxdlgs.h  
  
## See Also  
 [CFileDialog Class](../vs140/cfiledialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CFileDialog::CFileDialog](../vs140/cfiledialog--cfiledialog.md)   
 [CFileDialog::GetPathName](../vs140/cfiledialog--getpathname.md)   
 [CFileDialog::GetFileExt](../vs140/cfiledialog--getfileext.md)