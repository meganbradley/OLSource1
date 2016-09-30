---
title: "CObject::Serialize"
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
  - "CObject.Serialize"
  - "CObject::Serialize"
  - "Serialize"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Serialize method"
  - "CObject class, serialization"
ms.assetid: 6e571efe-4947-4e72-a56c-0fe6b552833e
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CObject::Serialize
Reads or writes this object from or to an archive.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object to serialize to or from.  
  
## Remarks  
 You must override <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> for each class that you intend to serialize. The overridden <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> must first call the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> function of its base class.  
  
 You must also use the [DECLARE_SERIAL](../vs140/declare_serial.md) macro in your class declaration, and you must use the [IMPLEMENT_SERIAL](../vs140/implement_serial.md) macro in the implementation.  
  
 Use [CArchive::IsLoading](../vs140/carchive--isloading.md) or [CArchive::IsStoring](../vs140/carchive--isstoring.md) to determine whether the archive is loading or storing.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is called by [CArchive::ReadObject](../vs140/carchive--readobject.md) and [CArchive::WriteObject](../vs140/carchive--writeobject.md). These functions are associated with the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> insertion operator (**<\<**) and extraction operator (**>>**).  
  
 For serialization examples, see the article [Serialization: Serializing an Object](../vs140/serialization--serializing-an-object.md).  
  
## Example  
 See [CObList::CObList](../vs140/coblist--coblist.md) for a listing of the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> class used in all <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> examples.  
  
 [!code[NVC_MFCCObjectSample#13](../vs140/codesnippet/CPP/cobject--serialize_1.cpp)]  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [CObject Class](../vs140/cobject-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)