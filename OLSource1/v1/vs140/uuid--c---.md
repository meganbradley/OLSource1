---
title: "uuid (C++)"
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
  - "uuid"
  - "uuid_cpp"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "__declspec keyword [C++], uuid"
  - "uuid __declspec keyword"
ms.assetid: 9d004621-09bc-4a8d-871b-648f5d5102d7
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# uuid (C++)
**Microsoft Specific**  
  
 The compiler attaches a GUID to a class or structure declared or defined (full COM object definitions only) with the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> attribute.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> attribute takes a string as its argument. This string names a GUID in normal registry format with or without the **{ }** delimiters. For example:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 This attribute can be applied in a redeclaration. This allows the system headers to supply the definitions of interfaces such as **IUnknown**, and the redeclaration in some other header (such as COMDEF.H) to supply the GUID.  
  
 The keyword [__uuidof](../vs140/__uuidof-operator.md) can be applied to retrieve the constant GUID attached to a user-defined type.  
  
 **END Microsoft Specific**  
  
## See Also  
 [__declspec](../vs140/__declspec.md)   
 [Keywords](../vs140/keywords--c---.md)