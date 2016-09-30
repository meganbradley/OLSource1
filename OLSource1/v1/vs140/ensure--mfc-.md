---
title: "ENSURE (MFC)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "AFX/ENSURE"
  - "ENSURE"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ENSURE"
ms.assetid: 738c4ccf-c29c-4c04-8d6c-f126bedf6e91
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ENSURE (MFC)
Use to validate data correctness.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies a boolean expression to be tested.  
  
## Remarks  
 The purpose of these macros is to improve the validation of parameters. The macros prevent further processing of incorrect parameters in your code. Unlike the **ASSERT** macros, the **ENSURE** macros throw an exception in addition to generating an assertion.  
  
 The macros behave in two ways, according to the project configuration. The macros call **ASSERT** and then throw an exception if the assertion fails. Thus, in Debug configurations (that is, where **_DEBUG** is defined) the macros produce an assertion and exception while in Release configurations, the macros produce only the exception (**ASSERT** does not evaluate the expression in Release configurations).  
  
 The macro **ENSURE_ARG** acts like the **ENSURE** macro.  
  
 **ENSURE_VALID** calls the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> macro (which has an effect only in Debug builds). In addition, **ENSURE_VALID** throws an exception if the pointer is NULL. The NULL test is performed in both Debug and Release configurations.  
  
 If any of these tests fails, an alert message is displayed in the same manner as **ASSERT**. The macro throws an invalid argument exception if needed.  
  
## Example  
 [!code[NVC_MFC_Utilities#33](../vs140/codesnippet/CPP/ensure--mfc-_1.cpp)]  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [VERIFY](../vs140/verify.md)   
 [ATLENSURE](../vs140/atlensure.md)