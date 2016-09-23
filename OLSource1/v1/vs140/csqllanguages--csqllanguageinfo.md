---
title: "CSQLLanguages, CSQLLanguageInfo"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - CSQLLanguageInfo
  - m_szProgrammingLanguage
  - m_szImplementation
  - m_szIntegrity
  - m_szBindingStyle
  - m_szConformance
  - m_szSource
  - m_szYear
  - CSQLLanguages
dev_langs: 
  - C++
helpviewer_keywords: 
  - m_szBindingStyle
  - m_szProgrammingLanguage
  - m_szYear
  - m_szImplementation
  - m_szSource
  - m_szConformance
  - CSQLLanguages typedef class
  - CSQLLanguageInfo parameter class
  - m_szIntegrity
ms.assetid: 9c36c5bb-6917-49c3-9ac3-942339893f19
caps.latest.revision: 10
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CSQLLanguages, CSQLLanguageInfo
Call the typedef class **CSQLLanguages** to implement its parameter class **CSQLLanguageInfo**.  
  
## Remarks  
 See [Schema Rowset Classes and Typedef Classes](../vs140/schema-rowset-classes-and-typedef-classes.md) for more information on using typedef classes.  
  
 This class identifies the conformance levels, options, and dialects supported by the SQL-implementation processing data defined in the catalog.  
  
 The following table lists the class data members and their corresponding OLE DB Columns. See [SQL_LANGUAGES Rowset](https://msdn.microsoft.com/en-us/library/ms714374.aspx) in the *OLE DB Programmer's Reference* for more information about the schema and columns.  
  
|Data members|OLE DB columns|  
|------------------|--------------------|  
|m_szSource|SQL_LANGUAGE_SOURCE|  
|m_szYear|SQL_LANGUAGE_YEAR|  
|m_szConformance|SQL_LANGUAGE_CONFORMANCE|  
|m_szIntegrity|SQL_LANGUAGE_INTEGRITY|  
|m_szImplementation|SQL_LANGUAGE_IMPLEMENTATION|  
|m_szBindingStyle|SQL_LANGUAGE_BINDING_STYLE|  
|m_szProgrammingLanguage|SQL_LANGUAGE_PROGRAMMING_LANGUAGE|  
  
## Requirements  
 **Header:** atldbsch.h  
  
## See Also  
 [CRestrictions Class](../vs140/crestrictions-class.md)