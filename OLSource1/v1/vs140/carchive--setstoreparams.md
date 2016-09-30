---
title: "CArchive::SetStoreParams"
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
  - "CArchive::SetStoreParams"
  - "SetStoreParams"
  - "CArchive.SetStoreParams"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetStoreParams method"
ms.assetid: ee710405-01be-4da8-be4d-414494fa327d
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CArchive::SetStoreParams
Use <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> when storing a large number of <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>-derived objects in an archive.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *nHashSize*  
 The size of the hash table for interface pointer maps. Should be a prime number.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Specifies the memory-allocation granularity for extending the parameters. Should be a power of 2 for the best performance.  
  
## Remarks  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> allows you to set the hash table size and the block size of the map used to identify unique objects during the serialization process.  
  
 You must not call <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> after any objects are stored, or after [MapObject](../vs140/carchive--mapobject.md) or [WriteObject](../vs140/carchive--writeobject.md) is called.  
  
## Example  
 [!code[NVC_MFCSerialization#26](../vs140/codesnippet/CPP/carchive--setstoreparams_1.h)]  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [CArchive Class](../vs140/carchive-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CArchive::SetLoadParams](../vs140/carchive--setloadparams.md)