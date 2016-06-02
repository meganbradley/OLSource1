---
title: Configure and Manage Thesaurus Files for Full-Text Search
ms.custom: na
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - dbe-search
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 3ef96a63-8a52-45be-9a1f-265bff400e54
---
# Configure and Manage Thesaurus Files for Full-Text Search
  In [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)], full\-text queries can search for synonyms of user\-specified terms through the use of a thesaurus. A [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] *thesaurus* defines a set of synonyms for a specific language. System administrators can define two forms of synonyms: expansion sets and replacement sets. By developing a thesaurus tailored to your full\-text data, you can effectively broaden the scope of full\-text queries on that data. Thesaurus matching occurs for all [FREETEXT](../Topic/FREETEXT%20\(Transact-SQL\).md) and [FREETEXTABLE](../Topic/FREETEXTTABLE%20\(Transact-SQL\).md) queries and for any [CONTAINS](../Topic/CONTAINS%20\(Transact-SQL\).md) and [CONTAINSTABLE](../Topic/CONTAINSTABLE%20\(Transact-SQL\).md) queries that specify the FORMSOF THESAURUS clause.  
  
##  <a name="tasks"></a> Basic Tasks for Setting Up a Thesaurus File  
 Before full\-text search queries on your server instance can look for synonyms in a given language, you must define thesaurus mappings \(synonyms\) for that language. Each thesaurus must be manually configured to define the following:  
  
-   Diacritics setting  
  
     For a given thesaurus, all search patterns are either sensitive or insensitive to diacritical marks such as a tilde \(**~**\), acute accent mark \(**´**\), or umlaut \(**¨**\) \(that is, *accent sensitive* or *accent insensitive*\). For example, suppose you specify the pattern "café" to be replaced by other patterns in a full\-text query. If the thesaurus is accent\-insensitive, full\-text search replaces the patterns "café" and "cafe". If the thesaurus is accent\-sensitive, full\-text search replaces only the pattern "café". By default, a thesaurus is accent\-insensitive.  
  
-   Expansion set  
  
     An expansion set contains a group of synonyms such as "writer", "author", and "journalist" that are substituted for one another by a full\-text query. Queries that contain a match for any synonym in an expansion set are expanded to include every other synonym in the expansion set.  
  
     For more information, see "XML Structure of an Expansion Set," later in this topic.  
  
