---
title: "CDocument::SetModifiedFlag"
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
  - "CDocument.SetModifiedFlag"
  - "CDocument::SetModifiedFlag"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDocument class, operations"
  - "SetModifiedFlag method"
  - "documents, modifying"
ms.assetid: c9b06b79-c4d6-4cb8-a52a-b7b12c936f53
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDocument::SetModifiedFlag
Call this function after you have made any modifications to the document.  
  
## Syntax  
  
```  
  
      virtual void SetModifiedFlag(  
   BOOL bModified = TRUE   
);  
```  
  
#### Parameters  
 `bModified`  
 Flag indicating whether the document has been modified.  
  
## Remarks  
 By calling this function consistently, you ensure that the framework prompts the user to save changes before closing a document. Typically you should use the default value of **TRUE** for the `bModified` parameter. To mark a document as clean (unmodified), call this function with a value of **FALSE**.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDocument Class](../vs140/cdocument-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDocument::IsModified](../vs140/cdocument--ismodified.md)   
 [CDocument::SaveModified](../vs140/cdocument--savemodified.md)