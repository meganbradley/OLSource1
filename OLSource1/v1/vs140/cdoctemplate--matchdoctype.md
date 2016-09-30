---
title: "CDocTemplate::MatchDocType"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "CDocTemplate::MatchDocType"
  - "MatchDocType"
  - "CDocTemplate.MatchDocType"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "documents, matching type"
  - "CDocTemplate class, overridables"
  - "matching types of documents"
  - "MatchDocType method"
ms.assetid: 85f7bb71-0920-49c3-8d2d-900ab7d6c8de
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDocTemplate::MatchDocType
Determines the degree of confidence in the match between a document type and this template.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Pathname of the file whose type is to be determined.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Pointer to a document that is assigned the matching document, if the file specified by <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is already open.  
  
## Return Value  
 A value from the **Confidence** enumeration, which is defined as follows:  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
  
## Remarks  
 Use this function to determine the type of document template to use for opening a file. If your application supports multiple file types, for example, you can use this function to determine which of the available document templates is appropriate for a given file by calling <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> for each template in turn, and choosing a template according to the confidence value returned.  
  
 If the file specified by <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is already open, this function returns **CDocTemplate::yesAlreadyOpen** and copies the file's **CDocument** object into the object at <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.  
  
 If the file is not open but the extension in <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> matches the extension specified by **CDocTemplate::filterExt**, this function returns **CDocTemplate::yesAttemptNative** and sets <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> to **NULL**. For more information on **CDocTemplate::filterExt**, see [CDocTemplate::GetDocString](../vs140/cdoctemplate--getdocstring.md).  
  
 If neither case is true, the function returns **CDocTemplate::yesAttemptForeign**.  
  
 The default implementation does not return **CDocTemplate::maybeAttemptForeign** or **CDocTemplate::maybeAttemptNative**. Override this function to implement type-matching logic appropriate to your application, perhaps using these two values from the **Confidence** enumeration.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDocTemplate Class](../vs140/cdoctemplate-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDocTemplate::GetDocString](../vs140/cdoctemplate--getdocstring.md)