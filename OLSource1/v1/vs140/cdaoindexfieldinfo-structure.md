---
title: "CDaoIndexFieldInfo Structure"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "CDaoIndexFieldInfo"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDaoIndexFieldInfo structure"
  - "DAO (Data Access Objects), Index Fields collection"
ms.assetid: 097ee8a6-83b1-4db7-8f05-d62a2deefe19
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoIndexFieldInfo Structure
The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> structure contains information about an index field object defined for data access objects (DAO).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Uniquely names the index field object. For details, see the topic "Name Property" in DAO Help.  
  
 *m_bDescending*  
 Indicates the index ordering defined by the index object. **TRUE** if the order is descending.  
  
## Remarks  
 An index object can have a number of fields, indicating which fields a tabledef (or a recordset based on a table) is indexed on. The references to Primary above indicate how the information is returned in the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> member of a [CDaoIndexInfo](../vs140/cdaoindexinfo-structure.md) object obtained by calling the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> member function of class [CDaoTableDef](../vs140/cdaotabledef--getindexinfo.md) or [CDaoRecordset](../vs140/cdaorecordset--getindexinfo.md).  
  
 Index objects and index field objects are not represented by an MFC class. Instead, the DAO objects underlying MFC objects of class [CDaoTableDef](../vs140/cdaotabledef-class.md) or [CDaoRecordset](../vs140/cdaorecordset-class.md) contain a collection of index objects, called the Indexes collection. Each index object, in turn, contains a collection of field objects. These classes supply member functions to access individual items of index information, or you can access them all at once with a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object by calling the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> member function of the containing object. The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object, then, has a data member, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, that points to an array of <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> objects.  
  
 Call the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> member function of the containing tabledef or recordset object in whose Indexes collection is stored the index object you are interested in. Then access the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> member of the [CDaoIndexInfo](../vs140/cdaoindexinfo-structure.md) object. The length of the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> array is stored in <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> also defines a <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> member function in debug builds. You can use <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> to dump the contents of a <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> object.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [Structures, Styles, Callbacks, and Message Maps](../vs140/structures--styles--callbacks--and-message-maps.md)   
 [CDaoTableDef::GetIndexInfo](../vs140/cdaotabledef--getindexinfo.md)   
 [CDaoRecordset::GetIndexInfo](../vs140/cdaorecordset--getindexinfo.md)