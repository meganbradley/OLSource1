---
title: Configure and Manage Word Breakers and Stemmers for Search
ms.custom: na
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - dbe-search
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: d4bdd16b-a2db-4101-a946-583d1c674229
---
# Configure and Manage Word Breakers and Stemmers for Search
  Word breakers and stemmers perform linguistic analysis on all full\-text indexed data. Linguistic analysis involves finding word boundaries \(word\-breaking\) and conjugating verbs \(stemming\). Word breakers and stemmers are language specific, and the rules for linguistic analysis differ for different languages. For a given language, a *word breaker* identifies individual words by determining where word boundaries exist based on the lexical rules of the language. Each word \(also known as a *token*\) is inserted into the full\-text index using a compressed representation to reduce its size. The *stemmer* generates inflectional forms of a particular word based on the rules of that language \(for example, "running", "ran", and "runner" are various forms of the word "run"\).  
  
 Using language\-specific word breakers enables the resulting terms to be more accurate for that language. Where there is a word breaker for the language family, but not for the specific sub\-language, the major language is used. For example, the French word breaker is used to handle text that is French Canadian. If no word breaker is available for a particular language, the neutral word breaker is used. With the neutral word breaker, words are broken at neutral characters such as spaces and punctuation marks.  
  
##  <a name="register"></a> Registering Word Breakers  
 For the word breakers of a language to be used, they must be registered. For registered word breakers, associated linguistic resources—stemmers, noise words \(stopwords\), and thesaurus files—also become available to full\-text indexing and querying operations. To view a list of the languages whose word breakers are currently registered with [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)], use the following [!INCLUDE[tsql](../../Token\Other/tsql_md.md)] statement:  
  
 SELECT \* FROM sys.fulltext\_languages  
  
 If you add, remove, or alter a word breaker, you need to refresh the list of Microsoft Windows locale identifiers \(LCIDs\) that are supported for full\-text indexing and querying. For more information, see [View or Change Registered Filters and Word Breakers](../../Topics\TopicNameNotContainA/View-or-Change-Registered-Filters-and-Word-Breakers.md).  
  
##  <a name="default"></a> Setting the Default Full\-Text Language Option  
 For a localized version of [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)], [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] Setup sets the **default full\-text language** option to the language of the server if an appropriate match exists. For a non\-localized version of [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)], the **default full\-text language** option is English.  
  
 When creating or altering a full\-text index, you can specify a different language for each full\-text indexed column. If no language is specified for a column, the default is the value of the configuration option **default full\-text language**.  
  
> [!NOTE]  
>  All columns listed in a single full\-text query function clause must use the same language, unless the LANGUAGE option is specified in the query. The language used for the full\-text indexed column being queried determines the linguistic analysis performed on arguments of the full\-text query predicates \([CONTAINS](../Topic/CONTAINS%20\(Transact-SQL\).md) and [FREETEXT](../Topic/FREETEXT%20\(Transact-SQL\).md)\) and functions \([CONTAINSTABLE](../Topic/CONTAINSTABLE%20\(Transact-SQL\).md) and [FREETEXTTABLE](../Topic/FREETEXTTABLE%20\(Transact-SQL\).md)\).  
  
##  <a name="lang"></a> Choosing the Language for an Indexed Column  
 When creating a full\-text index, we recommend that you specify a language for each indexed column. If a language is not specified for a column, the system default language is used. The language of a column determines which word breaker and stemmer are used for indexing that column. Also, the thesaurus file of that language will be used by full\-text queries on the column.  
  
 There are a couple of things to consider when choosing the column language for creating a full\-text index. These considerations relate to how your text is tokenized and then indexed by Full\-Text Engine. For more information, see [Choose a Language When Creating a Full-Text Index](../../Topics\TopicNameContainA/Choose-a-Language-When-Creating-a-Full-Text-Index.md).  
  
 **To view the word breaker language of a column**  
  
-   [Manage Full-Text Indexes](../../Topics\TopicNameNotContainA/Manage-Full-Text-Indexes.md)  
  
-   [sys.fulltext_index_columns &#40;Transact-SQL&#41;](../Topic/sys.fulltext_index_columns%20\(Transact-SQL\).md)  
  
    ```  
    SELECT 'language_id' AS "LCID" FROM sys.fulltext_index_columns;  
    ```  
  
##  <a name="info"></a> Obtaining Information about Word Breakers  
 **Viewing the tokenization result of a word breaker, thesaurus, and stoplist combination**  
  
-   [sys.dm_fts_parser &#40;Transact-SQL&#41;](../Topic/sys.dm_fts_parser%20\(Transact-SQL\).md).  
  
 **To return information about the registered word breakers**  
  
-   [sp_help_fulltext_system_components &#40;Transact-SQL&#41;](../Topic/sp_help_fulltext_system_components%20\(Transact-SQL\).md)  
  
##  <a name="tshoot"></a> Troubleshooting Word\-Breaking Time\-out Errors  
 A word\-breaking time\-out error might occur in a variety of situations. For information about these situations and how to respond in each situation, see [MSSQLSERVER_30053](../Topic/MSSQLSERVER_30053.md).  
  
##  <a name="impact"></a> Understanding the Impact of New Word Breakers  
 Each version of [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] typically includes new word breakers that have better linguistic rules and are more accurate than earlier word breakers. Potentially, the new word breakers might behave slightly differently from the word breakers in full\-text indexes that were imported from previous versions of [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)]. This is significant if a full\-text catalog was imported when a database was upgraded to the current version of [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)]. One or more languages used by the full\-text indexes in the full\-text catalog might now be associated with new word breakers. For more information, see [Upgrade Full-Text Search](../../Topics\TopicNameNotContainA/Upgrade-Full-Text-Search.md).  
  
 For a complete list of all the word breakers, see [sys.fulltext_languages &#40;Transact-SQL&#41;](../Topic/sys.fulltext_languages%20\(Transact-SQL\).md).  
  
## See Also  
 [ALTER FULLTEXT INDEX &#40;Transact-SQL&#41;](../Topic/ALTER%20FULLTEXT%20INDEX%20\(Transact-SQL\).md)   
 [CREATE FULLTEXT INDEX &#40;Transact-SQL&#41;](../Topic/CREATE%20FULLTEXT%20INDEX%20\(Transact-SQL\).md)   
 [sp_fulltext_service &#40;Transact-SQL&#41;](../Topic/sp_fulltext_service%20\(Transact-SQL\).md)   
 [sys.fulltext_languages &#40;Transact-SQL&#41;](../Topic/sys.fulltext_languages%20\(Transact-SQL\).md)   
 [Configure and Manage Stopwords and Stoplists for Full-Text Search](../../Topics\TopicNameNotContainA/Configure-and-Manage-Stopwords-and-Stoplists-for-Full-Text-Search.md)   
 [Upgrade Full-Text Search](../../Topics\TopicNameNotContainA/Upgrade-Full-Text-Search.md)  
  
  