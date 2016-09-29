---
title: "Schema Rowset Classes and Typedef Classes"
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
  - "vc.templates.ole"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "schema rowsets, classes"
ms.assetid: 4bd881b3-26ca-4bdb-9226-d67560864f29
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Schema Rowset Classes and Typedef Classes
A schema is a collection of database objects that are owned, or have been created by, a particular user. A catalog can contain one or more schemas, but must always contain a schema called INFORMATION_SCHEMA, which contains the views and domains of the information schema. Schema information in OLE DB is retrieved using predefined schema rowsets, and includes types, tables, columns, indexes, views, assertions and constraints, statistics, character sets, collations, and domains.  
  
 Schema rowsets are predefined rowsets representing metadata. Schema rowsets are generally used in dynamic programming, where the database structure is not known at compile time. You can use these schema rowsets to obtain information about a database at run time.  
  
 Use the typedef classes to instantiate the schema rowsets. The corresponding typedef and schema rowset classes are listed below. You must call [CRestrictions::Open](../VS_csharp/crestrictions--open.md) after you have created an instance of the schema rowset. This method returns a result set based on the restrictions you specify. See [IDBSchemaRowset](https://msdn.microsoft.com/en-us/library/ms713686.aspx) for information on restriction columns associated with each schema rowset.  
  
 The following table displays each OLE DB Schema Rowset and its corresponding OLE DB Templates typedef class and info class.  
  
|OLE DB Schema Rowset|Typedef class|Info class|  
|--------------------------|-------------------|----------------|  
|[ASSERTIONS](https://msdn.microsoft.com/en-us/library/ms719776.aspx)|[CAssertions](../VS_csharp/cassertions--cassertioninfo.md)|[CAssertionInfo](../VS_csharp/cassertions--cassertioninfo.md)|  
|[CATALOGS](https://msdn.microsoft.com/en-us/library/ms721241.aspx)|[CCatalogs](../VS_csharp/ccatalogs--ccataloginfo.md)|[CCatalogInfo](../VS_csharp/ccatalogs--ccataloginfo.md)|  
|[CHARACTER_SETS](https://msdn.microsoft.com/en-us/library/ms722638.aspx)|[CCharacterSets](../VS_csharp/ccharactersets--ccharactersetinfo.md)|[CCharacterSetInfo](../VS_csharp/ccharactersets--ccharactersetinfo.md)|  
|[COLLATIONS](https://msdn.microsoft.com/en-us/library/ms715783.aspx)|[CCollations](../VS_csharp/ccollations--ccollationinfo.md)|[CCollationInfo](../VS_csharp/ccollations--ccollationinfo.md)|  
|[COLUMN_PRIVILEGES](https://msdn.microsoft.com/en-us/library/ms715800.aspx)|[CColumnPrivileges](../VS_csharp/ccolumnprivileges--ccolumnprivilegeinfo.md)|[CColumnPrivilegeInfo](../VS_csharp/ccolumnprivileges--ccolumnprivilegeinfo.md)|  
|[COLUMNS](https://msdn.microsoft.com/en-us/library/ms723052.aspx)|[CColumns](../VS_csharp/ccolumns--ccolumnsinfo.md)|[CColumnsInfo](../VS_csharp/ccolumns--ccolumnsinfo.md)|  
|[CONSTRAINT_COLUMN_USAGE](https://msdn.microsoft.com/en-us/library/ms724522.aspx)|[CConstraintColumnUsage](../VS_csharp/cconstraintcolumnusage--cconstraintcolumnusageinfo.md)|[CConstraintColumnUsageInfo](../VS_csharp/cconstraintcolumnusage--cconstraintcolumnusageinfo.md)|  
|[CONSTRAINT_TABLE_USAGE](https://msdn.microsoft.com/en-us/library/ms713710.aspx)|[CConstraintTableUsage](../VS_csharp/cconstrainttableusage--cconstrainttableusageinfo.md)|[CConstraintTableUsageInfo](../VS_csharp/cconstrainttableusage--cconstrainttableusageinfo.md)|  
|[CHECK_CONSTRAINTS](https://msdn.microsoft.com/en-us/library/ms712845.aspx)|[CCheckConstraints](../VS_csharp/ccheckconstraints--ccheckconstraintinfo.md)|[CCheckConstraintInfo](../VS_csharp/ccheckconstraints--ccheckconstraintinfo.md)|  
|[COLUMN_DOMAIN_USAGE](https://msdn.microsoft.com/en-us/library/ms711240.aspx)|[CColumnDomainUsage](../VS_csharp/ccolumndomainusage--ccolumndomainusageinfo.md)|[CColumnDomainUsageInfo](../VS_csharp/ccolumndomainusage--ccolumndomainusageinfo.md)|  
|[FOREIGN_KEYS](https://msdn.microsoft.com/en-us/library/ms711276.aspx)|[CForeignKeys](../VS_csharp/cforeignkeys--cforeignkeysinfo.md)|[CForeignKeysInfo](../VS_csharp/cforeignkeys--cforeignkeysinfo.md)|  
|[INDEXES](https://msdn.microsoft.com/en-us/library/ms709712.aspx)|[CIndexes](../VS_csharp/cindexes--cindexinfo.md)|[CIndexInfo](../VS_csharp/cindexes--cindexinfo.md)|  
|[KEY_COLUMN_USAGE](https://msdn.microsoft.com/en-us/library/ms712990.aspx)|[CKeyColumnUsage](../VS_csharp/ckeycolumns--ckeycolumninfo.md)|[CKeyColumnUsageInfo](../VS_csharp/ckeycolumns--ckeycolumninfo.md)|  
|[PRIMARY_KEYS](https://msdn.microsoft.com/en-us/library/ms714362.aspx)|[CPrimaryKeys](../VS_csharp/cprimarykeys--cprimarykeyinfo.md)|[CPrimaryKeyInfo](../VS_csharp/cprimarykeys--cprimarykeyinfo.md)|  
|[PROCEDURES](https://msdn.microsoft.com/en-us/library/ms724021.aspx)|[CProcedures](../VS_csharp/cprocedures--cprocedureinfo.md)|[CProcedureInfo](../VS_csharp/cprocedures--cprocedureinfo.md)|  
|[PROCEDURE_COLUMNS](https://msdn.microsoft.com/en-us/library/ms723092.aspx)|[CProcedureColumns](../VS_csharp/cprocedurecolumns--cprocedurecolumninfo.md)|[CProcedureColumnInfo](../VS_csharp/cprocedurecolumns--cprocedurecolumninfo.md)|  
|[PROCEDURE_PARAMETERS](https://msdn.microsoft.com/en-us/library/ms713623.aspx)|[CProcedureParameters](../VS_csharp/cprocedureparameters-cprocedureparaminfo.md)|[CProcedureParameterInfo](../VS_csharp/cprocedureparameters-cprocedureparaminfo.md)|  
|[PROVIDER_TYPES](https://msdn.microsoft.com/en-us/library/ms709785.aspx)|[CProviderTypes](../VS_csharp/cprovidertypes--cproviderinfo.md)|[CProviderInfo](../VS_csharp/cprovidertypes--cproviderinfo.md)|  
|[REFERENTIAL_CONSTRAINTS](https://msdn.microsoft.com/en-us/library/ms719737.aspx)|[CReferentialConstraints](../VS_csharp/creferentialconstraints--creferentialconstraintinfo.md)|[CReferentialConstraintInfo](../VS_csharp/creferentialconstraints--creferentialconstraintinfo.md)|  
|[SCHEMATA](https://msdn.microsoft.com/en-us/library/ms716887.aspx)|[CSchemata](../VS_csharp/cschemata--cschematainfo.md)|[CSchemataInfo](../VS_csharp/cschemata--cschematainfo.md)|  
|[SQL_LANGUAGES](https://msdn.microsoft.com/en-us/library/ms714374.aspx)|[CSQLLanguages](../VS_csharp/csqllanguages--csqllanguageinfo.md)|[CSQLLanguageInfo](../VS_csharp/csqllanguages--csqllanguageinfo.md)|  
|[STATISTICS](https://msdn.microsoft.com/en-us/library/ms715957.aspx)|[CStatistics](../VS_csharp/cstatistics--cstatisticinfo.md)|[CStatisticInfo](../VS_csharp/cstatistics--cstatisticinfo.md)|  
|[TABLE_CONSTRAINTS](https://msdn.microsoft.com/en-us/library/ms715921.aspx)|[CTableConstraints](../VS_csharp/ctableconstraints--ctableconstraintinfo.md)|[CTableConstraintInfo](../VS_csharp/ctableconstraints--ctableconstraintinfo.md)|  
|[TABLES](https://msdn.microsoft.com/en-us/library/ms716980.aspx)|[CTables](../VS_csharp/ctables--ctableinfo.md)|[CTableInfo](../VS_csharp/ctables--ctableinfo.md)|  
|[TABLE_PRIVILEGES](https://msdn.microsoft.com/en-us/library/ms725428.aspx)|[CTablePrivileges](../VS_csharp/ctableprivileges--ctableprivilegeinfo.md)|[CTablePrivilegeInfo](../VS_csharp/ctableprivileges--ctableprivilegeinfo.md)|  
|[TRANSLATIONS](https://msdn.microsoft.com/en-us/library/ms725365.aspx)|[CTranslations](../VS_csharp/ctranslations--ctranslationinfo.md)|[CTranslationInfo](../VS_csharp/ctranslations--ctranslationinfo.md)|  
|[USAGE_PRIVILEGES](https://msdn.microsoft.com/en-us/library/ms722743.aspx)|[CUsagePrivileges](../VS_csharp/cusageprivileges--cusageprivilegeinfo.md)|[CUsagePrivilegeInfo](../VS_csharp/cusageprivileges--cusageprivilegeinfo.md)|  
|[VIEW_COLUMN_USAGE](https://msdn.microsoft.com/en-us/library/ms714896.aspx)|[CViewColumnUsage](../VS_csharp/cviewcolumnusage--cviewcolumninfo.md)|[CViewColumnInfo](../VS_csharp/cviewcolumnusage--cviewcolumninfo.md)|  
|[VIEWS](https://msdn.microsoft.com/en-us/library/ms723122.aspx)|[CViews](../VS_csharp/cviews--cviewinfo.md)|[CViewInfo](../VS_csharp/cviews--cviewinfo.md)|  
|[VIEW_TABLE_USAGE](https://msdn.microsoft.com/en-us/library/ms719727.aspx)|[CViewTableUsage](../VS_csharp/cviewtableusage--cviewtableinfo.md)|[CViewTableInfo](../VS_csharp/cviewtableusage--cviewtableinfo.md)|  
  
## Requirements  
 **Header:** atldbsch.h  
  
## See Also  
 [CRestrictions Class](../VS_csharp/crestrictions-class.md)