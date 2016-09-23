---
title: "CDocTemplate::MatchDocType"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CDocTemplate::MatchDocType
  - MatchDocType
  - CDocTemplate.MatchDocType
dev_langs: 
  - C++
helpviewer_keywords: 
  - documents, matching type
  - CDocTemplate class, overridables
  - matching types of documents
  - MatchDocType method
ms.assetid: 85f7bb71-0920-49c3-8d2d-900ab7d6c8de
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CDocTemplate::MatchDocType
Determines the degree of confidence in the match between a document type and this template.  
  
## Syntax  
  
```  
  
      virtual Confidence MatchDocType(  
   LPCTSTR lpszPathName,  
   CDocument*& rpDocMatch   
);  
```  
  
#### Parameters  
 `lpszPathName`  
 Pathname of the file whose type is to be determined.  
  
 `rpDocMatch`  
 Pointer to a document that is assigned the matching document, if the file specified by `lpszPathName` is already open.  
  
## Return Value  
 A value from the **Confidence** enumeration, which is defined as follows:  
  
 `enum Confidence`  
  
 `{`  
  
 `noAttempt,`  
  
 `maybeAttemptForeign,`  
  
 `maybeAttemptNative,`  
  
 `yesAttemptForeign,`  
  
 `yesAttemptNative,`  
  
 `yesAlreadyOpen`  
  
 `};`  
  
## Remarks  
 Use this function to determine the type of document template to use for opening a file. If your application supports multiple file types, for example, you can use this function to determine which of the available document templates is appropriate for a given file by calling `MatchDocType` for each template in turn, and choosing a template according to the confidence value returned.  
  
 If the file specified by `lpszPathName` is already open, this function returns **CDocTemplate::yesAlreadyOpen** and copies the file's **CDocument** object into the object at `rpDocMatch`.  
  
 If the file is not open but the extension in `lpszPathName` matches the extension specified by **CDocTemplate::filterExt**, this function returns **CDocTemplate::yesAttemptNative** and sets `rpDocMatch` to **NULL**. For more information on **CDocTemplate::filterExt**, see [CDocTemplate::GetDocString](../vs140/cdoctemplate--getdocstring.md).  
  
 If neither case is true, the function returns **CDocTemplate::yesAttemptForeign**.  
  
 The default implementation does not return **CDocTemplate::maybeAttemptForeign** or **CDocTemplate::maybeAttemptNative**. Override this function to implement type-matching logic appropriate to your application, perhaps using these two values from the **Confidence** enumeration.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDocTemplate Class](../vs140/cdoctemplate-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDocTemplate::GetDocString](../vs140/cdoctemplate--getdocstring.md)