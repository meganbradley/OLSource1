---
title: "CDaoDatabase::CreateRelation"
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
  - "CDaoDatabase::CreateRelation"
  - "CreateRelation"
  - "CDaoDatabase.CreateRelation"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "dbRelationUpdateCascade attribute"
  - "CreateRelation method"
  - "dbRelationLeft attribute"
  - "CDaoDatabase class, creating relations"
  - "tables [C++]"
  - "dbRelationRight attribute"
  - "dbRelationInherited attribute"
  - "databases [C++], creating relations"
  - "relationships [C++], creating between tables"
  - "dbRelationUnique attribute"
  - "dbRelationDeleteCascade attribute"
  - "dbRelationDontEnforce attribute"
  - "tables [C++], relationships"
  - "DAO [C++], relationships"
ms.assetid: a698f386-5ede-4fb8-8c6c-7d7e61ea353f
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoDatabase::CreateRelation
Call this member function to establish a relation between one or more fields in a primary table in the database and one or more fields in a foreign table (another table in the database).  
  
## Syntax  
  
```  
  
      void CreateRelation(   
   LPCTSTR lpszName,   
   LPCTSTR lpszTable,   
   LPCTSTR lpszForeignTable,   
   long lAttributes,   
   LPCTSTR lpszField,   
   LPCTSTR lpszForeignField    
);  
void CreateRelation(   
   CDaoRelationInfo& relinfo    
);  
```  
  
#### Parameters  
 `lpszName`  
 The unique name of the relation object. The name must start with a letter and can contain a maximum of 40 characters. It can include numbers and underscore characters but cannot include punctuation or spaces.  
  
 `lpszTable`  
 The name of the primary table in the relation. If the table does not exist, MFC throws an exception of type [CDaoException](../vs140/cdaoexception-class.md).  
  
 `lpszForeignTable`  
 The name of the foreign table in the relation. If the table does not exist, MFC throws an exception of type `CDaoException`.  
  
 `lAttributes`  
 A long value that contains information about the relationship type. You can use this value to enforce referential integrity, among other things. You can use the bitwise-OR operator (**&#124;**) to combine any of the following values (as long as the combination makes sense):  
  
-   **dbRelationUnique** Relationship is one-to-one.  
  
-   **dbRelationDontEnforce** Relationship is not enforced (no referential integrity).  
  
-   **dbRelationInherited** Relationship exists in a noncurrent database that contains the two attached tables.  
  
-   **dbRelationUpdateCascade** Updates will cascade (for more on cascades, see Remarks).  
  
-   **dbRelationDeleteCascade** Deletions will cascade.  
  
 *lpszField*  
 A pointer to a null-terminated string containing the name of a field in the primary table (named by `lpszTable`).  
  
 *lpszForeignField*  
 A pointer to a null-terminated string containing the name of a field in the foreign table (named by `lpszForeignTable`).  
  
 *relinfo*  
 A reference to a [CDaoRelationInfo](../vs140/cdaorelationinfo-structure.md) object that contains information about the relation you want to create.  
  
## Remarks  
 The relationship cannot involve a query or an attached table from an external database.  
  
 Use the first version of the function when the relation involves one field in each of the two tables. Use the second version when the relation involves multiple fields. The maximum number of fields in a relation is 14.  
  
 This action creates an underlying DAO relation object, but this is an MFC implementation detail since MFC's encapsulation of relation objects is contained within class `CDaoDatabase`. MFC does not supply a class for relations.  
  
 If you set the relation object's attributes to activate cascade operations, the database engine automatically updates or deletes records in one or more other tables when changes are made to related primary key tables.  
  
 For example, suppose you establish a cascade delete relationship between a Customers table and an Orders table. When you delete records from the Customers table, records in the Orders table related to that customer are also deleted. In addition, if you establish cascade delete relationships between the Orders table and other tables, records from those tables are automatically deleted when you delete records from the Customers table.  
  
 For related information, see the topic "CreateRelation Method" in DAO Help.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoDatabase Class](../vs140/cdaodatabase-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoDatabase::DeleteRelation](../vs140/cdaodatabase--deleterelation.md)