---
title: "&#39;Global&#39; must be followed by &#39;.&#39; and an identifier"
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
  - "bc36000"
  - "vbc36000"
helpviewer_keywords: 
  - "BC36000"
ms.assetid: 0007d7b4-54a2-4f09-904c-d5ad60a55f8e
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &#39;Global&#39; must be followed by &#39;.&#39; and an identifier
The [Global - delete](assetId:///18c8ba14-40f6-4978-8096-6a5852324635) keyword appears in a context other than accessing a namespace.  
  
 The purpose of <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> is to allow your code to access a root-level namespace from inside a namespace structure that has blocked the root-level namespace.  
  
 **Error ID:** BC36000  
  
### To correct this error  
  
-   If you want to access a root-level namespace, specify it following the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> keyword and a period (<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>).  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
-   If you do not want to access a root-level namespace, remove the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> keyword.  
  
## See Also  
 [Global - delete](assetId:///18c8ba14-40f6-4978-8096-6a5852324635)