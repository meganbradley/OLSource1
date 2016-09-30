---
title: "IEnumDebugCustomAttributes::Skip"
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
  - "IEnumCustomAttributes::Skip"
helpviewer_keywords: 
  - "IEnumDebugCustomAttributes::Skip"
ms.assetid: 54c72e23-cd4c-4746-935c-abea8057dd1b
caps.latest.revision: 13
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IEnumDebugCustomAttributes::Skip
Skips a specified number of custom attributes in an enumeration sequence.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] Number of elements to skip.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. Returns <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> if <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is greater than the number of remaining elements; otherwise, returns an error code.  
  
## Remarks  
 If <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> specifies a value greater than the number of remaining elements, the enumeration is set to the end and <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is returned.  
  
## See Also  
 [IEnumDebugCustomAttributes](../vs140/ienumdebugcustomattributes.md)