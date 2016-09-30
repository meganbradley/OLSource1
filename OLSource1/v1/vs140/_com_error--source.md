---
title: "_com_error::Source"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
f1_keywords: 
  - "_com_error.Source"
  - "_com_error::Source"
  - "source"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Source method"
ms.assetid: 55353741-fabc-4b0c-9787-b5a69bb189f2
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _com_error::Source
**Microsoft Specific**  
  
 Calls **IErrorInfo::GetSource** function.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Returns the result of **IErrorInfo::GetSource** for the **IErrorInfo** object recorded within the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object. The resulting BSTR is encapsulated in a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object. If no **IErrorInfo** is recorded, it returns an empty <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Remarks  
 Any failure while calling the **IErrorInfo::GetSource** method is ignored.  
  
 **END Microsoft Specific**  
  
## See Also  
 [_com_error Class](../vs140/_com_error-class.md)