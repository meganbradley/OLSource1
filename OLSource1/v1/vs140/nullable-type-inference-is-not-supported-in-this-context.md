---
title: "Nullable type inference is not supported in this context"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vbc36629"
  - "bc36629"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "BC36629"
ms.assetid: 0a1e2dbc-d9a4-433d-9306-c5540782b81d
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Nullable type inference is not supported in this context
Value types and structures can be declared nullable.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 However, you cannot use the nullable declaration in combination with type inference. The following examples cause this error.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Error ID:** BC36629  
  
### To correct this error  
  
-   Use an <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> clause to declare the variable as nullable.  
  
## See Also  
 [Nullable Value Types](../vs140/nullable-value-types--visual-basic-.md)   
 [Local Type Inference](../vs140/local-type-inference--visual-basic-.md)