---
title: "LINQ to ADO.NET (Portal Page)3"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "LINQ to ADO.NET (Portal Page)"
dev_langs: 
  - "CSharp"
ms.assetid: 6bd269b4-3509-4688-b672-836008704182
caps.latest.revision: 7
---
# LINQ to ADO.NET (Portal Page)3
[!INCLUDE[linq_adonet](../vs140/includes/linq_adonet_md.md)] enables you to query over any enumerable object in [!INCLUDE[vstecado](../vs140/includes/vstecado_md.md)] by using the [!INCLUDE[vbteclinqext](../vs140/includes/vbteclinqext_md.md)] programming model.  
  
> [!NOTE]
>  The [!INCLUDE[linq_adonet](../vs140/includes/linq_adonet_md.md)] documentation is located in the ADO.NET section of the .NET Framework SDK: [LINQ and ADO.NET](assetId:///bf0c8f93-3ff7-49f3-8aed-f2b7ac938dec).  
  
 There are three separate ADO.NET [!INCLUDE[vbteclinqext](../vs140/includes/vbteclinqext_md.md)] technologies: [!INCLUDE[linq_dataset](../vs140/includes/linq_dataset_md.md)], [!INCLUDE[vbtecdlinq](../vs140/includes/vbtecdlinq_md.md)], and [!INCLUDE[linq_entities](../vs140/includes/linq_entities_md.md)]. [!INCLUDE[linq_dataset](../vs140/includes/linq_dataset_md.md)] provides richer, optimized querying over the <xref:System.Data.DataSet*>, [!INCLUDE[vbtecdlinq](../vs140/includes/vbtecdlinq_md.md)] enables you to directly query [!INCLUDE[ssNoVersion](../vs140/includes/ssnoversion_md.md)] database schemas, and [!INCLUDE[linq_entities](../vs140/includes/linq_entities_md.md)] allows you to query an [!INCLUDE[adonet_edm](../vs140/includes/adonet_edm_md.md)].  
  
## LINQ to DataSet  
 The <xref:System.Data.DataSet*> is one of the most widely used components in [!INCLUDE[vstecado](../vs140/includes/vstecado_md.md)], and is a key element of the disconnected programming model that [!INCLUDE[vstecado](../vs140/includes/vstecado_md.md)] is built on. Despite this prominence, however, the <xref:System.Data.DataSet*> has limited query capabilities.  
  
 [!INCLUDE[linq_dataset](../vs140/includes/linq_dataset_md.md)] enables you to build richer query capabilities into <xref:System.Data.DataSet*> by using the same query functionality that is available for many other data sources.  
  
 For more information, see [LINQ to DataSet](assetId:///743e3755-3ecb-45a2-8d9b-9ed41f0dcf17).  
  
## LINQ to SQL  
 [!INCLUDE[vbtecdlinq](../vs140/includes/vbtecdlinq_md.md)] provides a run-time infrastructure for managing relational data as objects. In [!INCLUDE[vbtecdlinq](../vs140/includes/vbtecdlinq_md.md)], the data model of a relational database is mapped to an object model expressed in the programming language of the developer. When you execute the application, [!INCLUDE[vbtecdlinq](../vs140/includes/vbtecdlinq_md.md)] translates language-integrated queries in the object model into SQL and sends them to the database for execution. When the database returns the results, [!INCLUDE[vbtecdlinq](../vs140/includes/vbtecdlinq_md.md)] translates them back into objects that you can manipulate.  
  
 [!INCLUDE[vbtecdlinq](../vs140/includes/vbtecdlinq_md.md)] includes support for stored procedures and user-defined functions in the database, and for inheritance in the object model.  
  
 For more information, see [LINQ to SQL](assetId:///73d13345-eece-471a-af40-4cc7a2f11655).  
  
## LINQ to Entities  
 Through the [!INCLUDE[adonet_edm](../vs140/includes/adonet_edm_md.md)], relational data is exposed as objects in the .NET environment. This makes the object layer an ideal target for [!INCLUDE[vbteclinq](../vs140/includes/vbteclinq_md.md)] support, allowing developers to formulate queries against the database from the language used to build the business logic. This capability is known as [!INCLUDE[linq_entities](../vs140/includes/linq_entities_md.md)]. See [LINQ to Entities](assetId:///641f9b68-9046-47a1-abb0-1c8eaeda0e2d) for more information.  
  
## See Also  
 [LINQ and ADO.NET](assetId:///bf0c8f93-3ff7-49f3-8aed-f2b7ac938dec)   
 [Language-Integrated Query (LINQ) (C#)](../vs140/language-integrated-query--linq---csharp-.md)