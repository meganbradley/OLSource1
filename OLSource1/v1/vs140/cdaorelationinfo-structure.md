---
title: "CDaoRelationInfo Structure"
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
  - "CDaoRelationInfo"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DAO (Data Access Objects), Relations collection"
  - "CDaoRelationInfo structure"
ms.assetid: 92dda090-fe72-4090-84ec-429498a48aad
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoRelationInfo Structure
The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> structure contains information about a relation defined between fields of two tables in a [CDaoDatabase](../vs140/cdaodatabase-class.md) object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Uniquely names the relation object. For more information, see the topic "Name Property" in DAO Help.  
  
 *m_strTable*  
 Names the primary table in the relation.  
  
 *m_strForeignTable*  
 Names the foreign table in the relation. A foreign table is a table used to contain foreign keys. Generally, you use a foreign table to establish or enforce referential integrity. The foreign table is usually on the many side of a one-to-many relationship. Examples of foreign tables include tables containing codes for the American states or Canadian provinces or customer orders.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Contains information about the relation type. The value of this member can be any of the following:  
  
-   **dbRelationUnique** Relationship is one-to-one.  
  
-   **dbRelationDontEnforce** Relationship is not enforced (no referential integrity).  
  
-   **dbRelationInherited** Relationship exists in a noncurrent database that contains the two attached tables.  
  
-   **dbRelationLeft** The relationship is a left join. A left outer join includes all of the records from the first (left-hand) of two tables, even if there are no matching values for records in the second (right-hand) table.  
  
-   **dbRelationRight** The relationship is a right join. A right outer join includes all of the records from the second (right-hand) of two tables, even if there are no matching values for records in the first (left-hand) table.  
  
-   **dbRelationUpdateCascade** Updates will cascade.  
  
-   **dbRelationDeleteCascade** Deletions will cascade.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A pointer to an array of [CDaoRelationFieldInfo](../vs140/cdaorelationfieldinfo-structure.md) structures. The array contains one object for each field in the relation. The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> data member gives a count of the array elements.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The number of <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> objects in the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> data member.  
  
## Remarks  
 The references to Primary and Secondary above indicate how the information is returned by the [GetRelationInfo](../vs140/cdaodatabase--getrelationinfo.md) member function in class <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
 Relation objects are not represented by an MFC class. Instead, the DAO object underlying an MFC object of the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> class maintains a collection of relation objects: <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> supplies member functions to access some individual items of relation information, or you can access them all at once with a <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> object by calling the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> member function of the containing database object.  
  
 Information retrieved by the [CDaoDatabase::GetRelationInfo](../vs140/cdaodatabase--getrelationinfo.md) member function is stored in a <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> structure. <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> also defines a <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> member function in debug builds. You can use <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> to dump the contents of a <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> object.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoRelationFieldInfo Structure](../vs140/cdaorelationfieldinfo-structure.md)