---
title: "DOCCONTEXT_COMPARE"
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
  - "DOCCONTEXT_COMPARE"
helpviewer_keywords: 
  - "DOCCONTEXT_COMPARE enumeration"
ms.assetid: ed947c34-b07e-4b69-8381-b6e7cb842862
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# DOCCONTEXT_COMPARE
Specifies the criteria for comparing two document contexts.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Members  
 DOCCONTEXT_EQUAL  
 Find the first document context in the list that is equal to the target document context.  
  
 DOCCONTEXT_LESS_THAN  
 Find the first document context in the list that is less than the target document context.  
  
 DOCCONTEXT_GREATER_THAN  
 Find the first document context in the list that is greater than the target document context.  
  
 DOCCONTEXT_SAME_DOCUMENT  
 Find the first document context in the list that is in the same document as the target document context.  
  
## Remarks  
 Passed as an argument to the [Compare](../vs140/idebugdocumentcontext2--compare.md) method.  
  
 These values are used to specify a comparison criteria for finding the first document context in a list. A document context is given a list of document contexts to compare itself against through the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> method. The first document context in the list for which the comparison operator is <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is then returned.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Enumerations (Visual Studio Debugging SDK)](../vs140/enumerations--visual-studio-debugging-.md)   
 [Compare](../vs140/idebugdocumentcontext2--compare.md)