---
title: "&lt;deprecated&gt; (JavaScript)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: cf33d371-59da-4310-95ee-d7524fd9d58c
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &lt;deprecated&gt; (JavaScript)
Specifies a deprecated function or method.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Optional. Specifies whether the function or method will be removed in a future release, or whether the function or method has already been removed and that its use may result in an error. Set to <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> to specify that the function or method will be removed in a future release. Set to <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> to specify that the function or method has already been removed.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Optional. The identifier for localization information about the function or method. The identifier is either a member ID or it corresponds to the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> attribute value in a message bundle defined by OpenAjax metadata. The identifier type depends on the format specified in the [\<loc>](../vs140/-loc---javascript-.md) element.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Optional. A description of the function or method that is being deprecated.  
  
## Remarks  
 The elements used to annotate functions, which include <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, must be placed in the function body before any statements. When you mark a function as deprecated, we recommend that you replace its [\<summary>](../vs140/-summary---javascript-.md) element with the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> element.  
  
## Example  
 The following code shows how to use the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> element.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [XML Documentation Comments](../vs140/xml-documentation-comments--javascript-.md)