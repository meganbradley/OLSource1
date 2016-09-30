---
title: "CArchive::SetLoadParams"
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
  - "SetLoadParams"
  - "CArchive::SetLoadParams"
  - "CArchive.SetLoadParams"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetLoadParams method"
ms.assetid: a9f604e3-eb2d-4e9d-8d8a-060c01789453
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CArchive::SetLoadParams
Call <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> when you are going to read a large number of <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>-derived objects from an archive.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The minimum number of element slots to allocate if a size increase is necessary.  
  
## Remarks  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> uses a load array to resolve references to objects stored in the archive. <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> allows you to set the size to which the load array grows.  
  
 You must not call <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> after any object is loaded, or after [MapObject](../vs140/carchive--mapobject.md) or [ReadObject](../vs140/carchive--readobject.md) is called.  
  
## Example  
 [!code[NVC_MFCSerialization#26](../vs140/codesnippet/CPP/carchive--setloadparams_1.h)]  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [CArchive Class](../vs140/carchive-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CArchive::SetStoreParams](../vs140/carchive--setstoreparams.md)