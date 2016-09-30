---
title: "CArchive::SerializeClass"
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
  - "CArchive::SerializeClass"
  - "SerializeClass"
  - "CArchive.SerializeClass"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SerializeClass method"
ms.assetid: 27e534e5-8c0e-4112-8875-b148ea0d0bdd
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CArchive::SerializeClass
Call this member function when you want to store and load the version information of a base class.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to a run-time class object for the base class.  
  
## Remarks  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> reads or writes the reference to a class to the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object, depending on the direction of the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. Use <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> in place of [ReadClass](../vs140/carchive--readclass.md) and [WriteClass](../vs140/carchive--writeclass.md) as a convenient way to serialize base-class objects; <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> requires less code and fewer parameters.  
  
 Like <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> verifies that the archived class information is compatible with your runtime class. If it is not compatible, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> will throw a [CArchiveException](../vs140/carchiveexception-class.md).  
  
 Your runtime class must use [DECLARE_SERIAL](../vs140/declare_serial.md) and [IMPLEMENT_SERIAL](../vs140/implement_serial.md); otherwise, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> will throw a [CNotSupportedException](../vs140/cnotsupportedexception-class.md).  
  
 Use the [RUNTIME_CLASS](../vs140/runtime_class.md) macro to retrieve the value for the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> parameter. The base class must have used the [IMPLEMENT_SERIAL](../vs140/implement_serial.md) macro.  
  
## Example  
 [!code[NVC_MFCSerialization#25](../vs140/codesnippet/CPP/carchive--serializeclass_1.h)]  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [CArchive Class](../vs140/carchive-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CArchive::ReadClass](../vs140/carchive--readclass.md)   
 [CArchive::WriteClass](../vs140/carchive--writeclass.md)   
 [CArchive::GetObjectSchema](../vs140/carchive--getobjectschema.md)   
 [CArchive::SetObjectSchema](../vs140/carchive--setobjectschema.md)   
 [CArchiveException Class](../vs140/carchiveexception-class.md)   
 [CNotSupportedException Class](../vs140/cnotsupportedexception-class.md)