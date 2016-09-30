---
title: "CFileException::GetErrorMessage"
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
  - "CException::GetErrorMessage"
  - "CException.GetErrorMessage"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetErrorMessage method"
  - "CException class, operations"
ms.assetid: 42a8379e-ae53-4c8a-94d0-8628cefd5a3c
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFileException::GetErrorMessage
Retrieves text that describes an exception.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in, out] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Pointer to a buffer that receives an error message.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The maximum number of characters the specified buffer can hold. This includes the terminating null character.  
  
 [in, out] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Pointer to an unsigned integer that receives the help context ID. If <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, no ID is returned.  
  
## Return Value  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> if the method was successful; otherwise <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
## Remarks  
 If the specified buffer is too small, the error message is truncated.  
  
## Example  
 The following example uses <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
 [!code[NVC_MFCExceptions#22](../vs140/codesnippet/CPP/cfileexception--geterrormessage_1.cpp)]  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [CException Class](../vs140/cexception-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CException::ReportError](../vs140/cexception--reporterror.md)