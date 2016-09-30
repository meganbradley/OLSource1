---
title: "CArchive::SetObjectSchema"
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
  - "CArchive::SetObjectSchema"
  - "CArchive.SetObjectSchema"
  - "SetObjectSchema"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetObjectSchema method"
  - "schema"
  - "CArchive class, status"
ms.assetid: 51cb141d-35f4-48ff-89d6-0c1fc5b4d73a
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CArchive::SetObjectSchema
Call this member function to set the object schema stored in the archive object to <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the object's schema.  
  
## Remarks  
 The next call to [GetObjectSchema](../vs140/carchive--getobjectschema.md) will return the value stored in <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 Use <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> for advanced versioning; for example, when you want to force a particular version to be read in a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> function of a derived class.  
  
## Example  
 [!code[NVC_MFCSerialization#27](../vs140/codesnippet/CPP/carchive--setobjectschema_1.cpp)]  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [CArchive Class](../vs140/carchive-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CArchive::GetObjectSchema](../vs140/carchive--getobjectschema.md)