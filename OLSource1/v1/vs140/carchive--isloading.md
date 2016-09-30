---
title: "CArchive::IsLoading"
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
  - "CArchive.IsLoading"
  - "CArchive::IsLoading"
  - "IsLoading"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsLoading method"
  - "CArchive class, status"
ms.assetid: 837cd522-f78a-424e-9543-ee961edbfd5e
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CArchive::IsLoading
Determines whether the archive is loading data.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Nonzero if the archive is currently being used for loading; otherwise 0.  
  
## Remarks  
 This member function is called by the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> functions of the archived classes.  
  
## Example  
 [!code[NVC_MFCSerialization#16](../vs140/codesnippet/CPP/carchive--isloading_1.cpp)]  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [CArchive Class](../vs140/carchive-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CArchive::IsStoring](../vs140/carchive--isstoring.md)