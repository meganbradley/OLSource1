---
title: Find Key Phrases in Documents with Semantic Search
ms.custom: na
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - dbe-search
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 6ee3676e-ed5d-43ec-aeca-1eed78967111
---
# Find Key Phrases in Documents with Semantic Search
  Describes how to find the key phrases in documents or text columns that are configured for statistical semantic indexing.  
  
##  <a name="BasicsQueryKey"></a> Finding Key Phrases in Documents  
  
###  <a name="howtofind"></a> How to: Find the Key Phrases in Documents with SEMANTICKEYPHRASETABLE  
 To identify the key phrases in specific documents, or to identify documents that contain specific key phrases, query the function [semantickeyphrasetable &#40;Transact-SQL&#41;](../Topic/semantickeyphrasetable%20\(Transact-SQL\).md).  
  
 SEMANTICKEYPHRASETABLE returns a table with zero, one, or more rows for those key phrases associated with columns in the specified table. This rowset function can be referenced in the FROM clause of a SELECT statement as if it were a regular table name.  
  
> [!NOTE]  
>  In [!INCLUDE[ssCurrent](../../Token\Other/ssCurrent_md.md)], only single words are indexed for semantic search; multi\-word phrases \(ngrams\) are not indexed. Also, various forms of the same word are indexed separately; for example, "computer" and "computers" are indexed separately.  
  
 For detailed information about the parameters required by the SEMANTICKEYPHRASETABLE function, and about the table of results that it returns, see [semantickeyphrasetable &#40;Transact-SQL&#41;](../Topic/semantickeyphrasetable%20\(Transact-SQL\).md).  
  
> [!IMPORTANT]  
>  The columns that you target must have full\-text and semantic indexing enabled.  
  
###  <a name="HowToTopPhrases"></a> Example 1: Find the Top Key Phrases in a Specific Document  
 The following example retrieves the top 10 key phrases from the document specified by the @DocumentId variable in the Document column of the Production.Document table of the AdventureWorks sample database. The @DocumentId variable represents a value from the key column of the full\-text index.  
  
```tsql  
SELECT TOP(10) KEYP_TBL.keyphrase  
FROM SEMANTICKEYPHRASETABLE  
    (  
    Production.Document,  
    Document,  
    @DocumentId  
    ) AS KEYP_TBL  
ORDER BY KEYP_TBL.score DESC;  
GO  
```  
  
 The **SEMANTICKEYPHRASETABLE** function retrieves these results efficiently by using an index seek instead of a table scan.  
  
###  <a name="HowToTopDocuments"></a> Example 2: Find the Top Documents that Contain a Specific Key Phrase  
 The following example retrieves the top 25 documents that contain the key phrase “Bracket” from the Document column of the Production.Document table of the AdventureWorks sample database.  
  
```tsql  
SELECT TOP (25) DOC_TBL.DocumentID, DOC_TBL.DocumentSummary  
FROM Production.Document AS DOC_TBL  
    INNER JOIN SEMANTICKEYPHRASETABLE  
    (  
    Production.Document,  
    Document  
    ) AS KEYP_TBL  
ON DOC_TBL.DocumentID = KEYP_TBL.document_key  
WHERE KEYP_TBL.keyphrase = 'Bracket'  
ORDER BY KEYP_TBL.Score DESC;  
GO  
```  
  
  