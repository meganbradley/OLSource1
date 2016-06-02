---
title: View a Stored XML Schema Collection
ms.custom: na
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - dbe-xml
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: e38031af-22df-4cd9-a14e-e316b822f91b
---
# View a Stored XML Schema Collection
  After you import an XML schema collection by using [CREATE XML SCHEMA COLLECTION](../Topic/CREATE%20XML%20SCHEMA%20COLLECTION%20\(Transact-SQL\).md), the schema components are stored in the metadata. You can use the [xml\_schema\_namespace](../Topic/xml_schema_namespace%20\(Transact-SQL\).md)intrinsic function to reconstruct the XML schema collection. This function returns an **xml** data type instance.  
  
 For example, the following query retrieves an XML schema collection \(`ProductDescriptionSchemaCollection`\) from the production relational schema in the [!INCLUDE[ssSampleDBobject](../../Token\Other/ssSampleDBobject_md.md)] database.  
  
```  
SELECT xml_schema_namespace(N'Production',N'ProductDescriptionSchemaCollection')  
GO  
```  
  
 If you want to see only one schema from the XML schema collection, you can specify XQuery against the **xml** type result that is returned by `xml_schema_namespace`.  
  
```  
SELECT xml_schema_namespace(N'RelationalSchemaName',N'XmlSchemaCollectionName').query('  
/xs:schema[@targetNamespace="TargetNameSpace"]  
')  
GO  
```  
  
 For example, the following query retrieves product warranty and maintenance XML schema information from the `ProductDescriptionSchemaCollection` XML schema collection.  
  
```  
SELECT xml_schema_namespace(N'Production',N'ProductDescriptionSchemaCollection').query('  
/xs:schema[@targetNamespace="http://schemas.microsoft.com/sqlserver/2004/07/adventure-works/ProductModelWarrAndMain"]  
')  
GO  
```  
  
 You can also pass the optional target namespace as the third parameter to the `xml_schema_namespace` function to retrieve specific schema from the collection, as shown in the following query:  
  
```  
SELECT xml_schema_namespace(N'Production',N'ProductDescriptionSchemaCollection', N'http://schemas.microsoft.com/sqlserver/2004/07/adventure-works/ProductModelWarrAndMain')  
GO  
```  
  
 When you create an XML schema collection by using CREATE XML SCHEMA COLLECTION in the database, the statement stores the schema components in the metadata. Note that only the schema components that [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] understands are stored. Any comments, annotations, or non\-XSD attributes are not stored. Therefore, the schema reconstructed by **xml\_schema\_namespace** is functionally equivalent to the original schema, but it will not necessarily look the same. For example, you will not see the same prefixes you had in the original schema. The schema returned by **xml\_schema\_namespace** uses **t** as the prefix for the target namespace and **ns1**, **ns2**, and so on, for other namespaces.  
  
 If you want to retain an identical copy of the XML schemas, you should save your XML schema in a file or in a database table in an **xml** type column.  
  
 The [sys.xml\_schema\_collections](../Topic/sys.xml_schema_collections%20\(Transact-SQL\).md) catalog view also returns information about XML schema collections. This information includes the name of the collection, the creation date, and the owner of the collection.  
  
## See Also  
 [XML Schema Collections &#40;SQL Server&#41;](../Topic/XML%20Schema%20Collections%20\(SQL%20Server\).md)  
  
  