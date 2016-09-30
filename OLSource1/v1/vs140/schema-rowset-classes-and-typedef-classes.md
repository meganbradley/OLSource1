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
  
 Use the typedef classes to instantiate the schema rowsets. The corresponding typedef and schema rowset classes are listed below. You must call [CRestrictions::Open](../vs140/crestrictions--open.md) after you have created an instance of the schema rowset. This method returns a result set based on the restrictions you specify. See [IDBSchemaRowset](https://msdn.microsoft.com/en-us/library/ms713686.aspx) for information on restriction columns associated with each schema rowset.  
  
 The following table displays each OLE DB Schema Rowset and its corresponding OLE DB Templates typedef class and info class.  
  
|OLE DB Schema Rowset|Typedef class|Info class|  
|--------------------------|-------------------|----------------|  
|[ASSERTIONS](https://msdn.microsoft.com/en-us/library/ms719776.aspx)|[CAssertions](../vs140/cassertions--cassertioninfo.md)|[CAssertionInfo](../vs140/cassertions--cassertioninfo.md)|  
|[CATALOGS](https://msdn.microsoft.com/en-us/library/ms721241.aspx)|[CCatalogs](../vs140/ccatalogs--ccataloginfo.md)|[CCatalogInfo](../vs140/ccatalogs--ccataloginfo.md)|  
|[CHARACTER_SETS](https://msdn.microsoft.com/en-us/library/ms722638.aspx)|[CCharacterSets](../vs140/ccharactersets--ccharactersetinfo.md)|[CCharacterSetInfo](../vs140/ccharactersets--ccharactersetinfo.md)|  
|[COLLATIONS](https://msdn.microsoft.com/en-us/library/ms715783.aspx)|[CCollations](../vs140/ccollations--ccollationinfo.md)|[CCollationInfo](../vs140/ccollations--ccollationinfo.md)|  
|[COLUMN_PRIVILEGES](https://msdn.microsoft.com/en-us/library/ms715800.aspx)|[CColumnPrivileges](../vs140/ccolumnprivileges--ccolumnprivilegeinfo.md)|[CColumnPrivilegeInfo](../vs140/ccolumnprivileges--ccolumnprivilegeinfo.md)|  
|[COLUMNS](https://msdn.microsoft.com/en-us/library/ms723052.aspx)|[CColumns](../vs140/ccolumns--ccolumnsinfo.md)|[CColumnsInfo](../vs140/ccolumns--ccolumnsinfo.md)|  
|[CONSTRAINT_COLUMN_USAGE](https://msdn.microsoft.com/en-us/library/ms724522.aspx)|[CConstraintColumnUsage](../vs140/cconstraintcolumnusage--cconstraintcolumnusageinfo.md)|[CConstraintColumnUsageInfo](../vs140/cconstraintcolumnusage--cconstraintcolumnusageinfo.md)|  
|[CONSTRAINT_TABLE_USAGE](https://msdn.microsoft.com/en-us/library/ms713710.aspx)|[CConstraintTableUsage](../vs140/cconstrainttableusage--cconstrainttableusageinfo.md)|[CConstraintTableUsageInfo](../vs140/cconstrainttableusage--cconstrainttableusageinfo.md)|  
|[CHECK_CONSTRAINTS](https://msdn.microsoft.com/en-us/library/ms712845.aspx)|[CCheckConstraints](../vs140/ccheckconstraints--ccheckconstraintinfo.md)|[CCheckConstraintInfo](../vs140/ccheckconstraints--ccheckconstraintinfo.md)|  
|[COLUMN_DOMAIN_USAGE](https://msdn.microsoft.com/en-us/library/ms711240.aspx)|[CColumnDomainUsage](../vs140/ccolumndomainusage--ccolumndomainusageinfo.md)|[CColumnDomainUsageInfo](../vs140/ccolumndomainusage--ccolumndomainusageinfo.md)|  
|[FOREIGN_KEYS](https://msdn.microsoft.com/en-us/library/ms711276.aspx)|[CForeignKeys](../vs140/cforeignkeys--cforeignkeysinfo.md)|[CForeignKeysInfo](../vs140/cforeignkeys--cforeignkeysinfo.md)|  
|[INDEXES](https://msdn.microsoft.com/en-us/library/ms709712.aspx)|[CIndexes](../vs140/cindexes--cindexinfo.md)|[CIndexInfo](../vs140/cindexes--cindexinfo.md)|  
|[KEY_COLUMN_USAGE](https://msdn.microsoft.com/en-us/library/ms712990.aspx)|[CKeyColumnUsage](../vs140/ckeycolumns--ckeycolumninfo.md)|[CKeyColumnUsageInfo](../vs140/ckeycolumns--ckeycolumninfo.md)|  
|[PRIMARY_KEYS](https://msdn.microsoft.com/en-us/library/ms714362.aspx)|[CPrimaryKeys](../vs140/cprimarykeys--cprimarykeyinfo.md)|[CPrimaryKeyInfo](../vs140/cprimarykeys--cprimarykeyinfo.md)|  
|[PROCEDURES](https://msdn.microsoft.com/en-us/library/ms724021.aspx)|[CProcedures](../vs140/cprocedures--cprocedureinfo.md)|[CProcedureInfo](../vs140/cprocedures--cprocedureinfo.md)|  
|[PROCEDURE_COLUMNS](https://msdn.microsoft.com/en-us/library/ms723092.aspx)|[CProcedureColumns](../vs140/cprocedurecolumns--cprocedurecolumninfo.md)|[CProcedureColumnInfo](../vs140/cprocedurecolumns--cprocedurecolumninfo.md)|  
|[PROCEDURE_PARAMETERS](https://msdn.microsoft.com/en-us/library/ms713623.aspx)|[CProcedureParameters](../vs140/cprocedureparameters-cprocedureparaminfo.md)|[CProcedureParameterInfo](../vs140/cprocedureparameters-cprocedureparaminfo.md)|  
|[PROVIDER_TYPES](https://msdn.microsoft.com/en-us/library/ms709785.aspx)|[CProviderTypes](../vs140/cprovidertypes--cproviderinfo.md)|[CProviderInfo](../vs140/cprovidertypes--cproviderinfo.md)|  
|[REFERENTIAL_CONSTRAINTS](https://msdn.microsoft.com/en-us/library/ms719737.aspx)|[CReferentialConstraints](../vs140/creferentialconstraints--creferentialconstraintinfo.md)|[CReferentialConstraintInfo](../vs140/creferentialconstraints--creferentialconstraintinfo.md)|  
|[SCHEMATA](https://msdn.microsoft.com/en-us/library/ms716887.aspx)|[CSchemata](../vs140/cschemata--cschematainfo.md)|[CSchemataInfo](../vs140/cschemata--cschematainfo.md)|  
|[SQL_LANGUAGES](https://msdn.microsoft.com/en-us/library/ms714374.aspx)|[CSQLLanguages](../vs140/csqllanguages--csqllanguageinfo.md)|[CSQLLanguageInfo](../vs140/csqllanguages--csqllanguageinfo.md)|  
|[STATISTICS](https://msdn.microsoft.com/en-us/library/ms715957.aspx)|[CStatistics](../vs140/cstatistics--cstatisticinfo.md)|[CStatisticInfo](../vs140/cstatistics--cstatisticinfo.md)|  
|[TABLE_CONSTRAINTS](https://msdn.microsoft.com/en-us/library/ms715921.aspx)|[CTableConstraints](../vs140/ctableconstraints--ctableconstraintinfo.md)|[CTableConstraintInfo](../vs140/ctableconstraints--ctableconstraintinfo.md)|  
|[TABLES](https://msdn.microsoft.com/en-us/library/ms716980.aspx)|[CTables](../vs140/ctables--ctableinfo.md)|[CTableInfo](../vs140/ctables--ctableinfo.md)|  
|[TABLE_PRIVILEGES](https://msdn.microsoft.com/en-us/library/ms725428.aspx)|[CTablePrivileges](../vs140/ctableprivileges--ctableprivilegeinfo.md)|[CTablePrivilegeInfo](../vs140/ctableprivileges--ctableprivilegeinfo.md)|  
|[TRANSLATIONS](https://msdn.microsoft.com/en-us/library/ms725365.aspx)|[CTranslations](../vs140/ctranslations--ctranslationinfo.md)|[CTranslationInfo](../vs140/ctranslations--ctranslationinfo.md)|  
|[USAGE_PRIVILEGES](https://msdn.microsoft.com/en-us/library/ms722743.aspx)|[CUsagePrivileges](../vs140/cusageprivileges--cusageprivilegeinfo.md)|[CUsagePrivilegeInfo](../vs140/cusageprivileges--cusageprivilegeinfo.md)|  
|[VIEW_COLUMN_USAGE](https://msdn.microsoft.com/en-us/library/ms714896.aspx)|[CViewColumnUsage](../vs140/cviewcolumnusage--cviewcolumninfo.md)|[CViewColumnInfo](../vs140/cviewcolumnusage--cviewcolumninfo.md)|  
|[VIEWS](https://msdn.microsoft.com/en-us/library/ms723122.aspx)|[CViews](../vs140/cviews--cviewinfo.md)|[CViewInfo](../vs140/cviews--cviewinfo.md)|  
|[VIEW_TABLE_USAGE](https://msdn.microsoft.com/en-us/library/ms719727.aspx)|[CViewTableUsage](../vs140/cviewtableusage--cviewtableinfo.md)|[CViewTableInfo](../vs140/cviewtableusage--cviewtableinfo.md)|  
  
## Requirements  
 **Header:** atldbsch.h  
  
## See Also  
 [CRestrictions Class](../vs140/crestrictions-class.md)