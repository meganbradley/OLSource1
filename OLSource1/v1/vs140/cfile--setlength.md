---
title: "CFile::SetLength"
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
  - "CFile.SetLength"
  - "CFile::SetLength"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CFile class, position"
  - "SetLength method"
ms.assetid: d43b32c4-9c83-4cb7-b060-811c37e0dd66
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFile::SetLength
Call this function to change the length of the file.  
  
## Syntax  
  
```  
  
      virtual void SetLength(  
   ULONGLONG dwNewLen   
);  
```  
  
#### Parameters  
 `dwNewLen`  
 Desired length of the file in bytes. This value can be larger or smaller than the current length of the file. The file will be extended or truncated as appropriate.  
  
## Remarks  
  
> [!NOTE]
>  With `CMemFile`, this function could throw a `CMemoryException` object.  
  
## Example  
 [!code[NVC_MFCFiles#11](../vs140/codesnippet/CPP/cfile--setlength_1.cpp)]  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [CFile Class](../vs140/cfile-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)