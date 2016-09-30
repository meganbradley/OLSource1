---
title: "CArchive::IsStoring"
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
  - "IsStoring"
  - "CArchive::IsStoring"
  - "CArchive.IsStoring"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsStoring method"
  - "CArchive class, status"
ms.assetid: 201bc713-6f91-40e2-9d34-ed6999b8484d
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CArchive::IsStoring
Determines whether the archive is storing data.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Nonzero if the archive is currently being used for storing; otherwise 0.  
  
## Remarks  
 This member function is called by the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> functions of the archived classes.  
  
 If the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> status of an archive is nonzero, then its <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> status is 0, and vice versa.  
  
## Example  
 [!code[NVC_MFCSerialization#17](../vs140/codesnippet/CPP/carchive--isstoring_1.cpp)]  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [CArchive Class](../vs140/carchive-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CArchive::IsLoading](../vs140/carchive--isloading.md)