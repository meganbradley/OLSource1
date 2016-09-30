---
title: "IDebugEnumField::GetValueFromStringCaseInsensitive"
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
  - "IDebugEnumField::GetValueFromStringCaseInsensitive"
helpviewer_keywords: 
  - "IDebugEnumField::GetValueFromStringCaseInsensitive method"
ms.assetid: ef95b38e-d9b2-4fb5-a166-7c2e14641dc7
caps.latest.revision: 12
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugEnumField::GetValueFromStringCaseInsensitive
This method uses a case-insensitive search to return the value associated with the name of an enumeration constant.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] A string specifying the name for which to get the value. Note that for C++, this is a wide character string.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [out] Returns the associated numerical value.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>; otherwise, returns <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, if the name is not part of the enumeration, or an error code.  
  
## Remarks  
 This method is case-insensitive. If a case-sensitive search is needed (for example, in a language such as C++ where names are case-sensitive), use [IDebugEnumField::GetValueFromString](../vs140/idebugenumfield--getvaluefromstring.md).  
  
## See Also  
 [IDebugEnumField](../vs140/idebugenumfield.md)   
 [IDebugEnumField::GetValueFromString](../vs140/idebugenumfield--getvaluefromstring.md)