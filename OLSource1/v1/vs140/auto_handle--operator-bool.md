---
title: "auto_handle::operator bool"
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
  - "auto_handle.operator bool"
  - "msclr.auto_handle.operator bool"
  - "operator bool"
  - "msclr::auto_handle::operator bool"
  - "auto_handle::operator bool"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "auto_handle::operator bool"
ms.assetid: 2e535e99-cf87-4008-b588-02c587d77453
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# auto_handle::operator bool
Operator for using <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> in a conditional expression.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> if the wrapped object is valid; <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> otherwise.  
  
## Remarks  
 This operator actually converts to <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> which is safer than <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> because it cannot be converted to an integral type.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **s1 is invalid**  
**s2 is valid**  
**s2 is now invalid**   
## Requirements  
 **Header file** \<msclr\auto_handle.h>  
  
 **Namespace** msclr  
  
## See Also  
 [auto_handle Members](../vs140/auto_handle-members.md)   
 [auto_handle::operator!](../vs140/auto_handle--operator!.md)