-   Replacement set  
  
     A replacement set contains a text pattern to be replaced by a substitution set. For an example, see the section "XML Structure of a Replacement Set" later in this topic.  
  
 [&#91;Top&#93;](#Top)  
  
##  <a name="initial_thesaurus_files"></a> Initial Content of the Thesaurus Files  
 [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] provides a set of XML thesaurus files, one for each supported language. These files are essentially empty. They contain only the top\-level XML structure that is common to all [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] thesauruses and a commented\-out sample thesaurus.  
  
 The thesaurus files that are released with [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] all contain the following XML code:  
  
```  
<XML ID="Microsoft Search Thesaurus">  
  
<!--  Commented out  
  
    <thesaurus xmlns="x-schema:tsSchema.xml">  
<diacritics_sensitive>0</diacritics_sensitive>  
        <expansion>  
            <sub>Internet Explorer</sub>  
            <sub>IE</sub>  
            <sub>IE5</sub>  
        </expansion>  
        <replacement>  
            <pat>NT5</pat>  
            <pat>W2K</pat>  
            <sub>Windows 2012</sub>  
        </replacement>  
        <expansion>  
            <sub>run</sub>  
            <sub>jog</sub>  
        </expansion>  
    </thesaurus>  
-->  
</XML>  
```  
  
 [&#91;Top&#93;](#Top)  
  
##  <a name="location"></a> Location of the Thesaurus Files  
 The default location of the thesaurus files is:  
  
 *\<SQL\_Server\_data\_files\_path\>*\\MSSQL13.MSSQLSERVER\\MSSQL\\FTDATA\\  
  
 This default location contains the following files:  
  
-   Language\-specific thesaurus files  
  
     During setup, empty thesaurus files are installed in the above location. A separate file is provided for each supported language. A system administrator can customize these files.  
  
     The default file names of the thesaurus files use following format:  
  
     ‘ts’ \+ \<three\-letter language\-abbreviation\> \+ '.xml'  
  
     The name of the thesaurus file for a given language is specified in the registry in the following value HKEY\_LOCAL\_MACHINE\\SOFTWARE\\Microsoft\\Microsoft SQL Server\\\<instance\-name\>\\MSSearch\\\<language\-abbrev\>.  
  
-   The global thesaurus file  
  
     An empty global thesaurus file, tsGlobal.xml.  
  
 You can change the location and names of a thesaurus file by changing its registry key. For each language, the location of the thesaurus file is specified in the following value in the registry:  
  
 HKLM\/SOFTWARE\/Microsoft\/Microsoft SQL Server\/\<instance name\>\/MSSearch\/Language\/\<language\-abbreviation\>\/TsaurusFile  
  
 The global thesaurus file corresponds to the Neutral language with LCID 0. This value can be changed by administrators only.  
  
 [&#91;Top&#93;](#Top)  
  
##  <a name="how_queries_use_tf"></a> How Queries Use Thesaurus Files  
 A thesaurus query uses both a language\-specific thesaurus and the global thesaurus. First, the query looks up the language\-specific file and loads it for processing \(unless it is already loaded\). The query is expanded to include the language\-specific synonyms specified by the expansion set and replacement set rules in the thesaurus file. These steps are then repeated for the global thesaurus. However, if a term is already part of a match in the language specific thesaurus file, the term is ineligible for matching in the global thesaurus.  
  
 [&#91;Top&#93;](#Top)  
  
##  <a name="structure"></a> Understanding the Structure of a Thesaurus File  
 Each thesaurus file defines an XML container whose ID is `Microsoft Search Thesaurus`, and a comment, `<!--` … `-->`, that contains a sample thesaurus. The thesaurus is defined in a \<thesaurus\> element that contains samples of the child elements that define the diacritics setting, expansion sets, and replacement sets, as follows:  
  
-   XML Structure of the Diacritical Setting  
  
     The diacritics setting of a thesaurus is specified in a single \<diacritics\_sensitive\> element. This element contains an integer value that controls accent sensitivity, as follows:  
  
    |Diacritics Setting|Value|XML|  
    |------------------------|-----------|---------|  
    |Accent insensitive|0|`<diacritics_sensitive>0</diacritics_sensitive>`|  
    |Accent sensitive|1|`<diacritics_sensitive>1</diacritics_sensitive>`|  
  
    > [!NOTE]  
    >  This setting can only be applied one time in the file, and it applies to all search patterns in the file. This setting cannot be specified for individual patterns.  
  
-   XML Structure of an Expansion Set  
  
     Each expansion set is enclosed within an \<expansion\> element. Within this element, you specify one or more substitutions in a \<sub\> element. In the expansion set, you can specify a group of substitutions that are synonyms of each other.  
  
     For example, you can edit the expansion section to treat the substitutions "writer", "author", and "journalist" as synonyms. full\-text search queries that contain matches in one substitution are expanded to include all other substitutions specified in the expansion set. Therefore, in the preceding example, when you issue a FORMS OF THESAURUS or a FREETEXT query for the word "author", full\-text search also returns search results containing the words "writer" and "journalist".  
  
     This is what the expansion set section would look like for the above example:  
  
    ```  
    <expansion>  
            <sub>writer</sub>  
            <sub>author</sub>  
            <sub>journalist</sub>  
    </expansion>  
    ```  
  
-   XML Structure of a Replacement Set  
  
     Each replacement set is enclosed within a \<replacement\> element. Within this element you can specify one or more patterns in a \<pat\> element and zero or more substitutions in \<sub\> elements, one per synonym. You can specify a pattern to be replaced by a substitution set. Patterns and substitutions can contain a word, or a sequence of words. If there is no substitution specified for a pattern, it has the effect of removing the pattern from the user query.  
  
     For example, suppose you want queries for "Win8", the pattern, to be replaced by "Windows Server 2012" or "Windows 8.0", the substitutions. If you run a full\-text query for "Win8", full\-text search only returns search results containing "Windows Server 2012" or "Windows 8.0". It does not return results containing "Win8". This is because the pattern "Win8" has been "replaced" by the patterns "Windows Server 2012" and "Windows 8.0".  
  
     This is what the replacement set section would look like for the above example:  
  
    ```  
    <replacement>  
            <pat>Win8</pat>  
            <sub>Windows Server 2012</sub>  
            <sub>Windows 8.0</sub>  
    </replacement>  
    ```  
  
     If you have two replacement sets with similar patterns being matched, the longer of the two takes precedence. For example, if you run a FORMS OF THESAURUS query for "Internet Explorer online community" and you have the following replacement sets, the "Internet Explorer" replacement set takes precedence over the "Internet" replacement set. The query will therefore be processed as "IE online community" or "IE 9 online community".  
  
    ```  
    <replacement>  
             <pat>Internet</pat>  
             <sub>intranet</sub>  
    </replacement>  
    ```  
  
     and  
  
    ```  
    <replacement>  
             <pat>Internet Explorer</pat>  
             <sub>IE</sub>  
             <sub>IE 9</sub>  
    </replacement>  
    ```  
  
 [&#91;Top&#93;](#Top)  
  
##  <a name="working_with_thesaurus_files"></a> Working with Thesaurus Files  
 **To edit a thesaurus file**  
  
-   [Editing a Thesaurus File](#editing)  
  
 **To load an updated thesaurus file**  
  
-   [sp_fulltext_load_thesaurus_file &#40;Transact-SQL&#41;](../Topic/sp_fulltext_load_thesaurus_file%20\(Transact-SQL\).md)  
  
 **To view the tokenization result of a word breaker, thesaurus, and stoplist combination**  
  
-   [sys.dm_fts_parser &#40;Transact-SQL&#41;](../Topic/sys.dm_fts_parser%20\(Transact-SQL\).md)  
  
 [&#91;Top&#93;](#Top)  
  
##  <a name="editing"></a> Editing a Thesaurus File  
 The thesaurus for a given language can be configured by editing its thesaurus file \(an XML file\). During setup, empty thesaurus files that contain only the \<xml\> container and a commented\-out sample \<thesaurus\> element are installed. In order for full\-text search queries that look for synonyms to work properly, you must create an actual \<thesaurus\> element that defines a set of synonyms. You can define two forms of synonyms, expansion sets and replacement sets.  
  
 **Restrictions for thesaurus files**  
  
 The following restrictions apply to editing a thesaurus file:  
  
-   Only system administrators can update, modify, or delete thesaurus files.  
  
-   When editing thesaurus files using text editor tools, the files must be saved in Unicode format, and Byte Order Marks must be specified.  
  
-   Thesaurus entries cannot be empty or word break to an empty string.  
  
-   Phrases in the thesaurus file must be no longer than 512 characters.  
  
-   A thesaurus must not contain any duplicate entries among the \<sub\> entries of expansion sets and the \<pat\> elements of replacement sets.  
  
 **Recommendations for thesaurus files**  
  
 We recommend that entries in the thesaurus file contain no special characters. This is because word breakers have subtle behaviors with respect to special characters. If a thesaurus entry contains any special characters, word breakers used in combination with that entry can have subtle behavioral implications for a full\-text query.  
  
 We recommend that \<sub\> entries contain no stopwords since stopwords are omitted from the full\-text index. Queries are expanded to include the \<sub\> entries from a thesaurus file, and if a \<sub\> entry contains stopwords, query size increases unnecessarily.  
  
#### To edit a thesaurus file  
  
1.  Open the thesaurus file in Notepad.  
  
2.  If you are editing the thesaurus file for the first time, remove the following comment lines at the beginning and end of the file, respectively:  
  
    ```  
    <!--Commented out  
    -->  
    ```  
  
3.  Add, modify, or delete a replacement set, or expansion set.  
  
4.  Save the file and close Notepad.  
  
5.  Use [sp\_fulltext\_load\_thesaurus\_file](../Topic/sp_fulltext_load_thesaurus_file%20\(Transact-SQL\).md) to load the content of the thesaurus file into tempdb, specifying the local identifier \(LCID\) that corresponds to the language of the thesaurus file. For example, for the English thesaurus file, tsenu.xml, the corresponding LCID is 1033.  
  
    ```  
    USE AdventureWorks2012 ;  
    EXEC sys.sp_fulltext_load_thesaurus_file 1033;  
    GO  
    ```  
  
 [&#91;Top&#93;](#Top)  
  
## See Also  
 [CONTAINS &#40;Transact-SQL&#41;](../Topic/CONTAINS%20\(Transact-SQL\).md)   
 [CONTAINSTABLE &#40;Transact-SQL&#41;](../Topic/CONTAINSTABLE%20\(Transact-SQL\).md)   
 [FREETEXT &#40;Transact-SQL&#41;](../Topic/FREETEXT%20\(Transact-SQL\).md)   
 [FREETEXTTABLE &#40;Transact-SQL&#41;](../Topic/FREETEXTTABLE%20\(Transact-SQL\).md)   
 [Full-Text Search](../../Topics\TopicNameNotContainA/Full-Text-Search.md)  
  
  