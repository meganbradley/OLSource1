---
title: "basic_ios::imbue"
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
  - "ios/std::basic_ios::imbue"
  - "basic_ios.imbue"
  - "basic_ios::imbue"
  - "std::basic_ios::imbue"
  - "imbue"
  - "std.basic_ios.imbue"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "imbue method"
ms.assetid: 6cae631b-fe2b-47c5-bbfb-768516f4cc9f
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_ios::imbue
Changes the locale.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A locale string.  
  
## Return Value  
 The previous locale.  
  
## Remarks  
 If [rdbuf](../vs140/basic_ios--rdbuf.md) is not a null pointer, the member function calls  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>->[pubimbue](../vs140/basic_streambuf--pubimbue.md)(_*Loc*)  
  
 In any case, it returns [ios_base::imbue](../vs140/ios_base--imbue.md)(_*Loc*).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<ios>  
  
 **Namespace:** std  
  
## See Also  
 [basic_ios Class](../vs140/basic_ios-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)