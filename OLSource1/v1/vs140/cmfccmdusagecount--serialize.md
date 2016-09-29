---
title: "CMFCCmdUsageCount::Serialize"
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
  - "CMFCCmdUsageCount::Serialize"
  - "CMFCCmdUsageCount.Serialize"
  - "Serialize"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Serialize method"
ms.assetid: 6d06bd6d-74f9-48f2-96d9-0d568cb72a00
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCCmdUsageCount::Serialize
Reads this object from an archive, or writes it to an archive.  
  
## Syntax  
  
```  
virtual void Serialize(  
   CArchive& ar  
);  
```  
  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|[in] `ar`|A `CArchive` object to serialize from or to.|  
  
## Remarks  
 This method serializes the map structure of command counts, `m_CmdUsage`, and the total command usage, `m_nTotalUsage`, counter from or to the specified archive.  
  
 For serialization examples, see [Serialization: Serializing an Object](../vs140/serialization--serializing-an-object.md).  
  
## Requirements  
 **Header:** afxcmdusagecount.h  
  
## See Also  
 [CMFCCmdUsageCount Class](../vs140/cmfccmdusagecount-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CArchive Class](../vs140/carchive-class.md)   
 [Serialization: Serializing an Object](../vs140/serialization--serializing-an-object.md)