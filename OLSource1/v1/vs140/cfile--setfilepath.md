---
title: "CFile::SetFilePath"
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
  - "CFile::SetFilePath"
  - "CFile.SetFilePath"
  - "SetFilePath"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CFile class, attributes"
  - "SetFilePath method"
ms.assetid: 3c655d99-b323-4f1d-bdc7-da282cbb5bfb
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFile::SetFilePath
Call this function to specify the path of the file; for example, if the path of a file is not available when a [CFile](../vs140/cfile-class.md) object is constructed, call `SetFilePath` to provide it.  
  
## Syntax  
  
```  
  
      virtual void SetFilePath(  
   LPCTSTR lpszNewName   
);  
```  
  
#### Parameters  
 `lpszNewName`  
 Pointer to a string specifying the new path.  
  
## Remarks  
  
> [!NOTE]
>  `SetFilePath` does not open the file or create the file; it simply associates the `CFile` object with a path name, which can then be used.  
  
## Example  
 [!code[NVC_MFCFiles#20](../vs140/codesnippet/CPP/cfile--setfilepath_1.cpp)]  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [CFile Class](../vs140/cfile-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CFile::GetFilePath](../vs140/cfile--getfilepath.md)   
 [CFile::CFile](../vs140/cfile--cfile.md)