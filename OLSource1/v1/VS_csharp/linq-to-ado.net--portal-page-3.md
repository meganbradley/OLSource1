---
title: "LINQ to ADO.NET (Portal Page)3"
ms.custom: na
ms.date: "10/10/2016"
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
caps.latest.revision: 3
ms.author: "shoag"
manager: "wpickett"
translation.priority.mt: 
  - "cs-cz"
  - "pl-pl"
  - "pt-br"
  - "tr-tr"
---
# LINQ to ADO.NET (Portal Page)3
[!INCLUDE[linq_adonet](../VS_csharp/includes/linq_adonet_md.md)] enables you to query over any enumerable object in [!INCLUDE[vstecado](../VS_csharp/includes/vstecado_md.md)] by using the [!INCLUDE[vbteclinqext](../VS_csharp/includes/vbteclinqext_md.md)] programming model.  
  
> [!NOTE]
>  The [!INCLUDE[linq_adonet](../VS_csharp/includes/linq_adonet_md.md)] documentation is located in the ADO.NET section of the .NET Framework SDK: [LINQ and ADO.NET](../Topic/LINQ%20and%20ADO.NET.md).  
  
 There are three separate ADO.NET [!INCLUDE[vbteclinqext](../VS_csharp/includes/vbteclinqext_md.md)] technologies: [!INCLUDE[linq_dataset](../VS_csharp/includes/linq_dataset_md.md)], [!INCLUDE[vbtecdlinq](../VS_csharp/includes/vbtecdlinq_md.md)], and [!INCLUDE[linq_entities](../VS_csharp/includes/linq_entities_md.md)]. [!INCLUDE[linq_dataset](../VS_csharp/includes/linq_dataset_md.md)] provides richer, optimized querying over the \<xref:System.Data.DataSet>, [!INCLUDE[vbtecdlinq](../VS_csharp/includes/vbtecdlinq_md.md)] enables you to directly query [!INCLUDE[ssNoVersion](../VS_csharp/includes/ssnoversion_md.md)] database schemas, and [!INCLUDE[linq_entities](../VS_csharp/includes/linq_entities_md.md)] allows you to query an [!INCLUDE[adonet_edm](../VS_csharp/includes/adonet_edm_md.md)].  
  
## LINQ to DataSet  
 The \<xref:System.Data.DataSet> is one of the most widely used components in [!INCLUDE[vstecado](../VS_csharp/includes/vstecado_md.md)], and is a key element of the disconnected programming model that [!INCLUDE[vstecado](../VS_csharp/includes/vstecado_md.md)] is built on. Despite this prominence, however, the \<xref:System.Data.DataSet> has limited query capabilities.  
  
 [!INCLUDE[linq_dataset](../VS_csharp/includes/linq_dataset_md.md)] enables you to build richer query capabilities into \<xref:System.Data.DataSet> by using the same query functionality that is available for many other data sources.  
  
 For more information, see [LINQ to DataSet](../Topic/LINQ%20to%20DataSet.md).  
  
## LINQ to SQL  
 [!INCLUDE[vbtecdlinq](../VS_csharp/includes/vbtecdlinq_md.md)] provides a run-time infrastructure for managing relational data as objects. In [!INCLUDE[vbtecdlinq](../VS_csharp/includes/vbtecdlinq_md.md)], the data model of a relational database is mapped to an object model expressed in the programming language of the developer. When you execute the application, [!INCLUDE[vbtecdlinq](../VS_csharp/includes/vbtecdlinq_md.md)] translates language-integrated queries in the object model into SQL and sends them to the database for execution. When the database returns the results, [!INCLUDE[vbtecdlinq](../VS_csharp/includes/vbtecdlinq_md.md)] translates them back into objects that you can manipulate.  
  
 [!INCLUDE[vbtecdlinq](../VS_csharp/includes/vbtecdlinq_md.md)] includes support for stored procedures and user-defined functions in the database, and for inheritance in the object model.  
  
 For more information, see [LINQ to SQL](../Topic/LINQ%20to%20SQL.md).  
  
## LINQ to Entities  
 Through the [!INCLUDE[adonet_edm](../VS_csharp/includes/adonet_edm_md.md)], relational data is exposed as objects in the .NET environment. This makes the object layer an ideal target for [!INCLUDE[vbteclinq](../VS_csharp/includes/vbteclinq_md.md)] support, allowing developers to formulate queries against the database from the language used to build the business logic. This capability is known as [!INCLUDE[linq_entities](../VS_csharp/includes/linq_entities_md.md)]. See [LINQ to Entities](../Topic/LINQ%20to%20Entities.md) for more information.  
  
## See Also  
 [LINQ and ADO.NET](../Topic/LINQ%20and%20ADO.NET.md)   
 [Language-Integrated Query (LINQ) (C#)](../VS_csharp/language-integrated-query--linq---csharp-.md)