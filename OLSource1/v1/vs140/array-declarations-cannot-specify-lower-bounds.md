---
title: "Array declarations cannot specify lower bounds"
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
  - "vbc30805"
  - "bc30805"
helpviewer_keywords: 
  - "BC30805"
ms.assetid: f2055387-f4dc-4366-89fb-d752929a0258
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Array declarations cannot specify lower bounds
Arrays always have a lower bound of zero. You can specify zero as the lower bound to make your code more readable. However, you cannot specify any other value for the lower bound.  
  
 **Error ID:** BC30805  
  
### To correct this error  
  
-   Dimension arrays as one less than the total number of elements. For example, <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> has the same size (7 elements) as <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>. You can also specify <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
-   Use offsets to simulate nonzero lower bounds. The following example simulates an array dimensioned from 3 to 9.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [Arrays](../vs140/arrays-in-visual-basic.md)   
 [Array Dimensions in Visual Basic](../vs140/array-dimensions-in-visual-basic.md)   
 [NOTINBUILD How to: Specify a Zero Lower Bound on an Array](assetId:///20ffd49a-64f7-4634-8ed0-46ba1049d935)