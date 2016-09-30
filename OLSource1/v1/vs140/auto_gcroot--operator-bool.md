---
title: "auto_gcroot::operator bool"
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
  - "auto_gcroot.operator bool"
  - "auto_gcroot::operator bool"
  - "msclr.auto_gcroot.operator bool"
  - "msclr::auto_gcroot::operator bool"
  - "operator bool"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "bool operator"
ms.assetid: 87d38498-4221-4de8-8d02-c2dd2e6274ec
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# auto_gcroot::operator bool
Operator for using <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> in a conditional expression.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> if the wrapped object is valid; <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> otherwise.  
  
## Remarks  
 This operator actually converts to <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> which is safer than <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> because it cannot be converted to an integral type.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **s is invalid**  
**now s is valid**  
**now s is invalid**   
## Requirements  
 **Header file** \<msclr\auto_gcroot.h>  
  
 **Namespace** msclr  
  
## See Also  
 [auto_gcroot Members](../vs140/auto_gcroot-members.md)   
 [auto_gcroot::operator!](../vs140/auto_gcroot--operator!.md)