---
title: "CArchive::WriteObject"
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
  - "CArchive::WriteObject"
  - "WriteObject"
  - "CArchive.WriteObject"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "WriteObject method"
ms.assetid: abc9fa11-e08a-4ad5-8196-7074e5557e77
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CArchive::WriteObject
Stores the specified `CObject` to the archive.  
  
## Syntax  
  
```  
  
      void WriteObject(  
   const CObject* pOb   
);  
```  
  
#### Parameters  
 `pOb`  
 A constant pointer to the object being stored.  
  
## Remarks  
 This function is normally called by the `CArchive` insertion (**<<**) operator overloaded for `CObject`. **WriteObject**, in turn, calls the `Serialize` function of the archived class.  
  
 You must use the `IMPLEMENT_SERIAL` macro to enable archiving. **WriteObject** writes the ASCII class name to the archive. This class name is validated later during the load process. A special encoding scheme prevents unnecessary duplication of the class name for multiple objects of the class. This scheme also prevents redundant storage of objects that are targets of more than one pointer.  
  
 The exact object encoding method (including the presence of the ASCII class name) is an implementation detail and could change in future versions of the library.  
  
> [!NOTE]
>  Finish creating, deleting, and updating all your objects before you begin to archive them. Your archive will be corrupted if you mix archiving with object modification.  
  
## Example  
 For a definition of the class `CAge`, see the example for [CObList::CObList](../vs140/coblist--coblist.md).  
  
 [!code[NVC_MFCSerialization#29](../vs140/codesnippet/CPP/carchive--writeobject_1.cpp)]  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [CArchive Class](../vs140/carchive-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CArchive::ReadObject](../vs140/carchive--readobject.md)