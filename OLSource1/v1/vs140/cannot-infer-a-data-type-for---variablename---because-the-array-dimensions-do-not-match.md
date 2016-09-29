---
title: "Cannot infer a data type for &#39;&lt;variablename&gt;&#39; because the array dimensions do not match"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "bc36909"
  - "vbc36909"
helpviewer_keywords: 
  - "BC36909"
ms.assetid: e41fec81-efec-4395-a0a5-d81906a2d4f1
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Cannot infer a data type for &#39;&lt;variablename&gt;&#39; because the array dimensions do not match
If the dimensions used to initialize an array do not match the dimensions in the declaration, the compiler cannot infer a data type for the array. For example, the following code causes this error.  
  
```vb#  
' Valid. exampleArray1 is a one-dimensional array of integers.  
Dim exampleArray1() = New Integer() {1, 2, 3}  
' Not valid.  
'Dim exampleArray2(,) = New Integer() {1, 2, 3}  
'Dim exampleArray3(,) = New Integer() {}  
```  
  
 **Error ID:** BC36909  
  
## See Also  
 [Local Type Inference](../vs140/local-type-inference--visual-basic-.md)   
 [NOTINBUILD How to: Initialize a Multidimensional Array](assetId:///502dcf8b-d86c-46f1-ad7d-3ce809645774)