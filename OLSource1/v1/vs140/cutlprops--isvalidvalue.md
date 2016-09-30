---
title: "CUtlProps::IsValidValue"
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
  - "CUtlProps::IsValidValue"
  - "CUtlProps.IsValidValue"
  - "IsValidValue"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsValidValue method"
ms.assetid: 1164556e-8d98-429c-a396-fc9a699e0e97
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CUtlProps::IsValidValue
Used to validate a value before setting a property.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The index into the property-set array; zero if there is only one property set.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The property ID and new value in a [DBPROP](https://msdn.microsoft.com/en-us/library/ms717970.aspx) structure.  
  
## Return Value  
 A standard <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. The default return value is <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## Remarks  
 If you have any validation routines you want to run on a value that you are about to use to set a property, you should override this function. For example, you could validate **DBPROP_AUTH_PASSWORD** against a password table to determine a valid value.  
  
## Requirements  
 **Header:** atldb.h  
  
## See Also  
 [CUtlProps Class](../vs140/cutlprops-class.md)