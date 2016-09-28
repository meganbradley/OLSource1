---
title: "&#39;&lt;modifier&gt;&#39; is not valid on an Interface declaration"
ms.custom: na
ms.date: "09/21/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "bc30397"
  - "vbc30397"
helpviewer_keywords: 
  - "BC30397"
ms.assetid: 9143dc87-c396-4ff9-9987-0b460ee32b38
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &#39;&lt;modifier&gt;&#39; is not valid on an Interface declaration
You have used a modifier that is not valid on an `Interface` declaration. The only valid modifiers for `Sub`, `Function`, or `Property` statements declared in an `Interface` declaration are the `Overloads` and `Default` keywords. Other modifiers, such as `Public`, `Private`, `Friend`, `Protected`, `Shared`, `Static`, `Overrides`, `MustOverride` and `Overridable`, are not valid.  
  
 **Error ID:** BC30397  
  
### To correct this error  
  
-   Remove the modifier.  
  
## See Also  
 [NOT IN BUILD: Interface Definition](assetId:///7840a52c-9c38-42c4-adbc-e2c02e9dc204)