---
title: "CTime::Serialize64"
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
  - "Serialize64"
  - "ATL::CTime::Serialize64"
  - "CTime::Serialize64"
  - "ATL.CTime.Serialize64"
  - "CTime.Serialize64"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Serialize64 method"
  - "CTime class, operators"
  - "archive operators [C++]"
ms.assetid: 0aed2160-3a0f-413c-bbb9-f838af551c96
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTime::Serialize64
> [!NOTE]
>  This method is only available in MFC projects.  
  
 Serializes the data associated with the member variable to or from an archive.  
  
## Syntax  
  
```  
CArchive& Serialize64(  
   CArchive& ar   
);  
```  
  
#### Parameters  
 `ar`  
 The `CArchive` object that you want to update.  
  
## Return Value  
 The updated `CArchive` object.  
  
## Requirements  
 **Header:** atltime.h  
  
## See Also  
 [CTime Class](../vs140/ctime-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CArchive Class](../vs140/carchive-class.md)   
 [Serialization](../vs140/serialization-in-mfc.md)