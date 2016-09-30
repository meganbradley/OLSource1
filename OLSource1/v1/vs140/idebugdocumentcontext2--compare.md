---
title: "IDebugDocumentContext2::Compare"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "IDebugDocumentContext2::Compare"
helpviewer_keywords: 
  - "IDebugDocumentContext2::Compare"
ms.assetid: 2327b1ba-52d0-42fb-a01e-63cb4b332d2f
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugDocumentContext2::Compare
Compares this document context to a given array of document contexts.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] A value from the [DOCCONTEXT_COMPARE](../vs140/doccontext_compare.md) enumeration that specifies the type of comparison.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] An array of [IDebugDocumentContext2](../vs140/idebugdocumentcontext2.md) objects that represent the document contexts being compared to.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [in] The length of the array of document contexts to compare.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 [out] Returns the index into the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> array of the first document context that satisfies the comparison.  
  
## Return Value  
 Returns <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> if a match was found. Returns <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> if no match was found. Otherwise, returns an error code.  
  
## Remarks  
 The [IDebugDocumentContext2](../vs140/idebugdocumentcontext2.md) objects that are passed in the array must be implemented by the same debug engine that implements the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object being called on; otherwise, the comparison is not valid.  
  
## See Also  
 [IDebugDocumentContext2](../vs140/idebugdocumentcontext2.md)   
 [DOCCONTEXT_COMPARE](../vs140/doccontext_compare.md)