---
title: "IDebugDocumentChecksum2::GetChecksumAndAlgorithmId"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "IDebugDocumentChecksum2::GetChecksumAndAlgorithmI"
  - "GetChecksumAndAlgorithmI"
ms.assetid: 25efef99-0ef3-4332-a752-607605fc6e67
caps.latest.revision: 12
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugDocumentChecksum2::GetChecksumAndAlgorithmId
Retrieves the document checksum and algorithm identifier given the maximum number of bytes to use.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [out] Unique identifier for the checksum algorithm.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [in] Maximum number of bytes to be used for the checksum.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 [out] Value of the checksum.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 [out] Actual number of bytes used for the checksum.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Example  
 The following example uses this method to get the checksum and algorithm for a document.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [IDebugDocumentChecksum2](../vs140/idebugdocumentchecksum2.md)