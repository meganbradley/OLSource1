---
title: "CDaoRelationFieldInfo Structure"
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
  - "CDaoRelationFieldInfo"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DAO (Data Access Objects), Relations collection"
  - "CDaoRelationFieldInfo structure"
ms.assetid: 47cb89ca-dc80-47ce-96fd-cc4b88512558
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoRelationFieldInfo Structure
The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> structure contains information about a field in a relation defined for data access objects (DAO).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The name of the field in the primary table of the relation.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The name of the field in the foreign table of the relation.  
  
## Remarks  
 A DAO relation object specifies the fields in a primary table and the fields in a foreign table that define the relation. The references to Primary in the structure definition above indicate how the information is returned in the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> member of a [CDaoRelationInfo](../vs140/cdaorelationinfo-structure.md) object obtained by calling the [GetRelationInfo](../vs140/cdaodatabase--getrelationinfo.md) member function of class <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
 Relation objects and relation field objects are not represented by an MFC class. Instead, the DAO objects underlying MFC objects of class [CDaoDatabase](../vs140/cdaodatabase-class.md) contain a collection of relation objects, called the Relations collection. Each relation object, in turn, contains a collection of relation field objects. Each relation field object correlates a field in the primary table with a field in the foreign table. Taken together, the relation field objects define a group of fields in each table, which together define the relation. <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> lets you access relation objects with a <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object by calling the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> member function. The <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object, then, has a data member, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, that points to an array of <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> objects.  
  
 Call the [GetRelationInfo](../vs140/cdaodatabase--getrelationinfo.md) member function of the containing <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> object in whose Relations collection is stored the relation object you are interested in. Then access the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> member of the [CDaoRelationInfo](../vs140/cdaorelationinfo-structure.md) object. <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> also defines a <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> member function in debug builds. You can use <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> to dump the contents of a <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> object.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [Structures, Styles, Callbacks, and Message Maps](../vs140/structures--styles--callbacks--and-message-maps.md)   
 [CDaoRelationInfo Structure](../vs140/cdaorelationinfo-structure.md)