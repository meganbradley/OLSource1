---
title: "_com_error::HelpFile"
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
  - "HelpFile"
  - "_com_error::HelpFile"
  - "_com_error.HelpFile"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "HelpFile method"
ms.assetid: d2d3a0a1-6b62-4d52-a818-3cfae545a4af
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _com_error::HelpFile
**Microsoft Specific**  
  
 Calls **IErrorInfo::GetHelpFile** function.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Returns the result of **IErrorInfo::GetHelpFile** for the **IErrorInfo** object recorded within the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object. The resulting BSTR is encapsulated in a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object. If no **IErrorInfo** is recorded, it returns an empty <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Remarks  
 Any failure while calling the **IErrorInfo::GetHelpFile** method is ignored.  
  
 **END Microsoft Specific**  
  
## See Also  
 [_com_error Class](../vs140/_com_error-class.md)