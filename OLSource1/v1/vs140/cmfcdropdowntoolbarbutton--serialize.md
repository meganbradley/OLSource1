---
title: "CMFCDropDownToolbarButton::Serialize"
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
  - "CMFCDropDownToolbarButton.Serialize"
  - "Serialize"
  - "CMFCDropDownToolbarButton::Serialize"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Serialize method"
ms.assetid: a9e7d019-d0e8-4260-b38d-189702855a37
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCDropDownToolbarButton::Serialize
Reads this object from an archive or writes it to an archive.  
  
## Syntax  
  
```  
virtual void Serialize(  
   CArchive& ar  
);  
```  
  
#### Parameters  
 [in] `ar`  
 The `CArchive` object from which or to which to serialize.  
  
## Remarks  
 This method extends the base class implementation ([CMFCToolBarButton::Serialize](../vs140/cmfctoolbarbutton--serialize.md)) by serializing the resource ID of the parent toolbar. When the archive is loading ([CArchive::IsLoading](../vs140/carchive--isloading.md) returns a nonzero value), this method sets the `m_pToolBar` data member to the toolbar that contains the serialized resource ID.  
  
## Requirements  
 **Header:** afxdropdowntoolbar.h  
  
## See Also  
 [CMFCDropDownToolbarButton Class](../vs140/cmfcdropdowntoolbarbutton-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CMFCToolBarButton::Serialize](../vs140/cmfctoolbarbutton--serialize.md)   
 [CArchive::IsLoading](../vs140/carchive--isloading.md)