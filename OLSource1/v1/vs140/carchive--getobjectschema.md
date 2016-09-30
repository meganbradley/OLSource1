---
title: "CArchive::GetObjectSchema"
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
  - "GetObjectSchema"
  - "CArchive.GetObjectSchema"
  - "CArchive::GetObjectSchema"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetObjectSchema method"
  - "VERSIONABLE_SCHEMA macro"
  - "CArchive class, status"
ms.assetid: 8546decb-5fcf-4f41-b3f1-68e25b9df7ef
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CArchive::GetObjectSchema
Call this function from the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> function to determine the version of the object that is currently being deserialized.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 During deserialization, the version of the object being read.  
  
## Remarks  
 Calling this function is only valid when the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object is being loaded ([CArchive::IsLoading](../vs140/carchive--isloading.md) returns nonzero). It should be the first call in the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> function and called only once. A return value of (**UINT**)–1 indicates that the version number is unknown.  
  
 A <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>-derived class may use **VERSIONABLE_SCHEMA** combined (using bitwise <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>) with the schema version itself (in the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> macro) to create a "versionable object," that is, an object whose <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> member function can read multiple versions. The default framework functionality (without **VERSIONABLE_SCHEMA**) is to throw an exception when the version is mismatched.  
  
## Example  
 [!code[NVC_MFCSerialization#15](../vs140/codesnippet/CPP/carchive--getobjectschema_1.cpp)]  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [CArchive Class](../vs140/carchive-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CObject::Serialize](../vs140/cobject--serialize.md)   
 [CObject::IsSerializable](../vs140/cobject--isserializable.md)   
 [IMPLEMENT_SERIAL](../vs140/implement_serial.md)   
 [DECLARE_SERIAL](../vs140/declare_serial.md)   
 [CArchive::IsLoading](../vs140/carchive--isloading.md)